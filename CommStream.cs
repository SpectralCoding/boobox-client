using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using BooBox;

namespace BooBoxClient {
	class CommStream {
		private static Socket serverConnection;
		private static IAsyncResult asyncResult;
		private static AsyncCallback asyncCallBack;

		public static void ConnectToServer(ConnectionInfo ConnectionInfo, ConnectionMode ConnectionMode, String[] Params) {
			if (ConnectionInfo.Hostname != "") {
				Log.AddStatusText("Attempting to resolve hostname: " + ConnectionInfo.Hostname);
				IPHostEntry hostInfo = Dns.GetHostEntry(ConnectionInfo.Hostname);
				if (hostInfo.AddressList.Length > 0) {
					ConnectionInfo.IPAddress = hostInfo.AddressList[0].ToString();
					Log.AddStatusText("Hostname (" + ConnectionInfo.Hostname + ") resolved to " + ConnectionInfo.IPAddress + ".");
				}
			}
			serverConnection = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint connectionEndpoint = new IPEndPoint(IPAddress.Parse(ConnectionInfo.IPAddress), ConnectionInfo.StreamPort);
			try {
				serverConnection.Connect(connectionEndpoint);
			} catch (SocketException Se) {
				if (Se.ErrorCode == 10061) {
					Log.AddStatusText("Stream server @ " + ConnectionInfo.IPAddress + ":" + ConnectionInfo.StreamPort + " refused connection.");
					MessageBox.Show("The Stream Server refused connection. Is the server running? Are ports forwarded?");
				}
			}
			if (serverConnection.Connected) {
				String tempCreate = Protocol.CreateSTREAMSONG(Params[0]);
				Console.WriteLine("To ServerStream:\t" + tempCreate);
				serverConnection.Send(Encoding.UTF8.GetBytes(tempCreate + "\x4"));
				WaitForData(serverConnection);
			} else {
				Forms.MainFrm.UpdateStatusLabel("Ready");
			}
		}

		private class SocketPacket {
			public Socket Socket;
			public byte[] DataBuffer = new byte[Config.Instance.DataBufferSize];
			/// <summary>
			/// Constructor which starts a SocketPacket based on a Server object.
			/// </summary>
			/// <param name="iServer">Associated Server object</param>
			public SocketPacket(Socket iSocket) {
				Socket = iSocket;
			}
		}


		/// <summary>
		/// An always-active function that waits for the server to send data to the client. Eventually trigers OnDataReceived().
		/// </summary>
		/// <param name="waitServerInfo">Associated Server object</param>
		private static void WaitForData(Socket ServerSock) {
			if (asyncCallBack == null) { asyncCallBack = new AsyncCallback(OnDataReceived); }
			SocketPacket SocketPacket = new SocketPacket(ServerSock);
			asyncResult = SocketPacket.Socket.BeginReceive(
				SocketPacket.DataBuffer,
				0, SocketPacket.DataBuffer.Length,
				SocketFlags.None,
				asyncCallBack,
				SocketPacket
			);
		}

		/// <summary>
		/// Triggered when data is received from the Server. Takes care of closing dead Sockets and
		/// passing data to Server.OnRecieveData().
		/// </summary>
		/// <param name="asyn">Required associated IAsyncResult</param>
		private static void OnDataReceived(IAsyncResult asyn) {
			SocketPacket SocketPacket = (SocketPacket)asyn.AsyncState;
			try {
				int receiveLen = SocketPacket.Socket.EndReceive(asyn);
				if (receiveLen == 0) {
					CloseServerStreamConnection();
				} else {
					byte[] realBytes = new byte[receiveLen];
					Buffer.BlockCopy(SocketPacket.DataBuffer, 0, realBytes, 0, receiveLen);
					//Functions.MainFrm.UpdateFileBufferingProgressBar("Increment", realBytes.Length);
					ActiveSong.AppendSongData(realBytes);
				}
				WaitForData(SocketPacket.Socket);
			} catch (ObjectDisposedException) {
				CloseServerStreamConnection();
			} catch (NullReferenceException) {
				CloseServerStreamConnection();
			} catch (SocketException Se) {
				if (Se.ErrorCode == 10054) {
					CloseServerStreamConnection();
				}
			}
		}

		/// <summary>
		/// Closes a server connection based on the Server Index.
		/// </summary>
		public static void CloseServerStreamConnection() {
			//Functions.DumpByteArrayToFile(ActiveSong.SongData, "lolwut.mp3");
			serverConnection.Close();
		}

	}
}
