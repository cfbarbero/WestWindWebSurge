﻿namespace WebSurge
{
    partial class StressTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StressTestForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusFilename = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtProcessingTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.BottomSplitContainer = new System.Windows.Forms.SplitContainer();
            this.TabSessions = new System.Windows.Forms.TabControl();
            this.tabSession = new System.Windows.Forms.TabPage();
            this.SessionToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbAddRequest2 = new System.Windows.Forms.ToolStripButton();
            this.tbEditRequest2 = new System.Windows.Forms.ToolStripButton();
            this.tbDeleteRequest2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCapture = new System.Windows.Forms.ToolStripButton();
            this.tbSaveAllRequests2 = new System.Windows.Forms.ToolStripButton();
            this.tbEditFile = new System.Windows.Forms.ToolStripButton();
            this.ListRequests = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbAddRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tbEditRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRunRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDeleteRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSaveAllRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.tabResults = new System.Windows.Forms.TabPage();
            this.ListResults = new System.Windows.Forms.ListView();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Request = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErrorMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResultContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbResultCharts = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRequestsPerSecondChart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tbTimeTakenPerUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.tbImportWebSurgeResults = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRequestCount = new System.Windows.Forms.Label();
            this.cmbListDisplayMode = new System.Windows.Forms.ComboBox();
            this.TabsResult = new System.Windows.Forms.TabControl();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.TestResultBrowser = new System.Windows.Forms.WebBrowser();
            this.BrowserContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnOpenInDefaultBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tabPreview = new System.Windows.Forms.TabPage();
            this.PreViewBrowser = new System.Windows.Forms.WebBrowser();
            this.tabRequest = new System.Windows.Forms.TabPage();
            this.btnRunRequest = new System.Windows.Forms.Button();
            this.lblRequestContent = new System.Windows.Forms.Label();
            this.txtRequestContent = new System.Windows.Forms.TextBox();
            this.btnSaveRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestHeaders = new System.Windows.Forms.TextBox();
            this.txtRequestUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtHttpMethod = new System.Windows.Forms.ComboBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.OptionsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.tabPerfMon = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRecentSessions = new System.Windows.Forms.ToolStripMenuItem();
            this.RecentFilesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEditFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportXml = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportJson = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCharts = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRequestsPerSecondChart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimeTakenPerUrlChart = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelpIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGotoRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBugReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowErrorLog = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGotoSettingsFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGotoWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckForNewVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbStart = new System.Windows.Forms.ToolStripButton();
            this.tbStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbExport = new System.Windows.Forms.ToolStripSplitButton();
            this.tbExportRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.tbExportJson = new System.Windows.Forms.ToolStripMenuItem();
            this.tbExportXml = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCharts = new System.Windows.Forms.ToolStripSplitButton();
            this.tbRequestPerSecondChart = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTimeTakenPerUrlChart = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbtxtTimeToRun = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblTbThreads = new System.Windows.Forms.ToolStripLabel();
            this.tbtxtThreads = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbNoProgressEvents = new System.Windows.Forms.ToolStripButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Help = new System.Windows.Forms.HelpProvider();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainer)).BeginInit();
            this.BottomSplitContainer.Panel1.SuspendLayout();
            this.BottomSplitContainer.Panel2.SuspendLayout();
            this.BottomSplitContainer.SuspendLayout();
            this.TabSessions.SuspendLayout();
            this.tabSession.SuspendLayout();
            this.SessionToolStrip.SuspendLayout();
            this.RequestContextMenu.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.ResultContextMenu.SuspendLayout();
            this.TabsResult.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.BrowserContextMenu.SuspendLayout();
            this.tabPreview.SuspendLayout();
            this.tabRequest.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tabPerfMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.OptionsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusBar);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.BottomSplitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(992, 566);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(992, 673);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.MainToolStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.OptionsToolStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.MainMenu);
            // 
            // statusBar
            // 
            this.statusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusText,
            this.lblStatusFilename,
            this.txtProcessingTime});
            this.statusBar.Location = new System.Drawing.Point(0, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(992, 25);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = false;
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(300, 20);
            this.lblStatusText.Text = "Ready";
            this.lblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusFilename
            // 
            this.lblStatusFilename.DoubleClickEnabled = true;
            this.lblStatusFilename.Name = "lblStatusFilename";
            this.lblStatusFilename.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblStatusFilename.Size = new System.Drawing.Size(667, 20);
            this.lblStatusFilename.Spring = true;
            this.lblStatusFilename.Text = "No Fiddler Session File selected";
            this.lblStatusFilename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProcessingTime
            // 
            this.txtProcessingTime.DoubleClickEnabled = true;
            this.txtProcessingTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtProcessingTime.Name = "txtProcessingTime";
            this.txtProcessingTime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtProcessingTime.Size = new System.Drawing.Size(10, 20);
            this.txtProcessingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BottomSplitContainer
            // 
            this.BottomSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.BottomSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.BottomSplitContainer.Name = "BottomSplitContainer";
            // 
            // BottomSplitContainer.Panel1
            // 
            this.BottomSplitContainer.Panel1.Controls.Add(this.TabSessions);
            // 
            // BottomSplitContainer.Panel2
            // 
            this.BottomSplitContainer.Panel2.Controls.Add(this.TabsResult);
            this.BottomSplitContainer.Size = new System.Drawing.Size(992, 566);
            this.BottomSplitContainer.SplitterDistance = 429;
            this.BottomSplitContainer.SplitterIncrement = 2;
            this.BottomSplitContainer.TabIndex = 0;
            // 
            // TabSessions
            // 
            this.TabSessions.Controls.Add(this.tabSession);
            this.TabSessions.Controls.Add(this.tabResults);
            this.TabSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabSessions.Location = new System.Drawing.Point(0, 0);
            this.TabSessions.Name = "TabSessions";
            this.TabSessions.SelectedIndex = 0;
            this.TabSessions.Size = new System.Drawing.Size(429, 566);
            this.TabSessions.TabIndex = 3;
            // 
            // tabSession
            // 
            this.tabSession.Controls.Add(this.SessionToolStrip);
            this.tabSession.Controls.Add(this.ListRequests);
            this.tabSession.Location = new System.Drawing.Point(4, 29);
            this.tabSession.Margin = new System.Windows.Forms.Padding(0);
            this.tabSession.Name = "tabSession";
            this.tabSession.Size = new System.Drawing.Size(421, 533);
            this.tabSession.TabIndex = 0;
            this.tabSession.Text = "Session";
            this.tabSession.UseVisualStyleBackColor = true;
            // 
            // SessionToolStrip
            // 
            this.SessionToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SessionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAddRequest2,
            this.tbEditRequest2,
            this.tbDeleteRequest2,
            this.toolStripSeparator11,
            this.tbCapture,
            this.tbSaveAllRequests2,
            this.tbEditFile});
            this.SessionToolStrip.Location = new System.Drawing.Point(0, 0);
            this.SessionToolStrip.Name = "SessionToolStrip";
            this.SessionToolStrip.Size = new System.Drawing.Size(421, 27);
            this.SessionToolStrip.TabIndex = 5;
            // 
            // tbAddRequest2
            // 
            this.tbAddRequest2.Image = ((System.Drawing.Image)(resources.GetObject("tbAddRequest2.Image")));
            this.tbAddRequest2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddRequest2.Name = "tbAddRequest2";
            this.tbAddRequest2.Size = new System.Drawing.Size(59, 24);
            this.tbAddRequest2.Text = "New";
            this.tbAddRequest2.ToolTipText = "Create a new request";
            this.tbAddRequest2.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbEditRequest2
            // 
            this.tbEditRequest2.Image = ((System.Drawing.Image)(resources.GetObject("tbEditRequest2.Image")));
            this.tbEditRequest2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEditRequest2.Name = "tbEditRequest2";
            this.tbEditRequest2.Size = new System.Drawing.Size(55, 24);
            this.tbEditRequest2.Text = "Edit";
            this.tbEditRequest2.ToolTipText = "Edit selected request";
            this.tbEditRequest2.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbDeleteRequest2
            // 
            this.tbDeleteRequest2.Image = ((System.Drawing.Image)(resources.GetObject("tbDeleteRequest2.Image")));
            this.tbDeleteRequest2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDeleteRequest2.Name = "tbDeleteRequest2";
            this.tbDeleteRequest2.Size = new System.Drawing.Size(73, 24);
            this.tbDeleteRequest2.Text = "Delete";
            this.tbDeleteRequest2.ToolTipText = "Delete selected requests";
            this.tbDeleteRequest2.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 27);
            // 
            // tbCapture
            // 
            this.tbCapture.Image = ((System.Drawing.Image)(resources.GetObject("tbCapture.Image")));
            this.tbCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCapture.Name = "tbCapture";
            this.tbCapture.Size = new System.Drawing.Size(81, 24);
            this.tbCapture.Text = "Capture";
            this.tbCapture.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbSaveAllRequests2
            // 
            this.tbSaveAllRequests2.Image = ((System.Drawing.Image)(resources.GetObject("tbSaveAllRequests2.Image")));
            this.tbSaveAllRequests2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSaveAllRequests2.Name = "tbSaveAllRequests2";
            this.tbSaveAllRequests2.Size = new System.Drawing.Size(60, 24);
            this.tbSaveAllRequests2.Text = "Save";
            this.tbSaveAllRequests2.ToolTipText = "Save session to disk";
            this.tbSaveAllRequests2.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbEditFile
            // 
            this.tbEditFile.Image = ((System.Drawing.Image)(resources.GetObject("tbEditFile.Image")));
            this.tbEditFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEditFile.Name = "tbEditFile";
            this.tbEditFile.Size = new System.Drawing.Size(55, 24);
            this.tbEditFile.Text = "Edit";
            this.tbEditFile.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // ListRequests
            // 
            this.ListRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader2});
            this.ListRequests.ContextMenuStrip = this.RequestContextMenu;
            this.ListRequests.FullRowSelect = true;
            this.ListRequests.GridLines = true;
            this.ListRequests.HideSelection = false;
            this.ListRequests.Location = new System.Drawing.Point(0, 0);
            this.ListRequests.Margin = new System.Windows.Forms.Padding(0);
            this.ListRequests.Name = "ListRequests";
            this.ListRequests.ShowItemToolTips = true;
            this.ListRequests.Size = new System.Drawing.Size(423, 520);
            this.ListRequests.SmallImageList = this.Images;
            this.ListRequests.TabIndex = 4;
            this.ListRequests.UseCompatibleStateImageBehavior = false;
            this.ListRequests.View = System.Windows.Forms.View.Details;
            this.ListRequests.VirtualListSize = 50;
            this.ListRequests.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListRequests_ItemSelectionChanged);
            this.ListRequests.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListRequests_KeyUp);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Verb";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Url";
            this.columnHeader2.Width = 480;
            // 
            // RequestContextMenu
            // 
            this.RequestContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAddRequest,
            this.toolStripSeparator8,
            this.tbEditRequest,
            this.tbRunRequest,
            this.tbDeleteRequest,
            this.toolStripSeparator6,
            this.tbSaveAllRequests});
            this.RequestContextMenu.Name = "RequestContextMenu";
            this.RequestContextMenu.Size = new System.Drawing.Size(208, 136);
            this.RequestContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbAddRequest
            // 
            this.tbAddRequest.Name = "tbAddRequest";
            this.tbAddRequest.Size = new System.Drawing.Size(207, 24);
            this.tbAddRequest.Text = "&New Request";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(204, 6);
            // 
            // tbEditRequest
            // 
            this.tbEditRequest.Name = "tbEditRequest";
            this.tbEditRequest.Size = new System.Drawing.Size(207, 24);
            this.tbEditRequest.Text = "Edit Request";
            // 
            // tbRunRequest
            // 
            this.tbRunRequest.Name = "tbRunRequest";
            this.tbRunRequest.Size = new System.Drawing.Size(207, 24);
            this.tbRunRequest.Text = "Test Request";
            // 
            // tbDeleteRequest
            // 
            this.tbDeleteRequest.Name = "tbDeleteRequest";
            this.tbDeleteRequest.Size = new System.Drawing.Size(207, 24);
            this.tbDeleteRequest.Text = "Delete Request";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(204, 6);
            // 
            // tbSaveAllRequests
            // 
            this.tbSaveAllRequests.Name = "tbSaveAllRequests";
            this.tbSaveAllRequests.Size = new System.Drawing.Size(207, 24);
            this.tbSaveAllRequests.Text = "&Save Session to File";
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "ok");
            this.Images.Images.SetKeyName(1, "error");
            this.Images.Images.SetKeyName(2, "download");
            this.Images.Images.SetKeyName(3, "upload");
            this.Images.Images.SetKeyName(4, "accessdenied");
            this.Images.Images.SetKeyName(5, "notfound");
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.ListResults);
            this.tabResults.Controls.Add(this.lblRequestCount);
            this.tabResults.Controls.Add(this.cmbListDisplayMode);
            this.tabResults.Location = new System.Drawing.Point(4, 25);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(421, 535);
            this.tabResults.TabIndex = 1;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // ListResults
            // 
            this.ListResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Status,
            this.Request,
            this.ErrorMessage});
            this.ListResults.ContextMenuStrip = this.ResultContextMenu;
            this.ListResults.FullRowSelect = true;
            this.ListResults.GridLines = true;
            this.ListResults.HideSelection = false;
            this.ListResults.Location = new System.Drawing.Point(-1, 37);
            this.ListResults.Name = "ListResults";
            this.ListResults.ShowItemToolTips = true;
            this.ListResults.Size = new System.Drawing.Size(423, 515);
            this.ListResults.SmallImageList = this.Images;
            this.ListResults.TabIndex = 3;
            this.ListResults.UseCompatibleStateImageBehavior = false;
            this.ListResults.View = System.Windows.Forms.View.Details;
            this.ListResults.VirtualListSize = 50;
            this.ListResults.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListResults_ItemSelectionChanged);
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // Request
            // 
            this.Request.Text = "Request";
            this.Request.Width = 356;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.Width = 209;
            // 
            // ResultContextMenu
            // 
            this.ResultContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbResultCharts,
            this.tbImportWebSurgeResults});
            this.ResultContextMenu.Name = "ResultContextMenu";
            this.ResultContextMenu.Size = new System.Drawing.Size(247, 52);
            this.ResultContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbResultCharts
            // 
            this.tbResultCharts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRequestsPerSecondChart,
            this.toolStripSeparator9,
            this.tbTimeTakenPerUrl});
            this.tbResultCharts.Name = "tbResultCharts";
            this.tbResultCharts.Size = new System.Drawing.Size(246, 24);
            this.tbResultCharts.Text = "Charts";
            this.tbResultCharts.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbRequestsPerSecondChart
            // 
            this.tbRequestsPerSecondChart.Name = "tbRequestsPerSecondChart";
            this.tbRequestsPerSecondChart.Size = new System.Drawing.Size(216, 24);
            this.tbRequestsPerSecondChart.Text = "Requests per Second";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(213, 6);
            // 
            // tbTimeTakenPerUrl
            // 
            this.tbTimeTakenPerUrl.Name = "tbTimeTakenPerUrl";
            this.tbTimeTakenPerUrl.Size = new System.Drawing.Size(216, 24);
            this.tbTimeTakenPerUrl.Text = "Time Taken per URL";
            // 
            // tbImportWebSurgeResults
            // 
            this.tbImportWebSurgeResults.Enabled = false;
            this.tbImportWebSurgeResults.Name = "tbImportWebSurgeResults";
            this.tbImportWebSurgeResults.Size = new System.Drawing.Size(246, 24);
            this.tbImportWebSurgeResults.Text = "Import WebSurge Results";
            // 
            // lblRequestCount
            // 
            this.lblRequestCount.AutoSize = true;
            this.lblRequestCount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblRequestCount.Location = new System.Drawing.Point(181, 12);
            this.lblRequestCount.Name = "lblRequestCount";
            this.lblRequestCount.Size = new System.Drawing.Size(109, 19);
            this.lblRequestCount.TabIndex = 5;
            this.lblRequestCount.Text = "1000 items max";
            // 
            // cmbListDisplayMode
            // 
            this.cmbListDisplayMode.FormattingEnabled = true;
            this.cmbListDisplayMode.Items.AddRange(new object[] {
            "All",
            "Success",
            "Errors"});
            this.cmbListDisplayMode.Location = new System.Drawing.Point(8, 8);
            this.cmbListDisplayMode.Name = "cmbListDisplayMode";
            this.cmbListDisplayMode.Size = new System.Drawing.Size(167, 28);
            this.cmbListDisplayMode.TabIndex = 4;
            this.cmbListDisplayMode.SelectedIndexChanged += new System.EventHandler(this.cmbListDisplayMode_SelectedIndexChanged);
            // 
            // TabsResult
            // 
            this.TabsResult.Controls.Add(this.tabOutput);
            this.TabsResult.Controls.Add(this.tabPreview);
            this.TabsResult.Controls.Add(this.tabRequest);
            this.TabsResult.Controls.Add(this.tabOptions);
            this.TabsResult.Controls.Add(this.tabPerfMon);
            this.TabsResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsResult.ItemSize = new System.Drawing.Size(90, 22);
            this.TabsResult.Location = new System.Drawing.Point(0, 0);
            this.TabsResult.Margin = new System.Windows.Forms.Padding(0);
            this.TabsResult.Name = "TabsResult";
            this.TabsResult.Padding = new System.Drawing.Point(0, 0);
            this.TabsResult.SelectedIndex = 0;
            this.TabsResult.Size = new System.Drawing.Size(559, 566);
            this.TabsResult.TabIndex = 1;
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.TestResultBrowser);
            this.tabOutput.Controls.Add(this.txtConsole);
            this.tabOutput.Location = new System.Drawing.Point(4, 26);
            this.tabOutput.Margin = new System.Windows.Forms.Padding(0);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Size = new System.Drawing.Size(551, 536);
            this.tabOutput.TabIndex = 0;
            this.tabOutput.Text = "Output";
            // 
            // TestResultBrowser
            // 
            this.TestResultBrowser.ContextMenuStrip = this.BrowserContextMenu;
            this.TestResultBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestResultBrowser.IsWebBrowserContextMenuEnabled = false;
            this.TestResultBrowser.Location = new System.Drawing.Point(0, 0);
            this.TestResultBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TestResultBrowser.Name = "TestResultBrowser";
            this.TestResultBrowser.Size = new System.Drawing.Size(551, 536);
            this.TestResultBrowser.TabIndex = 3;
            this.TestResultBrowser.Visible = false;
            // 
            // BrowserContextMenu
            // 
            this.BrowserContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenInDefaultBrowser});
            this.BrowserContextMenu.Name = "BrowserContextMenu";
            this.BrowserContextMenu.Size = new System.Drawing.Size(274, 28);
            // 
            // btnOpenInDefaultBrowser
            // 
            this.btnOpenInDefaultBrowser.Name = "btnOpenInDefaultBrowser";
            this.btnOpenInDefaultBrowser.Size = new System.Drawing.Size(273, 24);
            this.btnOpenInDefaultBrowser.Text = "Open in default Web Browser";
            this.btnOpenInDefaultBrowser.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(0);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(551, 536);
            this.txtConsole.TabIndex = 2;
            this.txtConsole.WordWrap = false;
            // 
            // tabPreview
            // 
            this.tabPreview.Controls.Add(this.PreViewBrowser);
            this.tabPreview.Location = new System.Drawing.Point(4, 26);
            this.tabPreview.Margin = new System.Windows.Forms.Padding(0);
            this.tabPreview.Name = "tabPreview";
            this.tabPreview.Size = new System.Drawing.Size(551, 534);
            this.tabPreview.TabIndex = 1;
            this.tabPreview.Text = "Preview";
            this.tabPreview.UseVisualStyleBackColor = true;
            // 
            // PreViewBrowser
            // 
            this.PreViewBrowser.ContextMenuStrip = this.BrowserContextMenu;
            this.PreViewBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreViewBrowser.IsWebBrowserContextMenuEnabled = false;
            this.PreViewBrowser.Location = new System.Drawing.Point(0, 0);
            this.PreViewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.PreViewBrowser.Name = "PreViewBrowser";
            this.PreViewBrowser.ScriptErrorsSuppressed = true;
            this.PreViewBrowser.Size = new System.Drawing.Size(551, 534);
            this.PreViewBrowser.TabIndex = 2;
            this.PreViewBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.PreViewBrowser_Navigating);
            this.PreViewBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.PreViewBrowser_NewWindow);
            // 
            // tabRequest
            // 
            this.tabRequest.Controls.Add(this.btnRunRequest);
            this.tabRequest.Controls.Add(this.lblRequestContent);
            this.tabRequest.Controls.Add(this.txtRequestContent);
            this.tabRequest.Controls.Add(this.btnSaveRequest);
            this.tabRequest.Controls.Add(this.label2);
            this.tabRequest.Controls.Add(this.txtRequestHeaders);
            this.tabRequest.Controls.Add(this.txtRequestUrl);
            this.tabRequest.Controls.Add(this.lblUrl);
            this.tabRequest.Controls.Add(this.txtHttpMethod);
            this.tabRequest.Location = new System.Drawing.Point(4, 26);
            this.tabRequest.Name = "tabRequest";
            this.tabRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequest.Size = new System.Drawing.Size(551, 534);
            this.tabRequest.TabIndex = 3;
            this.tabRequest.Text = "Request";
            this.tabRequest.UseVisualStyleBackColor = true;
            // 
            // btnRunRequest
            // 
            this.btnRunRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRunRequest.Location = new System.Drawing.Point(88, 517);
            this.btnRunRequest.Name = "btnRunRequest";
            this.btnRunRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRunRequest.TabIndex = 8;
            this.btnRunRequest.Text = "Test";
            this.btnRunRequest.UseVisualStyleBackColor = true;
            this.btnRunRequest.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // lblRequestContent
            // 
            this.lblRequestContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRequestContent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRequestContent.Location = new System.Drawing.Point(6, 405);
            this.lblRequestContent.Name = "lblRequestContent";
            this.lblRequestContent.Size = new System.Drawing.Size(130, 20);
            this.lblRequestContent.TabIndex = 7;
            this.lblRequestContent.Text = "Content:";
            this.lblRequestContent.UseCompatibleTextRendering = true;
            // 
            // txtRequestContent
            // 
            this.txtRequestContent.AcceptsReturn = true;
            this.txtRequestContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestContent.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestContent.Location = new System.Drawing.Point(7, 428);
            this.txtRequestContent.Multiline = true;
            this.txtRequestContent.Name = "txtRequestContent";
            this.txtRequestContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequestContent.Size = new System.Drawing.Size(538, 79);
            this.txtRequestContent.TabIndex = 6;
            // 
            // btnSaveRequest
            // 
            this.btnSaveRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveRequest.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveRequest.Location = new System.Drawing.Point(7, 517);
            this.btnSaveRequest.Name = "btnSaveRequest";
            this.btnSaveRequest.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRequest.TabIndex = 5;
            this.btnSaveRequest.Text = "&Save";
            this.btnSaveRequest.UseVisualStyleBackColor = false;
            this.btnSaveRequest.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Headers:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtRequestHeaders
            // 
            this.txtRequestHeaders.AcceptsReturn = true;
            this.txtRequestHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestHeaders.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestHeaders.Location = new System.Drawing.Point(6, 115);
            this.txtRequestHeaders.Multiline = true;
            this.txtRequestHeaders.Name = "txtRequestHeaders";
            this.txtRequestHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequestHeaders.Size = new System.Drawing.Size(538, 287);
            this.txtRequestHeaders.TabIndex = 3;
            // 
            // txtRequestUrl
            // 
            this.txtRequestUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestUrl.Location = new System.Drawing.Point(6, 60);
            this.txtRequestUrl.Name = "txtRequestUrl";
            this.txtRequestUrl.Size = new System.Drawing.Size(537, 27);
            this.txtRequestUrl.TabIndex = 2;
            // 
            // lblUrl
            // 
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUrl.Location = new System.Drawing.Point(3, 40);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(45, 20);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = " Url:";
            this.lblUrl.UseCompatibleTextRendering = true;
            // 
            // txtHttpMethod
            // 
            this.txtHttpMethod.FormattingEnabled = true;
            this.txtHttpMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "HEAD",
            "TRACE",
            "OPTIONS",
            "PATCH"});
            this.txtHttpMethod.Location = new System.Drawing.Point(6, 10);
            this.txtHttpMethod.Name = "txtHttpMethod";
            this.txtHttpMethod.Size = new System.Drawing.Size(152, 28);
            this.txtHttpMethod.TabIndex = 0;
            this.txtHttpMethod.Text = "GET";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.OptionsPropertyGrid);
            this.tabOptions.Location = new System.Drawing.Point(4, 26);
            this.tabOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(551, 534);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // OptionsPropertyGrid
            // 
            this.OptionsPropertyGrid.BackColor = System.Drawing.Color.White;
            this.OptionsPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsPropertyGrid.HelpBackColor = System.Drawing.Color.White;
            this.OptionsPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.OptionsPropertyGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OptionsPropertyGrid.Name = "OptionsPropertyGrid";
            this.OptionsPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.OptionsPropertyGrid.Size = new System.Drawing.Size(551, 534);
            this.OptionsPropertyGrid.TabIndex = 1;
            this.OptionsPropertyGrid.ToolbarVisible = false;
            // 
            // tabPerfMon
            // 
            this.tabPerfMon.Controls.Add(this.button1);
            this.tabPerfMon.Controls.Add(this.chart1);
            this.tabPerfMon.Location = new System.Drawing.Point(4, 26);
            this.tabPerfMon.Name = "tabPerfMon";
            this.tabPerfMon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerfMon.Size = new System.Drawing.Size(551, 534);
            this.tabPerfMon.TabIndex = 4;
            this.tabPerfMon.Text = "Perf Mon";
            this.tabPerfMon.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(57, 114);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sessionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 27);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(992, 28);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnRecentSessions,
            this.btnEditFile,
            this.btnClose,
            this.toolStripSeparator10,
            this.btnCapture,
            this.toolStripSeparator2,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(184, 24);
            this.btnOpen.Text = "&Open Session";
            this.btnOpen.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnRecentSessions
            // 
            this.btnRecentSessions.DropDown = this.RecentFilesContextMenu;
            this.btnRecentSessions.Name = "btnRecentSessions";
            this.btnRecentSessions.Size = new System.Drawing.Size(184, 24);
            this.btnRecentSessions.Text = "Recent Sessions";
            // 
            // RecentFilesContextMenu
            // 
            this.RecentFilesContextMenu.Name = "RecentFilesContextMenu";
            this.RecentFilesContextMenu.OwnerItem = this.tbOpen;
            this.RecentFilesContextMenu.Size = new System.Drawing.Size(61, 4);
            this.RecentFilesContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.AddRecentFiles);
            // 
            // btnEditFile
            // 
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.Size = new System.Drawing.Size(184, 24);
            this.btnEditFile.Text = "&Edit Session File";
            this.btnEditFile.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(184, 24);
            this.btnClose.Text = "C&lose Session";
            this.btnClose.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(181, 6);
            // 
            // btnCapture
            // 
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(184, 24);
            this.btnCapture.Text = "&Capture Session";
            this.btnCapture.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            this.toolStripSeparator2.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 24);
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart,
            this.btnStop,
            this.toolStripSeparator14,
            this.btnExport,
            this.btnCharts});
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // btnStart
            // 
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 24);
            this.btnStart.Text = "&Start";
            this.btnStart.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnStop
            // 
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 24);
            this.btnStop.Text = "S&top";
            this.btnStop.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(118, 6);
            // 
            // btnExport
            // 
            this.btnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportXml,
            this.btnExportJson,
            this.btnExportHtml});
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(121, 24);
            this.btnExport.Text = "E&xport";
            // 
            // btnExportXml
            // 
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(111, 24);
            this.btnExportXml.Text = "Xml";
            this.btnExportXml.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(111, 24);
            this.btnExportJson.Text = "Json";
            this.btnExportJson.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnExportHtml
            // 
            this.btnExportHtml.Name = "btnExportHtml";
            this.btnExportHtml.Size = new System.Drawing.Size(111, 24);
            this.btnExportHtml.Text = "Html";
            this.btnExportHtml.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnCharts
            // 
            this.btnCharts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRequestsPerSecondChart,
            this.btnTimeTakenPerUrlChart});
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(121, 24);
            this.btnCharts.Text = "Charts";
            this.btnCharts.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // btnRequestsPerSecondChart
            // 
            this.btnRequestsPerSecondChart.Name = "btnRequestsPerSecondChart";
            this.btnRequestsPerSecondChart.Size = new System.Drawing.Size(216, 24);
            this.btnRequestsPerSecondChart.Text = "Requests per Second";
            // 
            // btnTimeTakenPerUrlChart
            // 
            this.btnTimeTakenPerUrlChart.Name = "btnTimeTakenPerUrlChart";
            this.btnTimeTakenPerUrlChart.Size = new System.Drawing.Size(216, 24);
            this.btnTimeTakenPerUrlChart.Text = "Time taken per URL";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelp,
            this.btnHelpIndex,
            this.toolStripSeparator7,
            this.btnGotoRegistration,
            this.btnRegistration,
            this.toolStripSeparator12,
            this.btnFeedback,
            this.btnBugReport,
            this.btnShowErrorLog,
            this.btnGotoSettingsFolder,
            this.toolStripSeparator13,
            this.btnGotoWebSite,
            this.btnCheckForNewVersion,
            this.toolStripSeparator4,
            this.btnAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.ShortcutKeyDisplayString = "F1";
            this.btnHelp.Size = new System.Drawing.Size(320, 24);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnHelpIndex
            // 
            this.btnHelpIndex.Name = "btnHelpIndex";
            this.btnHelpIndex.Size = new System.Drawing.Size(320, 24);
            this.btnHelpIndex.Text = "Index";
            this.btnHelpIndex.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(317, 6);
            // 
            // btnGotoRegistration
            // 
            this.btnGotoRegistration.Name = "btnGotoRegistration";
            this.btnGotoRegistration.Size = new System.Drawing.Size(320, 24);
            this.btnGotoRegistration.Text = "Register WebSurge";
            this.btnGotoRegistration.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(320, 24);
            this.btnRegistration.Text = "Enter Registration Key";
            this.btnRegistration.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(317, 6);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(320, 24);
            this.btnFeedback.Text = "Feedback and Suggestions";
            this.btnFeedback.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnBugReport
            // 
            this.btnBugReport.Name = "btnBugReport";
            this.btnBugReport.Size = new System.Drawing.Size(320, 24);
            this.btnBugReport.Text = "Report a Bug";
            this.btnBugReport.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnShowErrorLog
            // 
            this.btnShowErrorLog.Name = "btnShowErrorLog";
            this.btnShowErrorLog.Size = new System.Drawing.Size(320, 24);
            this.btnShowErrorLog.Text = "Show Error Log";
            this.btnShowErrorLog.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnGotoSettingsFolder
            // 
            this.btnGotoSettingsFolder.Name = "btnGotoSettingsFolder";
            this.btnGotoSettingsFolder.Size = new System.Drawing.Size(320, 24);
            this.btnGotoSettingsFolder.Text = "Go to Settings and Templates Folder";
            this.btnGotoSettingsFolder.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(317, 6);
            // 
            // btnGotoWebSite
            // 
            this.btnGotoWebSite.Name = "btnGotoWebSite";
            this.btnGotoWebSite.Size = new System.Drawing.Size(320, 24);
            this.btnGotoWebSite.Text = "WebSurge Web Site";
            this.btnGotoWebSite.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // btnCheckForNewVersion
            // 
            this.btnCheckForNewVersion.Name = "btnCheckForNewVersion";
            this.btnCheckForNewVersion.Size = new System.Drawing.Size(320, 24);
            this.btnCheckForNewVersion.Text = "Check for new Version";
            this.btnCheckForNewVersion.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(317, 6);
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(320, 24);
            this.btnAbout.Text = "&About";
            this.btnAbout.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbOpen,
            this.toolStripSeparator1,
            this.tbStart,
            this.tbStop,
            this.toolStripSeparator3,
            this.tbExport,
            this.tbCharts});
            this.MainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainToolStrip.Location = new System.Drawing.Point(3, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(490, 27);
            this.MainToolStrip.TabIndex = 0;
            // 
            // tbOpen
            // 
            this.tbOpen.DropDown = this.RecentFilesContextMenu;
            this.tbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbOpen.Image")));
            this.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(130, 24);
            this.tbOpen.Text = "Open Session";
            this.tbOpen.ButtonClick += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbStart
            // 
            this.tbStart.Image = ((System.Drawing.Image)(resources.GetObject("tbStart.Image")));
            this.tbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(60, 24);
            this.tbStart.Text = "Start";
            this.tbStart.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbStop
            // 
            this.tbStop.Image = ((System.Drawing.Image)(resources.GetObject("tbStop.Image")));
            this.tbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(60, 24);
            this.tbStop.Text = "Stop";
            this.tbStop.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tbExport
            // 
            this.tbExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbExportRaw,
            this.tbExportJson,
            this.tbExportXml});
            this.tbExport.Image = ((System.Drawing.Image)(resources.GetObject("tbExport.Image")));
            this.tbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExport.Name = "tbExport";
            this.tbExport.Size = new System.Drawing.Size(134, 24);
            this.tbExport.Text = "Export Results";
            // 
            // tbExportRaw
            // 
            this.tbExportRaw.Name = "tbExportRaw";
            this.tbExportRaw.Size = new System.Drawing.Size(147, 24);
            this.tbExportRaw.Text = "WebSurge";
            this.tbExportRaw.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbExportJson
            // 
            this.tbExportJson.Name = "tbExportJson";
            this.tbExportJson.Size = new System.Drawing.Size(147, 24);
            this.tbExportJson.Text = "Json";
            this.tbExportJson.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbExportXml
            // 
            this.tbExportXml.Name = "tbExportXml";
            this.tbExportXml.Size = new System.Drawing.Size(147, 24);
            this.tbExportXml.Text = "Xml";
            this.tbExportXml.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbCharts
            // 
            this.tbCharts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRequestPerSecondChart,
            this.tbTimeTakenPerUrlChart});
            this.tbCharts.Image = ((System.Drawing.Image)(resources.GetObject("tbCharts.Image")));
            this.tbCharts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCharts.Name = "tbCharts";
            this.tbCharts.Size = new System.Drawing.Size(82, 24);
            this.tbCharts.Text = "Charts";
            this.tbCharts.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbRequestPerSecondChart
            // 
            this.tbRequestPerSecondChart.Name = "tbRequestPerSecondChart";
            this.tbRequestPerSecondChart.Size = new System.Drawing.Size(216, 24);
            this.tbRequestPerSecondChart.Text = "Requests per Second";
            this.tbRequestPerSecondChart.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClickedToButtonHandler_Click);
            // 
            // tbTimeTakenPerUrlChart
            // 
            this.tbTimeTakenPerUrlChart.Name = "tbTimeTakenPerUrlChart";
            this.tbTimeTakenPerUrlChart.Size = new System.Drawing.Size(216, 24);
            this.tbTimeTakenPerUrlChart.Text = "Time taken per URL";
            // 
            // OptionsToolStrip
            // 
            this.OptionsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.OptionsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tbtxtTimeToRun,
            this.toolStripLabel3,
            this.lblTbThreads,
            this.tbtxtThreads,
            this.toolStripSeparator5,
            this.tbNoProgressEvents});
            this.OptionsToolStrip.Location = new System.Drawing.Point(3, 55);
            this.OptionsToolStrip.Name = "OptionsToolStrip";
            this.OptionsToolStrip.Size = new System.Drawing.Size(272, 27);
            this.OptionsToolStrip.TabIndex = 2;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 24);
            this.toolStripLabel2.Text = "Time:";
            // 
            // tbtxtTimeToRun
            // 
            this.tbtxtTimeToRun.Name = "tbtxtTimeToRun";
            this.tbtxtTimeToRun.Size = new System.Drawing.Size(40, 27);
            this.tbtxtTimeToRun.Text = "30";
            this.tbtxtTimeToRun.ToolTipText = "Duration of the test to run in seconds.";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(48, 24);
            this.toolStripLabel3.Text = "secs   ";
            // 
            // lblTbThreads
            // 
            this.lblTbThreads.Name = "lblTbThreads";
            this.lblTbThreads.Size = new System.Drawing.Size(64, 24);
            this.lblTbThreads.Text = "Threads:";
            // 
            // tbtxtThreads
            // 
            this.tbtxtThreads.Name = "tbtxtThreads";
            this.tbtxtThreads.Size = new System.Drawing.Size(30, 27);
            this.tbtxtThreads.Text = "2";
            this.tbtxtThreads.ToolTipText = "The number of sessions to run simultaneously";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tbNoProgressEvents
            // 
            this.tbNoProgressEvents.CheckOnClick = true;
            this.tbNoProgressEvents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNoProgressEvents.Image = ((System.Drawing.Image)(resources.GetObject("tbNoProgressEvents.Image")));
            this.tbNoProgressEvents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNoProgressEvents.Name = "tbNoProgressEvents";
            this.tbNoProgressEvents.Size = new System.Drawing.Size(23, 24);
            this.tbNoProgressEvents.Text = "No Console";
            this.tbNoProgressEvents.ToolTipText = "Don\'t show progress info - faster, can create more requests.";
            this.tbNoProgressEvents.CheckedChanged += new System.EventHandler(this.tbNoProgressEvents_CheckedChanged);
            // 
            // Help
            // 
            this.Help.HelpNamespace = "WebSurge.chm";
            // 
            // StressTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 673);
            this.Controls.Add(this.toolStripContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Help.SetHelpKeyword(this, "_435016xwo.htm");
            this.Help.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "StressTestForm";
            this.Help.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "West Wind WebSurge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StressTestForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StressTestForm_FormClosed);
            this.Load += new System.EventHandler(this.StressTestForm_Load);
            this.Shown += new System.EventHandler(this.StressTestForm_Shown);
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.BottomSplitContainer.Panel1.ResumeLayout(false);
            this.BottomSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottomSplitContainer)).EndInit();
            this.BottomSplitContainer.ResumeLayout(false);
            this.TabSessions.ResumeLayout(false);
            this.tabSession.ResumeLayout(false);
            this.tabSession.PerformLayout();
            this.SessionToolStrip.ResumeLayout(false);
            this.SessionToolStrip.PerformLayout();
            this.RequestContextMenu.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            this.tabResults.PerformLayout();
            this.ResultContextMenu.ResumeLayout(false);
            this.TabsResult.ResumeLayout(false);
            this.tabOutput.ResumeLayout(false);
            this.tabOutput.PerformLayout();
            this.BrowserContextMenu.ResumeLayout(false);
            this.tabPreview.ResumeLayout(false);
            this.tabRequest.ResumeLayout(false);
            this.tabRequest.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabPerfMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.OptionsToolStrip.ResumeLayout(false);
            this.OptionsToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusText;
        //private System.Windows.Forms.SplitContainer HorizontalSplitContainer;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel txtProcessingTime;
        public System.Windows.Forms.SplitContainer BottomSplitContainer;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusFilename;
        private System.Windows.Forms.TabControl TabsResult;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.TabPage tabPreview;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.WebBrowser PreViewBrowser;
        private System.Windows.Forms.ToolStripButton tbCapture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbStart;
        private System.Windows.Forms.ToolStripButton tbStop;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnEditFile;
        private System.Windows.Forms.ToolStripMenuItem btnCapture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnStart;
        private System.Windows.Forms.ToolStripMenuItem btnStop;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ToolStripMenuItem btnExportXml;
        private System.Windows.Forms.ToolStripMenuItem btnExportJson;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton tbExport;
        private System.Windows.Forms.ToolStripMenuItem tbExportXml;
        private System.Windows.Forms.ToolStripMenuItem tbExportJson;
        private System.Windows.Forms.ToolStripMenuItem btnGotoWebSite;
        private System.Windows.Forms.ToolStripMenuItem btnGotoRegistration;
        private System.Windows.Forms.ToolStripMenuItem btnRegistration;
        private System.Windows.Forms.ToolStripMenuItem btnExportHtml;
        private System.Windows.Forms.ToolStripMenuItem tbExportRaw;
        private System.Windows.Forms.ToolStrip OptionsToolStrip;
        private System.Windows.Forms.ToolStripLabel lblTbThreads;
        private System.Windows.Forms.ToolStripTextBox tbtxtThreads;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbtxtTimeToRun;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tbNoProgressEvents;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.PropertyGrid OptionsPropertyGrid;
        private System.Windows.Forms.TabControl TabSessions;
        private System.Windows.Forms.TabPage tabSession;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.ListView ListResults;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Request;
        private System.Windows.Forms.ColumnHeader ErrorMessage;
        private System.Windows.Forms.Label lblRequestCount;
        private System.Windows.Forms.ComboBox cmbListDisplayMode;
        private System.Windows.Forms.ListView ListRequests;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip RequestContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tbDeleteRequest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tbSaveAllRequests;
        private System.Windows.Forms.ToolStripMenuItem tbAddRequest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ContextMenuStrip ResultContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tbResultCharts;
        private System.Windows.Forms.ToolStripMenuItem tbRequestsPerSecondChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tbTimeTakenPerUrl;
        private System.Windows.Forms.ToolStripMenuItem btnCharts;
        private System.Windows.Forms.ToolStripMenuItem btnRequestsPerSecondChart;
        private System.Windows.Forms.ToolStripMenuItem btnTimeTakenPerUrlChart;
        private System.Windows.Forms.ToolStripSplitButton tbCharts;
        private System.Windows.Forms.ToolStripMenuItem tbRequestPerSecondChart;
        private System.Windows.Forms.ToolStripMenuItem tbTimeTakenPerUrlChart;
        private System.Windows.Forms.TabPage tabRequest;
        private System.Windows.Forms.Button btnSaveRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequestHeaders;
        private System.Windows.Forms.TextBox txtRequestUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.ComboBox txtHttpMethod;
        private System.Windows.Forms.ToolStripMenuItem tbEditRequest;
        private System.Windows.Forms.Label lblRequestContent;
        private System.Windows.Forms.TextBox txtRequestContent;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStrip SessionToolStrip;
        private System.Windows.Forms.ToolStripButton tbAddRequest2;
        private System.Windows.Forms.ToolStripButton tbEditRequest2;
        private System.Windows.Forms.ToolStripButton tbDeleteRequest2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tbSaveAllRequests2;
        private System.Windows.Forms.ToolStripMenuItem btnRecentSessions;
        private System.Windows.Forms.ContextMenuStrip RecentFilesContextMenu;
        private System.Windows.Forms.ToolStripButton tbEditFile;
        private System.Windows.Forms.ToolStripSplitButton tbOpen;
        private System.Windows.Forms.Button btnRunRequest;
        private System.Windows.Forms.ToolStripMenuItem tbRunRequest;
        private System.Windows.Forms.HelpProvider Help;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem btnHelpIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem btnFeedback;
        private System.Windows.Forms.ToolStripMenuItem btnBugReport;
        private System.Windows.Forms.ToolStripMenuItem btnShowErrorLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem btnCheckForNewVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.WebBrowser TestResultBrowser;
        private System.Windows.Forms.ToolStripMenuItem btnGotoSettingsFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ContextMenuStrip BrowserContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnOpenInDefaultBrowser;
        private System.Windows.Forms.ToolStripMenuItem tbImportWebSurgeResults;
        private System.Windows.Forms.TabPage tabPerfMon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}

