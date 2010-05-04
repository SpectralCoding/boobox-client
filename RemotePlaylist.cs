using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using BooBox;

namespace BooBoxClient {
	public class RemotePlaylist {
		public List<SongInfo> SongList = new List<SongInfo>();
		public ConnectionInfo ConnectionInfo;
		public String Name;
		public int SongCount;
		public String GUID;

		/// <summary>
		/// RemotePlaylist constructor. Sets various internal variables.
		/// </summary>
		/// <param name="iServerGUID">GUID of server hosting the playlist</param>
		/// <param name="iPlaylistName">Name of the playlist</param>
		/// <param name="iSongCount">Number of songs in the playlist</param>
		/// <param name="PlaylistGUID">GUID of the playlist</param>
		public RemotePlaylist(String iServerGUID, String iName, int iSongCount, String PlaylistGUID) {
			Name = iName;
			SongCount = iSongCount;
			ConnectionInfo = Functions.ServerGUIDToConnectionInfo(Config.Instance.ConnectionInfoList, iServerGUID);
			GUID = PlaylistGUID;
		}

		/// <summary>
		/// Returns a string describing the playlist.
		/// </summary>
		/// <returns>[Server Name] Playlist Name (Song Count)</returns>
		public override String ToString() {
			return "[" + ConnectionInfo.Name + "] " + Name + " (" + SongCount.ToString() + ")";
		}

		/// <summary>
		/// Parses an XML String and adds the appropriate songs to the playlist's SongList.
		/// </summary>
		/// <param name="XMLString">XML String to parse</param>
		public void ImportXMLString(String XMLString) {
			SongList.Clear();
			XmlTextReader XmlReader = new XmlTextReader(new StringReader(XMLString));
			SongInfo tempSI = new SongInfo();
			String currentTag = "";
			while (XmlReader.Read()) {
				switch (XmlReader.NodeType) {
					case XmlNodeType.Element:
						currentTag = XmlReader.Name;
						break;
					case XmlNodeType.Text:
						switch (currentTag) {
							case "name":
								Name = XmlReader.Value;
								break;
							case "songcount":
								SongCount = Convert.ToInt32(XmlReader.Value);
								break;
							case "guid":
								GUID = XmlReader.Value;
								break;
							case "song":
								tempSI = Library.MD5ToSongInfo(XmlReader.Value);
								if (tempSI.ServerGUID == ConnectionInfo.GUID) {
									SongList.Add(tempSI);
								}
								break;
						}
						break;
					case XmlNodeType.EndElement:
						currentTag = "";
						break;
				}
			}
		}

	}
}
