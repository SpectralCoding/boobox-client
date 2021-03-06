﻿namespace BooBoxClient {
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.ProgressBarStatusStrip = new System.Windows.Forms.ToolStripProgressBar();
			this.ProgressBarLblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.AddServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ConnectToServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ConnectToAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
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
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.VolumeUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VolumeDownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.DataBufferSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Bytes512MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Bytes1024MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Bytes2048MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Bytes4096MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Bytes8192MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BufferAtPercentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Percent5MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Percent10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Percent25MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Percent50MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Percent100MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.ActivePlaylistTab = new System.Windows.Forms.TabPage();
			this.CopyToLocalAPCmd = new System.Windows.Forms.Button();
			this.ActivePlaylistDGV = new System.Windows.Forms.DataGridView();
			this.NumberAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TitleAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ArtistsAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AlbumAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LengthAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GenresAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrackAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YearAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommentAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServerNameAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LengthHiddenAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FilesizeHiddenAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrackHiddenAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YearHiddenAPDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DelCmd = new System.Windows.Forms.Button();
			this.ToBottomCmd = new System.Windows.Forms.Button();
			this.DownCmd = new System.Windows.Forms.Button();
			this.UpCmd = new System.Windows.Forms.Button();
			this.ToTopCmd = new System.Windows.Forms.Button();
			this.NewPlaylistAPCmd = new System.Windows.Forms.Button();
			this.DeletePlaylistAPCmd = new System.Windows.Forms.Button();
			this.PlaylistAPComb = new System.Windows.Forms.ComboBox();
			this.LibraryTab = new System.Windows.Forms.TabPage();
			this.MusicLibraryDGV = new System.Windows.Forms.DataGridView();
			this.TitleMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ArtistsMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AlbumMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LengthMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GenresMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrackMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YearMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommentMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServerNameMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LengthHiddenMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FilesizeHiddenMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrackHiddenMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YearHiddenMLDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NewPlaylistMLComb = new System.Windows.Forms.Button();
			this.DeletePlaylistMLCmd = new System.Windows.Forms.Button();
			this.AddToPlaylistMLCmd = new System.Windows.Forms.Button();
			this.PlaylistMLComb = new System.Windows.Forms.ComboBox();
			this.SongBufferingProgressBar = new System.Windows.Forms.ProgressBar();
			this.CounterLbl = new System.Windows.Forms.Label();
			this.SongTrack = new System.Windows.Forms.TrackBar();
			this.VolumeTrack = new System.Windows.Forms.TrackBar();
			this.PreviousCmd = new System.Windows.Forms.Button();
			this.NextCmd = new System.Windows.Forms.Button();
			this.PlayCmd = new System.Windows.Forms.Button();
			this.RepeatToggleCmd = new System.Windows.Forms.Button();
			this.ShuffleToggleCmd = new System.Windows.Forms.Button();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.AlbumArtPicBox = new System.Windows.Forms.PictureBox();
			this.VolumeUpPicBox = new System.Windows.Forms.PictureBox();
			this.VolumeDownPicBox = new System.Windows.Forms.PictureBox();
			this.DebugCmd = new System.Windows.Forms.Button();
			this.PlayTimer = new System.Windows.Forms.Timer(this.components);
			this.StatusStrip.SuspendLayout();
			this.MenuStrip.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.ActivePlaylistTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ActivePlaylistDGV)).BeginInit();
			this.LibraryTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MusicLibraryDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SongTrack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AlbumArtPicBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeUpPicBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeDownPicBox)).BeginInit();
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
			this.ProgressBarStatusStrip.Maximum = 0;
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
            this.ConnectToServerMenuItem,
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
			this.SaveSettingsMenuItem.Click += new System.EventHandler(this.SaveSettingsMenuItem_Click);
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
			this.AddServerMenuItem.Click += new System.EventHandler(this.AddServerMenuItem_Click);
			// 
			// ConnectToServerMenuItem
			// 
			this.ConnectToServerMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToAllMenuItem,
            this.toolStripMenuItem7});
			this.ConnectToServerMenuItem.Name = "ConnectToServerMenuItem";
			this.ConnectToServerMenuItem.Size = new System.Drawing.Size(192, 22);
			this.ConnectToServerMenuItem.Text = "Connect To Server...";
			// 
			// ConnectToAllMenuItem
			// 
			this.ConnectToAllMenuItem.Name = "ConnectToAllMenuItem";
			this.ConnectToAllMenuItem.Size = new System.Drawing.Size(153, 22);
			this.ConnectToAllMenuItem.Text = "Connect To All";
			this.ConnectToAllMenuItem.Click += new System.EventHandler(this.ConnectToAllMenuItem_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(150, 6);
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
			this.ExportSettingsMenuItem.Click += new System.EventHandler(this.ExportSettingsMenuItem_Click);
			// 
			// ImportSettingsMenuItem
			// 
			this.ImportSettingsMenuItem.Name = "ImportSettingsMenuItem";
			this.ImportSettingsMenuItem.Size = new System.Drawing.Size(192, 22);
			this.ImportSettingsMenuItem.Text = "&Import Settings";
			this.ImportSettingsMenuItem.Click += new System.EventHandler(this.ImportSettingsMenuItem_Click);
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
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
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
			this.PlayMenuItem.Click += new System.EventHandler(this.PlayMenuItem_Click);
			// 
			// NextMenuItem
			// 
			this.NextMenuItem.Name = "NextMenuItem";
			this.NextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
			this.NextMenuItem.Size = new System.Drawing.Size(214, 22);
			this.NextMenuItem.Text = "Next";
			this.NextMenuItem.Click += new System.EventHandler(this.NextMenuItem_Click);
			// 
			// PreviousMenuItem
			// 
			this.PreviousMenuItem.Name = "PreviousMenuItem";
			this.PreviousMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
			this.PreviousMenuItem.Size = new System.Drawing.Size(214, 22);
			this.PreviousMenuItem.Text = "Previous";
			this.PreviousMenuItem.Click += new System.EventHandler(this.PreviousMenuItem_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(211, 6);
			// 
			// VolumeUpMenuItem
			// 
			this.VolumeUpMenuItem.Name = "VolumeUpMenuItem";
			this.VolumeUpMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
			this.VolumeUpMenuItem.Size = new System.Drawing.Size(214, 22);
			this.VolumeUpMenuItem.Text = "Volume Up";
			this.VolumeUpMenuItem.Click += new System.EventHandler(this.VolumeUpMenuItem_Click);
			// 
			// VolumeDownMenuItem
			// 
			this.VolumeDownMenuItem.Name = "VolumeDownMenuItem";
			this.VolumeDownMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
			this.VolumeDownMenuItem.Size = new System.Drawing.Size(214, 22);
			this.VolumeDownMenuItem.Text = "Volume Down";
			this.VolumeDownMenuItem.Click += new System.EventHandler(this.VolumeDownMenuItem_Click);
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
			this.ShuffleOffMenuItem.Click += new System.EventHandler(this.ShuffleOffMenuItem_Click);
			// 
			// ShuffleOnMenuItem
			// 
			this.ShuffleOnMenuItem.Name = "ShuffleOnMenuItem";
			this.ShuffleOnMenuItem.Size = new System.Drawing.Size(131, 22);
			this.ShuffleOnMenuItem.Text = "Shuffle On";
			this.ShuffleOnMenuItem.Click += new System.EventHandler(this.ShuffleOnMenuItem_Click);
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
			this.RepeatOffMenuItem.Click += new System.EventHandler(this.RepeatOffMenuItem_Click);
			// 
			// RepeatOneMenuItem
			// 
			this.RepeatOneMenuItem.Name = "RepeatOneMenuItem";
			this.RepeatOneMenuItem.Size = new System.Drawing.Size(135, 22);
			this.RepeatOneMenuItem.Text = "Repeat One";
			this.RepeatOneMenuItem.Click += new System.EventHandler(this.RepeatOneMenuItem_Click);
			// 
			// RepeatAllMenuItem
			// 
			this.RepeatAllMenuItem.Name = "RepeatAllMenuItem";
			this.RepeatAllMenuItem.Size = new System.Drawing.Size(135, 22);
			this.RepeatAllMenuItem.Text = "Repeat All";
			this.RepeatAllMenuItem.Click += new System.EventHandler(this.RepeatAllMenuItem_Click);
			// 
			// OptionsMenuHeader
			// 
			this.OptionsMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeClientNameMenuItem,
            this.RebuildLibraryMenuItem,
            this.DataBufferSizeMenuItem,
            this.BufferAtPercentMenuItem});
			this.OptionsMenuHeader.Name = "OptionsMenuHeader";
			this.OptionsMenuHeader.Size = new System.Drawing.Size(61, 20);
			this.OptionsMenuHeader.Text = "&Options";
			// 
			// ChangeClientNameMenuItem
			// 
			this.ChangeClientNameMenuItem.Name = "ChangeClientNameMenuItem";
			this.ChangeClientNameMenuItem.Size = new System.Drawing.Size(184, 22);
			this.ChangeClientNameMenuItem.Text = "Change Client Name";
			this.ChangeClientNameMenuItem.Click += new System.EventHandler(this.ChangeClientNameMenuItem_Click);
			// 
			// RebuildLibraryMenuItem
			// 
			this.RebuildLibraryMenuItem.Name = "RebuildLibraryMenuItem";
			this.RebuildLibraryMenuItem.Size = new System.Drawing.Size(184, 22);
			this.RebuildLibraryMenuItem.Text = "Rebuild Library";
			// 
			// DataBufferSizeMenuItem
			// 
			this.DataBufferSizeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bytes512MenuItem,
            this.Bytes1024MenuItem,
            this.Bytes2048MenuItem,
            this.Bytes4096MenuItem,
            this.Bytes8192MenuItem});
			this.DataBufferSizeMenuItem.Name = "DataBufferSizeMenuItem";
			this.DataBufferSizeMenuItem.Size = new System.Drawing.Size(184, 22);
			this.DataBufferSizeMenuItem.Text = "Data Buffer Size";
			// 
			// Bytes512MenuItem
			// 
			this.Bytes512MenuItem.Name = "Bytes512MenuItem";
			this.Bytes512MenuItem.Size = new System.Drawing.Size(221, 22);
			this.Bytes512MenuItem.Text = "512 Bytes";
			this.Bytes512MenuItem.Click += new System.EventHandler(this.Bytes512MenuItem_Click);
			// 
			// Bytes1024MenuItem
			// 
			this.Bytes1024MenuItem.Name = "Bytes1024MenuItem";
			this.Bytes1024MenuItem.Size = new System.Drawing.Size(221, 22);
			this.Bytes1024MenuItem.Text = "1024 Bytes";
			this.Bytes1024MenuItem.Click += new System.EventHandler(this.Bytes1024MenuItem_Click);
			// 
			// Bytes2048MenuItem
			// 
			this.Bytes2048MenuItem.Name = "Bytes2048MenuItem";
			this.Bytes2048MenuItem.Size = new System.Drawing.Size(221, 22);
			this.Bytes2048MenuItem.Text = "2048 Bytes";
			this.Bytes2048MenuItem.Click += new System.EventHandler(this.Bytes2048MenuItem_Click);
			// 
			// Bytes4096MenuItem
			// 
			this.Bytes4096MenuItem.Name = "Bytes4096MenuItem";
			this.Bytes4096MenuItem.Size = new System.Drawing.Size(221, 22);
			this.Bytes4096MenuItem.Text = "4096 Bytes (Recommended)";
			this.Bytes4096MenuItem.Click += new System.EventHandler(this.Bytes4096MenuItem_Click);
			// 
			// Bytes8192MenuItem
			// 
			this.Bytes8192MenuItem.Name = "Bytes8192MenuItem";
			this.Bytes8192MenuItem.Size = new System.Drawing.Size(221, 22);
			this.Bytes8192MenuItem.Text = "8192 Bytes";
			this.Bytes8192MenuItem.Click += new System.EventHandler(this.Bytes8192MenuItem_Click);
			// 
			// BufferAtPercentMenuItem
			// 
			this.BufferAtPercentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Percent5MenuItem,
            this.Percent10MenuItem,
            this.Percent25MenuItem,
            this.Percent50MenuItem,
            this.Percent100MenuItem});
			this.BufferAtPercentMenuItem.Name = "BufferAtPercentMenuItem";
			this.BufferAtPercentMenuItem.Size = new System.Drawing.Size(184, 22);
			this.BufferAtPercentMenuItem.Text = "Buffer at Percent";
			// 
			// Percent5MenuItem
			// 
			this.Percent5MenuItem.Name = "Percent5MenuItem";
			this.Percent5MenuItem.Size = new System.Drawing.Size(188, 22);
			this.Percent5MenuItem.Text = "5%";
			this.Percent5MenuItem.Click += new System.EventHandler(this.Percent5MenuItem_Click);
			// 
			// Percent10MenuItem
			// 
			this.Percent10MenuItem.Name = "Percent10MenuItem";
			this.Percent10MenuItem.Size = new System.Drawing.Size(188, 22);
			this.Percent10MenuItem.Text = "10% (Recommended)";
			this.Percent10MenuItem.Click += new System.EventHandler(this.Percent10MenuItem_Click);
			// 
			// Percent25MenuItem
			// 
			this.Percent25MenuItem.Name = "Percent25MenuItem";
			this.Percent25MenuItem.Size = new System.Drawing.Size(188, 22);
			this.Percent25MenuItem.Text = "25%";
			this.Percent25MenuItem.Click += new System.EventHandler(this.Percent25MenuItem_Click);
			// 
			// Percent50MenuItem
			// 
			this.Percent50MenuItem.Name = "Percent50MenuItem";
			this.Percent50MenuItem.Size = new System.Drawing.Size(188, 22);
			this.Percent50MenuItem.Text = "50%";
			this.Percent50MenuItem.Click += new System.EventHandler(this.Percent50MenuItem_Click);
			// 
			// Percent100MenuItem
			// 
			this.Percent100MenuItem.Name = "Percent100MenuItem";
			this.Percent100MenuItem.Size = new System.Drawing.Size(188, 22);
			this.Percent100MenuItem.Text = "100%";
			this.Percent100MenuItem.Click += new System.EventHandler(this.Percent100MenuItem_Click);
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
			this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
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
			this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
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
			this.ActivePlaylistTab.Controls.Add(this.CopyToLocalAPCmd);
			this.ActivePlaylistTab.Controls.Add(this.ActivePlaylistDGV);
			this.ActivePlaylistTab.Controls.Add(this.DelCmd);
			this.ActivePlaylistTab.Controls.Add(this.ToBottomCmd);
			this.ActivePlaylistTab.Controls.Add(this.DownCmd);
			this.ActivePlaylistTab.Controls.Add(this.UpCmd);
			this.ActivePlaylistTab.Controls.Add(this.ToTopCmd);
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
			// CopyToLocalAPCmd
			// 
			this.CopyToLocalAPCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CopyToLocalAPCmd.Enabled = false;
			this.CopyToLocalAPCmd.Location = new System.Drawing.Point(393, 4);
			this.CopyToLocalAPCmd.Name = "CopyToLocalAPCmd";
			this.CopyToLocalAPCmd.Size = new System.Drawing.Size(85, 23);
			this.CopyToLocalAPCmd.TabIndex = 8;
			this.CopyToLocalAPCmd.Text = "Copy To Local";
			this.CopyToLocalAPCmd.UseVisualStyleBackColor = true;
			this.CopyToLocalAPCmd.Click += new System.EventHandler(this.CopyToLocalAPCmd_Click);
			// 
			// ActivePlaylistDGV
			// 
			this.ActivePlaylistDGV.AllowUserToAddRows = false;
			this.ActivePlaylistDGV.AllowUserToDeleteRows = false;
			this.ActivePlaylistDGV.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.ActivePlaylistDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.ActivePlaylistDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ActivePlaylistDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.ActivePlaylistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ActivePlaylistDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberAPDGVColumn,
            this.TitleAPDGVColumn,
            this.ArtistsAPDGVColumn,
            this.AlbumAPDGVColumn,
            this.LengthAPDGVColumn,
            this.SizeAPDGVColumn,
            this.GenresAPDGVColumn,
            this.TrackAPDGVColumn,
            this.YearAPDGVColumn,
            this.CommentAPDGVColumn,
            this.ServerNameAPDGVColumn,
            this.LengthHiddenAPDGVColumn,
            this.FilesizeHiddenAPDGVColumn,
            this.TrackHiddenAPDGVColumn,
            this.YearHiddenAPDGVColumn});
			this.ActivePlaylistDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.ActivePlaylistDGV.Location = new System.Drawing.Point(6, 33);
			this.ActivePlaylistDGV.Name = "ActivePlaylistDGV";
			this.ActivePlaylistDGV.RowHeadersVisible = false;
			this.ActivePlaylistDGV.RowTemplate.Height = 18;
			this.ActivePlaylistDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ActivePlaylistDGV.ShowEditingIcon = false;
			this.ActivePlaylistDGV.Size = new System.Drawing.Size(613, 287);
			this.ActivePlaylistDGV.TabIndex = 11;
			this.ActivePlaylistDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ActivePlaylistDGV_CellMouseDoubleClick);
			this.ActivePlaylistDGV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ActivePlaylistDGV_ColumnHeaderMouseClick);
			this.ActivePlaylistDGV.SelectionChanged += new System.EventHandler(this.ActivePlaylistDGV_SelectionChanged);
			this.ActivePlaylistDGV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ActivePlaylistDGV_MouseUp);
			// 
			// NumberAPDGVColumn
			// 
			this.NumberAPDGVColumn.HeaderText = "#";
			this.NumberAPDGVColumn.MinimumWidth = 34;
			this.NumberAPDGVColumn.Name = "NumberAPDGVColumn";
			this.NumberAPDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.NumberAPDGVColumn.Width = 34;
			// 
			// TitleAPDGVColumn
			// 
			this.TitleAPDGVColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TitleAPDGVColumn.FillWeight = 200F;
			this.TitleAPDGVColumn.HeaderText = "Title";
			this.TitleAPDGVColumn.MinimumWidth = 200;
			this.TitleAPDGVColumn.Name = "TitleAPDGVColumn";
			// 
			// ArtistsAPDGVColumn
			// 
			this.ArtistsAPDGVColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ArtistsAPDGVColumn.HeaderText = "Artists";
			this.ArtistsAPDGVColumn.MinimumWidth = 100;
			this.ArtistsAPDGVColumn.Name = "ArtistsAPDGVColumn";
			// 
			// AlbumAPDGVColumn
			// 
			this.AlbumAPDGVColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AlbumAPDGVColumn.HeaderText = "Album";
			this.AlbumAPDGVColumn.MinimumWidth = 125;
			this.AlbumAPDGVColumn.Name = "AlbumAPDGVColumn";
			// 
			// LengthAPDGVColumn
			// 
			this.LengthAPDGVColumn.HeaderText = "Length";
			this.LengthAPDGVColumn.MinimumWidth = 65;
			this.LengthAPDGVColumn.Name = "LengthAPDGVColumn";
			this.LengthAPDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.LengthAPDGVColumn.Width = 65;
			// 
			// SizeAPDGVColumn
			// 
			this.SizeAPDGVColumn.HeaderText = "Size";
			this.SizeAPDGVColumn.MinimumWidth = 52;
			this.SizeAPDGVColumn.Name = "SizeAPDGVColumn";
			this.SizeAPDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.SizeAPDGVColumn.Width = 52;
			// 
			// GenresAPDGVColumn
			// 
			this.GenresAPDGVColumn.HeaderText = "Genres";
			this.GenresAPDGVColumn.MinimumWidth = 50;
			this.GenresAPDGVColumn.Name = "GenresAPDGVColumn";
			// 
			// TrackAPDGVColumn
			// 
			this.TrackAPDGVColumn.HeaderText = "Track";
			this.TrackAPDGVColumn.MinimumWidth = 60;
			this.TrackAPDGVColumn.Name = "TrackAPDGVColumn";
			this.TrackAPDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.TrackAPDGVColumn.Width = 60;
			// 
			// YearAPDGVColumn
			// 
			this.YearAPDGVColumn.HeaderText = "Year";
			this.YearAPDGVColumn.MinimumWidth = 54;
			this.YearAPDGVColumn.Name = "YearAPDGVColumn";
			this.YearAPDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.YearAPDGVColumn.Width = 54;
			// 
			// CommentAPDGVColumn
			// 
			this.CommentAPDGVColumn.HeaderText = "Comment";
			this.CommentAPDGVColumn.MinimumWidth = 50;
			this.CommentAPDGVColumn.Name = "CommentAPDGVColumn";
			this.CommentAPDGVColumn.Width = 150;
			// 
			// ServerNameAPDGVColumn
			// 
			this.ServerNameAPDGVColumn.HeaderText = "Server Name";
			this.ServerNameAPDGVColumn.MinimumWidth = 150;
			this.ServerNameAPDGVColumn.Name = "ServerNameAPDGVColumn";
			this.ServerNameAPDGVColumn.Width = 150;
			// 
			// LengthHiddenAPDGVColumn
			// 
			this.LengthHiddenAPDGVColumn.HeaderText = "LengthHidden";
			this.LengthHiddenAPDGVColumn.Name = "LengthHiddenAPDGVColumn";
			this.LengthHiddenAPDGVColumn.Visible = false;
			// 
			// FilesizeHiddenAPDGVColumn
			// 
			this.FilesizeHiddenAPDGVColumn.HeaderText = "FilesizeHidden";
			this.FilesizeHiddenAPDGVColumn.Name = "FilesizeHiddenAPDGVColumn";
			this.FilesizeHiddenAPDGVColumn.Visible = false;
			// 
			// TrackHiddenAPDGVColumn
			// 
			this.TrackHiddenAPDGVColumn.HeaderText = "TrackHidden";
			this.TrackHiddenAPDGVColumn.Name = "TrackHiddenAPDGVColumn";
			this.TrackHiddenAPDGVColumn.Visible = false;
			// 
			// YearHiddenAPDGVColumn
			// 
			this.YearHiddenAPDGVColumn.HeaderText = "YearHidden";
			this.YearHiddenAPDGVColumn.Name = "YearHiddenAPDGVColumn";
			this.YearHiddenAPDGVColumn.Visible = false;
			// 
			// DelCmd
			// 
			this.DelCmd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DelCmd.Enabled = false;
			this.DelCmd.Location = new System.Drawing.Point(625, 157);
			this.DelCmd.Name = "DelCmd";
			this.DelCmd.Size = new System.Drawing.Size(33, 40);
			this.DelCmd.TabIndex = 14;
			this.DelCmd.Text = "Del";
			this.DelCmd.UseVisualStyleBackColor = true;
			this.DelCmd.Click += new System.EventHandler(this.DelCmd_Click);
			// 
			// ToBottomCmd
			// 
			this.ToBottomCmd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.ToBottomCmd.Enabled = false;
			this.ToBottomCmd.Location = new System.Drawing.Point(625, 264);
			this.ToBottomCmd.Name = "ToBottomCmd";
			this.ToBottomCmd.Size = new System.Drawing.Size(33, 56);
			this.ToBottomCmd.TabIndex = 16;
			this.ToBottomCmd.Text = "\\/ \\/";
			this.ToBottomCmd.UseVisualStyleBackColor = true;
			this.ToBottomCmd.Click += new System.EventHandler(this.ToBottomCmd_Click);
			// 
			// DownCmd
			// 
			this.DownCmd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DownCmd.Enabled = false;
			this.DownCmd.Location = new System.Drawing.Point(625, 203);
			this.DownCmd.Name = "DownCmd";
			this.DownCmd.Size = new System.Drawing.Size(33, 56);
			this.DownCmd.TabIndex = 15;
			this.DownCmd.Text = "\\/";
			this.DownCmd.UseVisualStyleBackColor = true;
			this.DownCmd.Click += new System.EventHandler(this.DownCmd_Click);
			// 
			// UpCmd
			// 
			this.UpCmd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.UpCmd.Enabled = false;
			this.UpCmd.Location = new System.Drawing.Point(625, 95);
			this.UpCmd.Name = "UpCmd";
			this.UpCmd.Size = new System.Drawing.Size(33, 56);
			this.UpCmd.TabIndex = 13;
			this.UpCmd.Text = "/\\";
			this.UpCmd.UseVisualStyleBackColor = true;
			this.UpCmd.Click += new System.EventHandler(this.UpCmd_Click);
			// 
			// ToTopCmd
			// 
			this.ToTopCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ToTopCmd.Enabled = false;
			this.ToTopCmd.Location = new System.Drawing.Point(625, 33);
			this.ToTopCmd.Name = "ToTopCmd";
			this.ToTopCmd.Size = new System.Drawing.Size(33, 56);
			this.ToTopCmd.TabIndex = 12;
			this.ToTopCmd.Text = "/\\ /\\";
			this.ToTopCmd.UseVisualStyleBackColor = true;
			this.ToTopCmd.Click += new System.EventHandler(this.ToTopCmd_Click);
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
			this.NewPlaylistAPCmd.Click += new System.EventHandler(this.NewPlaylistAPCmd_Click);
			// 
			// DeletePlaylistAPCmd
			// 
			this.DeletePlaylistAPCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeletePlaylistAPCmd.Enabled = false;
			this.DeletePlaylistAPCmd.Location = new System.Drawing.Point(484, 4);
			this.DeletePlaylistAPCmd.Name = "DeletePlaylistAPCmd";
			this.DeletePlaylistAPCmd.Size = new System.Drawing.Size(85, 23);
			this.DeletePlaylistAPCmd.TabIndex = 9;
			this.DeletePlaylistAPCmd.Text = "Delete Playlist";
			this.DeletePlaylistAPCmd.UseVisualStyleBackColor = true;
			this.DeletePlaylistAPCmd.Click += new System.EventHandler(this.DeletePlaylistAPCmd_Click);
			// 
			// PlaylistAPComb
			// 
			this.PlaylistAPComb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PlaylistAPComb.FormattingEnabled = true;
			this.PlaylistAPComb.Location = new System.Drawing.Point(6, 6);
			this.PlaylistAPComb.Name = "PlaylistAPComb";
			this.PlaylistAPComb.Size = new System.Drawing.Size(381, 21);
			this.PlaylistAPComb.TabIndex = 7;
			this.PlaylistAPComb.SelectedIndexChanged += new System.EventHandler(this.PlaylistAPComb_SelectedIndexChanged);
			this.PlaylistAPComb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlaylistAPComb_KeyPress);
			// 
			// LibraryTab
			// 
			this.LibraryTab.Controls.Add(this.MusicLibraryDGV);
			this.LibraryTab.Controls.Add(this.NewPlaylistMLComb);
			this.LibraryTab.Controls.Add(this.DeletePlaylistMLCmd);
			this.LibraryTab.Controls.Add(this.AddToPlaylistMLCmd);
			this.LibraryTab.Controls.Add(this.PlaylistMLComb);
			this.LibraryTab.Location = new System.Drawing.Point(4, 22);
			this.LibraryTab.Name = "LibraryTab";
			this.LibraryTab.Padding = new System.Windows.Forms.Padding(3);
			this.LibraryTab.Size = new System.Drawing.Size(664, 326);
			this.LibraryTab.TabIndex = 1;
			this.LibraryTab.Text = "Music Library";
			this.LibraryTab.UseVisualStyleBackColor = true;
			// 
			// MusicLibraryDGV
			// 
			this.MusicLibraryDGV.AllowUserToAddRows = false;
			this.MusicLibraryDGV.AllowUserToDeleteRows = false;
			this.MusicLibraryDGV.AllowUserToResizeRows = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.MusicLibraryDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.MusicLibraryDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.MusicLibraryDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.MusicLibraryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MusicLibraryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleMLDGVColumn,
            this.ArtistsMLDGVColumn,
            this.AlbumMLDGVColumn,
            this.LengthMLDGVColumn,
            this.SizeMLDGVColumn,
            this.GenresMLDGVColumn,
            this.TrackMLDGVColumn,
            this.YearMLDGVColumn,
            this.CommentMLDGVColumn,
            this.ServerNameMLDGVColumn,
            this.LengthHiddenMLDGVColumn,
            this.FilesizeHiddenMLDGVColumn,
            this.TrackHiddenMLDGVColumn,
            this.YearHiddenMLDGVColumn});
			this.MusicLibraryDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.MusicLibraryDGV.Location = new System.Drawing.Point(5, 6);
			this.MusicLibraryDGV.Name = "MusicLibraryDGV";
			this.MusicLibraryDGV.RowHeadersVisible = false;
			this.MusicLibraryDGV.RowTemplate.Height = 18;
			this.MusicLibraryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.MusicLibraryDGV.ShowEditingIcon = false;
			this.MusicLibraryDGV.Size = new System.Drawing.Size(653, 287);
			this.MusicLibraryDGV.TabIndex = 17;
			this.MusicLibraryDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MusicLibraryDGV_CellMouseDoubleClick);
			this.MusicLibraryDGV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MusicLibraryDGV_ColumnHeaderMouseClick);
			this.MusicLibraryDGV.SelectionChanged += new System.EventHandler(this.MusicLibraryDGV_SelectionChanged);
			this.MusicLibraryDGV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MusicLibraryDGV_MouseUp);
			// 
			// TitleMLDGVColumn
			// 
			this.TitleMLDGVColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TitleMLDGVColumn.FillWeight = 200F;
			this.TitleMLDGVColumn.HeaderText = "Title";
			this.TitleMLDGVColumn.MinimumWidth = 200;
			this.TitleMLDGVColumn.Name = "TitleMLDGVColumn";
			// 
			// ArtistsMLDGVColumn
			// 
			this.ArtistsMLDGVColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ArtistsMLDGVColumn.HeaderText = "Artists";
			this.ArtistsMLDGVColumn.MinimumWidth = 100;
			this.ArtistsMLDGVColumn.Name = "ArtistsMLDGVColumn";
			// 
			// AlbumMLDGVColumn
			// 
			this.AlbumMLDGVColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AlbumMLDGVColumn.HeaderText = "Album";
			this.AlbumMLDGVColumn.MinimumWidth = 125;
			this.AlbumMLDGVColumn.Name = "AlbumMLDGVColumn";
			// 
			// LengthMLDGVColumn
			// 
			this.LengthMLDGVColumn.HeaderText = "Length";
			this.LengthMLDGVColumn.MinimumWidth = 65;
			this.LengthMLDGVColumn.Name = "LengthMLDGVColumn";
			this.LengthMLDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.LengthMLDGVColumn.Width = 65;
			// 
			// SizeMLDGVColumn
			// 
			this.SizeMLDGVColumn.HeaderText = "Size";
			this.SizeMLDGVColumn.MinimumWidth = 52;
			this.SizeMLDGVColumn.Name = "SizeMLDGVColumn";
			this.SizeMLDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.SizeMLDGVColumn.Width = 52;
			// 
			// GenresMLDGVColumn
			// 
			this.GenresMLDGVColumn.HeaderText = "Genres";
			this.GenresMLDGVColumn.MinimumWidth = 50;
			this.GenresMLDGVColumn.Name = "GenresMLDGVColumn";
			// 
			// TrackMLDGVColumn
			// 
			this.TrackMLDGVColumn.HeaderText = "Track";
			this.TrackMLDGVColumn.MinimumWidth = 60;
			this.TrackMLDGVColumn.Name = "TrackMLDGVColumn";
			this.TrackMLDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.TrackMLDGVColumn.Width = 60;
			// 
			// YearMLDGVColumn
			// 
			this.YearMLDGVColumn.HeaderText = "Year";
			this.YearMLDGVColumn.MinimumWidth = 54;
			this.YearMLDGVColumn.Name = "YearMLDGVColumn";
			this.YearMLDGVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.YearMLDGVColumn.Width = 54;
			// 
			// CommentMLDGVColumn
			// 
			this.CommentMLDGVColumn.HeaderText = "Comment";
			this.CommentMLDGVColumn.MinimumWidth = 50;
			this.CommentMLDGVColumn.Name = "CommentMLDGVColumn";
			this.CommentMLDGVColumn.Width = 150;
			// 
			// ServerNameMLDGVColumn
			// 
			this.ServerNameMLDGVColumn.HeaderText = "Server Name";
			this.ServerNameMLDGVColumn.MinimumWidth = 150;
			this.ServerNameMLDGVColumn.Name = "ServerNameMLDGVColumn";
			this.ServerNameMLDGVColumn.Width = 150;
			// 
			// LengthHiddenMLDGVColumn
			// 
			this.LengthHiddenMLDGVColumn.HeaderText = "LengthHidden";
			this.LengthHiddenMLDGVColumn.Name = "LengthHiddenMLDGVColumn";
			this.LengthHiddenMLDGVColumn.Visible = false;
			// 
			// FilesizeHiddenMLDGVColumn
			// 
			this.FilesizeHiddenMLDGVColumn.HeaderText = "FilesizeHidden";
			this.FilesizeHiddenMLDGVColumn.Name = "FilesizeHiddenMLDGVColumn";
			this.FilesizeHiddenMLDGVColumn.Visible = false;
			// 
			// TrackHiddenMLDGVColumn
			// 
			this.TrackHiddenMLDGVColumn.HeaderText = "TrackHidden";
			this.TrackHiddenMLDGVColumn.Name = "TrackHiddenMLDGVColumn";
			this.TrackHiddenMLDGVColumn.Visible = false;
			// 
			// YearHiddenMLDGVColumn
			// 
			this.YearHiddenMLDGVColumn.HeaderText = "YearHidden";
			this.YearHiddenMLDGVColumn.Name = "YearHiddenMLDGVColumn";
			this.YearHiddenMLDGVColumn.Visible = false;
			// 
			// NewPlaylistMLComb
			// 
			this.NewPlaylistMLComb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NewPlaylistMLComb.Location = new System.Drawing.Point(574, 297);
			this.NewPlaylistMLComb.Name = "NewPlaylistMLComb";
			this.NewPlaylistMLComb.Size = new System.Drawing.Size(85, 23);
			this.NewPlaylistMLComb.TabIndex = 21;
			this.NewPlaylistMLComb.Text = "New Playlist";
			this.NewPlaylistMLComb.UseVisualStyleBackColor = true;
			this.NewPlaylistMLComb.Click += new System.EventHandler(this.NewPlaylistMLComb_Click);
			// 
			// DeletePlaylistMLCmd
			// 
			this.DeletePlaylistMLCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeletePlaylistMLCmd.Enabled = false;
			this.DeletePlaylistMLCmd.Location = new System.Drawing.Point(483, 297);
			this.DeletePlaylistMLCmd.Name = "DeletePlaylistMLCmd";
			this.DeletePlaylistMLCmd.Size = new System.Drawing.Size(85, 23);
			this.DeletePlaylistMLCmd.TabIndex = 20;
			this.DeletePlaylistMLCmd.Text = "Delete Playlist";
			this.DeletePlaylistMLCmd.UseVisualStyleBackColor = true;
			this.DeletePlaylistMLCmd.Click += new System.EventHandler(this.DeletePlaylistMLCmd_Click);
			// 
			// AddToPlaylistMLCmd
			// 
			this.AddToPlaylistMLCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddToPlaylistMLCmd.Enabled = false;
			this.AddToPlaylistMLCmd.Location = new System.Drawing.Point(392, 297);
			this.AddToPlaylistMLCmd.Name = "AddToPlaylistMLCmd";
			this.AddToPlaylistMLCmd.Size = new System.Drawing.Size(85, 23);
			this.AddToPlaylistMLCmd.TabIndex = 19;
			this.AddToPlaylistMLCmd.Text = "Add To Playlist";
			this.AddToPlaylistMLCmd.UseVisualStyleBackColor = true;
			this.AddToPlaylistMLCmd.Click += new System.EventHandler(this.AddToPlaylistMLCmd_Click);
			// 
			// PlaylistMLComb
			// 
			this.PlaylistMLComb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PlaylistMLComb.FormattingEnabled = true;
			this.PlaylistMLComb.Location = new System.Drawing.Point(6, 299);
			this.PlaylistMLComb.Name = "PlaylistMLComb";
			this.PlaylistMLComb.Size = new System.Drawing.Size(380, 21);
			this.PlaylistMLComb.TabIndex = 18;
			this.PlaylistMLComb.SelectedIndexChanged += new System.EventHandler(this.PlaylistMLComb_SelectedIndexChanged);
			this.PlaylistMLComb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlaylistMLComb_KeyPress);
			// 
			// SongBufferingProgressBar
			// 
			this.SongBufferingProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.SongBufferingProgressBar.Location = new System.Drawing.Point(212, 62);
			this.SongBufferingProgressBar.Maximum = 0;
			this.SongBufferingProgressBar.Name = "SongBufferingProgressBar";
			this.SongBufferingProgressBar.Size = new System.Drawing.Size(389, 10);
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
			this.SongTrack.Size = new System.Drawing.Size(414, 23);
			this.SongTrack.TabIndex = 5;
			this.SongTrack.TickStyle = System.Windows.Forms.TickStyle.None;
			this.SongTrack.Scroll += new System.EventHandler(this.SongTrack_Scroll);
			this.SongTrack.ValueChanged += new System.EventHandler(this.SongTrack_ValueChanged);
			this.SongTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SongTrack_MouseDown);
			this.SongTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SongTrack_MouseUp);
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
			this.VolumeTrack.TabIndex = 6;
			this.VolumeTrack.TickStyle = System.Windows.Forms.TickStyle.None;
			this.VolumeTrack.Value = 50;
			this.VolumeTrack.Scroll += new System.EventHandler(this.VolumeTrack_Scroll);
			this.VolumeTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VolumeTrack_MouseUp);
			// 
			// PreviousCmd
			// 
			this.PreviousCmd.Enabled = false;
			this.PreviousCmd.Location = new System.Drawing.Point(7, 24);
			this.PreviousCmd.Name = "PreviousCmd";
			this.PreviousCmd.Size = new System.Drawing.Size(50, 23);
			this.PreviousCmd.TabIndex = 0;
			this.PreviousCmd.Text = "< <";
			this.PreviousCmd.UseVisualStyleBackColor = true;
			this.PreviousCmd.Click += new System.EventHandler(this.PreviousCmd_Click);
			// 
			// NextCmd
			// 
			this.NextCmd.Enabled = false;
			this.NextCmd.Location = new System.Drawing.Point(144, 24);
			this.NextCmd.Name = "NextCmd";
			this.NextCmd.Size = new System.Drawing.Size(50, 23);
			this.NextCmd.TabIndex = 2;
			this.NextCmd.Text = "> >";
			this.NextCmd.UseVisualStyleBackColor = true;
			this.NextCmd.Click += new System.EventHandler(this.NextCmd_Click);
			// 
			// PlayCmd
			// 
			this.PlayCmd.Enabled = false;
			this.PlayCmd.Location = new System.Drawing.Point(63, 24);
			this.PlayCmd.Name = "PlayCmd";
			this.PlayCmd.Size = new System.Drawing.Size(75, 23);
			this.PlayCmd.TabIndex = 1;
			this.PlayCmd.Text = "Play";
			this.PlayCmd.UseVisualStyleBackColor = true;
			this.PlayCmd.Click += new System.EventHandler(this.PlayCmd_Click);
			// 
			// RepeatToggleCmd
			// 
			this.RepeatToggleCmd.Location = new System.Drawing.Point(7, 53);
			this.RepeatToggleCmd.Name = "RepeatToggleCmd";
			this.RepeatToggleCmd.Size = new System.Drawing.Size(90, 23);
			this.RepeatToggleCmd.TabIndex = 3;
			this.RepeatToggleCmd.Text = "Repeat Off";
			this.RepeatToggleCmd.UseVisualStyleBackColor = true;
			this.RepeatToggleCmd.Click += new System.EventHandler(this.RepeatToggleCmd_Click);
			// 
			// ShuffleToggleCmd
			// 
			this.ShuffleToggleCmd.Location = new System.Drawing.Point(104, 53);
			this.ShuffleToggleCmd.Name = "ShuffleToggleCmd";
			this.ShuffleToggleCmd.Size = new System.Drawing.Size(90, 23);
			this.ShuffleToggleCmd.TabIndex = 4;
			this.ShuffleToggleCmd.Text = "Shuffle Off";
			this.ShuffleToggleCmd.UseVisualStyleBackColor = true;
			this.ShuffleToggleCmd.Click += new System.EventHandler(this.ShuffleToggleCmd_Click);
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.FileName = "openFileDialog1";
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "Playing";
			this.dataGridViewImageColumn1.Image = global::BooBoxClient.Properties.Resources.Playing;
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn1.MinimumWidth = 20;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 20;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "P";
			this.dataGridViewImageColumn2.Image = global::BooBoxClient.Properties.Resources.Playing;
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn2.MinimumWidth = 20;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Width = 20;
			// 
			// AlbumArtPicBox
			// 
			this.AlbumArtPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AlbumArtPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AlbumArtPicBox.Image = global::BooBoxClient.Properties.Resources.NoAlbum128m;
			this.AlbumArtPicBox.Location = new System.Drawing.Point(617, 31);
			this.AlbumArtPicBox.Name = "AlbumArtPicBox";
			this.AlbumArtPicBox.Size = new System.Drawing.Size(60, 60);
			this.AlbumArtPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.AlbumArtPicBox.TabIndex = 31;
			this.AlbumArtPicBox.TabStop = false;
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
			// DebugCmd
			// 
			this.DebugCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DebugCmd.Location = new System.Drawing.Point(212, 0);
			this.DebugCmd.Name = "DebugCmd";
			this.DebugCmd.Size = new System.Drawing.Size(75, 23);
			this.DebugCmd.TabIndex = 32;
			this.DebugCmd.Text = "Debug";
			this.DebugCmd.UseVisualStyleBackColor = true;
			this.DebugCmd.Click += new System.EventHandler(this.DebugCmd_Click);
			// 
			// PlayTimer
			// 
			this.PlayTimer.Interval = 250;
			this.PlayTimer.Tick += new System.EventHandler(this.PlayTimer_Tick);
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 462);
			this.Controls.Add(this.DebugCmd);
			this.Controls.Add(this.AlbumArtPicBox);
			this.Controls.Add(this.VolumeUpPicBox);
			this.Controls.Add(this.VolumeDownPicBox);
			this.Controls.Add(this.ShuffleToggleCmd);
			this.Controls.Add(this.RepeatToggleCmd);
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
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
			this.Load += new System.EventHandler(this.MainFrm_Load);
			this.Resize += new System.EventHandler(this.MainFrm_Resize);
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.TabControl.ResumeLayout(false);
			this.ActivePlaylistTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ActivePlaylistDGV)).EndInit();
			this.LibraryTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MusicLibraryDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SongTrack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AlbumArtPicBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeUpPicBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeDownPicBox)).EndInit();
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
		private System.Windows.Forms.Button RepeatToggleCmd;
		private System.Windows.Forms.Button ShuffleToggleCmd;
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
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem VolumeUpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem VolumeDownMenuItem;
		private System.Windows.Forms.Button NewPlaylistMLComb;
		private System.Windows.Forms.Button DeletePlaylistMLCmd;
		private System.Windows.Forms.Button AddToPlaylistMLCmd;
		private System.Windows.Forms.ComboBox PlaylistMLComb;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.PictureBox AlbumArtPicBox;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.ToolStripMenuItem DataBufferSizeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Bytes512MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Bytes1024MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Bytes2048MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Bytes4096MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Bytes8192MenuItem;
		private System.Windows.Forms.ToolStripMenuItem BufferAtPercentMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Percent5MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Percent10MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Percent25MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Percent50MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Percent100MenuItem;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog;
		private System.Windows.Forms.SaveFileDialog SaveFileDialog;
		private System.Windows.Forms.ToolStripMenuItem ConnectToServerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ConnectToAllMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.DataGridView MusicLibraryDGV;
		private System.Windows.Forms.Button DebugCmd;
		private System.Windows.Forms.DataGridView ActivePlaylistDGV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TitleMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ArtistsMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AlbumMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LengthMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn GenresMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrackMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn YearMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CommentMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServerNameMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LengthHiddenMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn FilesizeHiddenMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrackHiddenMLDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn YearHiddenMLDGVColumn;
		private System.Windows.Forms.Button CopyToLocalAPCmd;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumberAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TitleAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ArtistsAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AlbumAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LengthAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn GenresAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrackAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn YearAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CommentAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServerNameAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LengthHiddenAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn FilesizeHiddenAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrackHiddenAPDGVColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn YearHiddenAPDGVColumn;
		private System.Windows.Forms.Timer PlayTimer;
	}
}

