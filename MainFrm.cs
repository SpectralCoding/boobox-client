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
			SongTrack.Width = this.Width - 217;
			SongBufferingProgressBar.Width = this.Width - 242;
			TabControl.Width = this.Width - 28;
			VolumeDownPicBox.Left = this.Width - 204;
			VolumeUpPicBox.Left = this.Width - 37;
			VolumeTrack.Left = this.Width - 187;
	
			TabControl.Height = this.Height - 148;
		}

		private void MainFrm_Load(object sender, EventArgs e) {
			ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new MenuStripNoGradient());
		}
	}
}
