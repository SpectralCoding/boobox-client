namespace BooBoxClient {
	partial class MainFrm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.ProgressBarStatusStrip = new System.Windows.Forms.ToolStripProgressBar();
			this.ProgressBarLblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.AddServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.ExportSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ControlsMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.PlayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PreviousMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.ShuffleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShuffleOffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShuffleOnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RepeatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RepeatOffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RepeatOneMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RepeatAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.ChangeClientNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RebuildLibraryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.ActivePlaylistTab = new System.Windows.Forms.TabPage();
			this.LibraryTab = new System.Windows.Forms.TabPage();
			this.SongBufferingProgressBar = new System.Windows.Forms.ProgressBar();
			this.CounterLbl = new System.Windows.Forms.Label();
			this.SongTrack = new System.Windows.Forms.TrackBar();
			this.VolumeTrack = new System.Windows.Forms.TrackBar();
			this.PreviousCmd = new System.Windows.Forms.Button();
			this.NextCmd = new System.Windows.Forms.Button();
			this.PlayCmd = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.NewPlaylistCmd = new System.Windows.Forms.Button();
			this.DeletePlaylistCmd = new System.Windows.Forms.Button();
			this.PlaylistComb = new System.Windows.Forms.ComboBox();
			this.StatusStrip.SuspendLayout();
			this.MenuStrip.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.ActivePlaylistTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SongTrack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// StatusStrip
			// 
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBarStatusStrip,
            this.ProgressBarLblStatusStrip});
			this.StatusStrip.Location = new System.Drawing.Point(0, 440);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(684, 22);
			this.StatusStrip.TabIndex = 0;
			this.StatusStrip.Text = "statusStrip1";
			// 
			// ProgressBarStatusStrip
			// 
			this.ProgressBarStatusStrip.Name = "ProgressBarStatusStrip";
			this.ProgressBarStatusStrip.Size = new System.Drawing.Size(100, 16);
			// 
			// ProgressBarLblStatusStrip
			// 
			this.ProgressBarLblStatusStrip.Name = "ProgressBarLblStatusStrip";
			this.ProgressBarLblStatusStrip.Size = new System.Drawing.Size(39, 17);
			this.ProgressBarLblStatusStrip.Text = "Ready";
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuHeader,
            this.ControlsMenuHeader,
            this.OptionsMenuHeader,
            this.HelpMenuHeader});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(684, 24);
			this.MenuStrip.TabIndex = 1;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// FileMenuHeader
			// 
			this.FileMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveSettingsMenuItem,
            this.toolStripMenuItem5,
            this.AddServerMenuItem,
            this.EditServerMenuItem,
            this.DeleteServerMenuItem,
            this.toolStripMenuItem3,
            this.ExportSettingsMenuItem,
            this.ImportSettingsMenuItem,
            this.toolStripMenuItem4,
            this.ExitMenuItem});
			this.FileMenuHeader.Name = "FileMenuHeader";
			this.FileMenuHeader.Size = new System.Drawing.Size(37, 20);
			this.FileMenuHeader.Text = "&File";
			// 
			// SaveSettingsMenuItem
			// 
			this.SaveSettingsMenuItem.Name = "SaveSettingsMenuItem";
			this.SaveSettingsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.SaveSettingsMenuItem.Size = new System.Drawing.Size(192, 22);
			this.SaveSettingsMenuItem.Text = "&Save Settings...";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(189, 6);
			// 
			// AddServerMenuItem
			// 
			this.AddServerMenuItem.Name = "AddServerMenuItem";
			this.AddServerMenuItem.Size = new System.Drawing.Size(192, 22);
			this.AddServerMenuItem.Text = "&Add Server...";
			// 
			// EditServerMenuItem
			// 
			this.EditServerMenuItem.Name = "EditServerMenuItem";
			this.EditServerMenuItem.Size = new System.Drawing.Size(192, 22);
			this.EditServerMenuItem.Text = "Edit Server...";
			// 
			// DeleteServerMenuItem
			// 
			this.DeleteServerMenuItem.Name = "DeleteServerMenuItem";
			this.DeleteServerMenuItem.Size = new System.Drawing.Size(192, 22);
			this.DeleteServerMenuItem.Text = "&Delete Server...";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 6);
			// 
			// ExportSettingsMenuItem
			// 
			this.ExportSettingsMenuItem.Name = "ExportSettingsMenuItem";
			this.ExportSettingsMenuItem.Size = new System.Drawing.Size(192, 22);
			this.ExportSettingsMenuItem.Text = "&Export Settings";
			// 
			// ImportSettingsMenuItem
			// 
			this.ImportSettingsMenuItem.Name = "ImportSettingsMenuItem";
			this.ImportSettingsMenuItem.Size = new System.Drawing.Size(192, 22);
			this.ImportSettingsMenuItem.Text = "&Import Settings";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(189, 6);
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.ExitMenuItem.Size = new System.Drawing.Size(192, 22);
			this.ExitMenuItem.Text = "E&xit";
			// 
			// ControlsMenuHeader
			// 
			this.ControlsMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayMenuItem,
            this.NextMenuItem,
            this.PreviousMenuItem,
            this.toolStripMenuItem2,
            this.ShuffleMenuItem,
            this.RepeatMenuItem});
			this.ControlsMenuHeader.Name = "ControlsMenuHeader";
			this.ControlsMenuHeader.Size = new System.Drawing.Size(64, 20);
			this.ControlsMenuHeader.Text = "&Controls";
			// 
			// PlayMenuItem
			// 
			this.PlayMenuItem.Name = "PlayMenuItem";
			this.PlayMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.PlayMenuItem.Size = new System.Drawing.Size(173, 22);
			this.PlayMenuItem.Text = "Play";
			// 
			// NextMenuItem
			// 
			this.NextMenuItem.Name = "NextMenuItem";
			this.NextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
			this.NextMenuItem.Size = new System.Drawing.Size(173, 22);
			this.NextMenuItem.Text = "Next";
			// 
			// PreviousMenuItem
			// 
			this.PreviousMenuItem.Name = "PreviousMenuItem";
			this.PreviousMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
			this.PreviousMenuItem.Size = new System.Drawing.Size(173, 22);
			this.PreviousMenuItem.Text = "Previous";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
			// 
			// ShuffleMenuItem
			// 
			this.ShuffleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShuffleOffMenuItem,
            this.ShuffleOnMenuItem});
			this.ShuffleMenuItem.Name = "ShuffleMenuItem";
			this.ShuffleMenuItem.Size = new System.Drawing.Size(173, 22);
			this.ShuffleMenuItem.Text = "Shuffle";
			// 
			// ShuffleOffMenuItem
			// 
			this.ShuffleOffMenuItem.Name = "ShuffleOffMenuItem";
			this.ShuffleOffMenuItem.Size = new System.Drawing.Size(131, 22);
			this.ShuffleOffMenuItem.Text = "Shuffle Off";
			// 
			// ShuffleOnMenuItem
			// 
			this.ShuffleOnMenuItem.Name = "ShuffleOnMenuItem";
			this.ShuffleOnMenuItem.Size = new System.Drawing.Size(131, 22);
			this.ShuffleOnMenuItem.Text = "Shuffle On";
			// 
			// RepeatMenuItem
			// 
			this.RepeatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RepeatOffMenuItem,
            this.RepeatOneMenuItem,
            this.RepeatAllMenuItem});
			this.RepeatMenuItem.Name = "RepeatMenuItem";
			this.RepeatMenuItem.Size = new System.Drawing.Size(173, 22);
			this.RepeatMenuItem.Text = "Repeat";
			// 
			// RepeatOffMenuItem
			// 
			this.RepeatOffMenuItem.Name = "RepeatOffMenuItem";
			this.RepeatOffMenuItem.Size = new System.Drawing.Size(135, 22);
			this.RepeatOffMenuItem.Text = "Repeat Off";
			// 
			// RepeatOneMenuItem
			// 
			this.RepeatOneMenuItem.Name = "RepeatOneMenuItem";
			this.RepeatOneMenuItem.Size = new System.Drawing.Size(135, 22);
			this.RepeatOneMenuItem.Text = "Repeat One";
			// 
			// RepeatAllMenuItem
			// 
			this.RepeatAllMenuItem.Name = "RepeatAllMenuItem";
			this.RepeatAllMenuItem.Size = new System.Drawing.Size(135, 22);
			this.RepeatAllMenuItem.Text = "Repeat All";
			// 
			// OptionsMenuHeader
			// 
			this.OptionsMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeClientNameMenuItem,
            this.RebuildLibraryMenuItem});
			this.OptionsMenuHeader.Name = "OptionsMenuHeader";
			this.OptionsMenuHeader.Size = new System.Drawing.Size(61, 20);
			this.OptionsMenuHeader.Text = "&Options";
			// 
			// ChangeClientNameMenuItem
			// 
			this.ChangeClientNameMenuItem.Name = "ChangeClientNameMenuItem";
			this.ChangeClientNameMenuItem.Size = new System.Drawing.Size(184, 22);
			this.ChangeClientNameMenuItem.Text = "Change Client Name";
			// 
			// RebuildLibraryMenuItem
			// 
			this.RebuildLibraryMenuItem.Name = "RebuildLibraryMenuItem";
			this.RebuildLibraryMenuItem.Size = new System.Drawing.Size(184, 22);
			this.RebuildLibraryMenuItem.Text = "Rebuild Library";
			// 
			// HelpMenuHeader
			// 
			this.HelpMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpMenuItem,
            this.toolStripMenuItem1,
            this.AboutMenuItem});
			this.HelpMenuHeader.Name = "HelpMenuHeader";
			this.HelpMenuHeader.Size = new System.Drawing.Size(44, 20);
			this.HelpMenuHeader.Text = "&Help";
			// 
			// HelpMenuItem
			// 
			this.HelpMenuItem.Name = "HelpMenuItem";
			this.HelpMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.HelpMenuItem.Size = new System.Drawing.Size(118, 22);
			this.HelpMenuItem.Text = "Help";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Name = "AboutMenuItem";
			this.AboutMenuItem.Size = new System.Drawing.Size(118, 22);
			this.AboutMenuItem.Text = "About";
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.ActivePlaylistTab);
			this.TabControl.Controls.Add(this.LibraryTab);
			this.TabControl.Location = new System.Drawing.Point(7, 82);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(672, 352);
			this.TabControl.TabIndex = 2;
			// 
			// ActivePlaylistTab
			// 
			this.ActivePlaylistTab.Controls.Add(this.NewPlaylistCmd);
			this.ActivePlaylistTab.Controls.Add(this.DeletePlaylistCmd);
			this.ActivePlaylistTab.Controls.Add(this.PlaylistComb);
			this.ActivePlaylistTab.Location = new System.Drawing.Point(4, 22);
			this.ActivePlaylistTab.Name = "ActivePlaylistTab";
			this.ActivePlaylistTab.Padding = new System.Windows.Forms.Padding(3);
			this.ActivePlaylistTab.Size = new System.Drawing.Size(664, 326);
			this.ActivePlaylistTab.TabIndex = 0;
			this.ActivePlaylistTab.Text = "Active Playlist";
			this.ActivePlaylistTab.UseVisualStyleBackColor = true;
			// 
			// LibraryTab
			// 
			this.LibraryTab.Location = new System.Drawing.Point(4, 22);
			this.LibraryTab.Name = "LibraryTab";
			this.LibraryTab.Padding = new System.Windows.Forms.Padding(3);
			this.LibraryTab.Size = new System.Drawing.Size(609, 214);
			this.LibraryTab.TabIndex = 1;
			this.LibraryTab.Text = "Music Library";
			this.LibraryTab.UseVisualStyleBackColor = true;
			// 
			// SongBufferingProgressBar
			// 
			this.SongBufferingProgressBar.Location = new System.Drawing.Point(292, 58);
			this.SongBufferingProgressBar.Name = "SongBufferingProgressBar";
			this.SongBufferingProgressBar.Size = new System.Drawing.Size(378, 10);
			this.SongBufferingProgressBar.TabIndex = 22;
			// 
			// CounterLbl
			// 
			this.CounterLbl.Location = new System.Drawing.Point(285, 24);
			this.CounterLbl.Name = "CounterLbl";
			this.CounterLbl.Size = new System.Drawing.Size(252, 13);
			this.CounterLbl.TabIndex = 21;
			this.CounterLbl.Text = "0:00";
			// 
			// SongTrack
			// 
			this.SongTrack.AutoSize = false;
			this.SongTrack.BackColor = System.Drawing.SystemColors.Control;
			this.SongTrack.Location = new System.Drawing.Point(280, 36);
			this.SongTrack.Maximum = 10000;
			this.SongTrack.Name = "SongTrack";
			this.SongTrack.Size = new System.Drawing.Size(403, 23);
			this.SongTrack.TabIndex = 20;
			this.SongTrack.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// VolumeTrack
			// 
			this.VolumeTrack.AutoSize = false;
			this.VolumeTrack.BackColor = System.Drawing.SystemColors.Control;
			this.VolumeTrack.LargeChange = 1;
			this.VolumeTrack.Location = new System.Drawing.Point(104, 53);
			this.VolumeTrack.Maximum = 100;
			this.VolumeTrack.Name = "VolumeTrack";
			this.VolumeTrack.Size = new System.Drawing.Size(152, 23);
			this.VolumeTrack.TabIndex = 26;
			this.VolumeTrack.TickStyle = System.Windows.Forms.TickStyle.None;
			this.VolumeTrack.Value = 50;
			// 
			// PreviousCmd
			// 
			this.PreviousCmd.Enabled = false;
			this.PreviousCmd.Location = new System.Drawing.Point(87, 24);
			this.PreviousCmd.Name = "PreviousCmd";
			this.PreviousCmd.Size = new System.Drawing.Size(50, 23);
			this.PreviousCmd.TabIndex = 25;
			this.PreviousCmd.Text = "< <";
			this.PreviousCmd.UseVisualStyleBackColor = true;
			// 
			// NextCmd
			// 
			this.NextCmd.Enabled = false;
			this.NextCmd.Location = new System.Drawing.Point(224, 24);
			this.NextCmd.Name = "NextCmd";
			this.NextCmd.Size = new System.Drawing.Size(50, 23);
			this.NextCmd.TabIndex = 24;
			this.NextCmd.Text = "> >";
			this.NextCmd.UseVisualStyleBackColor = true;
			// 
			// PlayCmd
			// 
			this.PlayCmd.Enabled = false;
			this.PlayCmd.Location = new System.Drawing.Point(143, 24);
			this.PlayCmd.Name = "PlayCmd";
			this.PlayCmd.Size = new System.Drawing.Size(75, 23);
			this.PlayCmd.TabIndex = 23;
			this.PlayCmd.Text = "Play";
			this.PlayCmd.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 27;
			this.button1.Text = "Repeat Off";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 53);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 28;
			this.button2.Text = "Shuffle Off";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::BooBoxClient.Properties.Resources.VolumeUp;
			this.pictureBox2.Location = new System.Drawing.Point(254, 52);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.TabIndex = 30;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BooBoxClient.Properties.Resources.VolumeDown;
			this.pictureBox1.Location = new System.Drawing.Point(87, 52);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 20);
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			// 
			// NewPlaylistCmd
			// 
			this.NewPlaylistCmd.Location = new System.Drawing.Point(573, 4);
			this.NewPlaylistCmd.Name = "NewPlaylistCmd";
			this.NewPlaylistCmd.Size = new System.Drawing.Size(85, 23);
			this.NewPlaylistCmd.TabIndex = 10;
			this.NewPlaylistCmd.Text = "New Playlist";
			this.NewPlaylistCmd.UseVisualStyleBackColor = true;
			// 
			// DeletePlaylistCmd
			// 
			this.DeletePlaylistCmd.Location = new System.Drawing.Point(482, 4);
			this.DeletePlaylistCmd.Name = "DeletePlaylistCmd";
			this.DeletePlaylistCmd.Size = new System.Drawing.Size(85, 23);
			this.DeletePlaylistCmd.TabIndex = 9;
			this.DeletePlaylistCmd.Text = "Delete Playlist";
			this.DeletePlaylistCmd.UseVisualStyleBackColor = true;
			// 
			// PlaylistComb
			// 
			this.PlaylistComb.FormattingEnabled = true;
			this.PlaylistComb.Location = new System.Drawing.Point(6, 6);
			this.PlaylistComb.Name = "PlaylistComb";
			this.PlaylistComb.Size = new System.Drawing.Size(470, 21);
			this.PlaylistComb.TabIndex = 8;
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 462);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.VolumeTrack);
			this.Controls.Add(this.PreviousCmd);
			this.Controls.Add(this.NextCmd);
			this.Controls.Add(this.PlayCmd);
			this.Controls.Add(this.SongBufferingProgressBar);
			this.Controls.Add(this.CounterLbl);
			this.Controls.Add(this.SongTrack);
			this.Controls.Add(this.TabControl);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "MainFrm";
			this.Text = "BooBox Client : Name";
			this.Load += new System.EventHandler(this.MainFrm_Load);
			this.Resize += new System.EventHandler(this.MainFrm_Resize);
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.TabControl.ResumeLayout(false);
			this.ActivePlaylistTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SongTrack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FileMenuHeader;
		private System.Windows.Forms.ToolStripMenuItem SaveSettingsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem AddServerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditServerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteServerMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem ExportSettingsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ImportSettingsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ControlsMenuHeader;
		private System.Windows.Forms.ToolStripMenuItem PlayMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NextMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PreviousMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ShuffleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ShuffleOffMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ShuffleOnMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RepeatMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RepeatOffMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RepeatOneMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RepeatAllMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OptionsMenuHeader;
		private System.Windows.Forms.ToolStripMenuItem ChangeClientNameMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RebuildLibraryMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HelpMenuHeader;
		private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
		private System.Windows.Forms.ToolStripProgressBar ProgressBarStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel ProgressBarLblStatusStrip;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage ActivePlaylistTab;
		private System.Windows.Forms.TabPage LibraryTab;
		private System.Windows.Forms.ProgressBar SongBufferingProgressBar;
		private System.Windows.Forms.Label CounterLbl;
		private System.Windows.Forms.TrackBar SongTrack;
		private System.Windows.Forms.TrackBar VolumeTrack;
		private System.Windows.Forms.Button PreviousCmd;
		private System.Windows.Forms.Button NextCmd;
		private System.Windows.Forms.Button PlayCmd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button NewPlaylistCmd;
		private System.Windows.Forms.Button DeletePlaylistCmd;
		private System.Windows.Forms.ComboBox PlaylistComb;
	}
}

