using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BooBox;

namespace BooBoxClient {
	public partial class MainFrm : Form {

		#region Form Variables
		private Boolean ConfigLoaded = false;
		#endregion

		#region Custom Form Methods
		private void MoveTimeStamp() {
			int startOffset = SongTrack.Location.X;
			double percentage = SongTrack.Value / Convert.ToDouble(SongTrack.Maximum);
			int newX = startOffset + Convert.ToInt32((percentage * (SongTrack.Width - 27)));
			if (newX < (SongTrack.Location.X + 5)) { newX = (SongTrack.Location.X + 5); } else if (newX > (SongTrack.Location.X + SongTrack.Width - 32)) { newX = (SongTrack.Location.X + SongTrack.Width - 32); }
			CounterLbl.Location = new System.Drawing.Point(newX, CounterLbl.Location.Y);
		}
		private void PushSettingsToForm() {

		}
		#endregion

		#region Form Methods
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
				ConfigLoaded = true;
			} else {
				ConfigLoaded = true;
			}
			PushSettingsToForm();
		}
		#endregion

		private void SongTrack_Scroll(object sender, EventArgs e) {
			MoveTimeStamp();
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
		private void AboutMenuItem_Click(object sender, EventArgs e) {
			AboutFrm AboutFrm = new AboutFrm();
			AboutFrm.Show();
		}
		private void HelpMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("Help not yet implemented.");
		}
		private void ExitMenuItem_Click(object sender, EventArgs e) {
			this.Close();
		}
		private void SaveSettingsMenuItem_Click(object sender, EventArgs e) {
			Config.Instance.Save();
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
	}
}
