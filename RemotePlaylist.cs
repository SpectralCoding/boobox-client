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

		public RemotePlaylist(String iServerGUID, String iName, int iSongCount, String PlaylistGUID) {
			Name = iName;
			SongCount = iSongCount;
			ConnectionInfo = Functions.ServerGUIDToConnectionInfo(Config.Instance.ConnectionInfoList, iServerGUID);
			GUID = PlaylistGUID;
		}

		public override String ToString() {
			return "[" + ConnectionInfo.Name + "] " + Name + " (" + SongCount.ToString() + ")";
		}

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
