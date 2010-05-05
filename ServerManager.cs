using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooBox;

namespace BooBoxClient {
	public static class ServerManager {
		private static List<ServerStatus> ServerStatusList = new List<ServerStatus>();

		/// <summary>
		/// Initiats CommInfo.ConnectToServer() to test which servers are currently online.
		/// </summary>
		public static void VerifyUpToDate() {
			Forms.MainFrm.UpdateStatusLabel("Attempting to connect to all servers (" + Config.Instance.ConnectionInfoList.Count.ToString() + ")");
			ServerStatusList.Clear();
			String[] emptyString = new String[0];
			ServerStatus tempSS = new ServerStatus();
			for (int i = 0; i < Config.Instance.ConnectionInfoList.Count; i++) {
				tempSS.InternalGUID = Config.Instance.ConnectionInfoList[i].InternalGUID;
				tempSS.GUID = Config.Instance.ConnectionInfoList[i].GUID;
				tempSS.Online = false;
				ServerStatusList.Add(tempSS);
				CommInfo.ConnectToServer(Config.Instance.ConnectionInfoList[i], ConnectionMode.FirstConnect, emptyString);
			}
		}

		public static void RefreshPlaylistLists() {
			PlaylistManager.ClearRemotePlaylistList();
			String[] emptyString = new String[0];
			for (int i = 0; i < Config.Instance.ConnectionInfoList.Count; i++) {
				CommInfo.ConnectToServer(Config.Instance.ConnectionInfoList[i], ConnectionMode.PlaylistListRequest, emptyString);
			}
		}

		/// <summary>
		/// Marks a server as online based on the InternalGUID of that server, and its actual GUID.
		/// </summary>
		/// <param name="InternalGUID">InternalGUID of the server</param>
		/// <param name="GUID">Actual GUID of the server</param>
		public static void SetOnline(String InternalGUID, String GUID) {
			Boolean tempBool;
			ServerStatus tempSS = new ServerStatus();
			for (int i = 0; i < ServerStatusList.Count; i++) {
				if (ServerStatusList[i].InternalGUID == InternalGUID) {
					tempSS = ServerStatusList[i];
					tempBool = tempSS.Online;
					tempSS.GUID = GUID;
					tempSS.Online = true;
					ServerStatusList[i] = tempSS;
					if (tempBool != tempSS.Online) {
						Library.UpdateMainFrmDGV();
						Forms.MainFrm.UpdateActivePlaylistDGV();
					}
					break;
				}
			}
		}

		public static void SetOffline(String InternalGUID) {
			Boolean tempBool;
			ServerStatus tempSS = new ServerStatus();
			for (int i = 0; i < ServerStatusList.Count; i++) {
				if (ServerStatusList[i].InternalGUID == InternalGUID) {
					tempSS = ServerStatusList[i];
					tempBool = tempSS.Online;
					tempSS.Online = false;
					ServerStatusList[i] = tempSS;
					if (tempBool != tempSS.Online) {
						Library.UpdateMainFrmDGV();
						Forms.MainFrm.UpdateActivePlaylistDGV();
					}
					break;
				}
			}
		}

		/// <summary>
		/// Checks to see whether or not a server is online based on the Server's GUID.
		/// </summary>
		/// <param name="ServerGUID">GUID of server to check</param>
		/// <returns>Boolean revealing whether or not the server is online</returns>
		public static Boolean ServerOnline(String ServerGUID) {
			for (int i = 0; i < ServerStatusList.Count; i++) {
				if (ServerStatusList[i].GUID == ServerGUID) {
					if (ServerStatusList[i].Online == true) {
						return true;
					}
				}
			}
			return false;
		}

		public static Boolean RequestSong(SongInfo inputSongInfo) {
			if (ServerOnline(inputSongInfo.ServerGUID)) {
				if (ActiveSong.Playing == true) {
					ActiveSong.EndSong();
					CommStream.CloseServerStreamConnection();
					ActiveSong.ClearSongData();
				}
				String[] inputStr = new String[1];
				inputStr[0] = inputSongInfo.MD5;
				Forms.MainFrm.UpdateStatusLabel("Requesting \"" + inputSongInfo.Title + "\" from \"" + Functions.ServerGUIDToConnectionInfo(Config.Instance.ConnectionInfoList, inputSongInfo.ServerGUID).Description + "\".");
				CommInfo.ConnectToServer(Functions.ServerGUIDToConnectionInfo(Config.Instance.ConnectionInfoList, inputSongInfo.ServerGUID), ConnectionMode.SongRequest, inputStr);
				return true;
			} else {
				Forms.MainFrm.UpdateStatusLabel("Server \"" + Functions.ServerGUIDToConnectionInfo(Config.Instance.ConnectionInfoList, inputSongInfo.ServerGUID).Description + "\" is offline. Song skipped.");
				return false;
			}
		}

	}
}
