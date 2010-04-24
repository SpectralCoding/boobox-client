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
		public MainFrm() {
			InitializeComponent();
		}

		private void MainFrm_Resize(object sender, EventArgs e) {
			#region Horizontal Calculations
			//SongTrack.Width = this.Width - 217;
			//SongBufferingProgressBar.Width = this.Width - 242;
			//TabControl.Width = this.Width - 28;
			//PlaylistComb.Width = TabControl.Width - 200;
			#endregion
			#region Vertical Calculations
			//TabControl.Height = this.Height - 148;
			#endregion
		}

		private void MainFrm_Load(object sender, EventArgs e) {
			ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new MenuStripNoGradient());
		}
	}
}
