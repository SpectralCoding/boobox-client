using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BooBox;
using Un4seen.Bass;

namespace BooBoxClient {
	public static class ActiveSong {
		public static SongInfo SongInfo;
		private static byte[] SongData;
		private static int TotalBytesReceived;
		private static GCHandle pinGCHandle;
		private static int PlayingID;
		public static Boolean Playing = false;
		private static SYNCPROC SongSync = new SYNCPROC(SongEndSync);
		private static int StartStreamingAtByte = 0;

		public static void AppendSongData(byte[] newData) {
			if (StartStreamingAtByte == 0) {
				StartStreamingAtByte = Convert.ToInt32(SongInfo.StartByte + ((SongInfo.EndByte - SongInfo.StartByte) * Config.Instance.BufferAtPercent));
				Forms.MainFrm.UpdateStatusLabel("Receiving Metadata for \"" + SongInfo.Title + "\".");
			}
			int insertDataLen;
			if (SongData == null) {
				TotalBytesReceived = 0;
				SongData = new byte[Convert.ToInt32(SongInfo.FileLength) + Config.Instance.DataBufferSize];
			}
			if (((SongData.Length - TotalBytesReceived) < newData.Length) && ((SongData.Length - TotalBytesReceived) > 0)) {
				insertDataLen = SongData.Length - TotalBytesReceived;
			} else {
				insertDataLen = newData.Length;
			}
			pinGCHandle = GCHandle.Alloc(SongData, GCHandleType.Pinned);
			Buffer.BlockCopy(newData, 0, SongData, TotalBytesReceived, insertDataLen);
			TotalBytesReceived += newData.Length;
			if ((TotalBytesReceived >= SongInfo.StartByte) && (TotalBytesReceived <= SongInfo.EndByte)) {
				Forms.MainFrm.UpdateBufferingProgressBar("Value", TotalBytesReceived);
			}
			if (TotalBytesReceived >= StartStreamingAtByte) {
				if (Playing == false) {
					PlayingID = Bass.BASS_StreamCreateFile(pinGCHandle.AddrOfPinnedObject(), 0L, SongData.Length, BASSFlag.BASS_SAMPLE_FLOAT);
					if (PlayingID != 0 && Bass.BASS_ChannelPlay(PlayingID, false)) {
						Playing = true;
						Bass.BASS_ChannelSetSync(PlayingID, BASSSync.BASS_SYNC_END | BASSSync.BASS_SYNC_MIXTIME, 0, SongSync, IntPtr.Zero);
						Forms.MainFrm.UpdatePlayButton("ChangeToPause");
						Forms.MainFrm.UpdatePlayTimer("Start", 0);
						Forms.MainFrm.UpdateStatusLabel("Playing \"" + SongInfo.Title + "\".");
					} else {
						Console.WriteLine("Error: " + Bass.BASS_ErrorGetCode());
						CommStream.CloseServerStreamConnection();
						MessageBox.Show("MP3 Read Error. This error may be caused by setting your \"Play at Buffer Pct\" option too low.");
					}
				}
			}
			pinGCHandle.Free();
		}

		/// <summary>
		/// Triggered when the song ends playback, either by error or due to the end of the song.
		/// </summary>
		/// <param name="handle">Internal</param>
		/// <param name="channel">Internal</param>
		/// <param name="data">Internal</param>
		/// <param name="user">Internal</param>
		private static void SongEndSync(int handle, int channel, int data, IntPtr user) {
			Playing = false;
			PlayingID = 0;
			Forms.MainFrm.UpdatePlayButton("ChangeToPlay");
			Forms.MainFrm.UpdateBufferingProgressBar("Reset", 0);
			Forms.MainFrm.UpdatePlayTimer("Stop", 0);
			Forms.MainFrm.UpdateTrackBar("Reset");
			CommStream.CloseServerStreamConnection();
			TotalBytesReceived = 0;
			SongData = null;
			Forms.MainFrm.CheckNextSong();
		}

		/// <summary>
		/// Clears song data from the ActiveSong class.
		/// </summary>
		public static void ClearSongData() {
			Forms.MainFrm.UpdatePlayTimer("Stop", 0);
			Playing = false;
			SongData = null;
		}

		/// <summary>
		/// Gets the current byte positions of the song.
		/// </summary>
		public static int BytePosition {
			get {
				if (Playing == true) { return Convert.ToInt32(Bass.BASS_ChannelGetPosition(PlayingID)); }
				return 0;
			}
		}

		/// <summary>
		/// Gets the total length of the song in bytes.
		/// </summary>
		public static int ByteLength {
			get {
				if (Playing == true) { return Convert.ToInt32(Bass.BASS_ChannelGetLength(PlayingID)); }
				return 0;
			}
		}

		/// <summary>
		/// Gets the current play position in seconds.
		/// </summary>
		public static int PlayPosition {
			get {
				if (Playing == true) { return Convert.ToInt32(Bass.BASS_ChannelBytes2Seconds(PlayingID, Bass.BASS_ChannelGetPosition(PlayingID))); }
				return 0;
			}
		}

		/// <summary>
		/// Forces the end of a song. Should be used when moving between songs.
		/// </summary>
		public static void EndSong() {
			Playing = false;
			Bass.BASS_StreamFree(PlayingID);
			PlayingID = 0;
			TotalBytesReceived = 0;
			SongData = null;
			Forms.MainFrm.UpdateBufferingProgressBar("Reset", 0);
			Forms.MainFrm.UpdatePlayTimer("Stop", 0);
			Forms.MainFrm.UpdateTrackBar("Reset");
			CommStream.CloseServerStreamConnection();
		}
		
		/// <summary>
		/// Sets the current playback position of the song to a specific byte position.
		/// </summary>
		/// <param name="newPosition">Byte to set playback position to.</param>
		public static void SetBytePosition(int newPosition) {
			Bass.BASS_ChannelSetPosition(PlayingID, newPosition);
		}

		/// <summary>
		/// Returns the second of the song in which the byte in question is located.
		/// </summary>
		/// <param name="bytePosition">Byte position in question</param>
		/// <returns>Second</returns>
		public static int GetSecondsAtByte(int bytePosition) {
			return Convert.ToInt32(Bass.BASS_ChannelBytes2Seconds(PlayingID, bytePosition));
		}

		/// <summary>
		/// Returns the percentage (in decimal form) of the Audio Data downloaded.
		/// </summary>
		public static double PctOfSongDataBuffered {
			get {
				double temp = Convert.ToDouble((TotalBytesReceived - SongInfo.StartByte)) / Convert.ToDouble((SongInfo.FileLength - SongInfo.StartByte - (SongInfo.FileLength - SongInfo.EndByte)));
				if (temp < 0) { return 0; } else if (temp > 1) { return 1; } else { return temp; }
			}
		}

		/// <summary>
		/// Gets or sets the volume of the currently playing song.
		/// </summary>
		public static double Volume {
			get { return Config.Instance.Volume / 100.0; }
			set { Bass.BASS_ChannelSetAttribute(PlayingID, BASSAttribute.BASS_ATTRIB_VOL, Convert.ToSingle(value)); }
		}


	}
}
