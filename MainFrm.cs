using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BooBox;

namespace BooBoxClient {
	public partial class MainFrm : Form {

		// TODO: Avoid server name collisions by putting duplicate server names in the format of "Server Name (IP:Port)"
		// TODO: Duplicate servers appears when you edit a server.
		// TODO: First connection to a server shows all songs in red. Server not marked as "online".
		// TODO: Trim() hostname on Add/Edit Connection.

		#region Form Variables
		private Boolean DisablePlaylistButtonUpdating = false;
		private Boolean CurrentPlaylistIsLocal = false;
		private ContextMenu MusicLibraryCM = new ContextMenu();
		private ContextMenu PlaylistCM = new ContextMenu();
		#endregion

		#region Form Delegates
		public delegate void PushSettingsToFormDelegate();
		public void PushSettingsToForm() {
			if (this.InvokeRequired) {
				this.Invoke(new PushSettingsToFormDelegate(PushSettingsToForm));
			} else {
				this.Text = "BooBox Client : " + Config.Instance.ClientName;
				#region LoadConnection
				ToolStripDropDownItem ConnectToServerItem = (ToolStripDropDownItem)((ToolStripDropDownItem)MenuStrip.Items["FileMenuHeader"]).DropDownItems["ConnectToServerMenuItem"];
				ToolStripDropDownItem EditServerItem = (ToolStripDropDownItem)((ToolStripDropDownItem)MenuStrip.Items["FileMenuHeader"]).DropDownItems["EditServerMenuItem"];
				ToolStripDropDownItem DeleteServerItem = (ToolStripDropDownItem)((ToolStripDropDownItem)MenuStrip.Items["FileMenuHeader"]).DropDownItems["DeleteServerMenuItem"];
				ConnectToServerItem.DropDownItems.Clear();
				EditServerItem.DropDownItems.Clear();
				DeleteServerItem.DropDownItems.Clear();
				ToolStripMenuItem[] connectToServerItemArr = new ToolStripMenuItem[Config.Instance.ConnectionInfoList.Count];
				ToolStripMenuItem[] editServerItemArr = new ToolStripMenuItem[Config.Instance.ConnectionInfoList.Count];
				ToolStripMenuItem[] deleteServerItemArr = new ToolStripMenuItem[Config.Instance.ConnectionInfoList.Count];
				ToolStripMenuItem tempTSMI = new ToolStripMenuItem();
				tempTSMI.Name = "ConnectToServerItem0";
				tempTSMI.Tag = "Connect To All";
				tempTSMI.Text = "Connect To All";
				tempTSMI.Click += new EventHandler(ConnectToAllMenuItem_Click);
				ConnectToServerItem.DropDownItems.Add(tempTSMI);
				ConnectToServerItem.DropDownItems.Add(new ToolStripSeparator());
				for (int x = 0; x < Config.Instance.ConnectionInfoList.Count; x++) {
					connectToServerItemArr[x] = new ToolStripMenuItem();
					connectToServerItemArr[x].Name = "ConnectToServerItem" + x;
					connectToServerItemArr[x].Tag = Config.Instance.ConnectionInfoList[x];
					connectToServerItemArr[x].Text = Config.Instance.ConnectionInfoList[x].Description;
					connectToServerItemArr[x].Click += new EventHandler(ConnectToServerMenuItem_Click);
					editServerItemArr[x] = new ToolStripMenuItem();
					editServerItemArr[x].Name = "EditServerItem" + x;
					editServerItemArr[x].Tag = Config.Instance.ConnectionInfoList[x];
					editServerItemArr[x].Text = "Edit \"" + Config.Instance.ConnectionInfoList[x].Description + "\"";
					editServerItemArr[x].Click += new EventHandler(EditServerMenuItem_Click);
					deleteServerItemArr[x] = new ToolStripMenuItem();
					deleteServerItemArr[x].Name = "DeleteServerItem" + x;
					deleteServerItemArr[x].Tag = Config.Instance.ConnectionInfoList[x];
					deleteServerItemArr[x].Text = "Delete \"" + Config.Instance.ConnectionInfoList[x].Description + "\"";
					deleteServerItemArr[x].Click += new EventHandler(DeleteServerMenuItem_Click);
				}
				ConnectToServerItem.DropDownItems.AddRange(connectToServerItemArr);
				DeleteServerItem.DropDownItems.AddRange(deleteServerItemArr);
				EditServerItem.DropDownItems.AddRange(editServerItemArr);
				#endregion
				#region DataBufferSize
				if (Config.Instance.DataBufferSize == 512) {
					Bytes512MenuItem.Checked = true; Bytes1024MenuItem.Checked = false; Bytes2048MenuItem.Checked = false; Bytes4096MenuItem.Checked = false; Bytes8192MenuItem.Checked = false;
				} else if (Config.Instance.DataBufferSize == 1024) {
					Bytes512MenuItem.Checked = false; Bytes1024MenuItem.Checked = true; Bytes2048MenuItem.Checked = false; Bytes4096MenuItem.Checked = false; Bytes8192MenuItem.Checked = false;
				} else if (Config.Instance.DataBufferSize == 2048) {
					Bytes512MenuItem.Checked = false; Bytes1024MenuItem.Checked = false; Bytes2048MenuItem.Checked = true; Bytes4096MenuItem.Checked = false; Bytes8192MenuItem.Checked = false;
				} else if (Config.Instance.DataBufferSize == 4096) {
					Bytes512MenuItem.Checked = false; Bytes1024MenuItem.Checked = false; Bytes2048MenuItem.Checked = false; Bytes4096MenuItem.Checked = true; Bytes8192MenuItem.Checked = false;
				} else if (Config.Instance.DataBufferSize == 8192) {
					Bytes512MenuItem.Checked = false; Bytes1024MenuItem.Checked = false; Bytes2048MenuItem.Checked = false; Bytes4096MenuItem.Checked = false; Bytes8192MenuItem.Checked = true;
				}
				#endregion
				#region BufferAtPercent
				if (Config.Instance.BufferAtPercent == 0.05) {
					Percent5MenuItem.Checked = true; Percent10MenuItem.Checked = false; Percent25MenuItem.Checked = false; Percent50MenuItem.Checked = false; Percent100MenuItem.Checked = false;
				} else if (Config.Instance.BufferAtPercent == 0.1) {
					Percent5MenuItem.Checked = false; Percent10MenuItem.Checked = true; Percent25MenuItem.Checked = false; Percent50MenuItem.Checked = false; Percent100MenuItem.Checked = false;
				} else if (Config.Instance.BufferAtPercent == 0.25) {
					Percent5MenuItem.Checked = false; Percent10MenuItem.Checked = false; Percent25MenuItem.Checked = true; Percent50MenuItem.Checked = false; Percent100MenuItem.Checked = false;
				} else if (Config.Instance.BufferAtPercent == 0.5) {
					Percent5MenuItem.Checked = false; Percent10MenuItem.Checked = false; Percent25MenuItem.Checked = false; Percent50MenuItem.Checked = true; Percent100MenuItem.Checked = false;
				} else if (Config.Instance.BufferAtPercent == 1.0) {
					Percent5MenuItem.Checked = false; Percent10MenuItem.Checked = false; Percent25MenuItem.Checked = false; Percent50MenuItem.Checked = false; Percent100MenuItem.Checked = true;
				}
				#endregion
				#region RepeatMode
				if (Config.Instance.RepeatMode == RepeatMode.Off) {
					RepeatOffMenuItem.Checked = true; RepeatOneMenuItem.Checked = false; RepeatAllMenuItem.Checked = false;
				} else if (Config.Instance.RepeatMode == RepeatMode.One) {
					RepeatOffMenuItem.Checked = false; RepeatOneMenuItem.Checked = true; RepeatAllMenuItem.Checked = false;
				} else if (Config.Instance.RepeatMode == RepeatMode.All) {
					RepeatOffMenuItem.Checked = false; RepeatOneMenuItem.Checked = false; RepeatAllMenuItem.Checked = true;
				}
				#endregion
				#region ShuffleMode
				if (Config.Instance.ShuffleMode == ShuffleMode.Off) {
					ShuffleOffMenuItem.Checked = true; ShuffleOnMenuItem.Checked = false;
				} else if (Config.Instance.ShuffleMode == ShuffleMode.On) {
					ShuffleOffMenuItem.Checked = false; ShuffleOnMenuItem.Checked = true;
				}
				#endregion
			}
		}
		public delegate void UpdateStatusProgressBarDelegate(String Mode, int Param);
		public void UpdateStatusProgressBar(String Mode, int Param) {
			if (this.InvokeRequired) {
				this.Invoke(new UpdateStatusProgressBarDelegate(UpdateStatusProgressBar), Mode, Param);
			} else {
				if (Mode == "SetMax") {
					ProgressBarStatusStrip.Maximum = Param;
				} else if (Mode == "SetMin") {
					ProgressBarStatusStrip.Minimum = Param;
				} else if (Mode == "Increment") {
					if (ProgressBarStatusStrip.Maximum > 0) {
						ProgressBarStatusStrip.Increment(Param);
					}
				} else if (Mode == "Reset") {
					ProgressBarStatusStrip.Value = 0;
					ProgressBarStatusStrip.Maximum = 0;
					ProgressBarStatusStrip.Minimum = 0;
				}
			}
		}
		public delegate void UpdateStatusLabelDelegate(String StatusText);
		public void UpdateStatusLabel(String StatusText) {
			if (this.InvokeRequired) {
				this.Invoke(new UpdateStatusLabelDelegate(UpdateStatusLabel), StatusText);
			} else {
				ProgressBarLblStatusStrip.Text = StatusText;
			}
		}
		public delegate void UpdateMusicLibraryDGVDelegate(List<SongInfo> SongList);
		public void UpdateMusicLibraryDGV(List<SongInfo> SongList) {
			if (this.InvokeRequired) {
				Thread WorkerThread = new Thread(delegate() { this.Invoke(new UpdateMusicLibraryDGVDelegate(UpdateMusicLibraryDGV), SongList); }); WorkerThread.Start();
			} else {
				int newRowNum, artistCount = 0, albumCount = 0;
				ArrayList artistList = new ArrayList();
				ArrayList albumList = new ArrayList();
				MusicLibraryDGV.Rows.Clear();
				for (int i = 0; i < SongList.Count; i++) {
					newRowNum = MusicLibraryDGV.Rows.Add();
					if (ServerManager.ServerOnline(SongList[i].ServerGUID) == true) {
						MusicLibraryDGV.Rows[newRowNum].DefaultCellStyle.ForeColor = Color.Black;
					} else {
						MusicLibraryDGV.Rows[newRowNum].DefaultCellStyle.ForeColor = Color.DarkRed;
					}
					MusicLibraryDGV.Rows[newRowNum].Cells[0].Value = SongList[i].Title;
					MusicLibraryDGV.Rows[newRowNum].Cells[1].Value = Functions.StringArrToDelimitedStr(SongList[i].AlbumArtists, "; ");
					MusicLibraryDGV.Rows[newRowNum].Cells[2].Value = SongList[i].Album;
					MusicLibraryDGV.Rows[newRowNum].Cells[3].Value = Functions.MillisecondsToHumanReadable(SongList[i].PlayLength);
					MusicLibraryDGV.Rows[newRowNum].Cells[4].Value = Functions.BytesToHumanReadable(SongList[i].FileLength, 1);
					MusicLibraryDGV.Rows[newRowNum].Cells[5].Value = Functions.StringArrToDelimitedStr(SongList[i].Genres, "; ");
					MusicLibraryDGV.Rows[newRowNum].Cells[6].Value = SongList[i].Track;
					MusicLibraryDGV.Rows[newRowNum].Cells[7].Value = SongList[i].Year;
					MusicLibraryDGV.Rows[newRowNum].Cells[8].Value = SongList[i].Comment;
					MusicLibraryDGV.Rows[newRowNum].Cells[9].Value = Functions.ServerGUIDToConnectionInfo(Config.Instance.ConnectionInfoList, SongList[i].ServerGUID).Name;
					MusicLibraryDGV.Rows[newRowNum].Cells[10].Value = SongList[i].PlayLength.ToString("00000000");
					MusicLibraryDGV.Rows[newRowNum].Cells[11].Value = SongList[i].FileLength.ToString("000000000");
					MusicLibraryDGV.Rows[newRowNum].Cells[12].Value = SongList[i].Track.ToString("00000");
					MusicLibraryDGV.Rows[newRowNum].Cells[13].Value = SongList[i].Year.ToString("00000");
					if (!artistList.Contains(MusicLibraryDGV.Rows[newRowNum].Cells[1].Value)) {
						artistCount++;
						artistList.Add(MusicLibraryDGV.Rows[newRowNum].Cells[1].Value);
					}
					if (!albumList.Contains(SongList[i].Album)) {
						albumCount++;
						albumList.Add(SongList[i].Album);
					}
					MusicLibraryDGV.Rows[newRowNum].Tag = SongList[i];
				}
				MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
				MusicLibraryDGV.Columns[0].HeaderText = "Title (" + SongList.Count + ")";
				MusicLibraryDGV.Columns[1].HeaderText = "Artists (" + artistCount + ")";
				MusicLibraryDGV.Columns[2].HeaderText = "Album (" + albumCount + ")";
			}
		}
		public delegate void PopulatePlaylistCombDelegate();
		public void PopulatePlaylistComb() {
			if (this.InvokeRequired) {
				this.Invoke(new PopulatePlaylistCombDelegate(PopulatePlaylistComb));
			} else {
				PlaylistAPComb.Items.Clear();
				PlaylistMLComb.Items.Clear();
				for (int i = 0; i < PlaylistManager.LocalPlaylistList.Count; i++) {
					PlaylistAPComb.Items.Add(PlaylistManager.LocalPlaylistList[i]);
					PlaylistMLComb.Items.Add(PlaylistManager.LocalPlaylistList[i]);
				}
				for (int i = 0; i < PlaylistManager.RemotePlaylistList.Count; i++) {
					PlaylistAPComb.Items.Add(PlaylistManager.RemotePlaylistList[i]);
				}
			}
		}
		public delegate void UpdateActivePlaylistDGVDelegate(List<SongInfo> SongList);
		public void UpdateActivePlaylistDGV(List<SongInfo> SongList) {
			if (this.InvokeRequired) {
				Thread WorkerThread = new Thread(delegate() { this.Invoke(new UpdateActivePlaylistDGVDelegate(UpdateActivePlaylistDGV), SongList); }); WorkerThread.Start();
			} else {
				int newRowNum, artistCount = 0, albumCount = 0;
				ArrayList artistList = new ArrayList();
				ArrayList albumList = new ArrayList();
				ActivePlaylistDGV.Rows.Clear();
				for (int i = 0; i < SongList.Count; i++) {
					newRowNum = ActivePlaylistDGV.Rows.Add();
					if (ServerManager.ServerOnline(SongList[i].ServerGUID) == true) {
						ActivePlaylistDGV.Rows[newRowNum].DefaultCellStyle.ForeColor = Color.Black;
					} else {
						ActivePlaylistDGV.Rows[newRowNum].DefaultCellStyle.ForeColor = Color.DarkRed;
					}
					ActivePlaylistDGV.Rows[newRowNum].Cells[0].Value = i;
					ActivePlaylistDGV.Rows[newRowNum].Cells[1].Value = SongList[i].Title;
					ActivePlaylistDGV.Rows[newRowNum].Cells[2].Value = Functions.StringArrToDelimitedStr(SongList[i].AlbumArtists, "; ");
					ActivePlaylistDGV.Rows[newRowNum].Cells[3].Value = SongList[i].Album;
					ActivePlaylistDGV.Rows[newRowNum].Cells[4].Value = Functions.MillisecondsToHumanReadable(SongList[i].PlayLength);
					ActivePlaylistDGV.Rows[newRowNum].Cells[5].Value = Functions.BytesToHumanReadable(SongList[i].FileLength, 1);
					ActivePlaylistDGV.Rows[newRowNum].Cells[6].Value = Functions.StringArrToDelimitedStr(SongList[i].Genres, "; ");
					ActivePlaylistDGV.Rows[newRowNum].Cells[7].Value = SongList[i].Track;
					ActivePlaylistDGV.Rows[newRowNum].Cells[8].Value = SongList[i].Year;
					ActivePlaylistDGV.Rows[newRowNum].Cells[9].Value = SongList[i].Comment;
					ActivePlaylistDGV.Rows[newRowNum].Cells[10].Value = Functions.ServerGUIDToConnectionInfo(Config.Instance.ConnectionInfoList, SongList[i].ServerGUID).Name;
					ActivePlaylistDGV.Rows[newRowNum].Cells[11].Value = SongList[i].PlayLength.ToString("00000000");
					ActivePlaylistDGV.Rows[newRowNum].Cells[12].Value = SongList[i].FileLength.ToString("000000000");
					ActivePlaylistDGV.Rows[newRowNum].Cells[13].Value = SongList[i].Track.ToString("00000");
					ActivePlaylistDGV.Rows[newRowNum].Cells[14].Value = SongList[i].Year.ToString("00000");
					if (!artistList.Contains(ActivePlaylistDGV.Rows[newRowNum].Cells[2].Value)) {
						artistCount++;
						artistList.Add(ActivePlaylistDGV.Rows[newRowNum].Cells[2].Value);
					}
					if (!albumList.Contains(SongList[i].Album)) {
						albumCount++;
						albumList.Add(SongList[i].Album);
					}
					ActivePlaylistDGV.Rows[newRowNum].Tag = SongList[i];
				}
				ActivePlaylistDGV.Columns[1].HeaderText = "Title (" + SongList.Count + ")";
				ActivePlaylistDGV.Columns[2].HeaderText = "Artists (" + artistCount + ")";
				ActivePlaylistDGV.Columns[3].HeaderText = "Album (" + albumCount + ")";
				UpdatePlaylistButtons();
			}
		}
		#endregion

		#region Form Functions
		private void MoveTimeStamp() {
			int startOffset = SongTrack.Location.X;
			double percentage = SongTrack.Value / Convert.ToDouble(SongTrack.Maximum);
			int newX = startOffset + Convert.ToInt32((percentage * (SongTrack.Width - 27)));
			if (newX < (SongTrack.Location.X + 5)) { newX = (SongTrack.Location.X + 5); } else if (newX > (SongTrack.Location.X + SongTrack.Width - 32)) { newX = (SongTrack.Location.X + SongTrack.Width - 32); }
			CounterLbl.Location = new System.Drawing.Point(newX, CounterLbl.Location.Y);
		}
		private void UpdatePlaylistButtons() {
			if (DisablePlaylistButtonUpdating == false) {
				if (ActivePlaylistDGV.SelectedRows.Count > 0) {
					ArrayList SelectionAL = new ArrayList();
					for (int i = 0; i < ActivePlaylistDGV.SelectedRows.Count; i++) { SelectionAL.Add(ActivePlaylistDGV.SelectedRows[i].Index); }
					SelectionAL.Sort();
					UpCmd.Enabled = true;
					ToTopCmd.Enabled = true;
					DownCmd.Enabled = true;
					ToBottomCmd.Enabled = true;
					DelCmd.Enabled = true;
					if ((int)SelectionAL[0] == 0) {
						UpCmd.Enabled = false;
						ToTopCmd.Enabled = false;
					}
					if ((int)SelectionAL[SelectionAL.Count - 1] == (ActivePlaylistDGV.Rows.Count - 1)) {
						DownCmd.Enabled = false;
						ToBottomCmd.Enabled = false;
					}
				} else {
					UpCmd.Enabled = false;
					ToTopCmd.Enabled = false;
					DownCmd.Enabled = false;
					ToBottomCmd.Enabled = false;
					DelCmd.Enabled = false;
				}
			}
		}
		private void SaveCurrentPlaylist() {
			List<SongInfo> tempSIL = new List<SongInfo>();
			for (int i = 0; i < ActivePlaylistDGV.RowCount; i++) {
				tempSIL.Add((SongInfo)ActivePlaylistDGV.Rows[i].Tag);
				ActivePlaylistDGV.Rows[i].Cells[0].Value = i;
			}
			PlaylistManager.OverwritePlaylistByName(tempSIL, ((LocalPlaylist)PlaylistAPComb.SelectedItem).Name);
			PlaylistAPComb.Text = ((LocalPlaylist)PlaylistAPComb.SelectedItem).ToString();
		}
		#endregion

		#region Form Event Handlers
		public MainFrm() {
			InitializeComponent();
		}
		private void MainFrm_Resize(object sender, EventArgs e) {
			//#region Vertical Calculations
			//int PlaylistButtonHeight = Convert.ToInt32((ActivePlaylistDGV.Height - 23) * 0.212);
			//ToTopCmd.Height = PlaylistButtonHeight;
			//UpCmd.Height = PlaylistButtonHeight;
			//// Exact Calculation: 0.152073732718894
			//DelCmd.Height = Convert.ToInt32((ActivePlaylistDGV.Height - 23) * 0.1521);
			//DownCmd.Height = PlaylistButtonHeight;
			//ToBottomCmd.Height = PlaylistButtonHeight;
			//UpCmd.Top = ToTopCmd.Top + ToTopCmd.Height + 6;
			//DelCmd.Top = UpCmd.Top + UpCmd.Height + 6;
			//DownCmd.Top = DelCmd.Top + DelCmd.Height + 6;
			//ToBottomCmd.Top = DownCmd.Top + DownCmd.Height + 6;
			//#endregion
			int PlaylistButtonHeight = Convert.ToInt32((ActivePlaylistDGV.Height - 23) * 0.212);
			ToTopCmd.Height = PlaylistButtonHeight;
			UpCmd.Height = PlaylistButtonHeight;
			DelCmd.Height = Convert.ToInt32((ActivePlaylistDGV.Height - 23) * 0.1521);
			DownCmd.Height = PlaylistButtonHeight;
			ToBottomCmd.Height = PlaylistButtonHeight;
			UpCmd.Top = ToTopCmd.Top + ToTopCmd.Height + 6;
			DelCmd.Top = UpCmd.Top + UpCmd.Height + 6;
			DownCmd.Top = DelCmd.Top + DelCmd.Height + 6;
			ToBottomCmd.Top = DownCmd.Top + DownCmd.Height + 6;
		}
		private void MainFrm_Load(object sender, EventArgs e) {
			this.WindowState = Config.Instance.MainFrmWindowState;
			this.Width = Config.Instance.MainFrmWindowSizeWidth;
			this.Height = Config.Instance.MainFrmWindowSizeHeight;
			Forms.MainFrm = this;
			Log.AddStatusText("BooBox Client started.");
			ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new MenuStripNoGradient());
			if (Config.Instance.Configured == false) {
				Log.AddStatusText("No configuration file loaded. Assuming new installation. Starting the First Run Wizard.");
				InputBoxResult ClientRequestBox = InputBox.Show(
					"Enter a Client Name:\n\nThis will be used to uniquely identify you to a Server.",
					"Client Name Entry"
				);
				if (ClientRequestBox.ReturnCode == DialogResult.OK) {
					if (ClientRequestBox.Text.Length > 200) {
						MessageBox.Show("Client name may not be longer than 200 characters. Client name has not been changed.");
					} else {
						Log.AddStatusText("Changed client name from \"" + Config.Instance + "\" to \"" + ClientRequestBox.Text + "\".");
						Config.Instance.ClientName = ClientRequestBox.Text;
						Config.Instance.Configured = true;
						Config.Instance.Save();
					}
				}
			}
			ServerManager.VerifyUpToDate();
			Library.LoadSettings();
			PlaylistManager.LocalPlaylistList = Config.Instance.LocalPlaylistList;
			MusicLibraryDGV.ClearSelection();
			PushSettingsToForm();
			PopulatePlaylistComb();
		}
		private void MainFrm_FormClosing(object sender, FormClosingEventArgs e) {
			Config.Instance.MainFrmWindowState = this.WindowState;
			Config.Instance.MainFrmWindowSizeWidth = this.Width;
			Config.Instance.MainFrmWindowSizeHeight = this.Height;
			Library.SaveSettings();
			Config.Instance.LocalPlaylistList = PlaylistManager.LocalPlaylistList;
			Config.Instance.Save();
			Log.AddStatusText("BooBox Server close by user.");
			Log.CloseLog();
		}
		#endregion

		#region Menu Item Event Handlers
		// File Menu
		private void SaveSettingsMenuItem_Click(object sender, EventArgs e) {
			Config.Instance.Save();
		}
		private void ConnectToAllMenuItem_Click(object sender, EventArgs e) {
			Console.WriteLine("Connect To All");
			//CommInfo.ConnectToServer(Config.Instance.ConnectionList[Convert.ToInt32(clickedItem.Tag)], "Full", "");
		}
		private void ConnectToServerMenuItem_Click(object sender, EventArgs e) {
			ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
			String[] emptyString = new String[0];
			CommInfo.ConnectToServer((ConnectionInfo)clickedItem.Tag, ConnectionMode.LibraryRequest, emptyString);
		}
		private void EditServerMenuItem_Click(object sender, EventArgs e) {
			ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
			ConnectionFrm ConnectionFrm = new ConnectionFrm();
			ConnectionFrm.Show();
			ConnectionFrm.SetMode("Edit", (ConnectionInfo)clickedItem.Tag);
		}
		private void DeleteServerMenuItem_Click(object sender, EventArgs e) {
			ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
			ConnectionInfo tempCI = (ConnectionInfo)clickedItem.Tag;
			DialogResult tempMSResult = DialogResult.OK;
			if (tempCI.GUID != "") {
				tempMSResult = MessageBox.Show("This will remove all songs related to \"" + tempCI.Description + "\" from the Music Library and all Playlists. Would you like to continue?", "Remove all traces of server?", MessageBoxButtons.YesNo);
			}
			if (tempMSResult == DialogResult.OK) {
				Config.Instance.ConnectionInfoList.Remove(tempCI);
				if (tempCI.GUID != "") {
					Library.RemoveSongsByGUID(tempCI.GUID);
				}
			}
			PushSettingsToForm();
		}
		private void AddServerMenuItem_Click(object sender, EventArgs e) {
			ConnectionFrm ConnectionFrm = new ConnectionFrm();
			ConnectionFrm.SetMode("New");
			ConnectionFrm.Show();
		}
		private void ExportSettingsMenuItem_Click(object sender, EventArgs e) {
			SaveFileDialog.ShowDialog();
			String SaveFileAs = SaveFileDialog.FileName;
			if (SaveFileAs != "") {
				Config.Instance.Save(SaveFileAs);
			}
		}
		private void ImportSettingsMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog.ShowDialog();
			String OpenFilename = OpenFileDialog.FileName;
			if (OpenFilename != "") {
				Config.Instance.Load(OpenFilename);
			}
		}
		private void ExitMenuItem_Click(object sender, EventArgs e) {
			this.Close();
		}
		// Controls Menu
		private void PlayMenuItem_Click(object sender, EventArgs e) {

		}
		private void NextMenuItem_Click(object sender, EventArgs e) {

		}
		private void PreviousMenuItem_Click(object sender, EventArgs e) {

		}
		private void VolumeUpMenuItem_Click(object sender, EventArgs e) {

		}
		private void VolumeDownMenuItem_Click(object sender, EventArgs e) {

		}
		private void ShuffleOffMenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Shuffle Mode from " + Config.Instance.ShuffleMode.ToString() + " to Off.");
			Config.Instance.ShuffleMode = ShuffleMode.Off;
			PushSettingsToForm();
		}
		private void ShuffleOnMenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Shuffle Mode from " + Config.Instance.ShuffleMode.ToString() + " to On.");
			Config.Instance.ShuffleMode = ShuffleMode.On;
			PushSettingsToForm();
		}
		private void RepeatOffMenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Repeat Mode from " + Config.Instance.RepeatMode.ToString() + " to Off.");
			Config.Instance.RepeatMode = RepeatMode.Off;
			PushSettingsToForm();
		}
		private void RepeatOneMenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Repeat Mode from " + Config.Instance.RepeatMode.ToString() + " to One.");
			Config.Instance.RepeatMode = RepeatMode.One;
			PushSettingsToForm();
		}
		private void RepeatAllMenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Repeat Mode from " + Config.Instance.RepeatMode.ToString() + " to All.");
			Config.Instance.RepeatMode = RepeatMode.All;
			PushSettingsToForm();
		}
		// Options Menu
		private void ChangeClientNameMenuItem_Click(object sender, EventArgs e) {
			InputBoxResult ClientRequestBox = InputBox.Show(
				"Enter a Client Name:\n\nThis will be used to uniquely identify you to a Server.",
				"Client Name Entry"
			);
			if (ClientRequestBox.ReturnCode == DialogResult.OK) {
				if (ClientRequestBox.Text.Length > 200) {
					MessageBox.Show("Client name may not be longer than 200 characters. Client name has not been changed.");
				} else {
					Log.AddStatusText("Changed client name from \"" + Config.Instance + "\" to \"" + ClientRequestBox.Text + "\".");
					Config.Instance.ClientName = ClientRequestBox.Text;
					Config.Instance.Save();
				}
			}
			PushSettingsToForm();
		}
		private void Bytes512MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Data Buffer Size from " + Config.Instance.DataBufferSize.ToString() + " bytes to 512 bytes.");
			Config.Instance.DataBufferSize = 512;
			PushSettingsToForm();
		}
		private void Bytes1024MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Data Buffer Size from " + Config.Instance.DataBufferSize.ToString() + " bytes to 1024 bytes.");
			Config.Instance.DataBufferSize = 1024;
			PushSettingsToForm();
		}
		private void Bytes2048MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Data Buffer Size from " + Config.Instance.DataBufferSize.ToString() + " bytes to 2048 bytes.");
			Config.Instance.DataBufferSize = 2048;
			PushSettingsToForm();
		}
		private void Bytes4096MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Data Buffer Size from " + Config.Instance.DataBufferSize.ToString() + " bytes to 4096 bytes.");
			Config.Instance.DataBufferSize = 4096;
			PushSettingsToForm();
		}
		private void Bytes8192MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Data Buffer Size from " + Config.Instance.DataBufferSize.ToString() + " bytes to 8192 bytes.");
			Config.Instance.DataBufferSize = 8192;
			PushSettingsToForm();
		}
		private void Percent5MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Buffer at Percent from " + (Config.Instance.DataBufferSize * 100).ToString() + "% to 5%.");
			Config.Instance.BufferAtPercent = 0.05;
			PushSettingsToForm();
		}
		private void Percent10MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Buffer at Percent from " + (Config.Instance.DataBufferSize * 100).ToString() + "% to 10%.");
			Config.Instance.BufferAtPercent = 0.1;
			PushSettingsToForm();
		}
		private void Percent25MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Buffer at Percent from " + (Config.Instance.DataBufferSize * 100).ToString() + "% to 25%.");
			Config.Instance.BufferAtPercent = 0.25;
			PushSettingsToForm();
		}
		private void Percent50MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Buffer at Percent from " + (Config.Instance.DataBufferSize * 100).ToString() + "% to 50%.");
			Config.Instance.BufferAtPercent = 0.5;
			PushSettingsToForm();
		}
		private void Percent100MenuItem_Click(object sender, EventArgs e) {
			Log.AddStatusText("Changed Buffer at Percent from " + (Config.Instance.DataBufferSize * 100).ToString() + "% to 100%.");
			Config.Instance.BufferAtPercent = 1.0;
			PushSettingsToForm();
		}
		// Help Menu
		private void AboutMenuItem_Click(object sender, EventArgs e) {
			AboutFrm AboutFrm = new AboutFrm();
			AboutFrm.Show();
		}
		private void HelpMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("Help not yet implemented.");
		}
		#endregion

		#region MusicLibraryDGV Event Handlers
		private void MusicLibraryDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			MusicLibraryDGV.Columns[3].HeaderCell.SortGlyphDirection = SortOrder.None;
			MusicLibraryDGV.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.None;
			MusicLibraryDGV.Columns[6].HeaderCell.SortGlyphDirection = SortOrder.None;
			MusicLibraryDGV.Columns[7].HeaderCell.SortGlyphDirection = SortOrder.None;
			if (e.ColumnIndex == 3) {
				#region Play Length Column
				if (MusicLibraryDGV.SortOrder == SortOrder.Ascending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[10], ListSortDirection.Descending);
					MusicLibraryDGV.Columns[3].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[10], ListSortDirection.Ascending);
					MusicLibraryDGV.Columns[3].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 4) {
				#region File Length Column
				if (MusicLibraryDGV.SortOrder == SortOrder.Ascending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[11], ListSortDirection.Descending);
					MusicLibraryDGV.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[11], ListSortDirection.Ascending);
					MusicLibraryDGV.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 6) {
				#region Track Column
				if (MusicLibraryDGV.SortOrder == SortOrder.Ascending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[12], ListSortDirection.Descending);
					MusicLibraryDGV.Columns[6].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[12], ListSortDirection.Ascending);
					MusicLibraryDGV.Columns[6].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 7) {
				#region Year Column
				if (MusicLibraryDGV.SortOrder == SortOrder.Ascending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[13], ListSortDirection.Descending);
					MusicLibraryDGV.Columns[7].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[13], ListSortDirection.Ascending);
					MusicLibraryDGV.Columns[7].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			}
		}
		private void MusicLibraryDGV_SelectionChanged(object sender, EventArgs e) {
			if (PlaylistMLComb.SelectedIndex != -1) { AddToPlaylistMLCmd.Enabled = true; }
		}
		private void MusicLibraryDGV_MouseUp(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				MusicLibraryCM.MenuItems.Clear();
				MenuItem[] tempAddBySongCMMI = new MenuItem[PlaylistManager.LocalPlaylistList.Count];
				for (int i = 0; i < PlaylistManager.LocalPlaylistList.Count; i++) {
					tempAddBySongCMMI[i] = new MenuItem();
					tempAddBySongCMMI[i].Text = PlaylistManager.LocalPlaylistList[i].Name;
					tempAddBySongCMMI[i].Click += new EventHandler(AddBySongMLCMMI_Click);
				}
				if (MusicLibraryDGV.SelectedRows.Count == 1) {
					MusicLibraryCM.MenuItems.Add("View Extended Song Info", new EventHandler(ViewExtendedSongInfoMLCMMI_Click)).Enabled = true;
					MusicLibraryCM.MenuItems.Add("-");
					MusicLibraryCM.MenuItems.Add("Add Selected Song To Playlist", tempAddBySongCMMI).Enabled = true;
				} else if (MusicLibraryDGV.SelectedRows.Count > 1) {
					MusicLibraryCM.MenuItems.Add("View Extended Song Info", new EventHandler(ViewExtendedSongInfoMLCMMI_Click)).Enabled = false;
					MusicLibraryCM.MenuItems.Add("-");
					MusicLibraryCM.MenuItems.Add("Add Selected Songs To Playlist", tempAddBySongCMMI).Enabled = true;
				} else {
					MusicLibraryCM.MenuItems.Add("View Extended Song Info", new EventHandler(ViewExtendedSongInfoMLCMMI_Click)).Enabled = false;
					MusicLibraryCM.MenuItems.Add("-");
					MusicLibraryCM.MenuItems.Add("Add Selected Song(s) To Playlist", tempAddBySongCMMI).Enabled = false;
				}
				MusicLibraryCM.MenuItems.Add("-");
				if (MusicLibraryDGV.SelectedRows.Count == 1) {
					MusicLibraryCM.MenuItems.Add("Select All By Selected Artist", new EventHandler(SelectAllByArtistMLCMMI_Click)).Enabled = true;
					MusicLibraryCM.MenuItems.Add("Select All In Selected Album", new EventHandler(SelectAllInAlbumMLCMMI_Click)).Enabled = true;
					MusicLibraryCM.MenuItems.Add("Select All In Selected Song's Folder", new EventHandler(SelectAllInFolderMLCMMI_Click)).Enabled = true;
					MusicLibraryCM.MenuItems.Add("Select All Matching Selected Song's Genre", new EventHandler(SelectAllInGenreMLCMMI_Click)).Enabled = true;
				} else {
					MusicLibraryCM.MenuItems.Add("Select All By Selected Artist", new EventHandler(SelectAllByArtistMLCMMI_Click)).Enabled = false;
					MusicLibraryCM.MenuItems.Add("Select All In Selected Album", new EventHandler(SelectAllInAlbumMLCMMI_Click)).Enabled = false;
					MusicLibraryCM.MenuItems.Add("Select All In Selected Song's Folder", new EventHandler(SelectAllInFolderMLCMMI_Click)).Enabled = false;
					MusicLibraryCM.MenuItems.Add("Select All Matching Selected Song's Genre", new EventHandler(SelectAllInGenreMLCMMI_Click)).Enabled = false;
				}
				MusicLibraryCM.MenuItems.Add("-");
				if (MusicLibraryDGV.SelectedRows.Count == 0) {
					MusicLibraryCM.MenuItems.Add("Clear Selection", new EventHandler(ClearSelectionMLCMMI_Click)).Enabled = false;
				} else {
					MusicLibraryCM.MenuItems.Add("Clear Selection", new EventHandler(ClearSelectionMLCMMI_Click)).Enabled = true;
				}
				MusicLibraryDGV.ContextMenu = MusicLibraryCM;
				MusicLibraryCM.Show(MusicLibraryDGV, new Point(e.X, e.Y));
			}
		}
		private void ViewExtendedSongInfoMLCMMI_Click(object sender, EventArgs e) {
			SongInfo tempSongInfo = (SongInfo)MusicLibraryDGV.SelectedRows[0].Tag;
			MessageBox.Show(
				"Extended Song Information\n" +
				"\n" +
				"Title: " + tempSongInfo.Title + "\n" +
				"Artist(s): " + Functions.StringArrToDelimitedStr(tempSongInfo.AlbumArtists, "; ") + "\n" +
				"Album: " + tempSongInfo.Album + "\n" +
				"Length: " + Functions.MillisecondsToHumanReadable(tempSongInfo.PlayLength) + "\n" +
				"Track: " + tempSongInfo.Track.ToString() + " of " + tempSongInfo.TrackCount.ToString() + "\n" +
				"Year: " + tempSongInfo.Year + "\n" +
				"Bitrate: " + tempSongInfo.BitRate.ToString() + "kbps\n" +
				"Genre(s): " + Functions.StringArrToDelimitedStr(tempSongInfo.Genres, "; ") + "\n" +
				"Comment: " + tempSongInfo.Comment + "\n" +
				"Play Count: " + tempSongInfo.PlayCount + "\n" +
				"Filename: " + tempSongInfo.FileName + "\n" +
				"Filesize: " + Functions.BytesToHumanReadable(tempSongInfo.FileLength, 3) + "\n" +
				"Metadata Size: " + Functions.BytesToHumanReadable(tempSongInfo.StartByte, 3) + "\n" +
				"Audio Data Range: " + Functions.BytesToHumanReadable(tempSongInfo.StartByte, 3) + " - " + Functions.BytesToHumanReadable(tempSongInfo.EndByte, 3) + "\n"
			);
		}
		private void AddBySongMLCMMI_Click(object sender, EventArgs e) {
			// TODO: System.NullReferenceException: Object reference not set to an instance of an object.
			String playlistName = ((MenuItem)sender).Text;
			List<SongInfo> tempSIL = new List<SongInfo>();
			for (int i = 0; i < MusicLibraryDGV.SelectedRows.Count; i++) {
				tempSIL.Add((SongInfo)MusicLibraryDGV.SelectedRows[i].Tag);
			}
			int successfulCount = PlaylistManager.AddSongInfoListToPlaylist(tempSIL, PlaylistManager.GetPlaylistByName(playlistName).GUID);
			if (PlaylistAPComb.SelectedIndex != -1) {
				if (((LocalPlaylist)PlaylistAPComb.SelectedItem).Name == playlistName) {
					UpdateActivePlaylistDGV(PlaylistManager.GetPlaylistListByName(playlistName));
				}
			}
			UpdateStatusLabel("Added " + successfulCount + " songs (" + (tempSIL.Count - successfulCount) + " duplicates skipped) to the \"" + playlistName + "\" playlist.");
		}
		private void SelectAllByArtistMLCMMI_Click(object sender, EventArgs e) {
			String tempCompare = MusicLibraryDGV.SelectedRows[0].Cells[1].Value.ToString();
			for (int i = 0; i < MusicLibraryDGV.Rows.Count; i++) {
				if (MusicLibraryDGV.Rows[i].Cells[1].Value != null) {
					if (MusicLibraryDGV.Rows[i].Cells[1].Value.ToString() == tempCompare) {
						MusicLibraryDGV.Rows[i].Selected = true;
					}
				}
			}
		}
		private void SelectAllInAlbumMLCMMI_Click(object sender, EventArgs e) {
			String tempCompare = MusicLibraryDGV.SelectedRows[0].Cells[2].Value.ToString();
			for (int i = 0; i < MusicLibraryDGV.Rows.Count; i++) {
				if (MusicLibraryDGV.Rows[i].Cells[2].Value != null) {
					if (MusicLibraryDGV.Rows[i].Cells[2].Value.ToString() == tempCompare) {
						MusicLibraryDGV.Rows[i].Selected = true;
					}
				}
			}
		}
		private void SelectAllInFolderMLCMMI_Click(object sender, EventArgs e) {
			String tempCompare = MusicLibraryDGV.SelectedRows[0].Cells[10].Value.ToString();
			tempCompare = System.IO.Path.GetDirectoryName(tempCompare);
			for (int i = 0; i < MusicLibraryDGV.Rows.Count; i++) {
				if (MusicLibraryDGV.Rows[i].Cells[10].Value != null) {
					if (System.IO.Path.GetDirectoryName(MusicLibraryDGV.Rows[i].Cells[10].Value.ToString()) == tempCompare) {
						MusicLibraryDGV.Rows[i].Selected = true;
					}
				}
			}
		}
		private void SelectAllInGenreMLCMMI_Click(object sender, EventArgs e) {
			String[] strSplit = new String[] { "; " };
			String[] srcGenres = MusicLibraryDGV.SelectedRows[0].Cells[6].Value.ToString().Split(strSplit, StringSplitOptions.RemoveEmptyEntries);
			String[] testGenres;
			for (int i = 0; i < MusicLibraryDGV.Rows.Count; i++) {
				if (MusicLibraryDGV.Rows[i].Cells[6].Value != null) {
					testGenres = MusicLibraryDGV.Rows[i].Cells[6].Value.ToString().Split(strSplit, StringSplitOptions.RemoveEmptyEntries);
					for (int x = 0; x < testGenres.Length; x++) {
						for (int y = 0; y < srcGenres.Length; y++) {
							if (testGenres[x] == srcGenres[y]) {
								MusicLibraryDGV.Rows[i].Selected = true;
								break;
							}
						}
					}
				}
			}
		}
		private void ClearSelectionMLCMMI_Click(object sender, EventArgs e) {
			MusicLibraryDGV.ClearSelection();
			AddToPlaylistMLCmd.Enabled = false;
		}
		#endregion

		#region Music Library Tab
		private void PlaylistMLComb_SelectedIndexChanged(object sender, EventArgs e) {
			if (PlaylistMLComb.SelectedIndex != -1) {
				DeletePlaylistMLCmd.Enabled = true;
				if (MusicLibraryDGV.SelectedRows.Count > 0) { AddToPlaylistMLCmd.Enabled = true; }
			} else {
				DeletePlaylistMLCmd.Enabled = false;
				AddToPlaylistMLCmd.Enabled = false;
			}
		}
		private void PlaylistMLComb_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = true;
		}
		private void NewPlaylistMLComb_Click(object sender, EventArgs e) {
			InputBoxResult PlaylistRequestBox = InputBox.Show(
				"Enter a name for your playlist:",
				"Playlist Name Entry"
			);
			if (PlaylistRequestBox.ReturnCode == DialogResult.OK) {
				if (PlaylistRequestBox.Text.Length > 200) {
					MessageBox.Show("Playlist names may not be longer than 200 characters. Playlist has not been created.");
				} else {
					Log.AddStatusText("Created playlist: " + PlaylistRequestBox.Text);
					Boolean playlistCreationSuccessful = PlaylistManager.CreatePlaylist(PlaylistRequestBox.Text);
					if (playlistCreationSuccessful) {
						PopulatePlaylistComb();
						for (int i = 0; i < PlaylistMLComb.Items.Count; i++) {
							if (((LocalPlaylist)PlaylistMLComb.Items[i]).Name == PlaylistRequestBox.Text) {
								PlaylistMLComb.SelectedIndex = i;
								break;
							}
						}
					}
				}
			}
		}
		private void DeletePlaylistMLCmd_Click(object sender, EventArgs e) {
			UpdateStatusLabel("Deleted the \"" + ((LocalPlaylist)PlaylistMLComb.SelectedItem).Name + "\" playlist.");
			if (PlaylistMLComb.SelectedItem == PlaylistAPComb.SelectedItem) { PlaylistAPComb.SelectedIndex = -1; }
			PlaylistManager.DeleteLocalPlaylist(((LocalPlaylist)PlaylistMLComb.SelectedItem).GUID);
			PlaylistMLComb.SelectedIndex = -1;
			PopulatePlaylistComb();
		}
		private void AddToPlaylistMLCmd_Click(object sender, EventArgs e) {
			List<SongInfo> tempSIL = new List<SongInfo>();
			for (int i = 0; i < MusicLibraryDGV.SelectedRows.Count; i++) {
				tempSIL.Add((SongInfo)MusicLibraryDGV.SelectedRows[i].Tag);
			}
			LocalPlaylist tempLP = (LocalPlaylist)PlaylistMLComb.SelectedItem;
			int successfulCount = PlaylistManager.AddSongInfoListToPlaylist(tempSIL, tempLP.GUID);
			if (PlaylistMLComb.SelectedItem == PlaylistAPComb.SelectedItem) {
				UpdateActivePlaylistDGV(PlaylistManager.GetPlaylistListByName(tempLP.Name));
			}
			UpdateStatusLabel("Added " + successfulCount + " songs (" + (tempSIL.Count - successfulCount) + " duplicates skipped) to the \"" + tempLP.Name + "\" playlist.");
		}
		#endregion

		#region ActivePlaylistDGV Event Handlers
		private void ActivePlaylistDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			ActivePlaylistDGV.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.None;
			ActivePlaylistDGV.Columns[5].HeaderCell.SortGlyphDirection = SortOrder.None;
			ActivePlaylistDGV.Columns[7].HeaderCell.SortGlyphDirection = SortOrder.None;
			ActivePlaylistDGV.Columns[8].HeaderCell.SortGlyphDirection = SortOrder.None;
			if (e.ColumnIndex == 4) {
				#region Play Length Column
				if (ActivePlaylistDGV.SortOrder == SortOrder.Ascending) {
					ActivePlaylistDGV.Sort(ActivePlaylistDGV.Columns[11], ListSortDirection.Descending);
					ActivePlaylistDGV.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else {
					ActivePlaylistDGV.Sort(ActivePlaylistDGV.Columns[11], ListSortDirection.Ascending);
					ActivePlaylistDGV.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 5) {
				#region File Length Column
				if (ActivePlaylistDGV.SortOrder == SortOrder.Ascending) {
					ActivePlaylistDGV.Sort(ActivePlaylistDGV.Columns[12], ListSortDirection.Descending);
					ActivePlaylistDGV.Columns[5].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else {
					ActivePlaylistDGV.Sort(ActivePlaylistDGV.Columns[12], ListSortDirection.Ascending);
					ActivePlaylistDGV.Columns[5].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 7) {
				#region Track Column
				if (ActivePlaylistDGV.SortOrder == SortOrder.Ascending) {
					ActivePlaylistDGV.Sort(ActivePlaylistDGV.Columns[13], ListSortDirection.Descending);
					ActivePlaylistDGV.Columns[7].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else {
					ActivePlaylistDGV.Sort(ActivePlaylistDGV.Columns[13], ListSortDirection.Ascending);
					ActivePlaylistDGV.Columns[7].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 8) {
				#region Year Column
				if (ActivePlaylistDGV.SortOrder == SortOrder.Ascending) {
					ActivePlaylistDGV.Sort(ActivePlaylistDGV.Columns[14], ListSortDirection.Descending);
					ActivePlaylistDGV.Columns[8].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else {
					ActivePlaylistDGV.Sort(ActivePlaylistDGV.Columns[14], ListSortDirection.Ascending);
					ActivePlaylistDGV.Columns[8].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			}
			if (CurrentPlaylistIsLocal) {
				SaveCurrentPlaylist();
			}
		}
		private void ActivePlaylistDGV_SelectionChanged(object sender, EventArgs e) {
			UpdatePlaylistButtons();
		}
		private void ActivePlaylistDGV_MouseUp(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				PlaylistCM.MenuItems.Clear();
				if (ActivePlaylistDGV.SelectedRows.Count == 1) {
					PlaylistCM.MenuItems.Add("View Extended Song Info", new EventHandler(ViewExtendedSongInfoPLCMMI_Click)).Enabled = true;
					PlaylistCM.MenuItems.Add("-");
				} else if (ActivePlaylistDGV.SelectedRows.Count > 1) {
					PlaylistCM.MenuItems.Add("View Extended Song Info", new EventHandler(ViewExtendedSongInfoPLCMMI_Click)).Enabled = false;
					PlaylistCM.MenuItems.Add("-");
				} else {
					PlaylistCM.MenuItems.Add("View Extended Song Info", new EventHandler(ViewExtendedSongInfoPLCMMI_Click)).Enabled = false;
					PlaylistCM.MenuItems.Add("-");
				}
				PlaylistCM.MenuItems.Add("-");
				if (ActivePlaylistDGV.SelectedRows.Count == 1) {
					PlaylistCM.MenuItems.Add("Select All By Selected Artist", new EventHandler(SelectAllByArtistPLCMMI_Click)).Enabled = true;
					PlaylistCM.MenuItems.Add("Select All In Selected Album", new EventHandler(SelectAllInAlbumPLCMMI_Click)).Enabled = true;
					PlaylistCM.MenuItems.Add("Select All In Selected Song's Folder", new EventHandler(SelectAllInFolderPLCMMI_Click)).Enabled = true;
					PlaylistCM.MenuItems.Add("Select All Matching Selected Song's Genre", new EventHandler(SelectAllInGenrePLCMMI_Click)).Enabled = true;
				} else {
					PlaylistCM.MenuItems.Add("Select All By Selected Artist", new EventHandler(SelectAllByArtistPLCMMI_Click)).Enabled = false;
					PlaylistCM.MenuItems.Add("Select All In Selected Album", new EventHandler(SelectAllInAlbumPLCMMI_Click)).Enabled = false;
					PlaylistCM.MenuItems.Add("Select All In Selected Song's Folder", new EventHandler(SelectAllInFolderPLCMMI_Click)).Enabled = false;
					PlaylistCM.MenuItems.Add("Select All Matching Selected Song's Genre", new EventHandler(SelectAllInGenrePLCMMI_Click)).Enabled = false;
				}
				PlaylistCM.MenuItems.Add("-");
				if (ActivePlaylistDGV.SelectedRows.Count == 0) {
					PlaylistCM.MenuItems.Add("Clear Selection", new EventHandler(ClearSelectionPLCMMI_Click)).Enabled = false;
				} else {
					PlaylistCM.MenuItems.Add("Clear Selection", new EventHandler(ClearSelectionPLCMMI_Click)).Enabled = true;
				}
				ActivePlaylistDGV.ContextMenu = PlaylistCM;
				PlaylistCM.Show(ActivePlaylistDGV, new Point(e.X, e.Y));
			}
		}
		private void ViewExtendedSongInfoPLCMMI_Click(object sender, EventArgs e) {
			SongInfo tempSongInfo = (SongInfo)ActivePlaylistDGV.SelectedRows[0].Tag;
			MessageBox.Show(
				"Extended Song Information\n" +
				"\n" +
				"Title: " + tempSongInfo.Title + "\n" +
				"Artist(s): " + Functions.StringArrToDelimitedStr(tempSongInfo.AlbumArtists, "; ") + "\n" +
				"Album: " + tempSongInfo.Album + "\n" +
				"Length: " + Functions.MillisecondsToHumanReadable(tempSongInfo.PlayLength) + "\n" +
				"Track: " + tempSongInfo.Track.ToString() + " of " + tempSongInfo.TrackCount.ToString() + "\n" +
				"Year: " + tempSongInfo.Year + "\n" +
				"Bitrate: " + tempSongInfo.BitRate.ToString() + "kbps\n" +
				"Genre(s): " + Functions.StringArrToDelimitedStr(tempSongInfo.Genres, "; ") + "\n" +
				"Comment: " + tempSongInfo.Comment + "\n" +
				"Play Count: " + tempSongInfo.PlayCount + "\n" +
				"Filename: " + tempSongInfo.FileName + "\n" +
				"Filesize: " + Functions.BytesToHumanReadable(tempSongInfo.FileLength, 3) + "\n" +
				"Metadata Size: " + Functions.BytesToHumanReadable(tempSongInfo.StartByte, 3) + "\n" +
				"Audio Data Range: " + Functions.BytesToHumanReadable(tempSongInfo.StartByte, 3) + " - " + Functions.BytesToHumanReadable(tempSongInfo.EndByte, 3) + "\n"
			);
		}
		private void SelectAllByArtistPLCMMI_Click(object sender, EventArgs e) {
			DisablePlaylistButtonUpdating = true;
			String tempCompare = ActivePlaylistDGV.SelectedRows[0].Cells[2].Value.ToString();
			for (int i = 0; i < ActivePlaylistDGV.Rows.Count; i++) {
				if (ActivePlaylistDGV.Rows[i].Cells[2].Value != null) {
					if (ActivePlaylistDGV.Rows[i].Cells[2].Value.ToString() == tempCompare) {
						ActivePlaylistDGV.Rows[i].Selected = true;
					}
				}
			}
			DisablePlaylistButtonUpdating = false;
			UpdatePlaylistButtons();
		}
		private void SelectAllInAlbumPLCMMI_Click(object sender, EventArgs e) {
			DisablePlaylistButtonUpdating = true;
			String tempCompare = ActivePlaylistDGV.SelectedRows[0].Cells[3].Value.ToString();
			for (int i = 0; i < ActivePlaylistDGV.Rows.Count; i++) {
				if (ActivePlaylistDGV.Rows[i].Cells[3].Value != null) {
					if (ActivePlaylistDGV.Rows[i].Cells[3].Value.ToString() == tempCompare) {
						ActivePlaylistDGV.Rows[i].Selected = true;
					}
				}
			}
			DisablePlaylistButtonUpdating = false;
			UpdatePlaylistButtons();
		}
		private void SelectAllInFolderPLCMMI_Click(object sender, EventArgs e) {
			DisablePlaylistButtonUpdating = true;
			String tempCompare = ActivePlaylistDGV.SelectedRows[0].Cells[11].Value.ToString();
			tempCompare = System.IO.Path.GetDirectoryName(tempCompare);
			for (int i = 0; i < ActivePlaylistDGV.Rows.Count; i++) {
				if (ActivePlaylistDGV.Rows[i].Cells[11].Value != null) {
					if (System.IO.Path.GetDirectoryName(ActivePlaylistDGV.Rows[i].Cells[11].Value.ToString()) == tempCompare) {
						ActivePlaylistDGV.Rows[i].Selected = true;
					}
				}
			}
			DisablePlaylistButtonUpdating = false;
			UpdatePlaylistButtons();
		}
		private void SelectAllInGenrePLCMMI_Click(object sender, EventArgs e) {
			DisablePlaylistButtonUpdating = true;
			String[] strSplit = new String[] { "; " };
			String[] srcGenres = ActivePlaylistDGV.SelectedRows[0].Cells[7].Value.ToString().Split(strSplit, StringSplitOptions.RemoveEmptyEntries);
			String[] testGenres;
			for (int i = 0; i < ActivePlaylistDGV.Rows.Count; i++) {
				if (ActivePlaylistDGV.Rows[i].Cells[7].Value != null) {
					testGenres = ActivePlaylistDGV.Rows[i].Cells[7].Value.ToString().Split(strSplit, StringSplitOptions.RemoveEmptyEntries);
					for (int x = 0; x < testGenres.Length; x++) {
						for (int y = 0; y < srcGenres.Length; y++) {
							if (testGenres[x] == srcGenres[y]) {
								ActivePlaylistDGV.Rows[i].Selected = true;
								break;
							}
						}
					}
				}
			}
			DisablePlaylistButtonUpdating = false;
			UpdatePlaylistButtons();
		}
		private void ClearSelectionPLCMMI_Click(object sender, EventArgs e) {
			ActivePlaylistDGV.ClearSelection();
		}
		#endregion

		#region Active Playlist Tab
		private void PlaylistAPComb_SelectedIndexChanged(object sender, EventArgs e) {
			if (PlaylistAPComb.SelectedIndex != -1) {
				if (PlaylistAPComb.SelectedItem.GetType().Name == "RemotePlaylist") {
					CurrentPlaylistIsLocal = false;
					DisablePlaylistButtonUpdating = true;
					ToTopCmd.Enabled = false; UpCmd.Enabled = false; DelCmd.Enabled = false; DownCmd.Enabled = false; ToBottomCmd.Enabled = false;
					CopyToLocalAPCmd.Enabled = true; DeletePlaylistAPCmd.Enabled = false;
					RemotePlaylist tempRP = (RemotePlaylist)PlaylistAPComb.SelectedItem;
					String[] paramsString = new String[1];
					paramsString[0] = tempRP.GUID;
					CommInfo.ConnectToServer(tempRP.ConnectionInfo, ConnectionMode.PlaylistRequest, paramsString);
				} else if (PlaylistAPComb.SelectedItem.GetType().Name == "LocalPlaylist") {
					CurrentPlaylistIsLocal = true;
					DisablePlaylistButtonUpdating = false;
					CopyToLocalAPCmd.Enabled = false; DeletePlaylistAPCmd.Enabled = true;
					LocalPlaylist tempRP = (LocalPlaylist)PlaylistAPComb.SelectedItem;
					UpdateActivePlaylistDGV(tempRP.SongList);
					UpdatePlaylistButtons();
				}
			}
		}
		private void PlaylistAPComb_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = true;
		}
		private void NewPlaylistAPCmd_Click(object sender, EventArgs e) {
			InputBoxResult PlaylistRequestBox = InputBox.Show(
				"Enter a name for your playlist:",
				"Playlist Name Entry"
			);
			if (PlaylistRequestBox.ReturnCode == DialogResult.OK) {
				if (PlaylistRequestBox.Text.Length > 200) {
					MessageBox.Show("Playlist names may not be longer than 200 characters. Playlist has not been created.");
				} else {
					Log.AddStatusText("Created playlist: " + PlaylistRequestBox.Text);
					Boolean playlistCreationSuccessful = PlaylistManager.CreatePlaylist(PlaylistRequestBox.Text);
					if (playlistCreationSuccessful) {
						PopulatePlaylistComb();
						for (int i = 0; i < PlaylistAPComb.Items.Count; i++) {
							if (((LocalPlaylist)PlaylistAPComb.Items[i]).Name == PlaylistRequestBox.Text) {
								PlaylistAPComb.SelectedIndex = i;
								break;
							}
						}
						MessageBox.Show("A new playlist has been successfully created. You may add songs to it using the Music Library tab.");
					}
				}
			}
		}
		private void DeletePlaylistAPCmd_Click(object sender, EventArgs e) {
			UpdateStatusLabel("Deleted the \"" + ((LocalPlaylist)PlaylistAPComb.SelectedItem).Name + "\" playlist.");
			if (PlaylistMLComb.SelectedItem == PlaylistAPComb.SelectedItem) { PlaylistMLComb.SelectedIndex = -1; }
			PlaylistManager.DeleteLocalPlaylist(((LocalPlaylist)PlaylistAPComb.SelectedItem).GUID);
			PlaylistAPComb.SelectedIndex = -1;
			PopulatePlaylistComb();
		}
		private void CopyToLocalAPCmd_Click(object sender, EventArgs e) {
			RemotePlaylist tempRP = (RemotePlaylist)PlaylistAPComb.SelectedItem;
			InputBoxResult PlaylistRequestBox = InputBox.Show("What would you like to name the local version of this playlist?", "Playlist Name", tempRP.Name);
			if (PlaylistRequestBox.ReturnCode == DialogResult.OK) {
				if (PlaylistRequestBox.Text.Length > 200) {
					MessageBox.Show("Playlist names may not be longer than 200 characters. Playlist has not been copied.");
				} else {
					if (PlaylistManager.CreatePlaylist(PlaylistRequestBox.Text)) {
						PlaylistManager.OverwritePlaylistByName(tempRP.SongList, PlaylistRequestBox.Text);
						PopulatePlaylistComb();
						for (int i = 0; i < PlaylistAPComb.Items.Count; i++) {
							if (((LocalPlaylist)PlaylistAPComb.Items[i]).Name == PlaylistRequestBox.Text) {
								PlaylistAPComb.SelectedIndex = i;
								break;
							}
						}
					}
				}
			} else {
				MessageBox.Show("Playlist not copied.");
			}
		}
		#endregion

		private void SongTrack_Scroll(object sender, EventArgs e) {
			MoveTimeStamp();
		}

		private void DebugCmd_Click(object sender, EventArgs e) {
			//ServerManager.RefreshPlaylistLists();
			//PlaylistManager.PrintPlaylistTree();
			Console.WriteLine("i++:");
			for (int i = 0; i < 10; i++) {
				Console.Write(i + " ");
			}
			Console.WriteLine("\n++i:");
			for (int i = 0; i < 10; ++i) {
				Console.Write(i + " ");
			}
		}





	}
}
