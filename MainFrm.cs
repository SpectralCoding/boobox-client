using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BooBoxClient {
	public partial class MainFrm : Form {
		public MainFrm() {
			InitializeComponent();
		}

		private void MainFrm_Resize(object sender, EventArgs e) {
			SongTrack.Width = this.Width - 17;
			SongBufferingProgressBar.Width = this.Width - 42;
		}

		private void MainFrm_Load(object sender, EventArgs e) {

		}
	}
}
