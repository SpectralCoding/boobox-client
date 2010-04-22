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
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ControlsMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.PlayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PreviousMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.ShuffleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RepeatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShuffleOffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShuffleOnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RepeatOffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RepeatOneMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RepeatAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChangeClientNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.ExportSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.RebuildLibraryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ProgressBarStatusStrip = new System.Windows.Forms.ToolStripProgressBar();
			this.ProgressBarLblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ActivePlaylistTab = new System.Windows.Forms.TabPage();
			this.LibraryTab = new System.Windows.Forms.TabPage();
			this.StatusStrip.SuspendLayout();
			this.MenuStrip.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// StatusStrip
			// 
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBarStatusStrip,
            this.ProgressBarLblStatusStrip});
			this.StatusStrip.Location = new System.Drawing.Point(0, 399);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(754, 22);
			this.StatusStrip.TabIndex = 0;
			this.StatusStrip.Text = "statusStrip1";
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
			this.MenuStrip.Size = new System.Drawing.Size(754, 24);
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
			// OptionsMenuHeader
			// 
			this.OptionsMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeClientNameMenuItem,
            this.RebuildLibraryMenuItem});
			this.OptionsMenuHeader.Name = "OptionsMenuHeader";
			this.OptionsMenuHeader.Size = new System.Drawing.Size(61, 20);
			this.OptionsMenuHeader.Text = "&Options";
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
			// ShuffleOffMenuItem
			// 
			this.ShuffleOffMenuItem.Name = "ShuffleOffMenuItem";
			this.ShuffleOffMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ShuffleOffMenuItem.Text = "Shuffle Off";
			// 
			// ShuffleOnMenuItem
			// 
			this.ShuffleOnMenuItem.Name = "ShuffleOnMenuItem";
			this.ShuffleOnMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ShuffleOnMenuItem.Text = "Shuffle On";
			// 
			// RepeatOffMenuItem
			// 
			this.RepeatOffMenuItem.Name = "RepeatOffMenuItem";
			this.RepeatOffMenuItem.Size = new System.Drawing.Size(152, 22);
			this.RepeatOffMenuItem.Text = "Repeat Off";
			// 
			// RepeatOneMenuItem
			// 
			this.RepeatOneMenuItem.Name = "RepeatOneMenuItem";
			this.RepeatOneMenuItem.Size = new System.Drawing.Size(152, 22);
			this.RepeatOneMenuItem.Text = "Repeat One";
			// 
			// RepeatAllMenuItem
			// 
			this.RepeatAllMenuItem.Name = "RepeatAllMenuItem";
			this.RepeatAllMenuItem.Size = new System.Drawing.Size(152, 22);
			this.RepeatAllMenuItem.Text = "Repeat All";
			// 
			// ChangeClientNameMenuItem
			// 
			this.ChangeClientNameMenuItem.Name = "ChangeClientNameMenuItem";
			this.ChangeClientNameMenuItem.Size = new System.Drawing.Size(184, 22);
			this.ChangeClientNameMenuItem.Text = "Change Client Name";
			// 
			// AddServerMenuItem
			// 
			this.AddServerMenuItem.Name = "AddServerMenuItem";
			this.AddServerMenuItem.Size = new System.Drawing.Size(192, 22);
			this.AddServerMenuItem.Text = "&Add Server...";
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
			// EditServerMenuItem
			// 
			this.EditServerMenuItem.Name = "EditServerMenuItem";
			this.EditServerMenuItem.Size = new System.Drawing.Size(192, 22);
			this.EditServerMenuItem.Text = "Edit Server...";
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
			// RebuildLibraryMenuItem
			// 
			this.RebuildLibraryMenuItem.Name = "RebuildLibraryMenuItem";
			this.RebuildLibraryMenuItem.Size = new System.Drawing.Size(184, 22);
			this.RebuildLibraryMenuItem.Text = "Rebuild Library";
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
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.ActivePlaylistTab);
			this.tabControl1.Controls.Add(this.LibraryTab);
			this.tabControl1.Location = new System.Drawing.Point(12, 169);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(278, 240);
			this.tabControl1.TabIndex = 2;
			// 
			// ActivePlaylistTab
			// 
			this.ActivePlaylistTab.Location = new System.Drawing.Point(4, 22);
			this.ActivePlaylistTab.Name = "ActivePlaylistTab";
			this.ActivePlaylistTab.Padding = new System.Windows.Forms.Padding(3);
			this.ActivePlaylistTab.Size = new System.Drawing.Size(270, 214);
			this.ActivePlaylistTab.TabIndex = 0;
			this.ActivePlaylistTab.Text = "Active Playlist";
			this.ActivePlaylistTab.UseVisualStyleBackColor = true;
			// 
			// LibraryTab
			// 
			this.LibraryTab.Location = new System.Drawing.Point(4, 22);
			this.LibraryTab.Name = "LibraryTab";
			this.LibraryTab.Padding = new System.Windows.Forms.Padding(3);
			this.LibraryTab.Size = new System.Drawing.Size(270, 214);
			this.LibraryTab.TabIndex = 1;
			this.LibraryTab.Text = "Music Library";
			this.LibraryTab.UseVisualStyleBackColor = true;
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 421);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "MainFrm";
			this.Text = "BooBox Client : Name";
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.tabControl1.ResumeLayout(false);
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
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage ActivePlaylistTab;
		private System.Windows.Forms.TabPage LibraryTab;
	}
}

