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
		#region Custom Form Methods
		private void MoveTimeStamp() {
			int startOffset = SongTrack.Location.X;
			double percentage = SongTrack.Value / Convert.ToDouble(SongTrack.Maximum);
			int newX = startOffset + Convert.ToInt32((percentage * (SongTrack.Width - 27)));
			if (newX < (SongTrack.Location.X + 5)) { newX = (SongTrack.Location.X + 5); } else if (newX > (SongTrack.Location.X + SongTrack.Width - 32)) { newX = (SongTrack.Location.X + SongTrack.Width - 32); }
			CounterLbl.Location = new System.Drawing.Point(newX, CounterLbl.Location.Y);
		}
		#endregion


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
			ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new MenuStripNoGradient());
		}

		private void SongTrack_Scroll(object sender, EventArgs e) {
			MoveTimeStamp();
		}
	}
}
