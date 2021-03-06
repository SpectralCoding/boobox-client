﻿using System;
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
					if (ConnectionMode != ConnectionMode.SongRequest) {
						Forms.MainFrm.UpdateStatusLabel("Exchanging information with \"" + ConnectionInfo.Description + "\" (" + ConnectionMode.ToString() + " mode).");
					}
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
					ServerManager.SetOnline(ConnectionInfo.InternalGUID, ConnectionInfo.GUID);
					ConnectionStatus = ConnectionStatus.Connected;
					if (ConnectionMode == ConnectionMode.FirstConnect) {
						#region FirstConnect
						Log.AddServerText("Connection is in FirstConnect mode, verifying Client data is up to date with \"" + ConnectionInfo.Name + "\".", Index);
						Log.AddServerText("Requesting Library from \"" + ConnectionInfo.Name + "\".", Index);
						Send(Protocol.CreateREQUESTLIBRARY(ConnectionInfo.LastLibraryQuery));
						Log.AddServerText("Requesting Playlist List from \"" + ConnectionInfo.Name + "\".", Index);
						Forms.MainFrm.UpdateStatusLabel("Verifying Library and Playlist congruency with \"" + ConnectionInfo.Name + "\".");
						Send(Protocol.CreateREQUESTPLAYLISTLIST()); 
						#endregion
					} else if (ConnectionMode == ConnectionMode.LibraryRequest) {
						#region LibraryRequest
						Forms.MainFrm.UpdateStatusLabel("Verifying Library congruency with \"" + ConnectionInfo.Name + "\".");
						Log.AddServerText("Requesting Library from \"" + ConnectionInfo.Name + "\".", Index);
						Send(Protocol.CreateREQUESTLIBRARY(DateTime.Parse("1/1/1900")));
						#endregion
					} else if (ConnectionMode == ConnectionMode.SongRequest) {
						#region SongRequest
						if (ConnectionParams[0] != null) {
							Log.AddServerText("Requested song (MD5: " + ConnectionParams[0] + ") from \"" + ConnectionInfo.Name + "\"", Index);
							Send(Protocol.CreateREQUESTSONG(ConnectionParams[0]));
						}
						#endregion
					} else if (ConnectionMode == ConnectionMode.OnlineTest) {
						#region OnlineTest
						Forms.MainFrm.UpdateStatusLabel("Ready");
						Send(Protocol.CreateGOODBYE());
						#endregion
					} else if (ConnectionMode == ConnectionMode.PlaylistRequest) {
						#region PlaylistRequest
						Forms.MainFrm.UpdateStatusLabel("Requesting playlist from \"" + ConnectionInfo.Name + "\".");
						Log.AddServerText("Requesting Playlist from \"" + ConnectionInfo.Name + "\".", Index);
						Send(Protocol.CreateREQUESTPLAYLIST(ConnectionParams[0]));
						#endregion
					} else if (ConnectionMode == ConnectionMode.PlaylistListRequest) {
						#region PlaylistListRequest
						Forms.MainFrm.UpdateStatusLabel("Requesting playlist list from \"" + ConnectionInfo.Name + "\".");
						Log.AddServerText("Requesting Playlist List from \"" + ConnectionInfo.Name + "\".", Index);
						Send(Protocol.CreateREQUESTPLAYLISTLIST());
						#endregion
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
								Config.Instance.ConnectionInfoList[Functions.ConnectionInfoInternalGUIDToIndex(Config.Instance.ConnectionInfoList, ConnectionInfo.InternalGUID)] = ConnectionInfo;
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
							case "PLAYLISTLISTFINISHED":
								#region PLAYLISTLISTFINISHED
								Log.AddServerText("Finished download playlist listing.", Index);
								Forms.MainFrm.PopulatePlaylistComb();
								Forms.MainFrm.UpdateStatusLabel("Ready");
								break;
								#endregion
							case "PLAYLISTLIST":
								#region PLAYLISTLIST
								requestData = tokenData[1].Split(spaceDelim, 4);
								PlaylistManager.AddRemotePlaylist(ConnectionInfo.GUID, requestData[3], Convert.ToInt32(requestData[1]), requestData[2]);
								Config.Instance.ConnectionInfoList[Functions.ConnectionInfoInternalGUIDToIndex(Config.Instance.ConnectionInfoList, ConnectionInfo.InternalGUID)] = ConnectionInfo;
								break;
								#endregion
							case "PLAYLIST":
								#region PLAYLIST
								Forms.MainFrm.UpdateStatusLabel("Ready");
								String tempGUID = requestData[1].Substring((requestData[1].IndexOf("<guid>") + 6), (requestData[1].IndexOf("</guid>") - requestData[1].IndexOf("<guid>") - 6));
								for (int i = 0; i < PlaylistManager.RemotePlaylistList.Count; i++) {
									if (PlaylistManager.RemotePlaylistList[i].GUID == tempGUID) {
										PlaylistManager.RemotePlaylistList[i].ImportXMLString(requestData[1]);
										Forms.MainFrm.UpdateActivePlaylistDGV(PlaylistManager.RemotePlaylistList[i].SongList);
										break;
									}
								}
								break;
								#endregion
							case "SONGKEY":
								#region SONGKEY
								requestData = tokenData[1].Split(spaceDelim, 3);
								ActiveSong.SongInfo = Library.MD5ToSongInfo(requestData[1]);
								Forms.MainFrm.UpdateStatusLabel("Starting to buffer \"" + ActiveSong.SongInfo.Title + "\" from \"" + ConnectionInfo.Name + "\".");
								Forms.MainFrm.UpdateBufferingProgressBar("SetMin", Convert.ToInt32(ActiveSong.SongInfo.StartByte));
								Forms.MainFrm.UpdateBufferingProgressBar("SetMax", Convert.ToInt32(ActiveSong.SongInfo.EndByte));
								Forms.MainFrm.UpdateBufferingProgressBar("Value", Convert.ToInt32(ActiveSong.SongInfo.StartByte));
								String[] inputString = new String[1];
								inputString[0] = requestData[2];
								CommStream.ConnectToServer(ConnectionInfo, ConnectionMode.SongRequest, inputString);
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
