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
			this.NewPlaylistAPCmd = new System.Windows.Forms.Button();
			this.DeletePlaylistAPCmd = new System.Windows.Forms.Button();
			this.PlaylistAPComb = new System.Windows.Forms.ComboBox();
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
			this.VolumeUpPicBox = new System.Windows.Forms.PictureBox();
			this.VolumeDownPicBox = new System.Windows.Forms.PictureBox();
			this.DelCmd = new System.Windows.Forms.Button();
			this.ToBottomCmd = new System.Windows.Forms.Button();
			this.DownCmd = new System.Windows.Forms.Button();
			this.UpCmd = new System.Windows.Forms.Button();
			this.ToTopCmd = new System.Windows.Forms.Button();
			this.ActivePlaylistDGV = new System.Windows.Forms.DataGridView();
			this.VolumeUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VolumeDownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.MusicLibraryDGV = new System.Windows.Forms.DataGridView();
			this.NewPlaylistMLComb = new System.Windows.Forms.Button();
			this.DeletePlaylistMLCmd = new System.Windows.Forms.Button();
			this.AddToPlaylistMLCmd = new System.Windows.Forms.Button();
			this.PlaylistMLComb = new System.Windows.Forms.ComboBox();
			this.StatusStrip.SuspendLayout();
			this.MenuStrip.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.ActivePlaylistTab.SuspendLayout();
			this.LibraryTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SongTrack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeUpPicBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeDownPicBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ActivePlaylistDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MusicLibraryDGV)).BeginInit();
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
            this.toolStripMenuItem6,
            this.VolumeUpMenuItem,
            this.VolumeDownMenuItem,
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
			this.PlayMenuItem.Size = new System.Drawing.Size(214, 22);
			this.PlayMenuItem.Text = "Play";
			// 
			// NextMenuItem
			// 
			this.NextMenuItem.Name = "NextMenuItem";
			this.NextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
			this.NextMenuItem.Size = new System.Drawing.Size(214, 22);
			this.NextMenuItem.Text = "Next";
			// 
			// PreviousMenuItem
			// 
			this.PreviousMenuItem.Name = "PreviousMenuItem";
			this.PreviousMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
			this.PreviousMenuItem.Size = new System.Drawing.Size(214, 22);
			this.PreviousMenuItem.Text = "Previous";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
			// 
			// ShuffleMenuItem
			// 
			this.ShuffleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShuffleOffMenuItem,
            this.ShuffleOnMenuItem});
			this.ShuffleMenuItem.Name = "ShuffleMenuItem";
			this.ShuffleMenuItem.Size = new System.Drawing.Size(214, 22);
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
			this.RepeatMenuItem.Size = new System.Drawing.Size(214, 22);
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
			this.HelpMenuItem.Size = new System.Drawing.Size(152, 22);
			this.HelpMenuItem.Text = "Help";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Name = "AboutMenuItem";
			this.AboutMenuItem.Size = new System.Drawing.Size(152, 22);
			this.AboutMenuItem.Text = "About";
			// 
			// TabControl
			// 
			this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
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
			this.ActivePlaylistTab.Controls.Add(this.DelCmd);
			this.ActivePlaylistTab.Controls.Add(this.ToBottomCmd);
			this.ActivePlaylistTab.Controls.Add(this.DownCmd);
			this.ActivePlaylistTab.Controls.Add(this.UpCmd);
			this.ActivePlaylistTab.Controls.Add(this.ToTopCmd);
			this.ActivePlaylistTab.Controls.Add(this.ActivePlaylistDGV);
			this.ActivePlaylistTab.Controls.Add(this.NewPlaylistAPCmd);
			this.ActivePlaylistTab.Controls.Add(this.DeletePlaylistAPCmd);
			this.ActivePlaylistTab.Controls.Add(this.PlaylistAPComb);
			this.ActivePlaylistTab.Location = new System.Drawing.Point(4, 22);
			this.ActivePlaylistTab.Name = "ActivePlaylistTab";
			this.ActivePlaylistTab.Padding = new System.Windows.Forms.Padding(3);
			this.ActivePlaylistTab.Size = new System.Drawing.Size(664, 326);
			this.ActivePlaylistTab.TabIndex = 0;
			this.ActivePlaylistTab.Text = "Active Playlist";
			this.ActivePlaylistTab.UseVisualStyleBackColor = true;
			// 
			// NewPlaylistAPCmd
			// 
			this.NewPlaylistAPCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NewPlaylistAPCmd.Location = new System.Drawing.Point(575, 4);
			this.NewPlaylistAPCmd.Name = "NewPlaylistAPCmd";
			this.NewPlaylistAPCmd.Size = new System.Drawing.Size(85, 23);
			this.NewPlaylistAPCmd.TabIndex = 10;
			this.NewPlaylistAPCmd.Text = "New Playlist";
			this.NewPlaylistAPCmd.UseVisualStyleBackColor = true;
			// 
			// DeletePlaylistAPCmd
			// 
			this.DeletePlaylistAPCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeletePlaylistAPCmd.Location = new System.Drawing.Point(484, 4);
			this.DeletePlaylistAPCmd.Name = "DeletePlaylistAPCmd";
			this.DeletePlaylistAPCmd.Size = new System.Drawing.Size(85, 23);
			this.DeletePlaylistAPCmd.TabIndex = 9;
			this.DeletePlaylistAPCmd.Text = "Delete Playlist";
			this.DeletePlaylistAPCmd.UseVisualStyleBackColor = true;
			// 
			// PlaylistAPComb
			// 
			this.PlaylistAPComb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PlaylistAPComb.FormattingEnabled = true;
			this.PlaylistAPComb.Location = new System.Drawing.Point(6, 6);
			this.PlaylistAPComb.Name = "PlaylistAPComb";
			this.PlaylistAPComb.Size = new System.Drawing.Size(472, 21);
			this.PlaylistAPComb.TabIndex = 8;
			// 
			// LibraryTab
			// 
			this.LibraryTab.Controls.Add(this.NewPlaylistMLComb);
			this.LibraryTab.Controls.Add(this.DeletePlaylistMLCmd);
			this.LibraryTab.Controls.Add(this.AddToPlaylistMLCmd);
			this.LibraryTab.Controls.Add(this.PlaylistMLComb);
			this.LibraryTab.Controls.Add(this.MusicLibraryDGV);
			this.LibraryTab.Location = new System.Drawing.Point(4, 22);
			this.LibraryTab.Name = "LibraryTab";
			this.LibraryTab.Padding = new System.Windows.Forms.Padding(3);
			this.LibraryTab.Size = new System.Drawing.Size(664, 326);
			this.LibraryTab.TabIndex = 1;
			this.LibraryTab.Text = "Music Library";
			this.LibraryTab.UseVisualStyleBackColor = true;
			// 
			// SongBufferingProgressBar
			// 
			this.SongBufferingProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.SongBufferingProgressBar.Location = new System.Drawing.Point(212, 62);
			this.SongBufferingProgressBar.Name = "SongBufferingProgressBar";
			this.SongBufferingProgressBar.Size = new System.Drawing.Size(458, 10);
			this.SongBufferingProgressBar.TabIndex = 22;
			// 
			// CounterLbl
			// 
			this.CounterLbl.Location = new System.Drawing.Point(205, 28);
			this.CounterLbl.Name = "CounterLbl";
			this.CounterLbl.Size = new System.Drawing.Size(332, 13);
			this.CounterLbl.TabIndex = 21;
			this.CounterLbl.Text = "0:00";
			// 
			// SongTrack
			// 
			this.SongTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.SongTrack.AutoSize = false;
			this.SongTrack.BackColor = System.Drawing.SystemColors.Control;
			this.SongTrack.Location = new System.Drawing.Point(200, 40);
			this.SongTrack.Maximum = 10000000;
			this.SongTrack.Name = "SongTrack";
			this.SongTrack.Size = new System.Drawing.Size(483, 23);
			this.SongTrack.TabIndex = 20;
			this.SongTrack.TickStyle = System.Windows.Forms.TickStyle.None;
			this.SongTrack.Scroll += new System.EventHandler(this.SongTrack_Scroll);
			// 
			// VolumeTrack
			// 
			this.VolumeTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.VolumeTrack.AutoSize = false;
			this.VolumeTrack.BackColor = System.Drawing.SystemColors.Control;
			this.VolumeTrack.LargeChange = 1;
			this.VolumeTrack.Location = new System.Drawing.Point(511, 4);
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
			this.PreviousCmd.Location = new System.Drawing.Point(7, 24);
			this.PreviousCmd.Name = "PreviousCmd";
			this.PreviousCmd.Size = new System.Drawing.Size(50, 23);
			this.PreviousCmd.TabIndex = 25;
			this.PreviousCmd.Text = "< <";
			this.PreviousCmd.UseVisualStyleBackColor = true;
			// 
			// NextCmd
			// 
			this.NextCmd.Enabled = false;
			this.NextCmd.Location = new System.Drawing.Point(144, 24);
			this.NextCmd.Name = "NextCmd";
			this.NextCmd.Size = new System.Drawing.Size(50, 23);
			this.NextCmd.TabIndex = 24;
			this.NextCmd.Text = "> >";
			this.NextCmd.UseVisualStyleBackColor = true;
			// 
			// PlayCmd
			// 
			this.PlayCmd.Enabled = false;
			this.PlayCmd.Location = new System.Drawing.Point(63, 24);
			this.PlayCmd.Name = "PlayCmd";
			this.PlayCmd.Size = new System.Drawing.Size(75, 23);
			this.PlayCmd.TabIndex = 23;
			this.PlayCmd.Text = "Play";
			this.PlayCmd.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(7, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 23);
			this.button1.TabIndex = 27;
			this.button1.Text = "Repeat Off";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(104, 53);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 23);
			this.button2.TabIndex = 28;
			this.button2.Text = "Shuffle Off";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// VolumeUpPicBox
			// 
			this.VolumeUpPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.VolumeUpPicBox.Image = global::BooBoxClient.Properties.Resources.VolumeUp;
			this.VolumeUpPicBox.Location = new System.Drawing.Point(661, 4);
			this.VolumeUpPicBox.Name = "VolumeUpPicBox";
			this.VolumeUpPicBox.Size = new System.Drawing.Size(20, 20);
			this.VolumeUpPicBox.TabIndex = 30;
			this.VolumeUpPicBox.TabStop = false;
			// 
			// VolumeDownPicBox
			// 
			this.VolumeDownPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.VolumeDownPicBox.Image = global::BooBoxClient.Properties.Resources.VolumeDown;
			this.VolumeDownPicBox.Location = new System.Drawing.Point(494, 4);
			this.VolumeDownPicBox.Name = "VolumeDownPicBox";
			this.VolumeDownPicBox.Size = new System.Drawing.Size(20, 20);
			this.VolumeDownPicBox.TabIndex = 29;
			this.VolumeDownPicBox.TabStop = false;
			// 
			// DelCmd
			// 
			this.DelCmd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DelCmd.Location = new System.Drawing.Point(625, 157);
			this.DelCmd.Name = "DelCmd";
			this.DelCmd.Size = new System.Drawing.Size(33, 40);
			this.DelCmd.TabIndex = 18;
			this.DelCmd.Text = "Del";
			this.DelCmd.UseVisualStyleBackColor = true;
			// 
			// ToBottomCmd
			// 
			this.ToBottomCmd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.ToBottomCmd.Location = new System.Drawing.Point(625, 264);
			this.ToBottomCmd.Name = "ToBottomCmd";
			this.ToBottomCmd.Size = new System.Drawing.Size(33, 56);
			this.ToBottomCmd.TabIndex = 20;
			this.ToBottomCmd.Text = "\\/ \\/";
			this.ToBottomCmd.UseVisualStyleBackColor = true;
			// 
			// DownCmd
			// 
			this.DownCmd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DownCmd.Location = new System.Drawing.Point(625, 203);
			this.DownCmd.Name = "DownCmd";
			this.DownCmd.Size = new System.Drawing.Size(33, 56);
			this.DownCmd.TabIndex = 19;
			this.DownCmd.Text = "\\/";
			this.DownCmd.UseVisualStyleBackColor = true;
			// 
			// UpCmd
			// 
			this.UpCmd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.UpCmd.Location = new System.Drawing.Point(625, 95);
			this.UpCmd.Name = "UpCmd";
			this.UpCmd.Size = new System.Drawing.Size(33, 56);
			this.UpCmd.TabIndex = 17;
			this.UpCmd.Text = "/\\";
			this.UpCmd.UseVisualStyleBackColor = true;
			// 
			// ToTopCmd
			// 
			this.ToTopCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ToTopCmd.Location = new System.Drawing.Point(625, 33);
			this.ToTopCmd.Name = "ToTopCmd";
			this.ToTopCmd.Size = new System.Drawing.Size(33, 56);
			this.ToTopCmd.TabIndex = 16;
			this.ToTopCmd.Text = "/\\ /\\";
			this.ToTopCmd.UseVisualStyleBackColor = true;
			// 
			// ActivePlaylistDGV
			// 
			this.ActivePlaylistDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ActivePlaylistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ActivePlaylistDGV.Location = new System.Drawing.Point(6, 33);
			this.ActivePlaylistDGV.Name = "ActivePlaylistDGV";
			this.ActivePlaylistDGV.Size = new System.Drawing.Size(613, 287);
			this.ActivePlaylistDGV.TabIndex = 15;
			// 
			// VolumeUpMenuItem
			// 
			this.VolumeUpMenuItem.Name = "VolumeUpMenuItem";
			this.VolumeUpMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
			this.VolumeUpMenuItem.Size = new System.Drawing.Size(214, 22);
			this.VolumeUpMenuItem.Text = "Volume Up";
			// 
			// VolumeDownMenuItem
			// 
			this.VolumeDownMenuItem.Name = "VolumeDownMenuItem";
			this.VolumeDownMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
			this.VolumeDownMenuItem.Size = new System.Drawing.Size(214, 22);
			this.VolumeDownMenuItem.Text = "Volume Down";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(211, 6);
			// 
			// MusicLibraryDGV
			// 
			this.MusicLibraryDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.MusicLibraryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MusicLibraryDGV.Location = new System.Drawing.Point(5, 6);
			this.MusicLibraryDGV.Name = "MusicLibraryDGV";
			this.MusicLibraryDGV.Size = new System.Drawing.Size(653, 287);
			this.MusicLibraryDGV.TabIndex = 19;
			// 
			// NewPlaylistMLComb
			// 
			this.NewPlaylistMLComb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NewPlaylistMLComb.Location = new System.Drawing.Point(574, 297);
			this.NewPlaylistMLComb.Name = "NewPlaylistMLComb";
			this.NewPlaylistMLComb.Size = new System.Drawing.Size(85, 23);
			this.NewPlaylistMLComb.TabIndex = 23;
			this.NewPlaylistMLComb.Text = "New Playlist";
			this.NewPlaylistMLComb.UseVisualStyleBackColor = true;
			// 
			// DeletePlaylistMLCmd
			// 
			this.DeletePlaylistMLCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeletePlaylistMLCmd.Location = new System.Drawing.Point(483, 297);
			this.DeletePlaylistMLCmd.Name = "DeletePlaylistMLCmd";
			this.DeletePlaylistMLCmd.Size = new System.Drawing.Size(85, 23);
			this.DeletePlaylistMLCmd.TabIndex = 22;
			this.DeletePlaylistMLCmd.Text = "Delete Playlist";
			this.DeletePlaylistMLCmd.UseVisualStyleBackColor = true;
			// 
			// AddToPlaylistMLCmd
			// 
			this.AddToPlaylistMLCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddToPlaylistMLCmd.Location = new System.Drawing.Point(392, 297);
			this.AddToPlaylistMLCmd.Name = "AddToPlaylistMLCmd";
			this.AddToPlaylistMLCmd.Size = new System.Drawing.Size(85, 23);
			this.AddToPlaylistMLCmd.TabIndex = 21;
			this.AddToPlaylistMLCmd.Text = "Add To Playlist";
			this.AddToPlaylistMLCmd.UseVisualStyleBackColor = true;
			// 
			// PlaylistMLComb
			// 
			this.PlaylistMLComb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PlaylistMLComb.FormattingEnabled = true;
			this.PlaylistMLComb.Location = new System.Drawing.Point(6, 299);
			this.PlaylistMLComb.Name = "PlaylistMLComb";
			this.PlaylistMLComb.Size = new System.Drawing.Size(380, 21);
			this.PlaylistMLComb.TabIndex = 20;
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 462);
			this.Controls.Add(this.VolumeUpPicBox);
			this.Controls.Add(this.VolumeDownPicBox);
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
			this.MinimumSize = new System.Drawing.Size(420, 400);
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
			this.LibraryTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SongTrack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeUpPicBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeDownPicBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ActivePlaylistDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MusicLibraryDGV)).EndInit();
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
		private System.Windows.Forms.PictureBox VolumeDownPicBox;
		private System.Windows.Forms.PictureBox VolumeUpPicBox;
		private System.Windows.Forms.Button NewPlaylistAPCmd;
		private System.Windows.Forms.Button DeletePlaylistAPCmd;
		private System.Windows.Forms.ComboBox PlaylistAPComb;
		private System.Windows.Forms.Button DelCmd;
		private System.Windows.Forms.Button ToBottomCmd;
		private System.Windows.Forms.Button DownCmd;
		private System.Windows.Forms.Button UpCmd;
		private System.Windows.Forms.Button ToTopCmd;
		private System.Windows.Forms.DataGridView ActivePlaylistDGV;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem VolumeUpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem VolumeDownMenuItem;
		private System.Windows.Forms.Button NewPlaylistMLComb;
		private System.Windows.Forms.Button DeletePlaylistMLCmd;
		private System.Windows.Forms.Button AddToPlaylistMLCmd;
		private System.Windows.Forms.ComboBox PlaylistMLComb;
		private System.Windows.Forms.DataGridView MusicLibraryDGV;
	}
}

