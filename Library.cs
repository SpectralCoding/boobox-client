using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using BooBox;

namespace BooBoxClient {
	public static class Library {
		private static List<SongInfo> SongList = new List<SongInfo>();

		/// <summary>
		/// Saves settings to the Config object.
		/// </summary>
		public static void SaveSettings() {
			Config.Instance.LibrarySongList = SongList;
			Config.Instance.Save();
		}

		/// <summary>
		/// Loads Library from the Config object.
		/// </summary>
		public static void LoadSettings() {
			SongList = Config.Instance.LibrarySongList;
			UpdateMainFrmDGV();
		}

		/// <summary>
		/// Updates the MainFrm Library DataGridView.
		/// </summary>
		public static void UpdateMainFrmDGV() {
			Forms.MainFrm.UpdateMusicLibraryDGV(SongList);
		}

		/// <summary>
		/// Adds a XML String to the Client Library based on the XML String from the server and its GUID.
		/// </summary>
		/// <param name="XMLString">XML String containing the song metadata.</param>
		/// <param name="ServerGUID">GUID of the server which sent the XML String.</param>
		public static void AddXMLStringToLibrary(String XMLString, String ServerGUID) {
			XmlTextReader XmlReader = new XmlTextReader(new StringReader(XMLString));
			Boolean fileExistsInLibrary = false;
			SongInfo tempSI = new SongInfo();
			Boolean inSong = false;
			String currentTag = "";
			ArrayList artistList = new ArrayList();
			ArrayList genreList = new ArrayList();
			while (XmlReader.Read()) {
				switch (XmlReader.NodeType) {
					case XmlNodeType.Element:
						if (XmlReader.Name == "song") { inSong = true; }
						currentTag = XmlReader.Name;
						break;
					case XmlNodeType.Text:
						if (inSong) {
							switch (currentTag) {
								case "album":
									tempSI.Album = XmlReader.Value;
									break;
								case "artist":
									artistList.Add(XmlReader.Value);
									break;
								case "bitrate":
									tempSI.BitRate = Convert.ToInt32(XmlReader.Value);
									break;
								case "comment":
									tempSI.Comment = XmlReader.Value;
									break;
								case "endbyte":
									tempSI.EndByte = Convert.ToInt64(XmlReader.Value);
									break;
								case "filelength":
									tempSI.FileLength = Convert.ToInt64(XmlReader.Value);
									break;
								case "filename":
									tempSI.FileName = XmlReader.Value;
									break;
								case "genre":
									genreList.Add(XmlReader.Value);
									break;
								case "md5":
									tempSI.MD5 = XmlReader.Value;
									break;
								case "playcount":
									tempSI.PlayCount = Convert.ToInt32(XmlReader.Value);
									break;
								case "playlength":
									tempSI.PlayLength = Convert.ToInt64(XmlReader.Value);
									break;
								case "title":
									tempSI.Title = XmlReader.Value;
									break;
								case "track":
									tempSI.Track = Convert.ToInt32(XmlReader.Value);
									break;
								case "trackcount":
									tempSI.TrackCount = Convert.ToInt32(XmlReader.Value);
									break;
								case "year":
									tempSI.Year = Convert.ToInt32(XmlReader.Value);
									break;
							}
						}
						break;
					case XmlNodeType.EndElement:
						if (XmlReader.Name == "song") {
							inSong = false;
							currentTag = "";
							tempSI.AlbumArtists = (String[])artistList.ToArray(typeof(String));
							tempSI.Genres = (String[])genreList.ToArray(typeof(String));
							tempSI.ServerGUID = ServerGUID;
							artistList.Clear();
							genreList.Clear();
							Forms.MainFrm.UpdateStatusProgressBar("Increment", 1);
							fileExistsInLibrary = false;
							for (int x = 0; x < SongList.Count; x++) { if (SongList[x].MD5 == tempSI.MD5) { fileExistsInLibrary = true; break; } }
							if (fileExistsInLibrary == false) { SongList.Add(tempSI); }
						}
						break;
				}
			}
			SaveSettings();
			UpdateMainFrmDGV();
		}

		/// <summary>
		/// Removes all songs from the library related to a specific Server GUID.
		/// </summary>
		/// <param name="GUID">GUID to remove</param>
		public static void RemoveSongsByGUID(String GUID) {
			for (int i = 0; i < SongList.Count; i++) {
				if (SongList[i].ServerGUID == GUID) {
					SongList.RemoveAt(i);
					i--;
				}
			}
			UpdateMainFrmDGV();
		}

		public static SongInfo MD5ToSongInfo(String MD5Hash) {
			for (int i = 0; i < SongList.Count; i++) {
				if (SongList[i].MD5 == MD5Hash) {
					return SongList[i];
				}
			}
			return new SongInfo();
		}

	}
}
