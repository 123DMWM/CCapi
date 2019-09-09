﻿namespace CCapi {
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bSkinDownload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bRawPlayer = new System.Windows.Forms.Button();
            this.lRegistered = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.bIDLookup = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbRegistered = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.bLookup = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFlags = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bRawLast5 = new System.Windows.Forms.Button();
            this.tbLast5 = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.bRefreshLast5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbFeatured = new System.Windows.Forms.TextBox();
            this.lFeatured = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lCountry = new System.Windows.Forms.Label();
            this.tbUptime = new System.Windows.Forms.TextBox();
            this.lUptime = new System.Windows.Forms.Label();
            this.bRefreshServers = new System.Windows.Forms.Button();
            this.bRawServer = new System.Windows.Forms.Button();
            this.bOpenHash = new System.Windows.Forms.Button();
            this.tbSoftware = new System.Windows.Forms.TextBox();
            this.lHash = new System.Windows.Forms.Label();
            this.lSoftware = new System.Windows.Forms.Label();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.lPlayers = new System.Windows.Forms.Label();
            this.tbPlayers = new System.Windows.Forms.TextBox();
            this.lof = new System.Windows.Forms.Label();
            this.txMaxPlayers = new System.Windows.Forms.TextBox();
            this.lServer = new System.Windows.Forms.Label();
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
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(5, 2);
            this.tabs.Margin = new System.Windows.Forms.Padding(4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(742, 362);
            this.tabs.TabIndex = 1;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_Change);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(734, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bSkinDownload);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(554, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(172, 219);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Skin";
            // 
            // bSkinDownload
            // 
            this.bSkinDownload.Enabled = false;
            this.bSkinDownload.Location = new System.Drawing.Point(6, 182);
            this.bSkinDownload.Margin = new System.Windows.Forms.Padding(4);
            this.bSkinDownload.Name = "bSkinDownload";
            this.bSkinDownload.Size = new System.Drawing.Size(160, 29);
            this.bSkinDownload.TabIndex = 1;
            this.bSkinDownload.Text = "Download Skin";
            this.toolTip1.SetToolTip(this.bSkinDownload, "Download the selected user\'s skin.");
            this.bSkinDownload.UseVisualStyleBackColor = true;
            this.bSkinDownload.Click += new System.EventHandler(this.bSkinDownload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bRawPlayer);
            this.groupBox3.Controls.Add(this.lRegistered);
            this.groupBox3.Controls.Add(this.lID);
            this.groupBox3.Controls.Add(this.lUserName);
            this.groupBox3.Controls.Add(this.bIDLookup);
            this.groupBox3.Controls.Add(this.tbUserName);
            this.groupBox3.Controls.Add(this.tbRegistered);
            this.groupBox3.Controls.Add(this.tbID);
            this.groupBox3.Controls.Add(this.bLookup);
            this.groupBox3.Controls.Add(this.tBSearch);
            this.groupBox3.Location = new System.Drawing.Point(269, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(281, 219);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Info";
            // 
            // bRawPlayer
            // 
            this.bRawPlayer.Location = new System.Drawing.Point(228, 121);
            this.bRawPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.bRawPlayer.Name = "bRawPlayer";
            this.bRawPlayer.Size = new System.Drawing.Size(46, 29);
            this.bRawPlayer.TabIndex = 32;
            this.bRawPlayer.Text = "Raw";
            this.toolTip1.SetToolTip(this.bRawPlayer, "Open the account\'s info in raw JSON.");
            this.bRawPlayer.UseVisualStyleBackColor = true;
            this.bRawPlayer.Click += new System.EventHandler(this.bRawPlayer_Click);
            // 
            // lRegistered
            // 
            this.lRegistered.AutoSize = true;
            this.lRegistered.Location = new System.Drawing.Point(8, 134);
            this.lRegistered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRegistered.Name = "lRegistered";
            this.lRegistered.Size = new System.Drawing.Size(81, 17);
            this.lRegistered.TabIndex = 31;
            this.lRegistered.Text = "Registered:";
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(208, 62);
            this.lID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(25, 17);
            this.lID.TabIndex = 30;
            this.lID.Text = "ID:";
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(8, 62);
            this.lUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(77, 17);
            this.lUserName.TabIndex = 29;
            this.lUserName.Text = "Username:";
            // 
            // bIDLookup
            // 
            this.bIDLookup.Location = new System.Drawing.Point(238, 25);
            this.bIDLookup.Margin = new System.Windows.Forms.Padding(4);
            this.bIDLookup.Name = "bIDLookup";
            this.bIDLookup.Size = new System.Drawing.Size(36, 29);
            this.bIDLookup.TabIndex = 28;
            this.bIDLookup.Text = "ID";
            this.toolTip1.SetToolTip(this.bIDLookup, "Perform a lookup with a user\'s ID.");
            this.bIDLookup.UseVisualStyleBackColor = true;
            this.bIDLookup.Click += new System.EventHandler(this.bIDLookup_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(8, 84);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(190, 22);
            this.tbUserName.TabIndex = 27;
            // 
            // tbRegistered
            // 
            this.tbRegistered.Location = new System.Drawing.Point(8, 155);
            this.tbRegistered.Margin = new System.Windows.Forms.Padding(4);
            this.tbRegistered.Multiline = true;
            this.tbRegistered.Name = "tbRegistered";
            this.tbRegistered.ReadOnly = true;
            this.tbRegistered.Size = new System.Drawing.Size(265, 55);
            this.tbRegistered.TabIndex = 26;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(206, 84);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(66, 22);
            this.tbID.TabIndex = 25;
            // 
            // bLookup
            // 
            this.bLookup.Location = new System.Drawing.Point(162, 25);
            this.bLookup.Margin = new System.Windows.Forms.Padding(4);
            this.bLookup.Name = "bLookup";
            this.bLookup.Size = new System.Drawing.Size(68, 29);
            this.bLookup.TabIndex = 24;
            this.bLookup.Text = "Lookup Player/ID";
            this.toolTip1.SetToolTip(this.bLookup, "Perform a lookup with a username.");
            this.bLookup.UseVisualStyleBackColor = true;
            this.bLookup.Click += new System.EventHandler(this.bLookup_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(8, 26);
            this.tBSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(146, 22);
            this.tBSearch.TabIndex = 23;
            this.tBSearch.Text = "Player Name/ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFlags);
            this.groupBox2.Location = new System.Drawing.Point(8, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(718, 90);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User\'s Flag(s):";
            // 
            // tbFlags
            // 
            this.tbFlags.Location = new System.Drawing.Point(8, 21);
            this.tbFlags.Margin = new System.Windows.Forms.Padding(4);
            this.tbFlags.Multiline = true;
            this.tbFlags.Name = "tbFlags";
            this.tbFlags.ReadOnly = true;
            this.tbFlags.Size = new System.Drawing.Size(700, 60);
            this.tbFlags.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bRawLast5);
            this.groupBox1.Controls.Add(this.tbLast5);
            this.groupBox1.Controls.Add(this.lTotal);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.bRefreshLast5);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(254, 219);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Five Accounts";
            // 
            // bRawLast5
            // 
            this.bRawLast5.Location = new System.Drawing.Point(8, 26);
            this.bRawLast5.Margin = new System.Windows.Forms.Padding(2);
            this.bRawLast5.Name = "bRawLast5";
            this.bRawLast5.Size = new System.Drawing.Size(46, 29);
            this.bRawLast5.TabIndex = 23;
            this.bRawLast5.Text = "Raw";
            this.toolTip1.SetToolTip(this.bRawLast5, "Open the last five accounts in raw JSON.");
            this.bRawLast5.UseVisualStyleBackColor = true;
            this.bRawLast5.Click += new System.EventHandler(this.bRawLast5_Click);
            // 
            // tbLast5
            // 
            this.tbLast5.Location = new System.Drawing.Point(8, 60);
            this.tbLast5.Margin = new System.Windows.Forms.Padding(4);
            this.tbLast5.Multiline = true;
            this.tbLast5.Name = "tbLast5";
            this.tbLast5.ReadOnly = true;
            this.tbLast5.Size = new System.Drawing.Size(238, 94);
            this.tbLast5.TabIndex = 2;
            this.tbLast5.Text = "1\r\n2\r\n3\r\n4\r\n5";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(12, 179);
            this.lTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(106, 17);
            this.lTotal.TabIndex = 6;
            this.lTotal.Text = "Total Accounts:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(128, 174);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(116, 22);
            this.tbTotal.TabIndex = 0;
            // 
            // bRefreshLast5
            // 
            this.bRefreshLast5.Location = new System.Drawing.Point(161, 26);
            this.bRefreshLast5.Margin = new System.Windows.Forms.Padding(4);
            this.bRefreshLast5.Name = "bRefreshLast5";
            this.bRefreshLast5.Size = new System.Drawing.Size(85, 29);
            this.bRefreshLast5.TabIndex = 4;
            this.bRefreshLast5.Text = "Refresh";
            this.toolTip1.SetToolTip(this.bRefreshLast5, "Refresh the last five accounts list.");
            this.bRefreshLast5.UseVisualStyleBackColor = true;
            this.bRefreshLast5.Click += new System.EventHandler(this.bRefreshLast5_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(734, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Servers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
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
            this.groupBox6.Location = new System.Drawing.Point(8, 102);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(718, 220);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Server Info";
            // 
            // tbFeatured
            // 
            this.tbFeatured.Location = new System.Drawing.Point(489, 100);
            this.tbFeatured.Margin = new System.Windows.Forms.Padding(4);
            this.tbFeatured.Name = "tbFeatured";
            this.tbFeatured.ReadOnly = true;
            this.tbFeatured.Size = new System.Drawing.Size(89, 22);
            this.tbFeatured.TabIndex = 30;
            // 
            // lFeatured
            // 
            this.lFeatured.AutoSize = true;
            this.lFeatured.Location = new System.Drawing.Point(491, 80);
            this.lFeatured.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFeatured.Name = "lFeatured";
            this.lFeatured.Size = new System.Drawing.Size(69, 17);
            this.lFeatured.TabIndex = 29;
            this.lFeatured.Text = "Featured:";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(489, 40);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.ReadOnly = true;
            this.tbCountry.Size = new System.Drawing.Size(89, 22);
            this.tbCountry.TabIndex = 28;
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Location = new System.Drawing.Point(491, 20);
            this.lCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(61, 17);
            this.lCountry.TabIndex = 27;
            this.lCountry.Text = "Country:";
            // 
            // tbUptime
            // 
            this.tbUptime.Location = new System.Drawing.Point(8, 40);
            this.tbUptime.Margin = new System.Windows.Forms.Padding(4);
            this.tbUptime.Name = "tbUptime";
            this.tbUptime.ReadOnly = true;
            this.tbUptime.Size = new System.Drawing.Size(445, 22);
            this.tbUptime.TabIndex = 9;
            // 
            // lUptime
            // 
            this.lUptime.AutoSize = true;
            this.lUptime.Location = new System.Drawing.Point(8, 20);
            this.lUptime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUptime.Name = "lUptime";
            this.lUptime.Size = new System.Drawing.Size(56, 17);
            this.lUptime.TabIndex = 16;
            this.lUptime.Text = "Uptime:";
            // 
            // bRefreshServers
            // 
            this.bRefreshServers.Location = new System.Drawing.Point(632, 20);
            this.bRefreshServers.Margin = new System.Windows.Forms.Padding(4);
            this.bRefreshServers.Name = "bRefreshServers";
            this.bRefreshServers.Size = new System.Drawing.Size(78, 29);
            this.bRefreshServers.TabIndex = 1;
            this.bRefreshServers.Text = "Refresh";
            this.toolTip1.SetToolTip(this.bRefreshServers, "Refresh the selected server\'s statistics.");
            this.bRefreshServers.UseVisualStyleBackColor = true;
            this.bRefreshServers.Click += new System.EventHandler(this.bRefreshServers_Click);
            // 
            // bRawServer
            // 
            this.bRawServer.Location = new System.Drawing.Point(632, 80);
            this.bRawServer.Margin = new System.Windows.Forms.Padding(2);
            this.bRawServer.Name = "bRawServer";
            this.bRawServer.Size = new System.Drawing.Size(78, 29);
            this.bRawServer.TabIndex = 23;
            this.bRawServer.Text = "Raw";
            this.toolTip1.SetToolTip(this.bRawServer, "Open the list of servers in raw JSON.");
            this.bRawServer.UseVisualStyleBackColor = true;
            this.bRawServer.Click += new System.EventHandler(this.bRawServer_Click);
            // 
            // bOpenHash
            // 
            this.bOpenHash.Location = new System.Drawing.Point(632, 156);
            this.bOpenHash.Margin = new System.Windows.Forms.Padding(2);
            this.bOpenHash.Name = "bOpenHash";
            this.bOpenHash.Size = new System.Drawing.Size(78, 29);
            this.bOpenHash.TabIndex = 26;
            this.bOpenHash.Text = "Play";
            this.toolTip1.SetToolTip(this.bOpenHash, "Join the selected server in your browser.");
            this.bOpenHash.UseVisualStyleBackColor = true;
            this.bOpenHash.Click += new System.EventHandler(this.bOpenHash_Click);
            // 
            // tbSoftware
            // 
            this.tbSoftware.Location = new System.Drawing.Point(8, 100);
            this.tbSoftware.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoftware.Name = "tbSoftware";
            this.tbSoftware.ReadOnly = true;
            this.tbSoftware.Size = new System.Drawing.Size(445, 22);
            this.tbSoftware.TabIndex = 11;
            // 
            // lHash
            // 
            this.lHash.AutoSize = true;
            this.lHash.Location = new System.Drawing.Point(8, 140);
            this.lHash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHash.Name = "lHash";
            this.lHash.Size = new System.Drawing.Size(76, 17);
            this.lHash.TabIndex = 25;
            this.lHash.Text = "Play Hash:";
            // 
            // lSoftware
            // 
            this.lSoftware.AutoSize = true;
            this.lSoftware.Location = new System.Drawing.Point(8, 80);
            this.lSoftware.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSoftware.Name = "lSoftware";
            this.lSoftware.Size = new System.Drawing.Size(67, 17);
            this.lSoftware.TabIndex = 17;
            this.lSoftware.Text = "Software:";
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(8, 160);
            this.tbHash.Margin = new System.Windows.Forms.Padding(4);
            this.tbHash.Name = "tbHash";
            this.tbHash.ReadOnly = true;
            this.tbHash.Size = new System.Drawing.Size(598, 22);
            this.tbHash.TabIndex = 24;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbServer);
            this.groupBox5.Controls.Add(this.lPlayers);
            this.groupBox5.Controls.Add(this.tbPlayers);
            this.groupBox5.Controls.Add(this.lof);
            this.groupBox5.Controls.Add(this.txMaxPlayers);
            this.groupBox5.Controls.Add(this.lServer);
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(718, 88);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Server";
            // 
            // cbServer
            // 
            this.cbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(11, 40);
            this.cbServer.Margin = new System.Windows.Forms.Padding(4);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(442, 24);
            this.cbServer.TabIndex = 0;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            // 
            // lPlayers
            // 
            this.lPlayers.AutoSize = true;
            this.lPlayers.Location = new System.Drawing.Point(491, 21);
            this.lPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlayers.Name = "lPlayers";
            this.lPlayers.Size = new System.Drawing.Size(93, 17);
            this.lPlayers.TabIndex = 18;
            this.lPlayers.Text = "Player Count:";
            // 
            // tbPlayers
            // 
            this.tbPlayers.Location = new System.Drawing.Point(489, 41);
            this.tbPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlayers.Name = "tbPlayers";
            this.tbPlayers.ReadOnly = true;
            this.tbPlayers.Size = new System.Drawing.Size(89, 22);
            this.tbPlayers.TabIndex = 5;
            this.tbPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lof
            // 
            this.lof.AutoSize = true;
            this.lof.Location = new System.Drawing.Point(586, 45);
            this.lof.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lof.Name = "lof";
            this.lof.Size = new System.Drawing.Size(20, 17);
            this.lof.TabIndex = 19;
            this.lof.Text = "of";
            // 
            // txMaxPlayers
            // 
            this.txMaxPlayers.Location = new System.Drawing.Point(610, 41);
            this.txMaxPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.txMaxPlayers.Name = "txMaxPlayers";
            this.txMaxPlayers.ReadOnly = true;
            this.txMaxPlayers.Size = new System.Drawing.Size(89, 22);
            this.txMaxPlayers.TabIndex = 13;
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(8, 20);
            this.lServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(113, 17);
            this.lServer.TabIndex = 15;
            this.lServer.Text = "Selected Server:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(750, 368);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tbLast5;
		private System.Windows.Forms.TextBox tbTotal;
		private System.Windows.Forms.TextBox tbSoftware;
		private System.Windows.Forms.TextBox tbUptime;
		private System.Windows.Forms.TextBox tbPlayers;
		private System.Windows.Forms.Button bRefreshServers;
		private System.Windows.Forms.ComboBox cbServer;
		private System.Windows.Forms.TextBox txMaxPlayers;
		private System.Windows.Forms.TextBox tbFlags;
		private System.Windows.Forms.Button bRefreshLast5;
		private System.Windows.Forms.Label lTotal;
		private System.Windows.Forms.Label lof;
		private System.Windows.Forms.Label lPlayers;
		private System.Windows.Forms.Label lSoftware;
		private System.Windows.Forms.Label lUptime;
		private System.Windows.Forms.Label lServer;
        private System.Windows.Forms.Button bRawLast5;
        private System.Windows.Forms.Button bRawServer;
        private System.Windows.Forms.Label lHash;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Button bOpenHash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bRawPlayer;
        private System.Windows.Forms.Label lRegistered;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Button bIDLookup;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbRegistered;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button bLookup;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bSkinDownload;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbFeatured;
        private System.Windows.Forms.Label lFeatured;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lCountry;
    }
}

