using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using BooBox;

namespace BooBoxClient {
	public static class CommInfo {
		private static int SocketCounter = 0;
		private static Socket serverConnection;
		private static IAsyncResult asyncResult;
		private static AsyncCallback asyncCallBack;
		private static ArrayList ServerInfoList = ArrayList.Synchronized(new ArrayList());

		/// <summary>
		/// Connect to a server.
		/// </summary>
		/// <param name="ConnectionInfo">ConnectionInfo object containing connection information</param>
		/// <param name="ConnectionMode">Mode describing the type of connection</param>
		/// <param name="Params">Optional params to be passed to the ServerInfo object</param>
		public static void ConnectToServer(ConnectionInfo ConnectionInfo, ConnectionMode ConnectionMode, String[] Params) {
			Log.AddStatusText("Connecting to server (" + ConnectionMode.ToString() + " mode): " + ConnectionInfo.Description);
			if (ConnectionInfo.Hostname != "") {
				Log.AddStatusText("Attempting to resolve hostname: " + ConnectionInfo.Hostname);
				IPHostEntry hostInfo = Dns.GetHostEntry(ConnectionInfo.Hostname);
				if (hostInfo.AddressList.Length > 0) {
					ConnectionInfo.IPAddress = hostInfo.AddressList[0].ToString();
					Log.AddStatusText("Hostname (" + ConnectionInfo.Hostname + ") resolved to " + ConnectionInfo.IPAddress + ".");
				}
			}
			serverConnection = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint connectionEndpoint = new IPEndPoint(IPAddress.Parse(ConnectionInfo.IPAddress), ConnectionInfo.InfoPort);
			try {
				serverConnection.Connect(connectionEndpoint);
			} catch (SocketException Se) {
				if (Se.ErrorCode == 10061) {
					Log.AddStatusText("Info server @ " + ConnectionInfo.IPAddress + ":" + ConnectionInfo.InfoPort + " refused connection.");
					if ((ConnectionMode != ConnectionMode.FirstConnect) && (ConnectionMode != ConnectionMode.OnlineTest)) {
						MessageBox.Show("The Info Server refused connection. Is the server running? Are ports forwarded?");
					}
				}
			}
			if (serverConnection.Connected) {
				ServerInfo tempServerInfo = new ServerInfo(serverConnection, SocketCounter, ConnectionInfo, ConnectionMode);
				if (Params.Length > 0) { tempServerInfo.ConnectionParams = Params; }
				ServerInfoList.Add(tempServerInfo);
				WaitForData(tempServerInfo);
				Interlocked.Increment(ref SocketCounter);
			}
		}

		private class SocketPacket {
			public Socket Socket;
			public ServerInfo ServerInfo;
			public byte[] DataBuffer = new byte[Config.Instance.DataBufferSize];
			public int ServerInfoIndex;
			/// <summary>
			/// Constructor which starts a SocketPacket based on a Server object.
			/// </summary>
			/// <param name="iServer">Associated Server object</param>
			public SocketPacket(ServerInfo iServer) {
				Socket = iServer.Socket;
				ServerInfoIndex = iServer.Index;
				ServerInfo = iServer;
				Forms.MainFrm.UpdateStatusProgressBar("Increment", DataBuffer.Length);
			}
		}

		/// <summary>
		/// An always-active function that waits for the server to send data to the client. Eventually trigers OnDataReceived().
		/// </summary>
		/// <param name="waitServerInfo">Associated Server object</param>
		private static void WaitForData(ServerInfo waitServerInfo) {
			if (asyncCallBack == null) { asyncCallBack = new AsyncCallback(OnDataReceived); }
			if (waitServerInfo != null) {
				SocketPacket SocketPacket = new SocketPacket(waitServerInfo);
				asyncResult = SocketPacket.Socket.BeginReceive(
					SocketPacket.DataBuffer,
					0, SocketPacket.DataBuffer.Length,
					SocketFlags.None,
					asyncCallBack,
					SocketPacket
				);
			}
		}

		/// <summary>
		/// Triggered when data is received from the Server. Takes care of closing dead Sockets and
		/// passing data to Server.OnRecieveData().
		/// </summary>
		/// <param name="asyn">Required associated IAsyncResult</param>
		private static void OnDataReceived(IAsyncResult asyn) {
			SocketPacket SocketPacket = (SocketPacket)asyn.AsyncState;
			if (SocketPacket.ServerInfo.Socket.Connected == true) {
				try {
					int receiveLen = SocketPacket.Socket.EndReceive(asyn);
					if (receiveLen == 0) {
						CloseServerInfoConnection(SocketPacket.ServerInfoIndex);
					} else {
						char[] receiveCharsOld = new char[receiveLen];
						int charLength = Encoding.UTF8.GetChars(SocketPacket.DataBuffer, 0, receiveLen, receiveCharsOld, 0);
						char[] receiveChars = new char[charLength];
						Array.Copy(receiveCharsOld, receiveChars, charLength);
						String receiveData = new String(receiveChars);
						SocketPacket.ServerInfo.DataBuffer += receiveData;
						// See if multiple messages were sent in the same packet, if so call OnReceiveData for all of them.
						if (Functions.OccurancesInString(SocketPacket.ServerInfo.DataBuffer, "\x4") >= 1) {
							String[] splitIncommingData = SocketPacket.ServerInfo.DataBuffer.Split(("\x4").ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
							for (int i = 0; i < splitIncommingData.Length; i++) {
								SocketPacket.ServerInfo.DataBuffer = SocketPacket.ServerInfo.DataBuffer.Remove(0, splitIncommingData[i].Length + 1);
								ServerInfoIndexToServerInfo(SocketPacket.ServerInfoIndex).OnReceiveData(splitIncommingData[i]);
							}
						}
						if (SocketPacket.ServerInfo.Socket.Connected == true) {
							WaitForData(ServerInfoIndexToServerInfo(SocketPacket.ServerInfoIndex));
						}
					}
				} catch (ObjectDisposedException) {
					CloseServerInfoConnection(SocketPacket.ServerInfoIndex);
				} catch (NullReferenceException) {
					CloseServerInfoConnection(SocketPacket.ServerInfoIndex);
				} catch (SocketException Se) {
					if (Se.ErrorCode == 10054) {
						CloseServerInfoConnection(SocketPacket.ServerInfoIndex);
					}
				}
			}
		}

		/// <summary>
		/// Closes a server connection based on the Server Index.
		/// </summary>
		/// <param name="iServerInfoNumber">Server Index to Close</param>
		private static void CloseServerInfoConnection(int iServerInfoNumber) {
			ServerInfo tempServerInfo = ServerInfoIndexToServerInfo(iServerInfoNumber);
			Log.AddServerText("Info server has disconnected.", tempServerInfo.Index);
			ServerInfoList.Remove(tempServerInfo);
		}

		/// <summary>
		/// Returns a Server object associated with a specific Server Index
		/// </summary>
		/// <param name="iServerInfoIndex">The Server Index being searched for.</param>
		/// <returns>Server Object</returns>
		public static ServerInfo ServerInfoIndexToServerInfo(int iServerInfoIndex) {
			for (int i = 0; i < ServerInfoList.Count; i++) {
				if (((ServerInfo)ServerInfoList[i]).Index == iServerInfoIndex) {
					return (ServerInfo)ServerInfoList[i];
				}
			}
			return null;
		}


	}
}
