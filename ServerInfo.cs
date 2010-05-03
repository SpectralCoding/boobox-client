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
	public class ServerInfo {
		public Socket Socket;
		public int Index;
		public ConnectionInfo ConnectionInfo;
		public ConnectionMode ConnectionMode;
		public ConnectionStatus ConnectionStatus;
		public String DataBuffer;
		public String[] ConnectionParams;
		public String Version;
		public List<ServerDetail> Details = new List<ServerDetail>();
		public int SongCount;

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
			if (Data.Length > 100) {
				Console.WriteLine("From ServerInfo " + Index + ":\t" + Data.Substring(0, 100) + "...");
			} else {
				Console.WriteLine("From ServerInfo " + Index + ":\t" + Data);
			}
			ParseMessage(Data);
			//DataBuffer = "";
		}

		/// <summary>
		/// Parses a line of incomming data.
		/// </summary>
		/// <param name="Data">Data to parse and execute</param>
		public void ParseMessage(String Data) {
			char[] spaceDelim = new char[] { ' ' };
			String[] tokenData = Data.Split(spaceDelim, 2);
			switch (tokenData[0]) {
				case "HELLO":
					#region HELLO
					ConnectionInfo.Name = tokenData[1];
					Log.AddServerText("Connected to \"" + ConnectionInfo.Name + "\".", Index);
					Send(Protocol.CreateHELLOR(Config.Instance.ClientName));
					break;
					#endregion
				case "VERSION":
					#region VERSION
					Version = tokenData[1];
					Log.AddServerText("\"" + ConnectionInfo.Name + "\" running at version " + Version, Index);
					Send(Protocol.CreateVERSIONR());
					break;
					#endregion
				case "DETAILS":
					#region DETAILS
					Details = ParseDetails(tokenData[1]);
					Log.AddServerText("\"" + ConnectionInfo.Name + "\" details: " + tokenData[1], Index);
					String TempDetailValue = ContainsDetailsKey("GUID");
					if (TempDetailValue != null) {
						ConnectionInfo.GUID = TempDetailValue;
					}
					TempDetailValue = ContainsDetailsKey("STREAMPORT");
					if (TempDetailValue != null) {
						ConnectionInfo.StreamPort = Convert.ToInt32(TempDetailValue);
					}
					TempDetailValue = ContainsDetailsKey("PASS");
					if (TempDetailValue == "1") {
						if (ConnectionInfo.RequiresPassword == false) {
							Log.AddServerText("\"" + ConnectionInfo.Name + "\" requires a password. None stored.", Index);
							MessageBox.Show(ConnectionInfo.Name + " requires a password. No password has been specified in the server connection information. Please edit " + ConnectionInfo.Name + "'s connection information to correct this issue.", "Password Required");
							Send(Protocol.CreateGOODBYE());
						} else {
							Log.AddServerText("Password Sent to \"" + ConnectionInfo.Name + "\"", Index);
							Send(Protocol.CreatePASS(ConnectionInfo.Password));
						}
					}
					Config.Instance.ConnectionInfoList[Functions.ConnectionInfoInternalGUIDToIndex(Config.Instance.ConnectionInfoList, ConnectionInfo.InternalGUID)] = ConnectionInfo;
					break;
					#endregion
				case "PASSR":
					#region PASSR
					if (tokenData[1] == "PASS_ACCEPTED") {
						Log.AddServerText("\"" + ConnectionInfo.Name + "\" accepted password.", Index);
					} else if (tokenData[1] == "PASS_REJECTED") {
						Log.AddServerText("\"" + ConnectionInfo.Name + "\" rejected password.", Index);
						MessageBox.Show("The password you have specified for " + ConnectionInfo.Name + " has been rejected by the server. Please edit " + ConnectionInfo.Name + "'s connection information to correct this issue.", "Password Rejected");
						Send(Protocol.CreateGOODBYE());
						Log.AddServerText("Disconnected from \"" + ConnectionInfo.Name + "\"", Index);
					} else if (tokenData[1] == "PASS_NOT_REQUIRED") {
						Log.AddServerText("\"" + ConnectionInfo.Name + "\" did not require a password. Ignored.", Index);
					}
					break;
					#endregion
				case "OK":
					#region OK
					Log.AddServerText("Fully connected to \"" + ConnectionInfo.Name + "\"!", Index);
					ServerManager.ConfirmOnline(ConnectionInfo.InternalGUID, ConnectionInfo.GUID);
					ConnectionStatus = ConnectionStatus.Connected;
					if (ConnectionMode == ConnectionMode.LibraryRequest) {
						Log.AddServerText("Requesting Library from \"" + ConnectionInfo.Name + "\".", Index);
						Send(Protocol.CreateREQUESTLIBRARY(ConnectionInfo.LastLibraryQuery));
					} else if (ConnectionMode == ConnectionMode.SongRequest) {
						/*
						if (ServerInfo.RequestSongFilename != null) {
							Functions.Log = "[SI" + ServerInfo.Index + "] Requested song from \"" + ServerInfo.Name + "\"";
							ServerInfo.Send("REQUEST SONG " + ServerInfo.RequestSongFilename);
							Functions.StatusChange("Buffering");
						}
						*/
					} else if (ConnectionMode == ConnectionMode.OnlineTest) {
						Send(Protocol.CreateGOODBYE());
					} else if (ConnectionMode == ConnectionMode.PlaylistRequest) {
						Log.AddServerText("Requesting Playlist from \"" + ConnectionInfo.Name + "\".", Index);
						//Send(Protocol.CreateREQUESTLIBRARY(ConnectionInfo.LastLibraryQuery));
					} else if (ConnectionMode == ConnectionMode.PlaylistListRequest) {
						Log.AddServerText("Requesting Playlist List from \"" + ConnectionInfo.Name + "\".", Index);
						Send(Protocol.CreateREQUESTPLAYLISTLIST());
					}
					break;
					#endregion
				case "REQUESTR":
                    #region REQUESTR
                    if (ConnectionStatus == ConnectionStatus.Connected) {
                        String[] requestData = tokenData[1].Split(spaceDelim, 2);
                        switch (requestData[0]) {
							case "LIBRARYUPTODATE":
								#region LIBRARYUPTODATE
								Forms.MainFrm.UpdateStatusProgressBar("Reset", 0);
								Log.AddServerText("Library already up to date.", Index);
								break;
								#endregion
							case "LIBRARYMETA":
                                #region LIBRARYMETA
                                requestData = tokenData[1].Split(spaceDelim);
                                SongCount = Convert.ToInt32(requestData[2]);
								int tempByteCount = Convert.ToInt32(requestData[1]);
								ConnectionInfo.LastLibraryQuery = Convert.ToDateTime(requestData[3]).ToUniversalTime();
								String tempStr = "Receiving Library Data: " + Functions.BytesToHumanReadable(tempByteCount, 2) + " in " + requestData[2] + " songs (last updated " + ConnectionInfo.LastLibraryQuery.ToLocalTime().ToString() + ").";
								Forms.MainFrm.UpdateStatusLabel(tempStr);
								Log.AddServerText(tempStr, Index);
								//Config.Instance.ConnectionInfoList[Functions.ConnectionInfoInternalGUIDToIndex(Config.Instance.ConnectionInfoList, ConnectionInfo.InternalGUID)] = ConnectionInfo;
								Forms.MainFrm.UpdateStatusProgressBar("SetMax", tempByteCount);
                                break;
                                #endregion
                            case "LIBRARY":
                                #region LIBRARY
								Forms.MainFrm.UpdateStatusProgressBar("Reset", 0);
								Forms.MainFrm.UpdateStatusLabel("Processing Library Data... " + SongCount + " Songs.");
								Forms.MainFrm.UpdateStatusProgressBar("SetMax", SongCount);
								Library.AddXMLStringToLibrary(Functions.DecompressString(requestData[1]), ConnectionInfo.GUID);
								Forms.MainFrm.UpdateStatusProgressBar("Reset", 0);
								Forms.MainFrm.UpdateStatusLabel("Ready");
								Send(Protocol.CreateGOODBYE());
                                break;
                                #endregion
							case "PLAYLISTLIST":
								#region PLAYLISTLIST
								requestData = tokenData[1].Split(spaceDelim, 3);
								PlaylistManager.AddRemotePlaylist(ConnectionInfo.GUID, requestData[2], Convert.ToInt32(requestData[1]));
								break;
								#endregion
							case "SONGINFO":
								#region SONGINFO
								/*
								ActiveSong.ImportXMLData(requestData[1]);
								Functions.Log = "[SI" + ServerInfo.Index + "] Received XML Data for \"" + ActiveSong.SongInfo.Title + "\"";
								*/
								break;
								#endregion
							case "SONGKEY":
								#region SONGKEY
								/*
								Functions.MainFrm.UpdateFileBufferingProgressBar("SetMax", Convert.ToInt32(ActiveSong.SongInfo.FileLength));
								Functions.MainFrm.UpdateSongBufferingProgressBar("SetMin", ActiveSong.SongInfo.StartByte);
								Functions.MainFrm.UpdateSongBufferingProgressBar("SetMax", ActiveSong.SongInfo.EndByte);
								Functions.MainFrm.UpdateSongBufferingProgressBar("Value", ActiveSong.SongInfo.StartByte);
								CommStream.ConnectToServerStream(ServerInfo.GUID, requestData[1], ActiveSong.SongInfo.FileName);
								*/
								break;
								#endregion
						}
                    } else {
						Log.AddServerText("Responded to data request before fully connected. Terminating connection.", Index);
						Send(Protocol.CreateGOODBYE());
                    }
                    break;
                    #endregion
				case "GOODBYE":
					#region GOODBYE
					Log.AddServerText("\"" + ConnectionInfo.Name + "\" sent GOODBYE. Disconnecting...", Index);
					Socket.Close();
					break;
					#endregion
			}
		}

		/// <summary>
		/// Parses a DETAILS string sent by a Server.
		/// </summary>
		/// <param name="DetailsStr">DETAILS string sent by the Server.</param>
		/// <returns>List of ServerDetail type containing Name/Value pairs.</returns>
		private static List<ServerDetail> ParseDetails(String DetailsStr) {
			List<ServerDetail> TempList = new List<ServerDetail>();
			ServerDetail TempSD = new ServerDetail();
			char[] spaceDelim = new char[] { ' ' };
			char[] equalsDelim = new char[] { '=' };
			String[] tokenData = DetailsStr.Split(spaceDelim);
			String[] tokenSplit;
			for (int i = 0; i < tokenData.Length; i++) {
				tokenSplit = tokenData[i].Split(equalsDelim, 2);
				TempSD.Name = tokenSplit[0];
				TempSD.Value = tokenSplit[1];
				TempList.Add(TempSD);
			}
			return TempList;
		}

		/// <summary>
		/// Determines if Server details contains a specific details key.
		/// </summary>
		/// <param name="KeyName">Key name</param>
		/// <returns>String containing the value corresponding to the key name.</returns>
		public String ContainsDetailsKey(String KeyName) {
			foreach (ServerDetail TempSD in Details) {
				if (TempSD.Name == KeyName) {
					return TempSD.Value;
				}
			}
			return null;
		}

	}
}
