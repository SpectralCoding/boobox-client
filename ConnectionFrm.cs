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
	public partial class ConnectionFrm : Form {
		private String Mode;
		private ConnectionInfo OrgConnInfo;
		
		public ConnectionFrm() {
			InitializeComponent();
		}

		private void NewConnectionFrm_Load(object sender, EventArgs e) {

		}
		
		/// <summary>
		/// Sets the operating mode for the Connection Form.
		/// </summary>
		/// <param name="iMode">String containing the Operating Mode</param>
		public void SetMode(String iMode) {
			Mode = iMode;
			if (iMode == "New") {
				OKCmd.Text = "Add Connection";
			} else {
				OKCmd.Text = "Edit Connection";
			}
		}
		
		/// <summary>
		/// Sets the operating mode for the Connection Form. Edit mode.
		/// </summary>
		/// <param name="iMode">String containing the Operating Mode</param>
		/// <param name="ConnectionInfo">ConnectionInfo object containing the ConnectionInfo to be populated.</param>
		public void SetMode(String iMode, ConnectionInfo ConnectionInfo) {
			SetMode(iMode);
			OrgConnInfo = ConnectionInfo;
			IPHostnameTxt.Text = ConnectionInfo.IPAddress;
			PortTxt.Text = ConnectionInfo.InfoPort.ToString();
			DescriptionTxt.Text = ConnectionInfo.Description;
			PasswordTxt.Text = ConnectionInfo.Password;
			ServerPasswordChk.Checked = ConnectionInfo.RequiresPassword;
		}

		private void ServerPasswordChk_CheckedChanged(object sender, EventArgs e) {
			if (ServerPasswordChk.Checked == true) {
				PasswordLbl.Enabled = true;
				PasswordTxt.Enabled = true;
			} else {
				PasswordLbl.Enabled = false;
				PasswordTxt.Enabled = false;
			}
		}

		private void OKCmd_Click(object sender, EventArgs e) {
			if (Mode == "Edit") {
				Config.Instance.ConnectionInfoList.Remove(OrgConnInfo);
			}
			ConnectionInfo tempConnInfo = new ConnectionInfo();
			UriHostNameType hostnameType = Uri.CheckHostName(IPHostnameTxt.Text);
			if (hostnameType == UriHostNameType.IPv4) {
				tempConnInfo.IPAddress = IPHostnameTxt.Text; tempConnInfo.Hostname = "";
			} else if (hostnameType == UriHostNameType.Dns) {
				tempConnInfo.IPAddress = ""; tempConnInfo.Hostname = IPHostnameTxt.Text;
			} else {
				MessageBox.Show("IP Address or Hostname appears to be invalid. Please choose a valid hostname to continue."); return;
			}
			tempConnInfo.IPAddress = IPHostnameTxt.Text;
			tempConnInfo.InfoPort = Convert.ToInt32(PortTxt.Text);
			tempConnInfo.Description = DescriptionTxt.Text;
			tempConnInfo.RequiresPassword = ServerPasswordChk.Checked;
			tempConnInfo.Password = PasswordTxt.Text;
			Config.Instance.ConnectionInfoList.Add(tempConnInfo);
			Config.Instance.Save();
			Forms.MainFrm.PushSettingsToForm();
			this.Close();
		}

	}
}
