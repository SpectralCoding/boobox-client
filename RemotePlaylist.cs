using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooBox;

namespace BooBoxClient {
	public class RemotePlaylist {
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
			return "[Local] " + Name + " (" + SongCount.ToString() + ")";
		}

	}
}
