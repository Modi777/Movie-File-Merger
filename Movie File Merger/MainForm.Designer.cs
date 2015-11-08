﻿/*
 * Created by SharpDevelop.
 * User: rlauer
 * Date: 2012-04-09
 * Time: 3:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Movie_File_Merger
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.fbdMovieFileMerger = new System.Windows.Forms.FolderBrowserDialog();
			this.ilMovieFileMerger = new System.Windows.Forms.ImageList(this.components);
			this.tmrUpdateCounters = new System.Windows.Forms.Timer(this.components);
			this.sfdMovieFileMerger = new System.Windows.Forms.SaveFileDialog();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.tcMovieFileMerger = new System.Windows.Forms.TabControl();
			this.tpSeparateLists = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.btnHigherRes = new System.Windows.Forms.Button();
			this.btnLowRes = new System.Windows.Forms.Button();
			this.btnToConsider = new System.Windows.Forms.Button();
			this.btnWish = new System.Windows.Forms.Button();
			this.btnExisting = new System.Windows.Forms.Button();
			this.btnGarbage = new System.Windows.Forms.Button();
			this.cobMinimumResolution = new System.Windows.Forms.ComboBox();
			this.btnJustScanIt = new System.Windows.Forms.Button();
			this.btnJustRipIt = new System.Windows.Forms.Button();
			this.cobCriteria = new System.Windows.Forms.ComboBox();
			this.btnAddToWish = new System.Windows.Forms.Button();
			this.btnBin = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.cobToolTipRegex = new System.Windows.Forms.ComboBox();
			this.tbToolTipRegex = new System.Windows.Forms.TextBox();
			this.cbMediaInfo = new System.Windows.Forms.CheckBox();
			this.lblTargetFolder = new System.Windows.Forms.Label();
			this.lblImportFolder = new System.Windows.Forms.Label();
			this.btnExportList = new System.Windows.Forms.Button();
			this.btnEraseColor = new System.Windows.Forms.Button();
			this.btnSearchDownload = new System.Windows.Forms.Button();
			this.btnMediaInfo = new System.Windows.Forms.Button();
			this.btnEraseSelected = new System.Windows.Forms.Button();
			this.scFolders = new System.Windows.Forms.SplitContainer();
			this.tbTargetFolder = new System.Windows.Forms.TextBox();
			this.tbImportFolder = new System.Windows.Forms.TextBox();
			this.btnSearchInfo = new System.Windows.Forms.Button();
			this.gbTypeSelection = new System.Windows.Forms.GroupBox();
			this.rbMiscellaneous = new System.Windows.Forms.RadioButton();
			this.rbAdults = new System.Windows.Forms.RadioButton();
			this.rbClips = new System.Windows.Forms.RadioButton();
			this.rbSeries = new System.Windows.Forms.RadioButton();
			this.rbDocumentaries = new System.Windows.Forms.RadioButton();
			this.rbMovies = new System.Windows.Forms.RadioButton();
			this.gbProcessImport = new System.Windows.Forms.GroupBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.cbGetHigherRes = new System.Windows.Forms.CheckBox();
			this.cbKeepFolders = new System.Windows.Forms.CheckBox();
			this.rbMove = new System.Windows.Forms.RadioButton();
			this.rbCopy = new System.Windows.Forms.RadioButton();
			this.btnPlay = new System.Windows.Forms.Button();
			this.scVertical = new System.Windows.Forms.SplitContainer();
			this.lvExisting = new System.Windows.Forms.ListView();
			this.chNameExisting = new System.Windows.Forms.ColumnHeader("(none)");
			this.scVerticalRight = new System.Windows.Forms.SplitContainer();
			this.scHorizontal = new System.Windows.Forms.SplitContainer();
			this.lvWish = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader("(none)");
			this.lvGarbage = new System.Windows.Forms.ListView();
			this.chNameGarbage = new System.Windows.Forms.ColumnHeader("(none)");
			this.lvImport = new System.Windows.Forms.ListView();
			this.chNameImport = new System.Windows.Forms.ColumnHeader("(none)");
			this.tpMaintenance = new System.Windows.Forms.TabPage();
			this.btnGoodEpisode = new System.Windows.Forms.Button();
			this.btnGoodDocu = new System.Windows.Forms.Button();
			this.btnGoodMovie = new System.Windows.Forms.Button();
			this.btnUnrelatedFile = new System.Windows.Forms.Button();
			this.btnBadEpisode = new System.Windows.Forms.Button();
			this.btnBadName = new System.Windows.Forms.Button();
			this.btnBadDocu = new System.Windows.Forms.Button();
			this.btnBadMovie = new System.Windows.Forms.Button();
			this.pbMFM = new System.Windows.Forms.PictureBox();
			this.lblSelect = new System.Windows.Forms.Label();
			this.scMaintenance = new System.Windows.Forms.SplitContainer();
			this.lvMaintenance = new System.Windows.Forms.ListView();
			this.chNameMaintenance = new System.Windows.Forms.ColumnHeader("(none)");
			this.rtbMaintenance = new System.Windows.Forms.RichTextBox();
			this.tpLog = new System.Windows.Forms.TabPage();
			this.rtbLog = new System.Windows.Forms.RichTextBox();
			this.tpSettings = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cobSearchDownload = new System.Windows.Forms.ComboBox();
			this.cobSearchInfo = new System.Windows.Forms.ComboBox();
			this.tbNickName = new System.Windows.Forms.TextBox();
			this.lblNickName = new System.Windows.Forms.Label();
			this.gbSupportingPrograms = new System.Windows.Forms.GroupBox();
			this.lblTeraCopyPath = new System.Windows.Forms.Label();
			this.tbMediaInfoPath = new System.Windows.Forms.TextBox();
			this.lblMediaInfoPath = new System.Windows.Forms.Label();
			this.tbTeraCopyPath = new System.Windows.Forms.TextBox();
			this.rtbSettings = new System.Windows.Forms.RichTextBox();
			this.gbSettingsNameUnification = new System.Windows.Forms.GroupBox();
			this.lblBadMovieNameRegex = new System.Windows.Forms.Label();
			this.tbBadMovieNameRegex = new System.Windows.Forms.TextBox();
			this.lblGoodMovieNameRegex = new System.Windows.Forms.Label();
			this.tbGoodMovieNameRegex = new System.Windows.Forms.TextBox();
			this.lblBadEpisodeNameRegex = new System.Windows.Forms.Label();
			this.tbBadEpisodeNameRegex = new System.Windows.Forms.TextBox();
			this.lblGoodEpisodeNameRegex = new System.Windows.Forms.Label();
			this.tbGoodEpisodeNameRegex = new System.Windows.Forms.TextBox();
			this.lblBadDocuNameRegex = new System.Windows.Forms.Label();
			this.tbBadDocuNameRegex = new System.Windows.Forms.TextBox();
			this.lblGoodDocuNameRegex = new System.Windows.Forms.Label();
			this.tbGoodDocuNameRegex = new System.Windows.Forms.TextBox();
			this.lblToLowerRegex = new System.Windows.Forms.Label();
			this.tbToLowerRegex = new System.Windows.Forms.TextBox();
			this.lblOnlyCharacters = new System.Windows.Forms.Label();
			this.tbOnlyCharactersRegex = new System.Windows.Forms.TextBox();
			this.lblEpisodesId = new System.Windows.Forms.Label();
			this.tbEpisodesIdRegex = new System.Windows.Forms.TextBox();
			this.lblCutNameBeforeRegex = new System.Windows.Forms.Label();
			this.tbCutNameBeforeRegex = new System.Windows.Forms.TextBox();
			this.gbSettingsConsideredFiles = new System.Windows.Forms.GroupBox();
			this.lblAddonExtensions = new System.Windows.Forms.Label();
			this.tbAddonExtensionsRegex = new System.Windows.Forms.TextBox();
			this.lblMainExtensions = new System.Windows.Forms.Label();
			this.tbMainExtensionsRegex = new System.Windows.Forms.TextBox();
			this.tpHelp = new System.Windows.Forms.TabPage();
			this.rtbHelp = new System.Windows.Forms.RichTextBox();
			this.tpAbout = new System.Windows.Forms.TabPage();
			this.lblLastChecked = new System.Windows.Forms.Label();
			this.cobCheckForUpdates = new System.Windows.Forms.ComboBox();
			this.btnCheckNow = new System.Windows.Forms.Button();
			this.pbAboutBanner = new System.Windows.Forms.PictureBox();
			this.lblCopyLeft = new System.Windows.Forms.Label();
			this.rtbCopyright = new System.Windows.Forms.RichTextBox();
			this.lblVersion = new System.Windows.Forms.Label();
			this.llMovieFileMergerOrg = new System.Windows.Forms.LinkLabel();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.ssMFM = new System.Windows.Forms.StatusStrip();
			this.tsslMFM = new System.Windows.Forms.ToolStripStatusLabel();
			this.tspbMFM = new System.Windows.Forms.ToolStripProgressBar();
			this.ttMovieFileMerger = new System.Windows.Forms.ToolTip(this.components);
			this.tcMovieFileMerger.SuspendLayout();
			this.tpSeparateLists.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFolders)).BeginInit();
			this.scFolders.Panel1.SuspendLayout();
			this.scFolders.Panel2.SuspendLayout();
			this.scFolders.SuspendLayout();
			this.gbTypeSelection.SuspendLayout();
			this.gbProcessImport.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scVertical)).BeginInit();
			this.scVertical.Panel1.SuspendLayout();
			this.scVertical.Panel2.SuspendLayout();
			this.scVertical.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scVerticalRight)).BeginInit();
			this.scVerticalRight.Panel1.SuspendLayout();
			this.scVerticalRight.Panel2.SuspendLayout();
			this.scVerticalRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scHorizontal)).BeginInit();
			this.scHorizontal.Panel1.SuspendLayout();
			this.scHorizontal.Panel2.SuspendLayout();
			this.scHorizontal.SuspendLayout();
			this.tpMaintenance.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbMFM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scMaintenance)).BeginInit();
			this.scMaintenance.Panel1.SuspendLayout();
			this.scMaintenance.Panel2.SuspendLayout();
			this.scMaintenance.SuspendLayout();
			this.tpLog.SuspendLayout();
			this.tpSettings.SuspendLayout();
			this.gbSupportingPrograms.SuspendLayout();
			this.gbSettingsNameUnification.SuspendLayout();
			this.gbSettingsConsideredFiles.SuspendLayout();
			this.tpHelp.SuspendLayout();
			this.tpAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAboutBanner)).BeginInit();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.ssMFM.SuspendLayout();
			this.SuspendLayout();
			// 
			// fbdMovieFileMerger
			// 
			this.fbdMovieFileMerger.ShowNewFolderButton = false;
			// 
			// ilMovieFileMerger
			// 
			this.ilMovieFileMerger.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMovieFileMerger.ImageStream")));
			this.ilMovieFileMerger.TransparentColor = System.Drawing.Color.Transparent;
			this.ilMovieFileMerger.Images.SetKeyName(0, "Color.gif");
			this.ilMovieFileMerger.Images.SetKeyName(1, "Copy.gif");
			this.ilMovieFileMerger.Images.SetKeyName(2, "Erase.gif");
			this.ilMovieFileMerger.Images.SetKeyName(3, "Folder.gif");
			this.ilMovieFileMerger.Images.SetKeyName(4, "Log.gif");
			this.ilMovieFileMerger.Images.SetKeyName(5, "Move.gif");
			this.ilMovieFileMerger.Images.SetKeyName(6, "Save.gif");
			this.ilMovieFileMerger.Images.SetKeyName(7, "Settings.gif");
			this.ilMovieFileMerger.Images.SetKeyName(8, "About.gif");
			this.ilMovieFileMerger.Images.SetKeyName(9, "Documentaries.gif");
			this.ilMovieFileMerger.Images.SetKeyName(10, "Help.gif");
			this.ilMovieFileMerger.Images.SetKeyName(11, "Series.gif");
			this.ilMovieFileMerger.Images.SetKeyName(12, "Clips.gif");
			this.ilMovieFileMerger.Images.SetKeyName(13, "MediaInfo.gif");
			this.ilMovieFileMerger.Images.SetKeyName(14, "List.gif");
			this.ilMovieFileMerger.Images.SetKeyName(15, "Adult.gif");
			this.ilMovieFileMerger.Images.SetKeyName(16, "Miscellaneaous.gif");
			this.ilMovieFileMerger.Images.SetKeyName(17, "Movie.gif");
			this.ilMovieFileMerger.Images.SetKeyName(18, "Play.gif");
			this.ilMovieFileMerger.Images.SetKeyName(19, "Garbage.gif");
			this.ilMovieFileMerger.Images.SetKeyName(20, "Process.gif");
			this.ilMovieFileMerger.Images.SetKeyName(21, "Select.gif");
			this.ilMovieFileMerger.Images.SetKeyName(22, "Wish.png");
			this.ilMovieFileMerger.Images.SetKeyName(23, "Start.gif");
			this.ilMovieFileMerger.Images.SetKeyName(24, "Download.png");
			// 
			// tmrUpdateCounters
			// 
			this.tmrUpdateCounters.Enabled = true;
			this.tmrUpdateCounters.Interval = 500;
			this.tmrUpdateCounters.Tick += new System.EventHandler(this.TmrUpdateCountersTick);
			// 
			// sfdMovieFileMerger
			// 
			this.sfdMovieFileMerger.DefaultExt = "csv";
			this.sfdMovieFileMerger.Filter = "Comma Searated Value files|*.csv";
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// ContentPanel
			// 
			this.ContentPanel.AutoScroll = true;
			this.ContentPanel.Size = new System.Drawing.Size(997, 587);
			// 
			// tcMovieFileMerger
			// 
			this.tcMovieFileMerger.Controls.Add(this.tpSeparateLists);
			this.tcMovieFileMerger.Controls.Add(this.tpMaintenance);
			this.tcMovieFileMerger.Controls.Add(this.tpLog);
			this.tcMovieFileMerger.Controls.Add(this.tpSettings);
			this.tcMovieFileMerger.Controls.Add(this.tpHelp);
			this.tcMovieFileMerger.Controls.Add(this.tpAbout);
			this.tcMovieFileMerger.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcMovieFileMerger.ImageList = this.ilMovieFileMerger;
			this.tcMovieFileMerger.Location = new System.Drawing.Point(0, 0);
			this.tcMovieFileMerger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tcMovieFileMerger.Name = "tcMovieFileMerger";
			this.tcMovieFileMerger.Padding = new System.Drawing.Point(9, 6);
			this.tcMovieFileMerger.SelectedIndex = 0;
			this.tcMovieFileMerger.Size = new System.Drawing.Size(928, 608);
			this.tcMovieFileMerger.TabIndex = 0;
			// 
			// tpSeparateLists
			// 
			this.tpSeparateLists.BackColor = System.Drawing.SystemColors.Control;
			this.tpSeparateLists.Controls.Add(this.label3);
			this.tpSeparateLists.Controls.Add(this.btnHigherRes);
			this.tpSeparateLists.Controls.Add(this.btnLowRes);
			this.tpSeparateLists.Controls.Add(this.btnToConsider);
			this.tpSeparateLists.Controls.Add(this.btnWish);
			this.tpSeparateLists.Controls.Add(this.btnExisting);
			this.tpSeparateLists.Controls.Add(this.btnGarbage);
			this.tpSeparateLists.Controls.Add(this.cobMinimumResolution);
			this.tpSeparateLists.Controls.Add(this.btnJustScanIt);
			this.tpSeparateLists.Controls.Add(this.btnJustRipIt);
			this.tpSeparateLists.Controls.Add(this.cobCriteria);
			this.tpSeparateLists.Controls.Add(this.btnAddToWish);
			this.tpSeparateLists.Controls.Add(this.btnBin);
			this.tpSeparateLists.Controls.Add(this.btnSelect);
			this.tpSeparateLists.Controls.Add(this.cobToolTipRegex);
			this.tpSeparateLists.Controls.Add(this.tbToolTipRegex);
			this.tpSeparateLists.Controls.Add(this.cbMediaInfo);
			this.tpSeparateLists.Controls.Add(this.lblTargetFolder);
			this.tpSeparateLists.Controls.Add(this.lblImportFolder);
			this.tpSeparateLists.Controls.Add(this.btnExportList);
			this.tpSeparateLists.Controls.Add(this.btnEraseColor);
			this.tpSeparateLists.Controls.Add(this.btnSearchDownload);
			this.tpSeparateLists.Controls.Add(this.btnMediaInfo);
			this.tpSeparateLists.Controls.Add(this.btnEraseSelected);
			this.tpSeparateLists.Controls.Add(this.scFolders);
			this.tpSeparateLists.Controls.Add(this.btnSearchInfo);
			this.tpSeparateLists.Controls.Add(this.gbTypeSelection);
			this.tpSeparateLists.Controls.Add(this.gbProcessImport);
			this.tpSeparateLists.Controls.Add(this.btnPlay);
			this.tpSeparateLists.Controls.Add(this.scVertical);
			this.tpSeparateLists.ImageKey = "List.gif";
			this.tpSeparateLists.Location = new System.Drawing.Point(4, 35);
			this.tpSeparateLists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSeparateLists.Name = "tpSeparateLists";
			this.tpSeparateLists.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSeparateLists.Size = new System.Drawing.Size(920, 569);
			this.tpSeparateLists.TabIndex = 0;
			this.tpSeparateLists.Text = "Lists";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoEllipsis = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 536);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 23);
			this.label3.TabIndex = 56;
			this.label3.Text = "Select";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnHigherRes
			// 
			this.btnHigherRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHigherRes.Location = new System.Drawing.Point(646, 532);
			this.btnHigherRes.Name = "btnHigherRes";
			this.btnHigherRes.Size = new System.Drawing.Size(120, 32);
			this.btnHigherRes.TabIndex = 50;
			this.btnHigherRes.Text = "Higher Res";
			this.btnHigherRes.UseVisualStyleBackColor = true;
			this.btnHigherRes.Click += new System.EventHandler(this.BtnHigherResClick);
			// 
			// btnLowRes
			// 
			this.btnLowRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLowRes.Location = new System.Drawing.Point(782, 532);
			this.btnLowRes.Name = "btnLowRes";
			this.btnLowRes.Size = new System.Drawing.Size(120, 32);
			this.btnLowRes.TabIndex = 51;
			this.btnLowRes.Text = "Low Res";
			this.btnLowRes.UseVisualStyleBackColor = true;
			this.btnLowRes.Click += new System.EventHandler(this.BtnLowResClick);
			// 
			// btnToConsider
			// 
			this.btnToConsider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnToConsider.Location = new System.Drawing.Point(510, 532);
			this.btnToConsider.Name = "btnToConsider";
			this.btnToConsider.Size = new System.Drawing.Size(120, 32);
			this.btnToConsider.TabIndex = 52;
			this.btnToConsider.Text = "To Consider";
			this.btnToConsider.UseVisualStyleBackColor = true;
			this.btnToConsider.Click += new System.EventHandler(this.BtnToConsiderClick);
			// 
			// btnWish
			// 
			this.btnWish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnWish.Location = new System.Drawing.Point(238, 532);
			this.btnWish.Name = "btnWish";
			this.btnWish.Size = new System.Drawing.Size(120, 32);
			this.btnWish.TabIndex = 53;
			this.btnWish.Text = "Wish";
			this.btnWish.UseVisualStyleBackColor = true;
			this.btnWish.Click += new System.EventHandler(this.BtnWishClick);
			// 
			// btnExisting
			// 
			this.btnExisting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExisting.Location = new System.Drawing.Point(102, 532);
			this.btnExisting.Name = "btnExisting";
			this.btnExisting.Size = new System.Drawing.Size(120, 32);
			this.btnExisting.TabIndex = 54;
			this.btnExisting.Text = "Existing";
			this.btnExisting.UseVisualStyleBackColor = true;
			this.btnExisting.Click += new System.EventHandler(this.BtnExistingClick);
			// 
			// btnGarbage
			// 
			this.btnGarbage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGarbage.Location = new System.Drawing.Point(374, 532);
			this.btnGarbage.Name = "btnGarbage";
			this.btnGarbage.Size = new System.Drawing.Size(120, 32);
			this.btnGarbage.TabIndex = 55;
			this.btnGarbage.Text = "Garbage";
			this.btnGarbage.UseVisualStyleBackColor = true;
			this.btnGarbage.Click += new System.EventHandler(this.BtnGarbageClick);
			// 
			// cobMinimumResolution
			// 
			this.cobMinimumResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cobMinimumResolution.BackColor = System.Drawing.SystemColors.Control;
			this.cobMinimumResolution.FormattingEnabled = true;
			this.cobMinimumResolution.Items.AddRange(new object[] {
			"Minimum 360p (nHD)",
			"Minimum 540p (qHD)",
			"Minimum 720p (HD)",
			"Minimum 900p (HD+)",
			"Minimum 1080p (Full HD)",
			"Minimum 1440p (WQHD)",
			"Minimum 2160p (4K UHD)",
			"Minimum 2880p (UHD+)",
			"Minimum 4320p (8K FUHD)",
			"Minimum 8640p (16k QUHD)"});
			this.cobMinimumResolution.Location = new System.Drawing.Point(697, 166);
			this.cobMinimumResolution.Name = "cobMinimumResolution";
			this.cobMinimumResolution.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cobMinimumResolution.Size = new System.Drawing.Size(210, 28);
			this.cobMinimumResolution.TabIndex = 28;
			this.cobMinimumResolution.Text = "Minimum 720p";
			// 
			// btnJustScanIt
			// 
			this.btnJustScanIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnJustScanIt.ImageKey = "Process.gif";
			this.btnJustScanIt.ImageList = this.ilMovieFileMerger;
			this.btnJustScanIt.Location = new System.Drawing.Point(8, 486);
			this.btnJustScanIt.Name = "btnJustScanIt";
			this.btnJustScanIt.Size = new System.Drawing.Size(142, 40);
			this.btnJustScanIt.TabIndex = 48;
			this.btnJustScanIt.Text = "Just Scan It";
			this.btnJustScanIt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnJustScanIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnJustScanIt, "Just scan the existing stuff and update the Existing list.");
			this.btnJustScanIt.UseVisualStyleBackColor = false;
			this.btnJustScanIt.Click += new System.EventHandler(this.BtnJustScanItClick);
			// 
			// btnJustRipIt
			// 
			this.btnJustRipIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnJustRipIt.ImageKey = "Process.gif";
			this.btnJustRipIt.ImageList = this.ilMovieFileMerger;
			this.btnJustRipIt.Location = new System.Drawing.Point(789, 486);
			this.btnJustRipIt.Name = "btnJustRipIt";
			this.btnJustRipIt.Size = new System.Drawing.Size(122, 40);
			this.btnJustRipIt.TabIndex = 47;
			this.btnJustRipIt.Text = "Just Rip It";
			this.btnJustRipIt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnJustRipIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnJustRipIt, "Just rip the stuff you don\'t have from the Import folder and put it in the Target" +
		" folder.");
			this.btnJustRipIt.UseVisualStyleBackColor = false;
			this.btnJustRipIt.Click += new System.EventHandler(this.BtnJustRipItClick);
			// 
			// cobCriteria
			// 
			this.cobCriteria.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.cobCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cobCriteria.BackColor = System.Drawing.SystemColors.Control;
			this.cobCriteria.FormattingEnabled = true;
			this.cobCriteria.Items.AddRange(new object[] {
			"Square Format",
			"Wide Screen",
			"Cinema Scope",
			"699 or narrower",
			"700 or wider",
			"1000 or wider",
			"2 Channels",
			"6 Channels",
			"Series with \"SxxExx\"",
			"Movies with \"(Year)\""});
			this.cobCriteria.Location = new System.Drawing.Point(528, 493);
			this.cobCriteria.Name = "cobCriteria";
			this.cobCriteria.Size = new System.Drawing.Size(194, 28);
			this.cobCriteria.TabIndex = 46;
			this.cobCriteria.Text = "Select the Criteria...";
			this.ttMovieFileMerger.SetToolTip(this.cobCriteria, "Select a predefined Tool Tip Regex,\r\nfor the Select, Bin, or Wish actions.");
			// 
			// btnAddToWish
			// 
			this.btnAddToWish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddToWish.ImageKey = "Wish.png";
			this.btnAddToWish.ImageList = this.ilMovieFileMerger;
			this.btnAddToWish.Location = new System.Drawing.Point(387, 485);
			this.btnAddToWish.Name = "btnAddToWish";
			this.btnAddToWish.Size = new System.Drawing.Size(135, 40);
			this.btnAddToWish.TabIndex = 45;
			this.btnAddToWish.Text = "Add to Wish";
			this.btnAddToWish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddToWish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnAddToWish, "Wish all items in the Import list according to the selection criteria.");
			this.btnAddToWish.UseVisualStyleBackColor = false;
			this.btnAddToWish.Click += new System.EventHandler(this.BtnAddToWishClick);
			// 
			// btnBin
			// 
			this.btnBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBin.ImageKey = "Garbage.gif";
			this.btnBin.ImageList = this.ilMovieFileMerger;
			this.btnBin.Location = new System.Drawing.Point(291, 486);
			this.btnBin.Name = "btnBin";
			this.btnBin.Size = new System.Drawing.Size(90, 40);
			this.btnBin.TabIndex = 44;
			this.btnBin.Text = "Bin";
			this.btnBin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnBin, "Put all items in all lists in the Garbage list according to the selection ctriter" +
		"ia.");
			this.btnBin.UseVisualStyleBackColor = false;
			this.btnBin.Click += new System.EventHandler(this.BtnBinClick);
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSelect.ImageKey = "Select.gif";
			this.btnSelect.ImageList = this.ilMovieFileMerger;
			this.btnSelect.Location = new System.Drawing.Point(187, 486);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(98, 40);
			this.btnSelect.TabIndex = 42;
			this.btnSelect.Text = "Select";
			this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnSelect, "Select all items in all lists according to the selection criteria.\r\nYou have to h" +
		"oover with the mouse of the list to see the selected items.");
			this.btnSelect.UseVisualStyleBackColor = false;
			this.btnSelect.Click += new System.EventHandler(this.BtnSelectClick);
			// 
			// cobToolTipRegex
			// 
			this.cobToolTipRegex.BackColor = System.Drawing.SystemColors.Control;
			this.cobToolTipRegex.FormattingEnabled = true;
			this.cobToolTipRegex.Items.AddRange(new object[] {
			"Square Format",
			"Wide Screen",
			"Cinema Scope",
			"Low Resolution",
			"Medium Resolution",
			"High Resolution",
			"2 Channels",
			"6 Channels",
			"Folder Name",
			"After 2009"});
			this.cobToolTipRegex.Location = new System.Drawing.Point(12, 166);
			this.cobToolTipRegex.Name = "cobToolTipRegex";
			this.cobToolTipRegex.Size = new System.Drawing.Size(210, 28);
			this.cobToolTipRegex.TabIndex = 41;
			this.cobToolTipRegex.Text = "Select Tool Tip Regex...";
			this.ttMovieFileMerger.SetToolTip(this.cobToolTipRegex, "Select a predefined Tool Tip Regex, \r\nwhich you can fine tune if needed.");
			this.cobToolTipRegex.SelectedIndexChanged += new System.EventHandler(this.CobToolTipRegexSelectedIndexChanged);
			// 
			// tbToolTipRegex
			// 
			this.tbToolTipRegex.AllowDrop = true;
			this.tbToolTipRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbToolTipRegex.Location = new System.Drawing.Point(236, 166);
			this.tbToolTipRegex.Name = "tbToolTipRegex";
			this.tbToolTipRegex.Size = new System.Drawing.Size(449, 26);
			this.tbToolTipRegex.TabIndex = 36;
			this.tbToolTipRegex.Text = "Enter a regular expression...";
			this.ttMovieFileMerger.SetToolTip(this.tbToolTipRegex, "Enter a regular expression to select lists items accordingly\r\nwhen they are dropp" +
		"ed here.");
			this.tbToolTipRegex.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbToolTipRegexDragDrop);
			this.tbToolTipRegex.DragOver += new System.Windows.Forms.DragEventHandler(this.TbToolTipRegexDragOver);
			// 
			// cbMediaInfo
			// 
			this.cbMediaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbMediaInfo.Location = new System.Drawing.Point(879, 241);
			this.cbMediaInfo.Name = "cbMediaInfo";
			this.cbMediaInfo.Size = new System.Drawing.Size(23, 25);
			this.cbMediaInfo.TabIndex = 37;
			this.cbMediaInfo.Text = "All Media Info";
			this.cbMediaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ttMovieFileMerger.SetToolTip(this.cbMediaInfo, "Check to get detailed media information (slows down the fetching).");
			this.cbMediaInfo.UseVisualStyleBackColor = true;
			// 
			// lblTargetFolder
			// 
			this.lblTargetFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTargetFolder.ImageKey = "Folder.gif";
			this.lblTargetFolder.ImageList = this.ilMovieFileMerger;
			this.lblTargetFolder.Location = new System.Drawing.Point(12, 17);
			this.lblTargetFolder.Name = "lblTargetFolder";
			this.lblTargetFolder.Size = new System.Drawing.Size(88, 23);
			this.lblTargetFolder.TabIndex = 36;
			this.lblTargetFolder.Text = "Target";
			this.lblTargetFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ttMovieFileMerger.SetToolTip(this.lblTargetFolder, "Drop a folder to where the movies should be copied or \r\nmoved in the field to the" +
		" right.");
			// 
			// lblImportFolder
			// 
			this.lblImportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblImportFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblImportFolder.ImageKey = "Folder.gif";
			this.lblImportFolder.ImageList = this.ilMovieFileMerger;
			this.lblImportFolder.Location = new System.Drawing.Point(817, 17);
			this.lblImportFolder.Name = "lblImportFolder";
			this.lblImportFolder.Size = new System.Drawing.Size(90, 23);
			this.lblImportFolder.TabIndex = 35;
			this.lblImportFolder.Text = "Import";
			this.lblImportFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ttMovieFileMerger.SetToolTip(this.lblImportFolder, "Drop a folder with movies to process in the field to the left.  \r\nAutomatically s" +
		"et when files or folders are dropped in the Import list.");
			// 
			// btnExportList
			// 
			this.btnExportList.AllowDrop = true;
			this.btnExportList.BackColor = System.Drawing.SystemColors.Control;
			this.btnExportList.ImageKey = "Save.gif";
			this.btnExportList.ImageList = this.ilMovieFileMerger;
			this.btnExportList.Location = new System.Drawing.Point(18, 204);
			this.btnExportList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExportList.Name = "btnExportList";
			this.btnExportList.Size = new System.Drawing.Size(103, 66);
			this.btnExportList.TabIndex = 34;
			this.btnExportList.Text = "Export List...";
			this.btnExportList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExportList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnExportList, "Drop an item of a list here to export the complete list as .CSV file.");
			this.btnExportList.UseVisualStyleBackColor = false;
			this.btnExportList.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnExportListDragDrop);
			this.btnExportList.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// btnEraseColor
			// 
			this.btnEraseColor.AllowDrop = true;
			this.btnEraseColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEraseColor.ImageKey = "Color.gif";
			this.btnEraseColor.ImageList = this.ilMovieFileMerger;
			this.btnEraseColor.Location = new System.Drawing.Point(421, 204);
			this.btnEraseColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEraseColor.Name = "btnEraseColor";
			this.btnEraseColor.Size = new System.Drawing.Size(94, 66);
			this.btnEraseColor.TabIndex = 28;
			this.btnEraseColor.Text = "Erase Color";
			this.btnEraseColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEraseColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnEraseColor, "Drop an item with a color here to erase all items of the same color from a list.");
			this.btnEraseColor.UseVisualStyleBackColor = false;
			this.btnEraseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnEraseColorDragDrop);
			this.btnEraseColor.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// btnSearchDownload
			// 
			this.btnSearchDownload.AllowDrop = true;
			this.btnSearchDownload.ImageKey = "Download.png";
			this.btnSearchDownload.ImageList = this.ilMovieFileMerger;
			this.btnSearchDownload.Location = new System.Drawing.Point(131, 204);
			this.btnSearchDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearchDownload.Name = "btnSearchDownload";
			this.btnSearchDownload.Size = new System.Drawing.Size(154, 66);
			this.btnSearchDownload.TabIndex = 33;
			this.btnSearchDownload.Text = "Torrent Hound";
			this.btnSearchDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearchDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnSearchDownload, "Drop items here to download them from the internet.");
			this.btnSearchDownload.UseVisualStyleBackColor = false;
			this.btnSearchDownload.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchDownloadDragDrop);
			this.btnSearchDownload.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// btnMediaInfo
			// 
			this.btnMediaInfo.AllowDrop = true;
			this.btnMediaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMediaInfo.ImageKey = "MediaInfo.gif";
			this.btnMediaInfo.ImageList = this.ilMovieFileMerger;
			this.btnMediaInfo.Location = new System.Drawing.Point(806, 204);
			this.btnMediaInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnMediaInfo.Name = "btnMediaInfo";
			this.btnMediaInfo.Size = new System.Drawing.Size(101, 66);
			this.btnMediaInfo.TabIndex = 14;
			this.btnMediaInfo.Text = "Media Info";
			this.btnMediaInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnMediaInfo, "Drop items here to show the details with Media Info.");
			this.btnMediaInfo.UseVisualStyleBackColor = false;
			this.btnMediaInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnMediaInfoDragDrop);
			this.btnMediaInfo.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// btnEraseSelected
			// 
			this.btnEraseSelected.AllowDrop = true;
			this.btnEraseSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEraseSelected.ImageKey = "Erase.gif";
			this.btnEraseSelected.ImageList = this.ilMovieFileMerger;
			this.btnEraseSelected.Location = new System.Drawing.Point(291, 204);
			this.btnEraseSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEraseSelected.Name = "btnEraseSelected";
			this.btnEraseSelected.Size = new System.Drawing.Size(120, 66);
			this.btnEraseSelected.TabIndex = 27;
			this.btnEraseSelected.Text = "Erase Selected";
			this.btnEraseSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEraseSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnEraseSelected, "Drop items here to erase them from a list.");
			this.btnEraseSelected.UseVisualStyleBackColor = false;
			this.btnEraseSelected.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnEraseSelectedDragDrop);
			this.btnEraseSelected.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// scFolders
			// 
			this.scFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.scFolders.BackColor = System.Drawing.SystemColors.Control;
			this.scFolders.Location = new System.Drawing.Point(121, 11);
			this.scFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.scFolders.Name = "scFolders";
			// 
			// scFolders.Panel1
			// 
			this.scFolders.Panel1.Controls.Add(this.tbTargetFolder);
			// 
			// scFolders.Panel2
			// 
			this.scFolders.Panel2.Controls.Add(this.tbImportFolder);
			this.scFolders.Size = new System.Drawing.Size(676, 34);
			this.scFolders.SplitterDistance = 333;
			this.scFolders.SplitterWidth = 6;
			this.scFolders.TabIndex = 25;
			// 
			// tbTargetFolder
			// 
			this.tbTargetFolder.AllowDrop = true;
			this.tbTargetFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbTargetFolder.Location = new System.Drawing.Point(0, 8);
			this.tbTargetFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbTargetFolder.Name = "tbTargetFolder";
			this.tbTargetFolder.ReadOnly = true;
			this.tbTargetFolder.Size = new System.Drawing.Size(333, 26);
			this.tbTargetFolder.TabIndex = 5;
			this.ttMovieFileMerger.SetToolTip(this.tbTargetFolder, "Drop a folder here to where the movies should be copied or moved.");
			this.tbTargetFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbTargetFolderDragDrop);
			this.tbTargetFolder.DragOver += new System.Windows.Forms.DragEventHandler(this.TbDragOver);
			// 
			// tbImportFolder
			// 
			this.tbImportFolder.AllowDrop = true;
			this.tbImportFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbImportFolder.Location = new System.Drawing.Point(0, 8);
			this.tbImportFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbImportFolder.Name = "tbImportFolder";
			this.tbImportFolder.ReadOnly = true;
			this.tbImportFolder.Size = new System.Drawing.Size(337, 26);
			this.tbImportFolder.TabIndex = 25;
			this.ttMovieFileMerger.SetToolTip(this.tbImportFolder, "Drop a folder with movies to process here.  \r\nAutomatically set when files or fol" +
		"ders are dropped in the Import list.");
			this.tbImportFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbImportFolderDragDrop);
			this.tbImportFolder.DragOver += new System.Windows.Forms.DragEventHandler(this.TbDragOver);
			// 
			// btnSearchInfo
			// 
			this.btnSearchInfo.AllowDrop = true;
			this.btnSearchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearchInfo.ImageKey = "About.gif";
			this.btnSearchInfo.ImageList = this.ilMovieFileMerger;
			this.btnSearchInfo.Location = new System.Drawing.Point(533, 204);
			this.btnSearchInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearchInfo.Name = "btnSearchInfo";
			this.btnSearchInfo.Size = new System.Drawing.Size(152, 66);
			this.btnSearchInfo.TabIndex = 32;
			this.btnSearchInfo.Text = "Adult DVD Empire";
			this.btnSearchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearchInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnSearchInfo, "Drop items here to search for them on the internet.");
			this.btnSearchInfo.UseVisualStyleBackColor = false;
			this.btnSearchInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnSearchInfoDragDrop);
			this.btnSearchInfo.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// gbTypeSelection
			// 
			this.gbTypeSelection.Controls.Add(this.rbMiscellaneous);
			this.gbTypeSelection.Controls.Add(this.rbAdults);
			this.gbTypeSelection.Controls.Add(this.rbClips);
			this.gbTypeSelection.Controls.Add(this.rbSeries);
			this.gbTypeSelection.Controls.Add(this.rbDocumentaries);
			this.gbTypeSelection.Controls.Add(this.rbMovies);
			this.gbTypeSelection.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbTypeSelection.Location = new System.Drawing.Point(12, 58);
			this.gbTypeSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbTypeSelection.Name = "gbTypeSelection";
			this.gbTypeSelection.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbTypeSelection.Size = new System.Drawing.Size(447, 100);
			this.gbTypeSelection.TabIndex = 23;
			this.gbTypeSelection.TabStop = false;
			this.gbTypeSelection.Text = "Collections";
			// 
			// rbMiscellaneous
			// 
			this.rbMiscellaneous.Checked = true;
			this.rbMiscellaneous.ImageKey = "Miscellaneaous.gif";
			this.rbMiscellaneous.ImageList = this.ilMovieFileMerger;
			this.rbMiscellaneous.Location = new System.Drawing.Point(146, 59);
			this.rbMiscellaneous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbMiscellaneous.Name = "rbMiscellaneous";
			this.rbMiscellaneous.Size = new System.Drawing.Size(174, 37);
			this.rbMiscellaneous.TabIndex = 6;
			this.rbMiscellaneous.TabStop = true;
			this.rbMiscellaneous.Tag = "Miscellaneous";
			this.rbMiscellaneous.Text = "Miscellaneous";
			this.rbMiscellaneous.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbMiscellaneous, "Use this collection for any video of any kind as temporarily collection \r\nto clea" +
		"n up your collections.");
			this.rbMiscellaneous.UseVisualStyleBackColor = true;
			this.rbMiscellaneous.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
			// 
			// rbAdults
			// 
			this.rbAdults.ImageKey = "Adult.gif";
			this.rbAdults.ImageList = this.ilMovieFileMerger;
			this.rbAdults.Location = new System.Drawing.Point(18, 59);
			this.rbAdults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbAdults.Name = "rbAdults";
			this.rbAdults.Size = new System.Drawing.Size(120, 37);
			this.rbAdults.TabIndex = 4;
			this.rbAdults.Tag = "Adults";
			this.rbAdults.Text = "Adults";
			this.rbAdults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbAdults, "An Adult video is telling a fictive story by the use of special actors, \r\nwhich s" +
		"hould not be watched by persons under 18 years.");
			this.rbAdults.UseVisualStyleBackColor = true;
			this.rbAdults.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
			// 
			// rbClips
			// 
			this.rbClips.ImageKey = "Clips.gif";
			this.rbClips.ImageList = this.ilMovieFileMerger;
			this.rbClips.Location = new System.Drawing.Point(328, 59);
			this.rbClips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbClips.Name = "rbClips";
			this.rbClips.Size = new System.Drawing.Size(99, 37);
			this.rbClips.TabIndex = 3;
			this.rbClips.Tag = "Clips";
			this.rbClips.Text = "Clips";
			this.rbClips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbClips, "A clip is a short video telling the story of a song by using dancers.");
			this.rbClips.UseVisualStyleBackColor = true;
			this.rbClips.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
			// 
			// rbSeries
			// 
			this.rbSeries.ImageKey = "Series.gif";
			this.rbSeries.ImageList = this.ilMovieFileMerger;
			this.rbSeries.Location = new System.Drawing.Point(328, 23);
			this.rbSeries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbSeries.Name = "rbSeries";
			this.rbSeries.Size = new System.Drawing.Size(113, 37);
			this.rbSeries.TabIndex = 2;
			this.rbSeries.Tag = "Series";
			this.rbSeries.Text = "Series";
			this.rbSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbSeries, "Series are a video collection telling a fictive story in multiple parts or \r\nepis" +
		"odes by the use of actors.");
			this.rbSeries.UseVisualStyleBackColor = true;
			this.rbSeries.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
			// 
			// rbDocumentaries
			// 
			this.rbDocumentaries.ImageKey = "Documentaries.gif";
			this.rbDocumentaries.ImageList = this.ilMovieFileMerger;
			this.rbDocumentaries.Location = new System.Drawing.Point(146, 23);
			this.rbDocumentaries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbDocumentaries.Name = "rbDocumentaries";
			this.rbDocumentaries.Size = new System.Drawing.Size(174, 37);
			this.rbDocumentaries.TabIndex = 1;
			this.rbDocumentaries.Tag = "Documentaries";
			this.rbDocumentaries.Text = "Documentaries";
			this.rbDocumentaries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbDocumentaries, "A documentary is video that is telling a more real story by the use of presenters" +
		" or \r\na movie or a television program that provides a factual record or report.");
			this.rbDocumentaries.UseVisualStyleBackColor = true;
			this.rbDocumentaries.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
			// 
			// rbMovies
			// 
			this.rbMovies.ImageKey = "Movie.gif";
			this.rbMovies.ImageList = this.ilMovieFileMerger;
			this.rbMovies.Location = new System.Drawing.Point(18, 23);
			this.rbMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbMovies.Name = "rbMovies";
			this.rbMovies.Size = new System.Drawing.Size(120, 37);
			this.rbMovies.TabIndex = 0;
			this.rbMovies.Tag = "Movies";
			this.rbMovies.Text = "Movies";
			this.rbMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbMovies, "A movie is a video telling a fictive story by the use of actors or \r\na story or e" +
		"vent recorded by a camera as a set of moving images and \r\nshown in a theatre or " +
		"on television; a motion picture.");
			this.rbMovies.UseVisualStyleBackColor = true;
			this.rbMovies.CheckedChanged += new System.EventHandler(this.RbCollectionsClick);
			// 
			// gbProcessImport
			// 
			this.gbProcessImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbProcessImport.Controls.Add(this.btnStart);
			this.gbProcessImport.Controls.Add(this.cbGetHigherRes);
			this.gbProcessImport.Controls.Add(this.cbKeepFolders);
			this.gbProcessImport.Controls.Add(this.rbMove);
			this.gbProcessImport.Controls.Add(this.rbCopy);
			this.gbProcessImport.Location = new System.Drawing.Point(474, 58);
			this.gbProcessImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbProcessImport.Name = "gbProcessImport";
			this.gbProcessImport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbProcessImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gbProcessImport.Size = new System.Drawing.Size(433, 100);
			this.gbProcessImport.TabIndex = 22;
			this.gbProcessImport.TabStop = false;
			this.gbProcessImport.Text = "Process Import";
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.Control;
			this.btnStart.ImageKey = "Start.gif";
			this.btnStart.ImageList = this.ilMovieFileMerger;
			this.btnStart.Location = new System.Drawing.Point(12, 22);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(118, 71);
			this.btnStart.TabIndex = 27;
			this.btnStart.Text = "Start Process";
			this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnStart, "Click to start the copying or moving of the files, which are marked as Wish in th" +
		"e Import list.");
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.BtnStartProcessClick);
			// 
			// cbGetHigherRes
			// 
			this.cbGetHigherRes.Checked = true;
			this.cbGetHigherRes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbGetHigherRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cbGetHigherRes.ImageKey = "Folder.gif";
			this.cbGetHigherRes.Location = new System.Drawing.Point(261, 64);
			this.cbGetHigherRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbGetHigherRes.Name = "cbGetHigherRes";
			this.cbGetHigherRes.Size = new System.Drawing.Size(157, 29);
			this.cbGetHigherRes.TabIndex = 26;
			this.cbGetHigherRes.Text = "Get Higher Res";
			this.cbGetHigherRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.cbGetHigherRes, "Check to copy higer horizontal resolution files, even if they are existing alread" +
		"y.");
			this.cbGetHigherRes.UseVisualStyleBackColor = true;
			// 
			// cbKeepFolders
			// 
			this.cbKeepFolders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cbKeepFolders.ImageKey = "Folder.gif";
			this.cbKeepFolders.ImageList = this.ilMovieFileMerger;
			this.cbKeepFolders.Location = new System.Drawing.Point(261, 24);
			this.cbKeepFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbKeepFolders.Name = "cbKeepFolders";
			this.cbKeepFolders.Size = new System.Drawing.Size(157, 37);
			this.cbKeepFolders.TabIndex = 26;
			this.cbKeepFolders.Text = "Keep Folders";
			this.cbKeepFolders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.cbKeepFolders, "Check to keep the import files in thier folder structure.");
			this.cbKeepFolders.UseVisualStyleBackColor = true;
			// 
			// rbMove
			// 
			this.rbMove.ImageKey = "Move.gif";
			this.rbMove.ImageList = this.ilMovieFileMerger;
			this.rbMove.Location = new System.Drawing.Point(133, 59);
			this.rbMove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbMove.Name = "rbMove";
			this.rbMove.Size = new System.Drawing.Size(120, 37);
			this.rbMove.TabIndex = 1;
			this.rbMove.Text = "Move";
			this.rbMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbMove, "If Move is checked and the Progress Bar clicked, the Wish colored items \r\nin the " +
		"Import list will be moved to the Target folder.");
			this.rbMove.UseVisualStyleBackColor = true;
			// 
			// rbCopy
			// 
			this.rbCopy.Checked = true;
			this.rbCopy.ImageKey = "Copy.gif";
			this.rbCopy.ImageList = this.ilMovieFileMerger;
			this.rbCopy.Location = new System.Drawing.Point(133, 23);
			this.rbCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbCopy.Name = "rbCopy";
			this.rbCopy.Size = new System.Drawing.Size(120, 37);
			this.rbCopy.TabIndex = 0;
			this.rbCopy.TabStop = true;
			this.rbCopy.Text = "Copy";
			this.rbCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.rbCopy, "If Copy is selected and you click the Progress Bar, the Wish colored items \r\nin t" +
		"he Import list will be copied to the Target folder.");
			this.rbCopy.UseVisualStyleBackColor = true;
			// 
			// btnPlay
			// 
			this.btnPlay.AllowDrop = true;
			this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlay.ImageKey = "Play.gif";
			this.btnPlay.ImageList = this.ilMovieFileMerger;
			this.btnPlay.Location = new System.Drawing.Point(693, 204);
			this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(103, 66);
			this.btnPlay.TabIndex = 31;
			this.btnPlay.Text = "Play Video";
			this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttMovieFileMerger.SetToolTip(this.btnPlay, "Drop an item here to play it with your movie player.");
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnPlayDragDrop);
			this.btnPlay.DragOver += new System.Windows.Forms.DragEventHandler(this.BtnDragOver);
			// 
			// scVertical
			// 
			this.scVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.scVertical.BackColor = System.Drawing.SystemColors.Control;
			this.scVertical.Location = new System.Drawing.Point(8, 280);
			this.scVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.scVertical.Name = "scVertical";
			// 
			// scVertical.Panel1
			// 
			this.scVertical.Panel1.Controls.Add(this.lvExisting);
			// 
			// scVertical.Panel2
			// 
			this.scVertical.Panel2.Controls.Add(this.scVerticalRight);
			this.scVertical.Size = new System.Drawing.Size(903, 198);
			this.scVertical.SplitterDistance = 293;
			this.scVertical.SplitterWidth = 6;
			this.scVertical.TabIndex = 7;
			this.scVertical.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScVerticalSplitterMoved);
			// 
			// lvExisting
			// 
			this.lvExisting.AllowDrop = true;
			this.lvExisting.BackColor = System.Drawing.SystemColors.Window;
			this.lvExisting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chNameExisting});
			this.lvExisting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvExisting.FullRowSelect = true;
			this.lvExisting.GridLines = true;
			this.lvExisting.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvExisting.LabelWrap = false;
			this.lvExisting.Location = new System.Drawing.Point(0, 0);
			this.lvExisting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvExisting.Name = "lvExisting";
			this.lvExisting.ShowItemToolTips = true;
			this.lvExisting.Size = new System.Drawing.Size(293, 198);
			this.lvExisting.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvExisting.TabIndex = 0;
			this.lvExisting.Tag = "Existing";
			this.lvExisting.UseCompatibleStateImageBehavior = false;
			this.lvExisting.View = System.Windows.Forms.View.Details;
			this.lvExisting.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
			this.lvExisting.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
			this.lvExisting.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
			this.lvExisting.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
			this.lvExisting.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
			this.lvExisting.DoubleClick += new System.EventHandler(this.LvDoubleClick);
			this.lvExisting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
			this.lvExisting.MouseEnter += new System.EventHandler(this.LvMouseEnter);
			// 
			// chNameExisting
			// 
			this.chNameExisting.Text = "Existing";
			this.chNameExisting.Width = 250;
			// 
			// scVerticalRight
			// 
			this.scVerticalRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scVerticalRight.Location = new System.Drawing.Point(0, 0);
			this.scVerticalRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.scVerticalRight.Name = "scVerticalRight";
			// 
			// scVerticalRight.Panel1
			// 
			this.scVerticalRight.Panel1.Controls.Add(this.scHorizontal);
			// 
			// scVerticalRight.Panel2
			// 
			this.scVerticalRight.Panel2.Controls.Add(this.lvImport);
			this.scVerticalRight.Size = new System.Drawing.Size(604, 198);
			this.scVerticalRight.SplitterDistance = 304;
			this.scVerticalRight.SplitterWidth = 6;
			this.scVerticalRight.TabIndex = 1;
			this.scVerticalRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScVerticalSplitterMoved);
			// 
			// scHorizontal
			// 
			this.scHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scHorizontal.Location = new System.Drawing.Point(0, 0);
			this.scHorizontal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.scHorizontal.Name = "scHorizontal";
			this.scHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scHorizontal.Panel1
			// 
			this.scHorizontal.Panel1.Controls.Add(this.lvWish);
			// 
			// scHorizontal.Panel2
			// 
			this.scHorizontal.Panel2.Controls.Add(this.lvGarbage);
			this.scHorizontal.Size = new System.Drawing.Size(304, 198);
			this.scHorizontal.SplitterDistance = 99;
			this.scHorizontal.SplitterWidth = 6;
			this.scHorizontal.TabIndex = 0;
			// 
			// lvWish
			// 
			this.lvWish.AllowDrop = true;
			this.lvWish.BackColor = System.Drawing.SystemColors.Window;
			this.lvWish.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1});
			this.lvWish.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvWish.FullRowSelect = true;
			this.lvWish.GridLines = true;
			this.lvWish.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvWish.LabelWrap = false;
			this.lvWish.Location = new System.Drawing.Point(0, 0);
			this.lvWish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvWish.Name = "lvWish";
			this.lvWish.ShowItemToolTips = true;
			this.lvWish.Size = new System.Drawing.Size(304, 99);
			this.lvWish.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvWish.TabIndex = 1;
			this.lvWish.Tag = "Wish";
			this.lvWish.UseCompatibleStateImageBehavior = false;
			this.lvWish.View = System.Windows.Forms.View.Details;
			this.lvWish.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
			this.lvWish.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
			this.lvWish.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
			this.lvWish.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
			this.lvWish.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
			this.lvWish.DoubleClick += new System.EventHandler(this.LvDoubleClick);
			this.lvWish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
			this.lvWish.MouseEnter += new System.EventHandler(this.LvMouseEnter);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Wish";
			this.columnHeader1.Width = 250;
			// 
			// lvGarbage
			// 
			this.lvGarbage.AllowDrop = true;
			this.lvGarbage.BackColor = System.Drawing.SystemColors.Window;
			this.lvGarbage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chNameGarbage});
			this.lvGarbage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvGarbage.FullRowSelect = true;
			this.lvGarbage.GridLines = true;
			this.lvGarbage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvGarbage.LabelWrap = false;
			this.lvGarbage.Location = new System.Drawing.Point(0, 0);
			this.lvGarbage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvGarbage.Name = "lvGarbage";
			this.lvGarbage.ShowItemToolTips = true;
			this.lvGarbage.Size = new System.Drawing.Size(304, 93);
			this.lvGarbage.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvGarbage.TabIndex = 1;
			this.lvGarbage.Tag = "Garbage";
			this.lvGarbage.UseCompatibleStateImageBehavior = false;
			this.lvGarbage.View = System.Windows.Forms.View.Details;
			this.lvGarbage.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
			this.lvGarbage.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
			this.lvGarbage.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
			this.lvGarbage.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
			this.lvGarbage.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
			this.lvGarbage.DoubleClick += new System.EventHandler(this.LvDoubleClick);
			this.lvGarbage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
			this.lvGarbage.MouseEnter += new System.EventHandler(this.LvMouseEnter);
			// 
			// chNameGarbage
			// 
			this.chNameGarbage.Text = "Garbage";
			this.chNameGarbage.Width = 250;
			// 
			// lvImport
			// 
			this.lvImport.AllowDrop = true;
			this.lvImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chNameImport});
			this.lvImport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvImport.FullRowSelect = true;
			this.lvImport.GridLines = true;
			this.lvImport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvImport.LabelWrap = false;
			this.lvImport.Location = new System.Drawing.Point(0, 0);
			this.lvImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvImport.Name = "lvImport";
			this.lvImport.ShowItemToolTips = true;
			this.lvImport.Size = new System.Drawing.Size(294, 198);
			this.lvImport.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvImport.TabIndex = 0;
			this.lvImport.Tag = "Import";
			this.lvImport.TileSize = new System.Drawing.Size(1, 1);
			this.lvImport.UseCompatibleStateImageBehavior = false;
			this.lvImport.View = System.Windows.Forms.View.Details;
			this.lvImport.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvItemDrag);
			this.lvImport.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvItemSelectionChanged);
			this.lvImport.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
			this.lvImport.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
			this.lvImport.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
			this.lvImport.DoubleClick += new System.EventHandler(this.LvDoubleClick);
			this.lvImport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
			this.lvImport.MouseEnter += new System.EventHandler(this.LvMouseEnter);
			// 
			// chNameImport
			// 
			this.chNameImport.Text = "Import";
			this.chNameImport.Width = 250;
			// 
			// tpMaintenance
			// 
			this.tpMaintenance.Controls.Add(this.btnGoodEpisode);
			this.tpMaintenance.Controls.Add(this.btnGoodDocu);
			this.tpMaintenance.Controls.Add(this.btnGoodMovie);
			this.tpMaintenance.Controls.Add(this.btnUnrelatedFile);
			this.tpMaintenance.Controls.Add(this.btnBadEpisode);
			this.tpMaintenance.Controls.Add(this.btnBadName);
			this.tpMaintenance.Controls.Add(this.btnBadDocu);
			this.tpMaintenance.Controls.Add(this.btnBadMovie);
			this.tpMaintenance.Controls.Add(this.pbMFM);
			this.tpMaintenance.Controls.Add(this.lblSelect);
			this.tpMaintenance.Controls.Add(this.scMaintenance);
			this.tpMaintenance.ImageKey = "Process.gif";
			this.tpMaintenance.Location = new System.Drawing.Point(4, 35);
			this.tpMaintenance.Name = "tpMaintenance";
			this.tpMaintenance.Padding = new System.Windows.Forms.Padding(3);
			this.tpMaintenance.Size = new System.Drawing.Size(920, 569);
			this.tpMaintenance.TabIndex = 5;
			this.tpMaintenance.Text = "Maintenance";
			// 
			// btnGoodEpisode
			// 
			this.btnGoodEpisode.Location = new System.Drawing.Point(8, 411);
			this.btnGoodEpisode.Name = "btnGoodEpisode";
			this.btnGoodEpisode.Size = new System.Drawing.Size(128, 32);
			this.btnGoodEpisode.TabIndex = 46;
			this.btnGoodEpisode.Text = "Good Episode";
			this.btnGoodEpisode.UseVisualStyleBackColor = true;
			this.btnGoodEpisode.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnGoodDocu
			// 
			this.btnGoodDocu.Location = new System.Drawing.Point(8, 373);
			this.btnGoodDocu.Name = "btnGoodDocu";
			this.btnGoodDocu.Size = new System.Drawing.Size(128, 32);
			this.btnGoodDocu.TabIndex = 46;
			this.btnGoodDocu.Text = "Good Docu";
			this.btnGoodDocu.UseVisualStyleBackColor = true;
			this.btnGoodDocu.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnGoodMovie
			// 
			this.btnGoodMovie.Location = new System.Drawing.Point(8, 335);
			this.btnGoodMovie.Name = "btnGoodMovie";
			this.btnGoodMovie.Size = new System.Drawing.Size(128, 32);
			this.btnGoodMovie.TabIndex = 46;
			this.btnGoodMovie.Text = "Good Movie";
			this.btnGoodMovie.UseVisualStyleBackColor = true;
			this.btnGoodMovie.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnUnrelatedFile
			// 
			this.btnUnrelatedFile.Location = new System.Drawing.Point(8, 297);
			this.btnUnrelatedFile.Name = "btnUnrelatedFile";
			this.btnUnrelatedFile.Size = new System.Drawing.Size(128, 32);
			this.btnUnrelatedFile.TabIndex = 46;
			this.btnUnrelatedFile.Text = "Unrelated File";
			this.btnUnrelatedFile.UseVisualStyleBackColor = true;
			this.btnUnrelatedFile.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnBadEpisode
			// 
			this.btnBadEpisode.Location = new System.Drawing.Point(8, 221);
			this.btnBadEpisode.Name = "btnBadEpisode";
			this.btnBadEpisode.Size = new System.Drawing.Size(128, 32);
			this.btnBadEpisode.TabIndex = 46;
			this.btnBadEpisode.Text = "Bad Episode";
			this.btnBadEpisode.UseVisualStyleBackColor = true;
			this.btnBadEpisode.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnBadName
			// 
			this.btnBadName.Location = new System.Drawing.Point(8, 259);
			this.btnBadName.Name = "btnBadName";
			this.btnBadName.Size = new System.Drawing.Size(128, 32);
			this.btnBadName.TabIndex = 46;
			this.btnBadName.Text = "Bad Name";
			this.btnBadName.UseVisualStyleBackColor = true;
			this.btnBadName.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnBadDocu
			// 
			this.btnBadDocu.Location = new System.Drawing.Point(8, 183);
			this.btnBadDocu.Name = "btnBadDocu";
			this.btnBadDocu.Size = new System.Drawing.Size(128, 32);
			this.btnBadDocu.TabIndex = 46;
			this.btnBadDocu.Text = "Bad Docu";
			this.btnBadDocu.UseVisualStyleBackColor = true;
			this.btnBadDocu.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// btnBadMovie
			// 
			this.btnBadMovie.Location = new System.Drawing.Point(8, 145);
			this.btnBadMovie.Name = "btnBadMovie";
			this.btnBadMovie.Size = new System.Drawing.Size(128, 32);
			this.btnBadMovie.TabIndex = 46;
			this.btnBadMovie.Text = "Bad Movie";
			this.btnBadMovie.UseVisualStyleBackColor = true;
			this.btnBadMovie.Click += new System.EventHandler(this.BtnSelectMaintenanceClick);
			// 
			// pbMFM
			// 
			this.pbMFM.Image = ((System.Drawing.Image)(resources.GetObject("pbMFM.Image")));
			this.pbMFM.InitialImage = null;
			this.pbMFM.Location = new System.Drawing.Point(22, 7);
			this.pbMFM.Name = "pbMFM";
			this.pbMFM.Size = new System.Drawing.Size(96, 103);
			this.pbMFM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbMFM.TabIndex = 44;
			this.pbMFM.TabStop = false;
			// 
			// lblSelect
			// 
			this.lblSelect.AutoEllipsis = true;
			this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelect.Location = new System.Drawing.Point(9, 119);
			this.lblSelect.Name = "lblSelect";
			this.lblSelect.Size = new System.Drawing.Size(126, 23);
			this.lblSelect.TabIndex = 41;
			this.lblSelect.Text = "Select";
			this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// scMaintenance
			// 
			this.scMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.scMaintenance.Location = new System.Drawing.Point(143, 6);
			this.scMaintenance.Name = "scMaintenance";
			this.scMaintenance.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scMaintenance.Panel1
			// 
			this.scMaintenance.Panel1.Controls.Add(this.lvMaintenance);
			this.scMaintenance.Panel1.Margin = new System.Windows.Forms.Padding(1);
			this.scMaintenance.Panel1.Padding = new System.Windows.Forms.Padding(1);
			this.scMaintenance.Panel1MinSize = 100;
			// 
			// scMaintenance.Panel2
			// 
			this.scMaintenance.Panel2.Controls.Add(this.rtbMaintenance);
			this.scMaintenance.Panel2MinSize = 100;
			this.scMaintenance.Size = new System.Drawing.Size(769, 557);
			this.scMaintenance.SplitterDistance = 334;
			this.scMaintenance.SplitterWidth = 6;
			this.scMaintenance.TabIndex = 39;
			// 
			// lvMaintenance
			// 
			this.lvMaintenance.AllowDrop = true;
			this.lvMaintenance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chNameMaintenance});
			this.lvMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvMaintenance.FullRowSelect = true;
			this.lvMaintenance.GridLines = true;
			this.lvMaintenance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvMaintenance.LabelWrap = false;
			this.lvMaintenance.Location = new System.Drawing.Point(1, 1);
			this.lvMaintenance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lvMaintenance.Name = "lvMaintenance";
			this.lvMaintenance.ShowItemToolTips = true;
			this.lvMaintenance.Size = new System.Drawing.Size(767, 332);
			this.lvMaintenance.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvMaintenance.TabIndex = 38;
			this.lvMaintenance.Tag = "Maintenance";
			this.lvMaintenance.TileSize = new System.Drawing.Size(1, 1);
			this.lvMaintenance.UseCompatibleStateImageBehavior = false;
			this.lvMaintenance.View = System.Windows.Forms.View.Details;
			this.lvMaintenance.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvFileListDrag);
			this.lvMaintenance.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvMaintenanceDragDrop);
			this.lvMaintenance.DragOver += new System.Windows.Forms.DragEventHandler(this.LvDragOver);
			this.lvMaintenance.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LvGiveFeedback);
			this.lvMaintenance.DoubleClick += new System.EventHandler(this.LvDoubleClick);
			this.lvMaintenance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKeyDown);
			this.lvMaintenance.MouseEnter += new System.EventHandler(this.LvMouseEnter);
			this.lvMaintenance.Resize += new System.EventHandler(this.LvMaintenanceResize);
			// 
			// chNameMaintenance
			// 
			this.chNameMaintenance.Text = "Maintenance";
			this.chNameMaintenance.Width = 700;
			// 
			// rtbMaintenance
			// 
			this.rtbMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbMaintenance.Location = new System.Drawing.Point(0, 0);
			this.rtbMaintenance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbMaintenance.Name = "rtbMaintenance";
			this.rtbMaintenance.ReadOnly = true;
			this.rtbMaintenance.Size = new System.Drawing.Size(769, 217);
			this.rtbMaintenance.TabIndex = 37;
			this.rtbMaintenance.Text = "";
			this.rtbMaintenance.WordWrap = false;
			// 
			// tpLog
			// 
			this.tpLog.Controls.Add(this.rtbLog);
			this.tpLog.ImageKey = "Log.gif";
			this.tpLog.Location = new System.Drawing.Point(4, 35);
			this.tpLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpLog.Name = "tpLog";
			this.tpLog.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpLog.Size = new System.Drawing.Size(920, 569);
			this.tpLog.TabIndex = 2;
			this.tpLog.Text = "Log";
			this.tpLog.UseVisualStyleBackColor = true;
			// 
			// rtbLog
			// 
			this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbLog.Location = new System.Drawing.Point(4, 5);
			this.rtbLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.ReadOnly = true;
			this.rtbLog.Size = new System.Drawing.Size(912, 559);
			this.rtbLog.TabIndex = 0;
			this.rtbLog.Text = "";
			this.rtbLog.WordWrap = false;
			this.rtbLog.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
			// 
			// tpSettings
			// 
			this.tpSettings.BackColor = System.Drawing.SystemColors.Control;
			this.tpSettings.Controls.Add(this.label2);
			this.tpSettings.Controls.Add(this.label1);
			this.tpSettings.Controls.Add(this.cobSearchDownload);
			this.tpSettings.Controls.Add(this.cobSearchInfo);
			this.tpSettings.Controls.Add(this.tbNickName);
			this.tpSettings.Controls.Add(this.lblNickName);
			this.tpSettings.Controls.Add(this.gbSupportingPrograms);
			this.tpSettings.Controls.Add(this.rtbSettings);
			this.tpSettings.Controls.Add(this.gbSettingsNameUnification);
			this.tpSettings.Controls.Add(this.gbSettingsConsideredFiles);
			this.tpSettings.ImageKey = "Settings.gif";
			this.tpSettings.Location = new System.Drawing.Point(4, 35);
			this.tpSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSettings.Name = "tpSettings";
			this.tpSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSettings.Size = new System.Drawing.Size(920, 569);
			this.tpSettings.TabIndex = 1;
			this.tpSettings.Text = "Settings";
			this.tpSettings.Leave += new System.EventHandler(this.TpSettingsLeave);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(602, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 27);
			this.label2.TabIndex = 45;
			this.label2.Text = "Search Info on";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(286, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 27);
			this.label1.TabIndex = 44;
			this.label1.Text = "Download from";
			// 
			// cobSearchDownload
			// 
			this.cobSearchDownload.BackColor = System.Drawing.SystemColors.Control;
			this.cobSearchDownload.FormattingEnabled = true;
			this.cobSearchDownload.Items.AddRange(new object[] {
			"All Below",
			"1337X",
			"Bit Snoop",
			"Demonoid",
			"Extra Torrent",
			"Eztv",
			"Kickass",
			"Magnet Seed",
			"Rarbg",
			"ISO Hunt",
			"Lime Torrents",
			"The Piratebay",
			"Torrentz",
			"Torrent Hound",
			"Torlock",
			"Yifi Torrents"});
			this.cobSearchDownload.Location = new System.Drawing.Point(420, 11);
			this.cobSearchDownload.Name = "cobSearchDownload";
			this.cobSearchDownload.Size = new System.Drawing.Size(157, 28);
			this.cobSearchDownload.TabIndex = 43;
			this.cobSearchDownload.Text = "Torrentz";
			this.cobSearchDownload.SelectedIndexChanged += new System.EventHandler(this.CobSearchDownloadSelectedIndexChanged);
			// 
			// cobSearchInfo
			// 
			this.cobSearchInfo.BackColor = System.Drawing.SystemColors.Control;
			this.cobSearchInfo.FormattingEnabled = true;
			this.cobSearchInfo.Items.AddRange(new object[] {
			"Nearly All Below",
			"All Movie",
			"IMDb",
			"The Movie DB",
			"The Movie Poster DB",
			"The TVDB",
			"Trailer Addict",
			"Adult DVD Empire"});
			this.cobSearchInfo.Location = new System.Drawing.Point(736, 11);
			this.cobSearchInfo.Name = "cobSearchInfo";
			this.cobSearchInfo.Size = new System.Drawing.Size(177, 28);
			this.cobSearchInfo.TabIndex = 42;
			this.cobSearchInfo.Text = "IMDb";
			this.cobSearchInfo.SelectedIndexChanged += new System.EventHandler(this.CobSearchInfoSelectedIndexChanged);
			// 
			// tbNickName
			// 
			this.tbNickName.Location = new System.Drawing.Point(135, 10);
			this.tbNickName.Name = "tbNickName";
			this.tbNickName.Size = new System.Drawing.Size(120, 26);
			this.tbNickName.TabIndex = 41;
			this.tbNickName.Text = "Modi";
			this.ttMovieFileMerger.SetToolTip(this.tbNickName, "Your nick name will be used as default in the exported lists name.");
			// 
			// lblNickName
			// 
			this.lblNickName.Location = new System.Drawing.Point(17, 13);
			this.lblNickName.Name = "lblNickName";
			this.lblNickName.Size = new System.Drawing.Size(109, 23);
			this.lblNickName.TabIndex = 40;
			this.lblNickName.Text = "Nick Name";
			this.ttMovieFileMerger.SetToolTip(this.lblNickName, "Your nick name will be used as default in the exported lists name.");
			// 
			// gbSupportingPrograms
			// 
			this.gbSupportingPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.gbSupportingPrograms.Controls.Add(this.lblTeraCopyPath);
			this.gbSupportingPrograms.Controls.Add(this.tbMediaInfoPath);
			this.gbSupportingPrograms.Controls.Add(this.lblMediaInfoPath);
			this.gbSupportingPrograms.Controls.Add(this.tbTeraCopyPath);
			this.gbSupportingPrograms.Location = new System.Drawing.Point(10, 372);
			this.gbSupportingPrograms.Name = "gbSupportingPrograms";
			this.gbSupportingPrograms.Size = new System.Drawing.Size(903, 63);
			this.gbSupportingPrograms.TabIndex = 8;
			this.gbSupportingPrograms.TabStop = false;
			this.gbSupportingPrograms.Text = "Supporting Programs Installation Paths";
			// 
			// lblTeraCopyPath
			// 
			this.lblTeraCopyPath.Location = new System.Drawing.Point(14, 31);
			this.lblTeraCopyPath.Name = "lblTeraCopyPath";
			this.lblTeraCopyPath.Size = new System.Drawing.Size(94, 23);
			this.lblTeraCopyPath.TabIndex = 6;
			this.lblTeraCopyPath.Text = "TeraCopy";
			this.ttMovieFileMerger.SetToolTip(this.lblTeraCopyPath, "The TeraCopy Path points to where you have installed TeraCopy. ");
			// 
			// tbMediaInfoPath
			// 
			this.tbMediaInfoPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbMediaInfoPath.Location = new System.Drawing.Point(556, 28);
			this.tbMediaInfoPath.Name = "tbMediaInfoPath";
			this.tbMediaInfoPath.Size = new System.Drawing.Size(334, 26);
			this.tbMediaInfoPath.TabIndex = 7;
			this.tbMediaInfoPath.Text = "C:\\Program Files\\MediaInfo\\MediaInfo.exe";
			this.ttMovieFileMerger.SetToolTip(this.tbMediaInfoPath, "The MediaInfo Path points to where you have installed MediaInfo.");
			// 
			// lblMediaInfoPath
			// 
			this.lblMediaInfoPath.Location = new System.Drawing.Point(456, 31);
			this.lblMediaInfoPath.Name = "lblMediaInfoPath";
			this.lblMediaInfoPath.Size = new System.Drawing.Size(94, 23);
			this.lblMediaInfoPath.TabIndex = 6;
			this.lblMediaInfoPath.Text = "MediaInfo";
			this.ttMovieFileMerger.SetToolTip(this.lblMediaInfoPath, "The MediaInfo Path points to where you have installed MediaInfo.");
			// 
			// tbTeraCopyPath
			// 
			this.tbTeraCopyPath.Location = new System.Drawing.Point(114, 28);
			this.tbTeraCopyPath.Name = "tbTeraCopyPath";
			this.tbTeraCopyPath.Size = new System.Drawing.Size(334, 26);
			this.tbTeraCopyPath.TabIndex = 7;
			this.tbTeraCopyPath.Text = "C:\\Program Files\\TeraCopy\\TeraCopy.exe";
			this.ttMovieFileMerger.SetToolTip(this.tbTeraCopyPath, "The TeraCopy Path points to where you have installed TeraCopy. ");
			// 
			// rtbSettings
			// 
			this.rtbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbSettings.Location = new System.Drawing.Point(9, 443);
			this.rtbSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbSettings.Name = "rtbSettings";
			this.rtbSettings.ReadOnly = true;
			this.rtbSettings.Size = new System.Drawing.Size(903, 121);
			this.rtbSettings.TabIndex = 3;
			this.rtbSettings.Text = "";
			this.rtbSettings.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
			this.rtbSettings.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
			// 
			// gbSettingsNameUnification
			// 
			this.gbSettingsNameUnification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.gbSettingsNameUnification.Controls.Add(this.lblBadMovieNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbBadMovieNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblGoodMovieNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbGoodMovieNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblBadEpisodeNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbBadEpisodeNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblGoodEpisodeNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbGoodEpisodeNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblBadDocuNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbBadDocuNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblGoodDocuNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbGoodDocuNameRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblToLowerRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbToLowerRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblOnlyCharacters);
			this.gbSettingsNameUnification.Controls.Add(this.tbOnlyCharactersRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblEpisodesId);
			this.gbSettingsNameUnification.Controls.Add(this.tbEpisodesIdRegex);
			this.gbSettingsNameUnification.Controls.Add(this.lblCutNameBeforeRegex);
			this.gbSettingsNameUnification.Controls.Add(this.tbCutNameBeforeRegex);
			this.gbSettingsNameUnification.Location = new System.Drawing.Point(9, 122);
			this.gbSettingsNameUnification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsNameUnification.Name = "gbSettingsNameUnification";
			this.gbSettingsNameUnification.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsNameUnification.Size = new System.Drawing.Size(903, 242);
			this.gbSettingsNameUnification.TabIndex = 1;
			this.gbSettingsNameUnification.TabStop = false;
			this.gbSettingsNameUnification.Text = "Name Unification Regular Expressions";
			// 
			// lblBadMovieNameRegex
			// 
			this.lblBadMovieNameRegex.Location = new System.Drawing.Point(482, 208);
			this.lblBadMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBadMovieNameRegex.Name = "lblBadMovieNameRegex";
			this.lblBadMovieNameRegex.Size = new System.Drawing.Size(153, 32);
			this.lblBadMovieNameRegex.TabIndex = 38;
			this.lblBadMovieNameRegex.Text = "Bad Movie Name";
			this.ttMovieFileMerger.SetToolTip(this.lblBadMovieNameRegex, resources.GetString("lblBadMovieNameRegex.ToolTip"));
			// 
			// tbBadMovieNameRegex
			// 
			this.tbBadMovieNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbBadMovieNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBadMovieNameRegex.Location = new System.Drawing.Point(643, 205);
			this.tbBadMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbBadMovieNameRegex.Name = "tbBadMovieNameRegex";
			this.tbBadMovieNameRegex.Size = new System.Drawing.Size(248, 26);
			this.tbBadMovieNameRegex.TabIndex = 39;
			this.tbBadMovieNameRegex.Text = "[12]\\d{3}";
			this.ttMovieFileMerger.SetToolTip(this.tbBadMovieNameRegex, resources.GetString("tbBadMovieNameRegex.ToolTip"));
			// 
			// lblGoodMovieNameRegex
			// 
			this.lblGoodMovieNameRegex.Location = new System.Drawing.Point(12, 208);
			this.lblGoodMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGoodMovieNameRegex.Name = "lblGoodMovieNameRegex";
			this.lblGoodMovieNameRegex.Size = new System.Drawing.Size(198, 32);
			this.lblGoodMovieNameRegex.TabIndex = 36;
			this.lblGoodMovieNameRegex.Text = "Good Movie Name";
			this.ttMovieFileMerger.SetToolTip(this.lblGoodMovieNameRegex, resources.GetString("lblGoodMovieNameRegex.ToolTip"));
			// 
			// tbGoodMovieNameRegex
			// 
			this.tbGoodMovieNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGoodMovieNameRegex.Location = new System.Drawing.Point(218, 205);
			this.tbGoodMovieNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbGoodMovieNameRegex.Name = "tbGoodMovieNameRegex";
			this.tbGoodMovieNameRegex.Size = new System.Drawing.Size(235, 26);
			this.tbGoodMovieNameRegex.TabIndex = 37;
			this.tbGoodMovieNameRegex.Text = ".* \\([12]\\d{3}\\)$";
			this.ttMovieFileMerger.SetToolTip(this.tbGoodMovieNameRegex, resources.GetString("tbGoodMovieNameRegex.ToolTip"));
			// 
			// lblBadEpisodeNameRegex
			// 
			this.lblBadEpisodeNameRegex.Location = new System.Drawing.Point(482, 172);
			this.lblBadEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBadEpisodeNameRegex.Name = "lblBadEpisodeNameRegex";
			this.lblBadEpisodeNameRegex.Size = new System.Drawing.Size(153, 32);
			this.lblBadEpisodeNameRegex.TabIndex = 34;
			this.lblBadEpisodeNameRegex.Text = "Bad Episode Name";
			this.ttMovieFileMerger.SetToolTip(this.lblBadEpisodeNameRegex, resources.GetString("lblBadEpisodeNameRegex.ToolTip"));
			// 
			// tbBadEpisodeNameRegex
			// 
			this.tbBadEpisodeNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbBadEpisodeNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBadEpisodeNameRegex.Location = new System.Drawing.Point(643, 169);
			this.tbBadEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbBadEpisodeNameRegex.Name = "tbBadEpisodeNameRegex";
			this.tbBadEpisodeNameRegex.Size = new System.Drawing.Size(248, 26);
			this.tbBadEpisodeNameRegex.TabIndex = 35;
			this.tbBadEpisodeNameRegex.Text = "[Ss]\\d{1,2}[Ee]\\d{1,2}";
			this.ttMovieFileMerger.SetToolTip(this.tbBadEpisodeNameRegex, resources.GetString("tbBadEpisodeNameRegex.ToolTip"));
			// 
			// lblGoodEpisodeNameRegex
			// 
			this.lblGoodEpisodeNameRegex.Location = new System.Drawing.Point(12, 172);
			this.lblGoodEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGoodEpisodeNameRegex.Name = "lblGoodEpisodeNameRegex";
			this.lblGoodEpisodeNameRegex.Size = new System.Drawing.Size(198, 32);
			this.lblGoodEpisodeNameRegex.TabIndex = 32;
			this.lblGoodEpisodeNameRegex.Text = "Good Episode Name";
			this.ttMovieFileMerger.SetToolTip(this.lblGoodEpisodeNameRegex, resources.GetString("lblGoodEpisodeNameRegex.ToolTip"));
			// 
			// tbGoodEpisodeNameRegex
			// 
			this.tbGoodEpisodeNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGoodEpisodeNameRegex.Location = new System.Drawing.Point(218, 169);
			this.tbGoodEpisodeNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbGoodEpisodeNameRegex.Name = "tbGoodEpisodeNameRegex";
			this.tbGoodEpisodeNameRegex.Size = new System.Drawing.Size(235, 26);
			this.tbGoodEpisodeNameRegex.TabIndex = 33;
			this.tbGoodEpisodeNameRegex.Text = ".* S\\d{2}E\\d{2}(-E\\d{2})? .*$";
			this.ttMovieFileMerger.SetToolTip(this.tbGoodEpisodeNameRegex, resources.GetString("tbGoodEpisodeNameRegex.ToolTip"));
			// 
			// lblBadDocuNameRegex
			// 
			this.lblBadDocuNameRegex.Location = new System.Drawing.Point(482, 136);
			this.lblBadDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBadDocuNameRegex.Name = "lblBadDocuNameRegex";
			this.lblBadDocuNameRegex.Size = new System.Drawing.Size(153, 32);
			this.lblBadDocuNameRegex.TabIndex = 30;
			this.lblBadDocuNameRegex.Text = "Bad Docu Name";
			this.ttMovieFileMerger.SetToolTip(this.lblBadDocuNameRegex, resources.GetString("lblBadDocuNameRegex.ToolTip"));
			// 
			// tbBadDocuNameRegex
			// 
			this.tbBadDocuNameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbBadDocuNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBadDocuNameRegex.Location = new System.Drawing.Point(643, 133);
			this.tbBadDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbBadDocuNameRegex.Name = "tbBadDocuNameRegex";
			this.tbBadDocuNameRegex.Size = new System.Drawing.Size(248, 26);
			this.tbBadDocuNameRegex.TabIndex = 31;
			this.tbBadDocuNameRegex.Text = "[Ss][12]\\d{3}[Ee]\\d{1,3}";
			this.ttMovieFileMerger.SetToolTip(this.tbBadDocuNameRegex, resources.GetString("tbBadDocuNameRegex.ToolTip"));
			// 
			// lblGoodDocuNameRegex
			// 
			this.lblGoodDocuNameRegex.Location = new System.Drawing.Point(12, 136);
			this.lblGoodDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGoodDocuNameRegex.Name = "lblGoodDocuNameRegex";
			this.lblGoodDocuNameRegex.Size = new System.Drawing.Size(198, 32);
			this.lblGoodDocuNameRegex.TabIndex = 28;
			this.lblGoodDocuNameRegex.Text = "Good Docu Name";
			this.ttMovieFileMerger.SetToolTip(this.lblGoodDocuNameRegex, resources.GetString("lblGoodDocuNameRegex.ToolTip"));
			// 
			// tbGoodDocuNameRegex
			// 
			this.tbGoodDocuNameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGoodDocuNameRegex.Location = new System.Drawing.Point(218, 133);
			this.tbGoodDocuNameRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbGoodDocuNameRegex.Name = "tbGoodDocuNameRegex";
			this.tbGoodDocuNameRegex.Size = new System.Drawing.Size(235, 26);
			this.tbGoodDocuNameRegex.TabIndex = 29;
			this.tbGoodDocuNameRegex.Text = ".* S[12]\\d{3}E\\d{1,3} .*$";
			this.ttMovieFileMerger.SetToolTip(this.tbGoodDocuNameRegex, resources.GetString("tbGoodDocuNameRegex.ToolTip"));
			// 
			// lblToLowerRegex
			// 
			this.lblToLowerRegex.Location = new System.Drawing.Point(12, 68);
			this.lblToLowerRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblToLowerRegex.Name = "lblToLowerRegex";
			this.lblToLowerRegex.Size = new System.Drawing.Size(162, 32);
			this.lblToLowerRegex.TabIndex = 26;
			this.lblToLowerRegex.Text = "Convert to Lower";
			this.ttMovieFileMerger.SetToolTip(this.lblToLowerRegex, resources.GetString("lblToLowerRegex.ToolTip"));
			// 
			// tbToLowerRegex
			// 
			this.tbToLowerRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbToLowerRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbToLowerRegex.Location = new System.Drawing.Point(182, 65);
			this.tbToLowerRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbToLowerRegex.Multiline = true;
			this.tbToLowerRegex.Name = "tbToLowerRegex";
			this.tbToLowerRegex.Size = new System.Drawing.Size(709, 26);
			this.tbToLowerRegex.TabIndex = 27;
			this.tbToLowerRegex.Text = " On | A | The | Of | And | Or | To | From | For | In | As | At | With";
			this.ttMovieFileMerger.SetToolTip(this.tbToLowerRegex, resources.GetString("tbToLowerRegex.ToolTip"));
			// 
			// lblOnlyCharacters
			// 
			this.lblOnlyCharacters.Location = new System.Drawing.Point(482, 100);
			this.lblOnlyCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOnlyCharacters.Name = "lblOnlyCharacters";
			this.lblOnlyCharacters.Size = new System.Drawing.Size(153, 32);
			this.lblOnlyCharacters.TabIndex = 24;
			this.lblOnlyCharacters.Text = "Only Characters";
			this.ttMovieFileMerger.SetToolTip(this.lblOnlyCharacters, resources.GetString("lblOnlyCharacters.ToolTip"));
			// 
			// tbOnlyCharactersRegex
			// 
			this.tbOnlyCharactersRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbOnlyCharactersRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbOnlyCharactersRegex.Location = new System.Drawing.Point(643, 97);
			this.tbOnlyCharactersRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbOnlyCharactersRegex.Name = "tbOnlyCharactersRegex";
			this.tbOnlyCharactersRegex.Size = new System.Drawing.Size(248, 26);
			this.tbOnlyCharactersRegex.TabIndex = 25;
			this.tbOnlyCharactersRegex.Text = "[^a-zA-Z0-9 -\'üöä]";
			this.ttMovieFileMerger.SetToolTip(this.tbOnlyCharactersRegex, resources.GetString("tbOnlyCharactersRegex.ToolTip"));
			// 
			// lblEpisodesId
			// 
			this.lblEpisodesId.Location = new System.Drawing.Point(12, 100);
			this.lblEpisodesId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEpisodesId.Name = "lblEpisodesId";
			this.lblEpisodesId.Size = new System.Drawing.Size(198, 32);
			this.lblEpisodesId.TabIndex = 22;
			this.lblEpisodesId.Text = "Episodes Identification";
			this.ttMovieFileMerger.SetToolTip(this.lblEpisodesId, resources.GetString("lblEpisodesId.ToolTip"));
			// 
			// tbEpisodesIdRegex
			// 
			this.tbEpisodesIdRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEpisodesIdRegex.Location = new System.Drawing.Point(218, 97);
			this.tbEpisodesIdRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbEpisodesIdRegex.Name = "tbEpisodesIdRegex";
			this.tbEpisodesIdRegex.Size = new System.Drawing.Size(235, 26);
			this.tbEpisodesIdRegex.TabIndex = 23;
			this.tbEpisodesIdRegex.Text = ".s\\d+e\\d+";
			this.ttMovieFileMerger.SetToolTip(this.tbEpisodesIdRegex, resources.GetString("tbEpisodesIdRegex.ToolTip"));
			// 
			// lblCutNameBeforeRegex
			// 
			this.lblCutNameBeforeRegex.Location = new System.Drawing.Point(12, 34);
			this.lblCutNameBeforeRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCutNameBeforeRegex.Name = "lblCutNameBeforeRegex";
			this.lblCutNameBeforeRegex.Size = new System.Drawing.Size(162, 32);
			this.lblCutNameBeforeRegex.TabIndex = 16;
			this.lblCutNameBeforeRegex.Text = "Cut Name Before";
			this.ttMovieFileMerger.SetToolTip(this.lblCutNameBeforeRegex, "The Cut Name Before regular expression tells MFM what not to include in the name." +
		" \r\nEverything after, including the match itself, will be removed from the item n" +
		"ame.");
			// 
			// tbCutNameBeforeRegex
			// 
			this.tbCutNameBeforeRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tbCutNameBeforeRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCutNameBeforeRegex.Location = new System.Drawing.Point(198, 29);
			this.tbCutNameBeforeRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbCutNameBeforeRegex.Name = "tbCutNameBeforeRegex";
			this.tbCutNameBeforeRegex.Size = new System.Drawing.Size(693, 26);
			this.tbCutNameBeforeRegex.TabIndex = 17;
			this.tbCutNameBeforeRegex.Text = "720p|1080p|(cd[12])|x264|aac|divx|xvid";
			this.ttMovieFileMerger.SetToolTip(this.tbCutNameBeforeRegex, "The Cut Name Before regular expression tells MFM what not to include in the name." +
		" \r\nEverything after, including the match itself, will be removed from the item n" +
		"ame.");
			// 
			// gbSettingsConsideredFiles
			// 
			this.gbSettingsConsideredFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.gbSettingsConsideredFiles.Controls.Add(this.lblAddonExtensions);
			this.gbSettingsConsideredFiles.Controls.Add(this.tbAddonExtensionsRegex);
			this.gbSettingsConsideredFiles.Controls.Add(this.lblMainExtensions);
			this.gbSettingsConsideredFiles.Controls.Add(this.tbMainExtensionsRegex);
			this.gbSettingsConsideredFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbSettingsConsideredFiles.Location = new System.Drawing.Point(9, 45);
			this.gbSettingsConsideredFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsConsideredFiles.Name = "gbSettingsConsideredFiles";
			this.gbSettingsConsideredFiles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbSettingsConsideredFiles.Size = new System.Drawing.Size(903, 67);
			this.gbSettingsConsideredFiles.TabIndex = 0;
			this.gbSettingsConsideredFiles.TabStop = false;
			this.gbSettingsConsideredFiles.Text = "Considered Files Regular Expressions";
			// 
			// lblAddonExtensions
			// 
			this.lblAddonExtensions.Location = new System.Drawing.Point(482, 30);
			this.lblAddonExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAddonExtensions.Name = "lblAddonExtensions";
			this.lblAddonExtensions.Size = new System.Drawing.Size(189, 29);
			this.lblAddonExtensions.TabIndex = 22;
			this.lblAddonExtensions.Text = "Add-on File Extensions";
			this.ttMovieFileMerger.SetToolTip(this.lblAddonExtensions, "The Add-on Files Extension identified add-on files like subtitles or posters. \r\nA" +
		"dd-on files will be only considered if a main video file exists.");
			// 
			// tbAddonExtensionsRegex
			// 
			this.tbAddonExtensionsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAddonExtensionsRegex.Location = new System.Drawing.Point(679, 27);
			this.tbAddonExtensionsRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbAddonExtensionsRegex.Name = "tbAddonExtensionsRegex";
			this.tbAddonExtensionsRegex.Size = new System.Drawing.Size(212, 26);
			this.tbAddonExtensionsRegex.TabIndex = 23;
			this.tbAddonExtensionsRegex.Text = "srt|sub";
			this.ttMovieFileMerger.SetToolTip(this.tbAddonExtensionsRegex, "The Add-on Files Extension identified add-on files like subtitles or posters. \r\nA" +
		"dd-on files will be only considered if a main video file exists.");
			// 
			// lblMainExtensions
			// 
			this.lblMainExtensions.Location = new System.Drawing.Point(8, 30);
			this.lblMainExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMainExtensions.Name = "lblMainExtensions";
			this.lblMainExtensions.Size = new System.Drawing.Size(182, 29);
			this.lblMainExtensions.TabIndex = 20;
			this.lblMainExtensions.Text = "Main File Extensions";
			this.ttMovieFileMerger.SetToolTip(this.lblMainExtensions, "The Main Files Extension regular expression identifies main files. \r\nIf no main f" +
		"ile exists also the add-on files will be ignored.");
			// 
			// tbMainExtensionsRegex
			// 
			this.tbMainExtensionsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMainExtensionsRegex.Location = new System.Drawing.Point(198, 27);
			this.tbMainExtensionsRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbMainExtensionsRegex.Name = "tbMainExtensionsRegex";
			this.tbMainExtensionsRegex.Size = new System.Drawing.Size(255, 26);
			this.tbMainExtensionsRegex.TabIndex = 21;
			this.tbMainExtensionsRegex.Text = "avi|mkv|mp4";
			this.ttMovieFileMerger.SetToolTip(this.tbMainExtensionsRegex, "The Main Files Extension regular expression identifies main files. \r\nIf no main f" +
		"ile exists also the add-on files will be ignored.");
			// 
			// tpHelp
			// 
			this.tpHelp.Controls.Add(this.rtbHelp);
			this.tpHelp.ImageKey = "Help.gif";
			this.tpHelp.Location = new System.Drawing.Point(4, 35);
			this.tpHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpHelp.Name = "tpHelp";
			this.tpHelp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpHelp.Size = new System.Drawing.Size(920, 569);
			this.tpHelp.TabIndex = 4;
			this.tpHelp.Text = "Instructions";
			this.tpHelp.UseVisualStyleBackColor = true;
			// 
			// rtbHelp
			// 
			this.rtbHelp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbHelp.Location = new System.Drawing.Point(4, 5);
			this.rtbHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbHelp.Name = "rtbHelp";
			this.rtbHelp.ReadOnly = true;
			this.rtbHelp.Size = new System.Drawing.Size(912, 559);
			this.rtbHelp.TabIndex = 0;
			this.rtbHelp.Text = "";
			this.rtbHelp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
			this.rtbHelp.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
			// 
			// tpAbout
			// 
			this.tpAbout.BackColor = System.Drawing.SystemColors.Control;
			this.tpAbout.Controls.Add(this.lblLastChecked);
			this.tpAbout.Controls.Add(this.cobCheckForUpdates);
			this.tpAbout.Controls.Add(this.btnCheckNow);
			this.tpAbout.Controls.Add(this.pbAboutBanner);
			this.tpAbout.Controls.Add(this.lblCopyLeft);
			this.tpAbout.Controls.Add(this.rtbCopyright);
			this.tpAbout.Controls.Add(this.lblVersion);
			this.tpAbout.Controls.Add(this.llMovieFileMergerOrg);
			this.tpAbout.ImageKey = "About.gif";
			this.tpAbout.Location = new System.Drawing.Point(4, 35);
			this.tpAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpAbout.Name = "tpAbout";
			this.tpAbout.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpAbout.Size = new System.Drawing.Size(920, 569);
			this.tpAbout.TabIndex = 3;
			this.tpAbout.Text = "About";
			// 
			// lblLastChecked
			// 
			this.lblLastChecked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblLastChecked.Location = new System.Drawing.Point(259, 186);
			this.lblLastChecked.Name = "lblLastChecked";
			this.lblLastChecked.Size = new System.Drawing.Size(404, 40);
			this.lblLastChecked.TabIndex = 9;
			this.lblLastChecked.Text = "Last Checked: Never";
			this.lblLastChecked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cobCheckForUpdates
			// 
			this.cobCheckForUpdates.FormattingEnabled = true;
			this.cobCheckForUpdates.Items.AddRange(new object[] {
			"Check for updates daily.",
			"Check for updates weekly.",
			"Check for updates monthly."});
			this.cobCheckForUpdates.Location = new System.Drawing.Point(9, 198);
			this.cobCheckForUpdates.Name = "cobCheckForUpdates";
			this.cobCheckForUpdates.Size = new System.Drawing.Size(243, 28);
			this.cobCheckForUpdates.TabIndex = 8;
			this.cobCheckForUpdates.Text = "Check for updates daily.";
			// 
			// btnCheckNow
			// 
			this.btnCheckNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCheckNow.Location = new System.Drawing.Point(669, 186);
			this.btnCheckNow.Name = "btnCheckNow";
			this.btnCheckNow.Size = new System.Drawing.Size(243, 40);
			this.btnCheckNow.TabIndex = 7;
			this.btnCheckNow.Text = "Check for updates now!";
			this.btnCheckNow.UseVisualStyleBackColor = true;
			this.btnCheckNow.Click += new System.EventHandler(this.BtnCheckNowClick);
			// 
			// pbAboutBanner
			// 
			this.pbAboutBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbAboutBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbAboutBanner.Image")));
			this.pbAboutBanner.Location = new System.Drawing.Point(9, 8);
			this.pbAboutBanner.Name = "pbAboutBanner";
			this.pbAboutBanner.Size = new System.Drawing.Size(903, 127);
			this.pbAboutBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbAboutBanner.TabIndex = 6;
			this.pbAboutBanner.TabStop = false;
			// 
			// lblCopyLeft
			// 
			this.lblCopyLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCopyLeft.BackColor = System.Drawing.Color.Transparent;
			this.lblCopyLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCopyLeft.Location = new System.Drawing.Point(713, 155);
			this.lblCopyLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCopyLeft.Name = "lblCopyLeft";
			this.lblCopyLeft.Size = new System.Drawing.Size(200, 23);
			this.lblCopyLeft.TabIndex = 2;
			this.lblCopyLeft.Text = "© 2015 Reinhold Lauer";
			this.lblCopyLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbCopyright
			// 
			this.rtbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbCopyright.Location = new System.Drawing.Point(0, 241);
			this.rtbCopyright.Name = "rtbCopyright";
			this.rtbCopyright.ReadOnly = true;
			this.rtbCopyright.Size = new System.Drawing.Size(912, 354);
			this.rtbCopyright.TabIndex = 4;
			this.rtbCopyright.Text = "";
			this.rtbCopyright.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
			this.rtbCopyright.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
			// 
			// lblVersion
			// 
			this.lblVersion.BackColor = System.Drawing.Color.Transparent;
			this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.Location = new System.Drawing.Point(9, 155);
			this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(99, 23);
			this.lblVersion.TabIndex = 1;
			this.lblVersion.Text = "x.x.x";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// llMovieFileMergerOrg
			// 
			this.llMovieFileMergerOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.llMovieFileMergerOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llMovieFileMergerOrg.Location = new System.Drawing.Point(8, 140);
			this.llMovieFileMergerOrg.Name = "llMovieFileMergerOrg";
			this.llMovieFileMergerOrg.Size = new System.Drawing.Size(916, 43);
			this.llMovieFileMergerOrg.TabIndex = 5;
			this.llMovieFileMergerOrg.TabStop = true;
			this.llMovieFileMergerOrg.Text = "www.Movie-File-Merger.org";
			this.llMovieFileMergerOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.llMovieFileMergerOrg.Click += new System.EventHandler(this.LlMovieFileMergerOrgClick);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.ssMFM);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.tcMovieFileMerger);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(928, 608);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(928, 663);
			this.toolStripContainer1.TabIndex = 2;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// ssMFM
			// 
			this.ssMFM.Dock = System.Windows.Forms.DockStyle.None;
			this.ssMFM.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.ssMFM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsslMFM,
			this.tspbMFM});
			this.ssMFM.Location = new System.Drawing.Point(0, 0);
			this.ssMFM.Name = "ssMFM";
			this.ssMFM.Size = new System.Drawing.Size(928, 30);
			this.ssMFM.TabIndex = 0;
			// 
			// tsslMFM
			// 
			this.tsslMFM.Name = "tsslMFM";
			this.tsslMFM.Size = new System.Drawing.Size(611, 25);
			this.tsslMFM.Spring = true;
			this.tsslMFM.Text = "Welcome to MFM";
			this.tsslMFM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tspbMFM
			// 
			this.tspbMFM.Name = "tspbMFM";
			this.tspbMFM.Size = new System.Drawing.Size(300, 24);
			// 
			// ttMovieFileMerger
			// 
			this.ttMovieFileMerger.AutoPopDelay = 10000;
			this.ttMovieFileMerger.InitialDelay = 500;
			this.ttMovieFileMerger.IsBalloon = true;
			this.ttMovieFileMerger.ReshowDelay = 100;
			this.ttMovieFileMerger.ShowAlways = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(928, 663);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(950, 700);
			this.Name = "MainForm";
			this.Text = "Movie File Merger";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MfFormClosing);
			this.Shown += new System.EventHandler(this.MfShown);
			this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
			this.tcMovieFileMerger.ResumeLayout(false);
			this.tpSeparateLists.ResumeLayout(false);
			this.tpSeparateLists.PerformLayout();
			this.scFolders.Panel1.ResumeLayout(false);
			this.scFolders.Panel1.PerformLayout();
			this.scFolders.Panel2.ResumeLayout(false);
			this.scFolders.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFolders)).EndInit();
			this.scFolders.ResumeLayout(false);
			this.gbTypeSelection.ResumeLayout(false);
			this.gbProcessImport.ResumeLayout(false);
			this.scVertical.Panel1.ResumeLayout(false);
			this.scVertical.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scVertical)).EndInit();
			this.scVertical.ResumeLayout(false);
			this.scVerticalRight.Panel1.ResumeLayout(false);
			this.scVerticalRight.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scVerticalRight)).EndInit();
			this.scVerticalRight.ResumeLayout(false);
			this.scHorizontal.Panel1.ResumeLayout(false);
			this.scHorizontal.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scHorizontal)).EndInit();
			this.scHorizontal.ResumeLayout(false);
			this.tpMaintenance.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbMFM)).EndInit();
			this.scMaintenance.Panel1.ResumeLayout(false);
			this.scMaintenance.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scMaintenance)).EndInit();
			this.scMaintenance.ResumeLayout(false);
			this.tpLog.ResumeLayout(false);
			this.tpSettings.ResumeLayout(false);
			this.tpSettings.PerformLayout();
			this.gbSupportingPrograms.ResumeLayout(false);
			this.gbSupportingPrograms.PerformLayout();
			this.gbSettingsNameUnification.ResumeLayout(false);
			this.gbSettingsNameUnification.PerformLayout();
			this.gbSettingsConsideredFiles.ResumeLayout(false);
			this.gbSettingsConsideredFiles.PerformLayout();
			this.tpHelp.ResumeLayout(false);
			this.tpAbout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbAboutBanner)).EndInit();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ssMFM.ResumeLayout(false);
			this.ssMFM.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox tbToolTipRegex;
		private System.Windows.Forms.GroupBox gbSupportingPrograms;
		private System.Windows.Forms.Label lblMediaInfoPath;
		private System.Windows.Forms.TextBox tbMediaInfoPath;
		private System.Windows.Forms.ToolTip ttMovieFileMerger;
		private System.Windows.Forms.CheckBox cbMediaInfo;
		private System.Windows.Forms.RichTextBox rtbCopyright;
		private System.Windows.Forms.Label lblTeraCopyPath;
		private System.Windows.Forms.TextBox tbTeraCopyPath;
		private System.Windows.Forms.Label lblNickName;
		private System.Windows.Forms.TextBox tbNickName;
		private System.Windows.Forms.Label lblImportFolder;
		private System.Windows.Forms.Label lblTargetFolder;
		//private System.Diagnostics.PerformanceCounter performanceCounter1;
		private System.Windows.Forms.Button btnExportList;
		private System.Windows.Forms.Button btnSearchInfo;
		private System.Windows.Forms.Button btnSearchDownload;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnEraseSelected;
		private System.Windows.Forms.Button btnEraseColor;
		private System.Windows.Forms.CheckBox cbKeepFolders;
		private System.Windows.Forms.TabPage tpSeparateLists;
		private System.Windows.Forms.SplitContainer scVerticalRight;
		private System.Windows.Forms.ListView lvWish;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TabControl tcMovieFileMerger;
		private System.Windows.Forms.TextBox tbAddonExtensionsRegex;
		private System.Windows.Forms.Label lblAddonExtensions;
		private System.Windows.Forms.RadioButton rbAdults;
		private System.Windows.Forms.RadioButton rbMiscellaneous;
		private System.Windows.Forms.SplitContainer scFolders;
		private System.Windows.Forms.GroupBox gbTypeSelection;
		private System.Windows.Forms.TextBox tbImportFolder;
		private System.Windows.Forms.GroupBox gbSettingsNameUnification;
		private System.Windows.Forms.TextBox tbToLowerRegex;
		private System.Windows.Forms.Label lblToLowerRegex;
		private System.Windows.Forms.Label lblOnlyCharacters;
		private System.Windows.Forms.TextBox tbOnlyCharactersRegex;
		private System.Windows.Forms.RichTextBox rtbSettings;
		private System.Windows.Forms.ImageList ilMovieFileMerger;
		private System.Windows.Forms.RadioButton rbClips;
		private System.Windows.Forms.RadioButton rbSeries;
		private System.Windows.Forms.RadioButton rbDocumentaries;
		private System.Windows.Forms.RadioButton rbMovies;
		private System.Windows.Forms.ColumnHeader chNameExisting;
		private System.Windows.Forms.ColumnHeader chNameImport;
		private System.Windows.Forms.ColumnHeader chNameGarbage;
		private System.Windows.Forms.GroupBox gbProcessImport;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblCopyLeft;
		private System.Windows.Forms.RichTextBox rtbHelp;
		private System.Windows.Forms.TabPage tpHelp;
		private System.Windows.Forms.TabPage tpAbout;
		private System.Windows.Forms.RichTextBox rtbLog;
		private System.Windows.Forms.TabPage tpLog;
		private System.Windows.Forms.TextBox tbEpisodesIdRegex;
		private System.Windows.Forms.Label lblEpisodesId;
		private System.Windows.Forms.GroupBox gbSettingsConsideredFiles;
		private System.Windows.Forms.TabPage tpSettings;
		private System.Windows.Forms.RadioButton rbCopy;
		private System.Windows.Forms.RadioButton rbMove;
		private System.Windows.Forms.Button btnMediaInfo;
		private System.Windows.Forms.Label lblMainExtensions;
		private System.Windows.Forms.TextBox tbMainExtensionsRegex;
		private System.Windows.Forms.SaveFileDialog sfdMovieFileMerger;
		private System.Windows.Forms.Timer tmrUpdateCounters;
		private System.Windows.Forms.ListView lvGarbage;
		private System.Windows.Forms.Label lblCutNameBeforeRegex;
		private System.Windows.Forms.TextBox tbCutNameBeforeRegex;
		private System.Windows.Forms.FolderBrowserDialog fbdMovieFileMerger;
		private System.Windows.Forms.TextBox tbTargetFolder;
		private System.Windows.Forms.SplitContainer scVertical;
		private System.Windows.Forms.SplitContainer scHorizontal;
		private System.Windows.Forms.ListView lvExisting;
		private System.Windows.Forms.ListView lvImport;
		private System.Windows.Forms.LinkLabel llMovieFileMergerOrg;
		private System.Windows.Forms.ComboBox cobToolTipRegex;
		private System.Windows.Forms.PictureBox pbAboutBanner;
		private System.Windows.Forms.CheckBox cbGetHigherRes;
		private System.Windows.Forms.StatusStrip ssMFM;
		private System.Windows.Forms.ToolStripStatusLabel tsslMFM;
		private System.Windows.Forms.ToolStripProgressBar tspbMFM;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ComboBox cobCheckForUpdates;
		private System.Windows.Forms.Button btnCheckNow;
		private System.Windows.Forms.Label lblLastChecked;
		private System.Windows.Forms.ComboBox cobCriteria;
		private System.Windows.Forms.Button btnAddToWish;
		private System.Windows.Forms.Button btnBin;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnJustRipIt;
		private System.Windows.Forms.Button btnJustScanIt;
		private System.Windows.Forms.TabPage tpMaintenance;
		private System.Windows.Forms.RichTextBox rtbMaintenance;
		private System.Windows.Forms.ListView lvMaintenance;
		private System.Windows.Forms.ColumnHeader chNameMaintenance;
		private System.Windows.Forms.SplitContainer scMaintenance;
		private System.Windows.Forms.Label lblSelect;
		private System.Windows.Forms.PictureBox pbMFM;
		private System.Windows.Forms.Button btnGoodEpisode;
		private System.Windows.Forms.Button btnGoodDocu;
		private System.Windows.Forms.Button btnGoodMovie;
		private System.Windows.Forms.Button btnUnrelatedFile;
		private System.Windows.Forms.Button btnBadEpisode;
		private System.Windows.Forms.Button btnBadName;
		private System.Windows.Forms.Button btnBadDocu;
		private System.Windows.Forms.Button btnBadMovie;
		private System.Windows.Forms.Label lblBadMovieNameRegex;
		private System.Windows.Forms.TextBox tbBadMovieNameRegex;
		private System.Windows.Forms.Label lblGoodMovieNameRegex;
		private System.Windows.Forms.TextBox tbGoodMovieNameRegex;
		private System.Windows.Forms.Label lblBadEpisodeNameRegex;
		private System.Windows.Forms.TextBox tbBadEpisodeNameRegex;
		private System.Windows.Forms.Label lblGoodEpisodeNameRegex;
		private System.Windows.Forms.TextBox tbGoodEpisodeNameRegex;
		private System.Windows.Forms.Label lblBadDocuNameRegex;
		private System.Windows.Forms.TextBox tbBadDocuNameRegex;
		private System.Windows.Forms.Label lblGoodDocuNameRegex;
		private System.Windows.Forms.TextBox tbGoodDocuNameRegex;
		private System.Windows.Forms.ComboBox cobSearchDownload;
		private System.Windows.Forms.ComboBox cobSearchInfo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cobMinimumResolution;
		private System.Windows.Forms.Button btnHigherRes;
		private System.Windows.Forms.Button btnLowRes;
		private System.Windows.Forms.Button btnToConsider;
		private System.Windows.Forms.Button btnWish;
		private System.Windows.Forms.Button btnExisting;
		private System.Windows.Forms.Button btnGarbage;
		private System.Windows.Forms.Label label3;
	}
}
