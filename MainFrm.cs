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

		#region Form Variables
		
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
					MusicLibraryDGV.Rows[newRowNum].Cells[5].Value = SongList[i].PlayCount;
					MusicLibraryDGV.Rows[newRowNum].Cells[6].Value = Functions.StringArrToDelimitedStr(SongList[i].Genres, "; ");
					MusicLibraryDGV.Rows[newRowNum].Cells[7].Value = SongList[i].Track;
					MusicLibraryDGV.Rows[newRowNum].Cells[8].Value = SongList[i].Year;
					MusicLibraryDGV.Rows[newRowNum].Cells[9].Value = SongList[i].Comment;
					MusicLibraryDGV.Rows[newRowNum].Cells[10].Value = Functions.ServerGUIDToConnectionInfo(Config.Instance.ConnectionInfoList, SongList[i].ServerGUID).Name;
					MusicLibraryDGV.Rows[newRowNum].Cells[11].Value = SongList[i].FileName;
					MusicLibraryDGV.Rows[newRowNum].Cells[12].Value = SongList[i].PlayLength.ToString("00000000");
					MusicLibraryDGV.Rows[newRowNum].Cells[13].Value = SongList[i].FileLength.ToString("000000000");
					MusicLibraryDGV.Rows[newRowNum].Cells[14].Value = SongList[i].PlayCount.ToString("000000");
					MusicLibraryDGV.Rows[newRowNum].Cells[15].Value = SongList[i].Track.ToString("00000");
					MusicLibraryDGV.Rows[newRowNum].Cells[16].Value = SongList[i].Year.ToString("00000");
					if (!artistList.Contains(MusicLibraryDGV.Rows[newRowNum].Cells[1].Value)) {
						artistCount++;
						artistList.Add(MusicLibraryDGV.Rows[newRowNum].Cells[1].Value);
					}
					if (!albumList.Contains(SongList[i].Album)) {
						albumCount++;
						albumList.Add(SongList[i].Album);
					}
				}
				MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
				MusicLibraryDGV.Columns[0].HeaderText = "Title (" + SongList.Count + ")";
				MusicLibraryDGV.Columns[1].HeaderText = "Artists (" + artistCount + ")";
				MusicLibraryDGV.Columns[2].HeaderText = "Album (" + albumCount + ")";
			}
		}
		#endregion

		#region MusicLibraryDGV Event Handlers
		private void MusicLibraryDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
			if (e.ColumnIndex == 3) {
				#region Play Length Column
				if (MusicLibraryDGV.SortOrder == SortOrder.Ascending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[12], ListSortDirection.Descending);
					MusicLibraryDGV.Columns[3].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else if (MusicLibraryDGV.SortOrder == SortOrder.Descending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[12], ListSortDirection.Ascending);
					MusicLibraryDGV.Columns[3].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 4) {
				#region File Length Column
				if (MusicLibraryDGV.SortOrder == SortOrder.Ascending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[13], ListSortDirection.Descending);
					MusicLibraryDGV.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else if (MusicLibraryDGV.SortOrder == SortOrder.Descending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[13], ListSortDirection.Ascending);
					MusicLibraryDGV.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 5) {
				#region Play Count Column
				if (MusicLibraryDGV.SortOrder == SortOrder.Ascending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[14], ListSortDirection.Descending);
					MusicLibraryDGV.Columns[5].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else if (MusicLibraryDGV.SortOrder == SortOrder.Descending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[14], ListSortDirection.Ascending);
					MusicLibraryDGV.Columns[5].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 7) {
				#region Track Column
				if (MusicLibraryDGV.SortOrder == SortOrder.Ascending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[15], ListSortDirection.Descending);
					MusicLibraryDGV.Columns[7].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else if (MusicLibraryDGV.SortOrder == SortOrder.Descending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[15], ListSortDirection.Ascending);
					MusicLibraryDGV.Columns[7].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else if (e.ColumnIndex == 8) {
				#region Year Column
				if (MusicLibraryDGV.SortOrder == SortOrder.Ascending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[16], ListSortDirection.Descending);
					MusicLibraryDGV.Columns[8].HeaderCell.SortGlyphDirection = SortOrder.Descending;
				} else if (MusicLibraryDGV.SortOrder == SortOrder.Descending) {
					MusicLibraryDGV.Sort(MusicLibraryDGV.Columns[16], ListSortDirection.Ascending);
					MusicLibraryDGV.Columns[8].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
				}
				#endregion
			} else {
				MusicLibraryDGV.Columns[3].HeaderCell.SortGlyphDirection = SortOrder.None;
				MusicLibraryDGV.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.None;
				MusicLibraryDGV.Columns[5].HeaderCell.SortGlyphDirection = SortOrder.None;
				MusicLibraryDGV.Columns[7].HeaderCell.SortGlyphDirection = SortOrder.None;
				MusicLibraryDGV.Columns[8].HeaderCell.SortGlyphDirection = SortOrder.None;
			}
		}
		#endregion

		#region Custom Form Methods
		private void MoveTimeStamp() {
			int startOffset = SongTrack.Location.X;
			double percentage = SongTrack.Value / Convert.ToDouble(SongTrack.Maximum);
			int newX = startOffset + Convert.ToInt32((percentage * (SongTrack.Width - 27)));
			if (newX < (SongTrack.Location.X + 5)) { newX = (SongTrack.Location.X + 5); } else if (newX > (SongTrack.Location.X + SongTrack.Width - 32)) { newX = (SongTrack.Location.X + SongTrack.Width - 32); }
			CounterLbl.Location = new System.Drawing.Point(newX, CounterLbl.Location.Y);
		}
		#endregion

		#region Form Event Handlers
		public MainFrm() {
			InitializeComponent();
		}
		private void MainFrm_Resize(object sender, EventArgs e) {
			#region Horizontal Calculations

			#endregion
			#region Vertical Calculations
			int PlaylistButtonHeight = Convert.ToInt32((ActivePlaylistDGV.Height - 23) * 0.212);
			ToTopCmd.Height = PlaylistButtonHeight;
			UpCmd.Height = PlaylistButtonHeight;
			// Exact Calculation: 0.152073732718894
			DelCmd.Height = Convert.ToInt32((ActivePlaylistDGV.Height - 23) * 0.1521);
			DownCmd.Height = PlaylistButtonHeight;
			ToBottomCmd.Height = PlaylistButtonHeight;
			UpCmd.Top = ToTopCmd.Top + ToTopCmd.Height + 6;
			DelCmd.Top = UpCmd.Top + UpCmd.Height + 6;
			DownCmd.Top = DelCmd.Top + DelCmd.Height + 6;
			ToBottomCmd.Top = DownCmd.Top + DownCmd.Height + 6;
			#endregion
		}
		private void MainFrm_Load(object sender, EventArgs e) {
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
			ServerManager.TestServers();
			Library.LoadSettings();
			PushSettingsToForm();
		}
		private void MainFrm_FormClosing(object sender, FormClosingEventArgs e) {
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

		private void SongTrack_Scroll(object sender, EventArgs e) {
			MoveTimeStamp();
		}

		private void DebugCmd_Click(object sender, EventArgs e) {
		}

	}
}
