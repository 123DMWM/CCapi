namespace CCapi {
	partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bSkinDownload = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbRegistered = new MetroFramework.Controls.MetroTextBox();
            this.cbUTC = new MetroFramework.Controls.MetroCheckBox();
            this.dtpRegistered = new MetroFramework.Controls.MetroDateTime();
            this.bRawPlayer = new MetroFramework.Controls.MetroButton();
            this.lRegistered = new MetroFramework.Controls.MetroLabel();
            this.lID = new MetroFramework.Controls.MetroLabel();
            this.lUserName = new MetroFramework.Controls.MetroLabel();
            this.bIDLookup = new MetroFramework.Controls.MetroButton();
            this.tbUserName = new MetroFramework.Controls.MetroTextBox();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.bLookup = new MetroFramework.Controls.MetroButton();
            this.tBSearch = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbForumTitle = new MetroFramework.Controls.MetroTextBox();
            this.lForumTitle = new MetroFramework.Controls.MetroLabel();
            this.tbFlags = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bRawLast5 = new MetroFramework.Controls.MetroButton();
            this.tbLast5 = new MetroFramework.Controls.MetroTextBox();
            this.lTotal = new MetroFramework.Controls.MetroLabel();
            this.tbTotal = new MetroFramework.Controls.MetroTextBox();
            this.bRefreshLast5 = new MetroFramework.Controls.MetroButton();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pbCountry = new System.Windows.Forms.PictureBox();
            this.tbFeatured = new MetroFramework.Controls.MetroTextBox();
            this.lFeatured = new MetroFramework.Controls.MetroLabel();
            this.tbCountry = new MetroFramework.Controls.MetroTextBox();
            this.lCountry = new MetroFramework.Controls.MetroLabel();
            this.tbUptime = new MetroFramework.Controls.MetroTextBox();
            this.lUptime = new MetroFramework.Controls.MetroLabel();
            this.bRefreshServers = new MetroFramework.Controls.MetroButton();
            this.bRawServer = new MetroFramework.Controls.MetroButton();
            this.bOpenHash = new MetroFramework.Controls.MetroButton();
            this.tbSoftware = new MetroFramework.Controls.MetroTextBox();
            this.lHash = new MetroFramework.Controls.MetroLabel();
            this.lSoftware = new MetroFramework.Controls.MetroLabel();
            this.tbHash = new MetroFramework.Controls.MetroTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbServer = new MetroFramework.Controls.MetroComboBox();
            this.lPlayers = new MetroFramework.Controls.MetroLabel();
            this.tbPlayers = new MetroFramework.Controls.MetroTextBox();
            this.lof = new MetroFramework.Controls.MetroLabel();
            this.txMaxPlayers = new MetroFramework.Controls.MetroTextBox();
            this.lServer = new MetroFramework.Controls.MetroLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(4, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(594, 290);
            this.tabs.TabIndex = 1;
            this.tabs.UseSelectable = true;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_Change);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bSkinDownload);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(443, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 175);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Skin";
            // 
            // bSkinDownload
            // 
            this.bSkinDownload.Enabled = false;
            this.bSkinDownload.Location = new System.Drawing.Point(5, 146);
            this.bSkinDownload.Name = "bSkinDownload";
            this.bSkinDownload.Size = new System.Drawing.Size(128, 23);
            this.bSkinDownload.TabIndex = 1;
            this.bSkinDownload.Text = "Download Skin";
            this.toolTip1.SetToolTip(this.bSkinDownload, "Download the selected user\'s skin.");
            this.bSkinDownload.UseSelectable = true;
            this.bSkinDownload.Click += new System.EventHandler(this.bSkinDownload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbRegistered);
            this.groupBox3.Controls.Add(this.cbUTC);
            this.groupBox3.Controls.Add(this.dtpRegistered);
            this.groupBox3.Controls.Add(this.bRawPlayer);
            this.groupBox3.Controls.Add(this.lRegistered);
            this.groupBox3.Controls.Add(this.lID);
            this.groupBox3.Controls.Add(this.lUserName);
            this.groupBox3.Controls.Add(this.bIDLookup);
            this.groupBox3.Controls.Add(this.tbUserName);
            this.groupBox3.Controls.Add(this.tbID);
            this.groupBox3.Controls.Add(this.bLookup);
            this.groupBox3.Controls.Add(this.tBSearch);
            this.groupBox3.Location = new System.Drawing.Point(215, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 175);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Info";
            // 
            // tbRegistered
            // 
            // 
            // 
            // 
            this.tbRegistered.CustomButton.Image = null;
            this.tbRegistered.CustomButton.Location = new System.Drawing.Point(70, 2);
            this.tbRegistered.CustomButton.Name = "";
            this.tbRegistered.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbRegistered.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRegistered.CustomButton.TabIndex = 1;
            this.tbRegistered.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRegistered.CustomButton.UseSelectable = true;
            this.tbRegistered.CustomButton.Visible = false;
            this.tbRegistered.Lines = new string[0];
            this.tbRegistered.Location = new System.Drawing.Point(85, 149);
            this.tbRegistered.MaxLength = 32767;
            this.tbRegistered.Name = "tbRegistered";
            this.tbRegistered.PasswordChar = '\0';
            this.tbRegistered.ReadOnly = true;
            this.tbRegistered.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRegistered.SelectedText = "";
            this.tbRegistered.SelectionLength = 0;
            this.tbRegistered.SelectionStart = 0;
            this.tbRegistered.ShortcutsEnabled = true;
            this.tbRegistered.Size = new System.Drawing.Size(88, 20);
            this.tbRegistered.TabIndex = 36;
            this.tbRegistered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRegistered.UseSelectable = true;
            this.tbRegistered.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRegistered.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbUTC
            // 
            this.cbUTC.AutoSize = true;
            this.cbUTC.Checked = true;
            this.cbUTC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUTC.Location = new System.Drawing.Point(35, 151);
            this.cbUTC.Name = "cbUTC";
            this.cbUTC.Size = new System.Drawing.Size(44, 15);
            this.cbUTC.TabIndex = 35;
            this.cbUTC.Text = "UTC";
            this.cbUTC.UseSelectable = true;
            this.cbUTC.CheckedChanged += new System.EventHandler(this.cbUTC_CheckedChanged);
            // 
            // dtpRegistered
            // 
            this.dtpRegistered.CustomFormat = "dddd MMMM d, yyyy  h:mm:ss tt";
            this.dtpRegistered.Enabled = false;
            this.dtpRegistered.Location = new System.Drawing.Point(6, 111);
            this.dtpRegistered.MinDate = new System.DateTime(2013, 8, 13, 0, 0, 0, 0);
            this.dtpRegistered.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpRegistered.Name = "dtpRegistered";
            this.dtpRegistered.Size = new System.Drawing.Size(213, 29);
            this.dtpRegistered.TabIndex = 32;
            this.dtpRegistered.Value = new System.DateTime(2020, 1, 8, 0, 0, 0, 0);
            this.dtpRegistered.ValueChanged += new System.EventHandler(this.dtpRegistered_Changed);
            // 
            // bRawPlayer
            // 
            this.bRawPlayer.Location = new System.Drawing.Point(179, 149);
            this.bRawPlayer.Name = "bRawPlayer";
            this.bRawPlayer.Size = new System.Drawing.Size(40, 20);
            this.bRawPlayer.TabIndex = 32;
            this.bRawPlayer.Text = "Raw";
            this.toolTip1.SetToolTip(this.bRawPlayer, "Open the account\'s info in raw JSON.");
            this.bRawPlayer.UseSelectable = true;
            this.bRawPlayer.Click += new System.EventHandler(this.bRawPlayer_Click);
            // 
            // lRegistered
            // 
            this.lRegistered.AutoSize = true;
            this.lRegistered.Location = new System.Drawing.Point(6, 89);
            this.lRegistered.Name = "lRegistered";
            this.lRegistered.Size = new System.Drawing.Size(74, 19);
            this.lRegistered.TabIndex = 31;
            this.lRegistered.Text = "Registered:";
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(162, 44);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(24, 19);
            this.lID.TabIndex = 30;
            this.lID.Text = "ID:";
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(6, 44);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(71, 19);
            this.lUserName.TabIndex = 29;
            this.lUserName.Text = "Username:";
            // 
            // bIDLookup
            // 
            this.bIDLookup.Location = new System.Drawing.Point(179, 20);
            this.bIDLookup.Name = "bIDLookup";
            this.bIDLookup.Size = new System.Drawing.Size(40, 23);
            this.bIDLookup.TabIndex = 28;
            this.bIDLookup.Text = "ID";
            this.toolTip1.SetToolTip(this.bIDLookup, "Perform a lookup with a user\'s ID.");
            this.bIDLookup.UseSelectable = true;
            this.bIDLookup.Click += new System.EventHandler(this.bIDLookup_Click);
            // 
            // tbUserName
            // 
            // 
            // 
            // 
            this.tbUserName.CustomButton.Image = null;
            this.tbUserName.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.tbUserName.CustomButton.Name = "";
            this.tbUserName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUserName.CustomButton.TabIndex = 1;
            this.tbUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUserName.CustomButton.UseSelectable = true;
            this.tbUserName.CustomButton.Visible = false;
            this.tbUserName.Lines = new string[0];
            this.tbUserName.Location = new System.Drawing.Point(6, 66);
            this.tbUserName.MaxLength = 32767;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.ReadOnly = true;
            this.tbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserName.SelectedText = "";
            this.tbUserName.SelectionLength = 0;
            this.tbUserName.SelectionStart = 0;
            this.tbUserName.ShortcutsEnabled = true;
            this.tbUserName.Size = new System.Drawing.Size(153, 20);
            this.tbUserName.TabIndex = 27;
            this.tbUserName.UseSelectable = true;
            this.tbUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbID
            // 
            // 
            // 
            // 
            this.tbID.CustomButton.Image = null;
            this.tbID.CustomButton.Location = new System.Drawing.Point(36, 2);
            this.tbID.CustomButton.Name = "";
            this.tbID.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbID.CustomButton.TabIndex = 1;
            this.tbID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbID.CustomButton.UseSelectable = true;
            this.tbID.CustomButton.Visible = false;
            this.tbID.Lines = new string[0];
            this.tbID.Location = new System.Drawing.Point(165, 66);
            this.tbID.MaxLength = 32767;
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.ReadOnly = true;
            this.tbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbID.SelectedText = "";
            this.tbID.SelectionLength = 0;
            this.tbID.SelectionStart = 0;
            this.tbID.ShortcutsEnabled = true;
            this.tbID.Size = new System.Drawing.Size(54, 20);
            this.tbID.TabIndex = 25;
            this.tbID.UseSelectable = true;
            this.tbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bLookup
            // 
            this.bLookup.Location = new System.Drawing.Point(130, 20);
            this.bLookup.Name = "bLookup";
            this.bLookup.Size = new System.Drawing.Size(43, 23);
            this.bLookup.TabIndex = 24;
            this.bLookup.Text = "Player";
            this.toolTip1.SetToolTip(this.bLookup, "Perform a lookup with a username.");
            this.bLookup.UseSelectable = true;
            this.bLookup.Click += new System.EventHandler(this.bLookup_Click);
            // 
            // tBSearch
            // 
            // 
            // 
            // 
            this.tBSearch.CustomButton.Image = null;
            this.tBSearch.CustomButton.Location = new System.Drawing.Point(100, 2);
            this.tBSearch.CustomButton.Name = "";
            this.tBSearch.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tBSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBSearch.CustomButton.TabIndex = 1;
            this.tBSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBSearch.CustomButton.UseSelectable = true;
            this.tBSearch.CustomButton.Visible = false;
            this.tBSearch.Lines = new string[] {
        "Player Name/ID"};
            this.tBSearch.Location = new System.Drawing.Point(6, 21);
            this.tBSearch.MaxLength = 32767;
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.PasswordChar = '\0';
            this.tBSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBSearch.SelectedText = "";
            this.tBSearch.SelectionLength = 0;
            this.tBSearch.SelectionStart = 0;
            this.tBSearch.ShortcutsEnabled = true;
            this.tBSearch.Size = new System.Drawing.Size(118, 20);
            this.tBSearch.TabIndex = 23;
            this.tBSearch.Text = "Player Name/ID";
            this.tBSearch.UseSelectable = true;
            this.tBSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBSearch.GotFocus += new System.EventHandler(this.tBSearch_GotFocus);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbForumTitle);
            this.groupBox2.Controls.Add(this.lForumTitle);
            this.groupBox2.Controls.Add(this.tbFlags);
            this.groupBox2.Location = new System.Drawing.Point(6, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 63);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User\'s Flag(s):";
            // 
            // tbForumTitle
            // 
            // 
            // 
            // 
            this.tbForumTitle.CustomButton.Image = null;
            this.tbForumTitle.CustomButton.Location = new System.Drawing.Point(459, 2);
            this.tbForumTitle.CustomButton.Name = "";
            this.tbForumTitle.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbForumTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbForumTitle.CustomButton.TabIndex = 1;
            this.tbForumTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbForumTitle.CustomButton.UseSelectable = true;
            this.tbForumTitle.CustomButton.Visible = false;
            this.tbForumTitle.Lines = new string[0];
            this.tbForumTitle.Location = new System.Drawing.Point(91, 41);
            this.tbForumTitle.MaxLength = 32767;
            this.tbForumTitle.Multiline = true;
            this.tbForumTitle.Name = "tbForumTitle";
            this.tbForumTitle.PasswordChar = '\0';
            this.tbForumTitle.ReadOnly = true;
            this.tbForumTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbForumTitle.SelectedText = "";
            this.tbForumTitle.SelectionLength = 0;
            this.tbForumTitle.SelectionStart = 0;
            this.tbForumTitle.ShortcutsEnabled = true;
            this.tbForumTitle.Size = new System.Drawing.Size(477, 20);
            this.tbForumTitle.TabIndex = 33;
            this.tbForumTitle.UseSelectable = true;
            this.tbForumTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbForumTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lForumTitle
            // 
            this.lForumTitle.AutoSize = true;
            this.lForumTitle.Location = new System.Drawing.Point(6, 42);
            this.lForumTitle.Name = "lForumTitle";
            this.lForumTitle.Size = new System.Drawing.Size(79, 19);
            this.lForumTitle.TabIndex = 34;
            this.lForumTitle.Text = "Forum Title:";
            // 
            // tbFlags
            // 
            // 
            // 
            // 
            this.tbFlags.CustomButton.Image = null;
            this.tbFlags.CustomButton.Location = new System.Drawing.Point(544, 2);
            this.tbFlags.CustomButton.Name = "";
            this.tbFlags.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbFlags.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFlags.CustomButton.TabIndex = 1;
            this.tbFlags.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFlags.CustomButton.UseSelectable = true;
            this.tbFlags.CustomButton.Visible = false;
            this.tbFlags.Lines = new string[0];
            this.tbFlags.Location = new System.Drawing.Point(6, 19);
            this.tbFlags.MaxLength = 32767;
            this.tbFlags.Multiline = true;
            this.tbFlags.Name = "tbFlags";
            this.tbFlags.PasswordChar = '\0';
            this.tbFlags.ReadOnly = true;
            this.tbFlags.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFlags.SelectedText = "";
            this.tbFlags.SelectionLength = 0;
            this.tbFlags.SelectionStart = 0;
            this.tbFlags.ShortcutsEnabled = true;
            this.tbFlags.Size = new System.Drawing.Size(562, 20);
            this.tbFlags.TabIndex = 9;
            this.tbFlags.UseSelectable = true;
            this.tbFlags.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFlags.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bRawLast5);
            this.groupBox1.Controls.Add(this.tbLast5);
            this.groupBox1.Controls.Add(this.lTotal);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.bRefreshLast5);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 175);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Five Accounts";
            // 
            // bRawLast5
            // 
            this.bRawLast5.Location = new System.Drawing.Point(6, 21);
            this.bRawLast5.Margin = new System.Windows.Forms.Padding(2);
            this.bRawLast5.Name = "bRawLast5";
            this.bRawLast5.Size = new System.Drawing.Size(37, 23);
            this.bRawLast5.TabIndex = 23;
            this.bRawLast5.Text = "Raw";
            this.toolTip1.SetToolTip(this.bRawLast5, "Open the last five accounts in raw JSON.");
            this.bRawLast5.UseSelectable = true;
            this.bRawLast5.Click += new System.EventHandler(this.bRawLast5_Click);
            // 
            // tbLast5
            // 
            // 
            // 
            // 
            this.tbLast5.CustomButton.Image = null;
            this.tbLast5.CustomButton.Location = new System.Drawing.Point(101, 2);
            this.tbLast5.CustomButton.Name = "";
            this.tbLast5.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.tbLast5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLast5.CustomButton.TabIndex = 1;
            this.tbLast5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLast5.CustomButton.UseSelectable = true;
            this.tbLast5.CustomButton.Visible = false;
            this.tbLast5.Lines = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5"};
            this.tbLast5.Location = new System.Drawing.Point(6, 48);
            this.tbLast5.MaxLength = 32767;
            this.tbLast5.Multiline = true;
            this.tbLast5.Name = "tbLast5";
            this.tbLast5.PasswordChar = '\0';
            this.tbLast5.ReadOnly = true;
            this.tbLast5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLast5.SelectedText = "";
            this.tbLast5.SelectionLength = 0;
            this.tbLast5.SelectionStart = 0;
            this.tbLast5.ShortcutsEnabled = true;
            this.tbLast5.Size = new System.Drawing.Size(191, 92);
            this.tbLast5.TabIndex = 2;
            this.tbLast5.Text = "1\r\n2\r\n3\r\n4\r\n5";
            this.tbLast5.UseSelectable = true;
            this.tbLast5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLast5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(6, 146);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(95, 19);
            this.lTotal.TabIndex = 6;
            this.lTotal.Text = "Total Accounts:";
            // 
            // tbTotal
            // 
            // 
            // 
            // 
            this.tbTotal.CustomButton.Image = null;
            this.tbTotal.CustomButton.Location = new System.Drawing.Point(76, 2);
            this.tbTotal.CustomButton.Name = "";
            this.tbTotal.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTotal.CustomButton.TabIndex = 1;
            this.tbTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTotal.CustomButton.UseSelectable = true;
            this.tbTotal.CustomButton.Visible = false;
            this.tbTotal.Lines = new string[0];
            this.tbTotal.Location = new System.Drawing.Point(103, 146);
            this.tbTotal.MaxLength = 32767;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.PasswordChar = '\0';
            this.tbTotal.ReadOnly = true;
            this.tbTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTotal.SelectedText = "";
            this.tbTotal.SelectionLength = 0;
            this.tbTotal.SelectionStart = 0;
            this.tbTotal.ShortcutsEnabled = true;
            this.tbTotal.Size = new System.Drawing.Size(94, 20);
            this.tbTotal.TabIndex = 0;
            this.tbTotal.UseSelectable = true;
            this.tbTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bRefreshLast5
            // 
            this.bRefreshLast5.Location = new System.Drawing.Point(129, 21);
            this.bRefreshLast5.Name = "bRefreshLast5";
            this.bRefreshLast5.Size = new System.Drawing.Size(68, 23);
            this.bRefreshLast5.TabIndex = 4;
            this.bRefreshLast5.Text = "Refresh";
            this.toolTip1.SetToolTip(this.bRefreshLast5, "Refresh the last five accounts list.");
            this.bRefreshLast5.UseSelectable = true;
            this.bRefreshLast5.Click += new System.EventHandler(this.bRefreshLast5_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Servers";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pbCountry);
            this.groupBox6.Controls.Add(this.tbFeatured);
            this.groupBox6.Controls.Add(this.lFeatured);
            this.groupBox6.Controls.Add(this.tbCountry);
            this.groupBox6.Controls.Add(this.lCountry);
            this.groupBox6.Controls.Add(this.tbUptime);
            this.groupBox6.Controls.Add(this.lUptime);
            this.groupBox6.Controls.Add(this.bRefreshServers);
            this.groupBox6.Controls.Add(this.bRawServer);
            this.groupBox6.Controls.Add(this.bOpenHash);
            this.groupBox6.Controls.Add(this.tbSoftware);
            this.groupBox6.Controls.Add(this.lHash);
            this.groupBox6.Controls.Add(this.lSoftware);
            this.groupBox6.Controls.Add(this.tbHash);
            this.groupBox6.Location = new System.Drawing.Point(6, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(574, 160);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Server Info";
            // 
            // pbCountry
            // 
            this.pbCountry.Location = new System.Drawing.Point(445, 36);
            this.pbCountry.Name = "pbCountry";
            this.pbCountry.Size = new System.Drawing.Size(32, 22);
            this.pbCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCountry.TabIndex = 31;
            this.pbCountry.TabStop = false;
            // 
            // tbFeatured
            // 
            // 
            // 
            // 
            this.tbFeatured.CustomButton.Image = null;
            this.tbFeatured.CustomButton.Location = new System.Drawing.Point(54, 2);
            this.tbFeatured.CustomButton.Name = "";
            this.tbFeatured.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbFeatured.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFeatured.CustomButton.TabIndex = 1;
            this.tbFeatured.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFeatured.CustomButton.UseSelectable = true;
            this.tbFeatured.CustomButton.Visible = false;
            this.tbFeatured.Lines = new string[0];
            this.tbFeatured.Location = new System.Drawing.Point(391, 83);
            this.tbFeatured.MaxLength = 32767;
            this.tbFeatured.Name = "tbFeatured";
            this.tbFeatured.PasswordChar = '\0';
            this.tbFeatured.ReadOnly = true;
            this.tbFeatured.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFeatured.SelectedText = "";
            this.tbFeatured.SelectionLength = 0;
            this.tbFeatured.SelectionStart = 0;
            this.tbFeatured.ShortcutsEnabled = true;
            this.tbFeatured.Size = new System.Drawing.Size(72, 20);
            this.tbFeatured.TabIndex = 30;
            this.tbFeatured.UseSelectable = true;
            this.tbFeatured.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFeatured.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lFeatured
            // 
            this.lFeatured.AutoSize = true;
            this.lFeatured.Location = new System.Drawing.Point(391, 61);
            this.lFeatured.Name = "lFeatured";
            this.lFeatured.Size = new System.Drawing.Size(64, 19);
            this.lFeatured.TabIndex = 29;
            this.lFeatured.Text = "Featured:";
            // 
            // tbCountry
            // 
            // 
            // 
            // 
            this.tbCountry.CustomButton.Image = null;
            this.tbCountry.CustomButton.Location = new System.Drawing.Point(30, 2);
            this.tbCountry.CustomButton.Name = "";
            this.tbCountry.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbCountry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCountry.CustomButton.TabIndex = 1;
            this.tbCountry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCountry.CustomButton.UseSelectable = true;
            this.tbCountry.CustomButton.Visible = false;
            this.tbCountry.Lines = new string[0];
            this.tbCountry.Location = new System.Drawing.Point(391, 38);
            this.tbCountry.MaxLength = 32767;
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.PasswordChar = '\0';
            this.tbCountry.ReadOnly = true;
            this.tbCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCountry.SelectedText = "";
            this.tbCountry.SelectionLength = 0;
            this.tbCountry.SelectionStart = 0;
            this.tbCountry.ShortcutsEnabled = true;
            this.tbCountry.Size = new System.Drawing.Size(48, 20);
            this.tbCountry.TabIndex = 28;
            this.tbCountry.UseSelectable = true;
            this.tbCountry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCountry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Location = new System.Drawing.Point(391, 16);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(59, 19);
            this.lCountry.TabIndex = 27;
            this.lCountry.Text = "Country:";
            // 
            // tbUptime
            // 
            // 
            // 
            // 
            this.tbUptime.CustomButton.Image = null;
            this.tbUptime.CustomButton.Location = new System.Drawing.Point(339, 2);
            this.tbUptime.CustomButton.Name = "";
            this.tbUptime.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbUptime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUptime.CustomButton.TabIndex = 1;
            this.tbUptime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUptime.CustomButton.UseSelectable = true;
            this.tbUptime.CustomButton.Visible = false;
            this.tbUptime.Lines = new string[0];
            this.tbUptime.Location = new System.Drawing.Point(6, 38);
            this.tbUptime.MaxLength = 32767;
            this.tbUptime.Name = "tbUptime";
            this.tbUptime.PasswordChar = '\0';
            this.tbUptime.ReadOnly = true;
            this.tbUptime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUptime.SelectedText = "";
            this.tbUptime.SelectionLength = 0;
            this.tbUptime.SelectionStart = 0;
            this.tbUptime.ShortcutsEnabled = true;
            this.tbUptime.Size = new System.Drawing.Size(357, 20);
            this.tbUptime.TabIndex = 9;
            this.tbUptime.UseSelectable = true;
            this.tbUptime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUptime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lUptime
            // 
            this.lUptime.AutoSize = true;
            this.lUptime.Location = new System.Drawing.Point(6, 16);
            this.lUptime.Name = "lUptime";
            this.lUptime.Size = new System.Drawing.Size(55, 19);
            this.lUptime.TabIndex = 16;
            this.lUptime.Text = "Uptime:";
            // 
            // bRefreshServers
            // 
            this.bRefreshServers.Location = new System.Drawing.Point(507, 35);
            this.bRefreshServers.Margin = new System.Windows.Forms.Padding(2);
            this.bRefreshServers.Name = "bRefreshServers";
            this.bRefreshServers.Size = new System.Drawing.Size(62, 23);
            this.bRefreshServers.TabIndex = 1;
            this.bRefreshServers.Text = "Refresh";
            this.toolTip1.SetToolTip(this.bRefreshServers, "Refresh the selected server\'s statistics.");
            this.bRefreshServers.UseSelectable = true;
            this.bRefreshServers.Click += new System.EventHandler(this.bRefreshServers_Click);
            // 
            // bRawServer
            // 
            this.bRawServer.Location = new System.Drawing.Point(507, 80);
            this.bRawServer.Margin = new System.Windows.Forms.Padding(2);
            this.bRawServer.Name = "bRawServer";
            this.bRawServer.Size = new System.Drawing.Size(62, 23);
            this.bRawServer.TabIndex = 23;
            this.bRawServer.Text = "Raw";
            this.toolTip1.SetToolTip(this.bRawServer, "Open the list of servers in raw JSON.");
            this.bRawServer.UseSelectable = true;
            this.bRawServer.Click += new System.EventHandler(this.bRawServer_Click);
            // 
            // bOpenHash
            // 
            this.bOpenHash.Location = new System.Drawing.Point(507, 125);
            this.bOpenHash.Margin = new System.Windows.Forms.Padding(2);
            this.bOpenHash.Name = "bOpenHash";
            this.bOpenHash.Size = new System.Drawing.Size(62, 23);
            this.bOpenHash.TabIndex = 26;
            this.bOpenHash.Text = "Play";
            this.toolTip1.SetToolTip(this.bOpenHash, "Join the selected server in your browser.");
            this.bOpenHash.UseSelectable = true;
            this.bOpenHash.Click += new System.EventHandler(this.bOpenHash_Click);
            // 
            // tbSoftware
            // 
            // 
            // 
            // 
            this.tbSoftware.CustomButton.Image = null;
            this.tbSoftware.CustomButton.Location = new System.Drawing.Point(339, 2);
            this.tbSoftware.CustomButton.Name = "";
            this.tbSoftware.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbSoftware.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSoftware.CustomButton.TabIndex = 1;
            this.tbSoftware.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSoftware.CustomButton.UseSelectable = true;
            this.tbSoftware.CustomButton.Visible = false;
            this.tbSoftware.Lines = new string[0];
            this.tbSoftware.Location = new System.Drawing.Point(6, 83);
            this.tbSoftware.MaxLength = 32767;
            this.tbSoftware.Name = "tbSoftware";
            this.tbSoftware.PasswordChar = '\0';
            this.tbSoftware.ReadOnly = true;
            this.tbSoftware.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSoftware.SelectedText = "";
            this.tbSoftware.SelectionLength = 0;
            this.tbSoftware.SelectionStart = 0;
            this.tbSoftware.ShortcutsEnabled = true;
            this.tbSoftware.Size = new System.Drawing.Size(357, 20);
            this.tbSoftware.TabIndex = 11;
            this.tbSoftware.UseSelectable = true;
            this.tbSoftware.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSoftware.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lHash
            // 
            this.lHash.AutoSize = true;
            this.lHash.Location = new System.Drawing.Point(6, 106);
            this.lHash.Name = "lHash";
            this.lHash.Size = new System.Drawing.Size(68, 19);
            this.lHash.TabIndex = 25;
            this.lHash.Text = "Play Hash:";
            // 
            // lSoftware
            // 
            this.lSoftware.AutoSize = true;
            this.lSoftware.Location = new System.Drawing.Point(6, 61);
            this.lSoftware.Name = "lSoftware";
            this.lSoftware.Size = new System.Drawing.Size(63, 19);
            this.lSoftware.TabIndex = 17;
            this.lSoftware.Text = "Software:";
            // 
            // tbHash
            // 
            // 
            // 
            // 
            this.tbHash.CustomButton.Image = null;
            this.tbHash.CustomButton.Location = new System.Drawing.Point(461, 2);
            this.tbHash.CustomButton.Name = "";
            this.tbHash.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbHash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbHash.CustomButton.TabIndex = 1;
            this.tbHash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbHash.CustomButton.UseSelectable = true;
            this.tbHash.CustomButton.Visible = false;
            this.tbHash.Lines = new string[0];
            this.tbHash.Location = new System.Drawing.Point(6, 128);
            this.tbHash.MaxLength = 32767;
            this.tbHash.Name = "tbHash";
            this.tbHash.PasswordChar = '\0';
            this.tbHash.ReadOnly = true;
            this.tbHash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbHash.SelectedText = "";
            this.tbHash.SelectionLength = 0;
            this.tbHash.SelectionStart = 0;
            this.tbHash.ShortcutsEnabled = true;
            this.tbHash.Size = new System.Drawing.Size(479, 20);
            this.tbHash.TabIndex = 24;
            this.tbHash.UseSelectable = true;
            this.tbHash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbHash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbServer);
            this.groupBox5.Controls.Add(this.lPlayers);
            this.groupBox5.Controls.Add(this.tbPlayers);
            this.groupBox5.Controls.Add(this.lof);
            this.groupBox5.Controls.Add(this.txMaxPlayers);
            this.groupBox5.Controls.Add(this.lServer);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(574, 70);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Server";
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.ItemHeight = 23;
            this.cbServer.Location = new System.Drawing.Point(9, 32);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(354, 29);
            this.cbServer.TabIndex = 0;
            this.cbServer.UseSelectable = true;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            // 
            // lPlayers
            // 
            this.lPlayers.AutoSize = true;
            this.lPlayers.Location = new System.Drawing.Point(391, 11);
            this.lPlayers.Name = "lPlayers";
            this.lPlayers.Size = new System.Drawing.Size(87, 19);
            this.lPlayers.TabIndex = 18;
            this.lPlayers.Text = "Player Count:";
            // 
            // tbPlayers
            // 
            // 
            // 
            // 
            this.tbPlayers.CustomButton.Image = null;
            this.tbPlayers.CustomButton.Location = new System.Drawing.Point(54, 2);
            this.tbPlayers.CustomButton.Name = "";
            this.tbPlayers.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbPlayers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPlayers.CustomButton.TabIndex = 1;
            this.tbPlayers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPlayers.CustomButton.UseSelectable = true;
            this.tbPlayers.CustomButton.Visible = false;
            this.tbPlayers.Lines = new string[0];
            this.tbPlayers.Location = new System.Drawing.Point(391, 33);
            this.tbPlayers.MaxLength = 32767;
            this.tbPlayers.Name = "tbPlayers";
            this.tbPlayers.PasswordChar = '\0';
            this.tbPlayers.ReadOnly = true;
            this.tbPlayers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPlayers.SelectedText = "";
            this.tbPlayers.SelectionLength = 0;
            this.tbPlayers.SelectionStart = 0;
            this.tbPlayers.ShortcutsEnabled = true;
            this.tbPlayers.Size = new System.Drawing.Size(72, 20);
            this.tbPlayers.TabIndex = 5;
            this.tbPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPlayers.UseSelectable = true;
            this.tbPlayers.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPlayers.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lof
            // 
            this.lof.AutoSize = true;
            this.lof.Location = new System.Drawing.Point(464, 33);
            this.lof.Name = "lof";
            this.lof.Size = new System.Drawing.Size(21, 19);
            this.lof.TabIndex = 19;
            this.lof.Text = "of";
            // 
            // txMaxPlayers
            // 
            // 
            // 
            // 
            this.txMaxPlayers.CustomButton.Image = null;
            this.txMaxPlayers.CustomButton.Location = new System.Drawing.Point(54, 2);
            this.txMaxPlayers.CustomButton.Name = "";
            this.txMaxPlayers.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txMaxPlayers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txMaxPlayers.CustomButton.TabIndex = 1;
            this.txMaxPlayers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txMaxPlayers.CustomButton.UseSelectable = true;
            this.txMaxPlayers.CustomButton.Visible = false;
            this.txMaxPlayers.Lines = new string[0];
            this.txMaxPlayers.Location = new System.Drawing.Point(488, 33);
            this.txMaxPlayers.MaxLength = 32767;
            this.txMaxPlayers.Name = "txMaxPlayers";
            this.txMaxPlayers.PasswordChar = '\0';
            this.txMaxPlayers.ReadOnly = true;
            this.txMaxPlayers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMaxPlayers.SelectedText = "";
            this.txMaxPlayers.SelectionLength = 0;
            this.txMaxPlayers.SelectionStart = 0;
            this.txMaxPlayers.ShortcutsEnabled = true;
            this.txMaxPlayers.Size = new System.Drawing.Size(72, 20);
            this.txMaxPlayers.TabIndex = 13;
            this.txMaxPlayers.UseSelectable = true;
            this.txMaxPlayers.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txMaxPlayers.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(9, 11);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(104, 19);
            this.lServer.TabIndex = 15;
            this.lServer.Text = "Selected Server:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 294);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassiCube API";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroTextBox tbLast5;
		private MetroFramework.Controls.MetroTextBox tbTotal;
		private MetroFramework.Controls.MetroTextBox tbSoftware;
		private MetroFramework.Controls.MetroTextBox tbUptime;
		private MetroFramework.Controls.MetroTextBox tbPlayers;
		private MetroFramework.Controls.MetroButton bRefreshServers;
		private MetroFramework.Controls.MetroComboBox cbServer;
		private MetroFramework.Controls.MetroTextBox txMaxPlayers;
		private MetroFramework.Controls.MetroTextBox tbFlags;
		private MetroFramework.Controls.MetroButton bRefreshLast5;
		private MetroFramework.Controls.MetroLabel lTotal;
		private MetroFramework.Controls.MetroLabel lof;
		private MetroFramework.Controls.MetroLabel lPlayers;
		private MetroFramework.Controls.MetroLabel lSoftware;
		private MetroFramework.Controls.MetroLabel lUptime;
		private MetroFramework.Controls.MetroLabel lServer;
        private MetroFramework.Controls.MetroButton bRawLast5;
        private MetroFramework.Controls.MetroButton bRawServer;
        private MetroFramework.Controls.MetroLabel lHash;
        private MetroFramework.Controls.MetroTextBox tbHash;
        private MetroFramework.Controls.MetroButton bOpenHash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton bRawPlayer;
        private MetroFramework.Controls.MetroLabel lRegistered;
        private MetroFramework.Controls.MetroLabel lID;
        private MetroFramework.Controls.MetroLabel lUserName;
        private MetroFramework.Controls.MetroButton bIDLookup;
        private MetroFramework.Controls.MetroTextBox tbUserName;
        private MetroFramework.Controls.MetroTextBox tbID;
        private MetroFramework.Controls.MetroButton bLookup;
        private MetroFramework.Controls.MetroTextBox tBSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton bSkinDownload;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroTextBox tbFeatured;
        private MetroFramework.Controls.MetroLabel lFeatured;
        private MetroFramework.Controls.MetroTextBox tbCountry;
        private MetroFramework.Controls.MetroLabel lCountry;
        private MetroFramework.Controls.MetroLabel lForumTitle;
        private MetroFramework.Controls.MetroTextBox tbForumTitle;
        private MetroFramework.Controls.MetroDateTime dtpRegistered;
        private MetroFramework.Controls.MetroCheckBox cbUTC;
        private MetroFramework.Controls.MetroTextBox tbRegistered;
        private System.Windows.Forms.PictureBox pbCountry;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabPage1;
        private MetroFramework.Controls.MetroTabPage tabPage2;
    }
}

