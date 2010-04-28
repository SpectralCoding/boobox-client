using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BooBox;

namespace BooBoxClient {
	public static class ServerManager {
		private static List<ServerStatus> ServerStatusList = new List<ServerStatus>();

		public static void TestServers() {
			ServerStatusList.Clear();
			String[] emptyString = new String[0];
			ServerStatus tempSS = new ServerStatus();
			for (int i = 0; i < Config.Instance.ConnectionInfoList.Count; i++) {
				tempSS.InternalGUID = Config.Instance.ConnectionInfoList[i].InternalGUID;
				tempSS.GUID = Config.Instance.ConnectionInfoList[i].GUID;
				tempSS.Online = false;
				ServerStatusList.Add(tempSS);
				CommInfo.ConnectToServer(Config.Instance.ConnectionInfoList[i], ConnectionMode.OnlineTest, emptyString);
			}
		}

		public static void ConfirmOnline(String InternalGUID, String GUID) {
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
					}
					break;
				}
			}
		}

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


	}
}
