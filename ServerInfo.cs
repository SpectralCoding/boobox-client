using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using BooBox;

namespace BooBoxClient {
	public class ServerInfo {
		public Socket Socket;
		public int Index;
		public ConnectionInfo ConnectionInfo;
		public ConnectionMode ConnectionMode;
		public ConnectionStatus ConnectionStatus;
		public String DataBuffer;
		public String[] ConnectionParams;
		//public List<SongInfo> LibraryList = new List<SongInfo>();
		//public String Name;
		//public String Version;
		//public List<ServerDetail> Details = new List<ServerDetail>();
		//public Boolean ReceivingData = false;
		//public Boolean ReceivingSong = false;

		/// <summary>
		/// Public constructor for createing a Server object
		/// </summary>
		/// <param name="iSocket">Socket associated with Server object</param>
		/// <param name="iServerInfoIndex">Index number of the associated Server object</param>
		public ServerInfo(Socket iSocket, int iServerInfoIndex, ConnectionInfo iConnectionInfo, ConnectionMode iConnectionMode) {
			Socket = iSocket;
			Index = iServerInfoIndex;
			ConnectionInfo = iConnectionInfo;
			ConnectionMode = iConnectionMode;
			ConnectionStatus = ConnectionStatus.Pending;
			OnServerConnect();
		}

		/// <summary>
		/// Triggered when the Client and Server have achieved a full TCP connection
		/// </summary>
		private void OnServerConnect() {

		}

		/// <summary>
		/// Sends data to associated Server
		/// </summary>
		/// <param name="Data">String containing the data to be sent to the server</param>
		public void Send(String Data) {
			if (Data.Length > 1000) {
				Console.WriteLine("To ServerInfo " + Index + ":\t" + Data.Substring(0, 1000) + "...");
			} else {
				Console.WriteLine("To ServerInfo " + Index + ":\t" + Data);
			}
			byte[] byteData = Encoding.UTF8.GetBytes(Data + "\x4");
			Socket.Send(byteData);
		}

		/// <summary>
		/// Triggered when data is recieved from the Server
		/// </summary>
		/// <param name="Data">Contains data sent from the Server</param>
		public void OnReceiveData(String Data) {
			if (Data.Length > 1000) {
				Console.WriteLine("From ServerInfo " + Index + ":\t" + Data.Substring(0, 1000) + "...");
			} else {
				Console.WriteLine("From ServerInfo " + Index + ":\t" + Data);
			}
			DataBuffer = "";
		}


	}
}
