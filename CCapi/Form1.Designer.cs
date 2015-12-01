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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bRawPlayer = new System.Windows.Forms.Button();
            this.lFlags = new System.Windows.Forms.Label();
            this.lRegistered = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.bIDLookup = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbFlags = new System.Windows.Forms.TextBox();
            this.tbRegistered = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRawLast5 = new System.Windows.Forms.Button();
            this.lTotal = new System.Windows.Forms.Label();
            this.lLast5 = new System.Windows.Forms.Label();
            this.bRefreshLast5 = new System.Windows.Forms.Button();
            this.tbLast5 = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.bLookup = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bRawServer = new System.Windows.Forms.Button();
            this.lof = new System.Windows.Forms.Label();
            this.lPlayers = new System.Windows.Forms.Label();
            this.lSoftware = new System.Windows.Forms.Label();
            this.lUptime = new System.Windows.Forms.Label();
            this.lServer = new System.Windows.Forms.Label();
            this.txMaxPlayers = new System.Windows.Forms.TextBox();
            this.tbSoftware = new System.Windows.Forms.TextBox();
            this.tbUptime = new System.Windows.Forms.TextBox();
            this.tbPlayers = new System.Windows.Forms.TextBox();
            this.bRefreshServers = new System.Windows.Forms.Button();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(576, 270);
            this.tabs.TabIndex = 1;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_Change);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bRawPlayer);
            this.tabPage1.Controls.Add(this.lFlags);
            this.tabPage1.Controls.Add(this.lRegistered);
            this.tabPage1.Controls.Add(this.lID);
            this.tabPage1.Controls.Add(this.lUserName);
            this.tabPage1.Controls.Add(this.bIDLookup);
            this.tabPage1.Controls.Add(this.tbUserName);
            this.tabPage1.Controls.Add(this.tbFlags);
            this.tabPage1.Controls.Add(this.tbRegistered);
            this.tabPage1.Controls.Add(this.tbID);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.bLookup);
            this.tabPage1.Controls.Add(this.tBSearch);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(568, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bRawPlayer
            // 
            this.bRawPlayer.Location = new System.Drawing.Point(518, 140);
            this.bRawPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRawPlayer.Name = "bRawPlayer";
            this.bRawPlayer.Size = new System.Drawing.Size(47, 23);
            this.bRawPlayer.TabIndex = 22;
            this.bRawPlayer.Text = "Raw";
            this.bRawPlayer.UseVisualStyleBackColor = true;
            this.bRawPlayer.Click += new System.EventHandler(this.bRawPlayer_Click);
            // 
            // lFlags
            // 
            this.lFlags.AutoSize = true;
            this.lFlags.Location = new System.Drawing.Point(234, 175);
            this.lFlags.Name = "lFlags";
            this.lFlags.Size = new System.Drawing.Size(32, 13);
            this.lFlags.TabIndex = 18;
            this.lFlags.Text = "Flags";
            // 
            // lRegistered
            // 
            this.lRegistered.AutoSize = true;
            this.lRegistered.Location = new System.Drawing.Point(234, 124);
            this.lRegistered.Name = "lRegistered";
            this.lRegistered.Size = new System.Drawing.Size(58, 13);
            this.lRegistered.TabIndex = 17;
            this.lRegistered.Text = "Registered";
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(374, 71);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(18, 13);
            this.lID.TabIndex = 16;
            this.lID.Text = "ID";
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(234, 72);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(60, 13);
            this.lUserName.TabIndex = 15;
            this.lUserName.Text = "User Name";
            // 
            // bIDLookup
            // 
            this.bIDLookup.Location = new System.Drawing.Point(399, 7);
            this.bIDLookup.Name = "bIDLookup";
            this.bIDLookup.Size = new System.Drawing.Size(29, 23);
            this.bIDLookup.TabIndex = 14;
            this.bIDLookup.Text = "ID";
            this.bIDLookup.UseVisualStyleBackColor = true;
            this.bIDLookup.Click += new System.EventHandler(this.bIDLookup_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(234, 88);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(134, 20);
            this.tbUserName.TabIndex = 10;
            // 
            // tbFlags
            // 
            this.tbFlags.Location = new System.Drawing.Point(6, 190);
            this.tbFlags.Multiline = true;
            this.tbFlags.Name = "tbFlags";
            this.tbFlags.ReadOnly = true;
            this.tbFlags.Size = new System.Drawing.Size(559, 45);
            this.tbFlags.TabIndex = 9;
            // 
            // tbRegistered
            // 
            this.tbRegistered.Location = new System.Drawing.Point(234, 140);
            this.tbRegistered.Name = "tbRegistered";
            this.tbRegistered.ReadOnly = true;
            this.tbRegistered.Size = new System.Drawing.Size(277, 20);
            this.tbRegistered.TabIndex = 7;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(376, 88);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(54, 20);
            this.tbID.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bRawLast5);
            this.panel1.Controls.Add(this.lTotal);
            this.panel1.Controls.Add(this.lLast5);
            this.panel1.Controls.Add(this.bRefreshLast5);
            this.panel1.Controls.Add(this.tbLast5);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 152);
            this.panel1.TabIndex = 3;
            // 
            // bRawLast5
            // 
            this.bRawLast5.Location = new System.Drawing.Point(2, 127);
            this.bRawLast5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRawLast5.Name = "bRawLast5";
            this.bRawLast5.Size = new System.Drawing.Size(47, 23);
            this.bRawLast5.TabIndex = 23;
            this.bRawLast5.Text = "Raw";
            this.bRawLast5.UseVisualStyleBackColor = true;
            this.bRawLast5.Click += new System.EventHandler(this.bRawLast5_Click);
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(75, 114);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(79, 13);
            this.lTotal.TabIndex = 6;
            this.lTotal.Text = "Total Accounts";
            // 
            // lLast5
            // 
            this.lLast5.AutoSize = true;
            this.lLast5.Location = new System.Drawing.Point(1, 13);
            this.lLast5.Name = "lLast5";
            this.lLast5.Size = new System.Drawing.Size(98, 13);
            this.lLast5.TabIndex = 5;
            this.lLast5.Text = "Last Five Accounts";
            // 
            // bRefreshLast5
            // 
            this.bRefreshLast5.Location = new System.Drawing.Point(144, 1);
            this.bRefreshLast5.Name = "bRefreshLast5";
            this.bRefreshLast5.Size = new System.Drawing.Size(75, 23);
            this.bRefreshLast5.TabIndex = 4;
            this.bRefreshLast5.Text = "Refresh";
            this.bRefreshLast5.UseVisualStyleBackColor = true;
            this.bRefreshLast5.Click += new System.EventHandler(this.bRefreshLast5_Click);
            // 
            // tbLast5
            // 
            this.tbLast5.Location = new System.Drawing.Point(4, 29);
            this.tbLast5.Multiline = true;
            this.tbLast5.Name = "tbLast5";
            this.tbLast5.ReadOnly = true;
            this.tbLast5.Size = new System.Drawing.Size(215, 76);
            this.tbLast5.TabIndex = 2;
            this.tbLast5.Text = "1\r\n2\r\n3\r\n4\r\n5";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(160, 110);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(59, 20);
            this.tbTotal.TabIndex = 0;
            this.tbTotal.Text = "1337";
            // 
            // bLookup
            // 
            this.bLookup.Location = new System.Drawing.Point(339, 7);
            this.bLookup.Name = "bLookup";
            this.bLookup.Size = new System.Drawing.Size(54, 23);
            this.bLookup.TabIndex = 2;
            this.bLookup.Text = "Lookup Player/ID";
            this.bLookup.UseVisualStyleBackColor = true;
            this.bLookup.Click += new System.EventHandler(this.bLookup_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(234, 10);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(100, 20);
            this.tBSearch.TabIndex = 1;
            this.tBSearch.Text = "Player Name/ID";
            this.tBSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBSearch_Key);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(436, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bRawServer);
            this.tabPage2.Controls.Add(this.lof);
            this.tabPage2.Controls.Add(this.lPlayers);
            this.tabPage2.Controls.Add(this.lSoftware);
            this.tabPage2.Controls.Add(this.lUptime);
            this.tabPage2.Controls.Add(this.lServer);
            this.tabPage2.Controls.Add(this.txMaxPlayers);
            this.tabPage2.Controls.Add(this.tbSoftware);
            this.tabPage2.Controls.Add(this.tbUptime);
            this.tabPage2.Controls.Add(this.tbPlayers);
            this.tabPage2.Controls.Add(this.bRefreshServers);
            this.tabPage2.Controls.Add(this.cbServer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(568, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Servers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bRawServer
            // 
            this.bRawServer.Location = new System.Drawing.Point(5, 218);
            this.bRawServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRawServer.Name = "bRawServer";
            this.bRawServer.Size = new System.Drawing.Size(47, 23);
            this.bRawServer.TabIndex = 23;
            this.bRawServer.Text = "Raw";
            this.bRawServer.UseVisualStyleBackColor = true;
            this.bRawServer.Click += new System.EventHandler(this.bRawServer_Click);
            // 
            // lof
            // 
            this.lof.AutoSize = true;
            this.lof.Location = new System.Drawing.Point(468, 62);
            this.lof.Name = "lof";
            this.lof.Size = new System.Drawing.Size(16, 13);
            this.lof.TabIndex = 19;
            this.lof.Text = "of";
            // 
            // lPlayers
            // 
            this.lPlayers.AutoSize = true;
            this.lPlayers.Location = new System.Drawing.Point(389, 40);
            this.lPlayers.Name = "lPlayers";
            this.lPlayers.Size = new System.Drawing.Size(67, 13);
            this.lPlayers.TabIndex = 18;
            this.lPlayers.Text = "Player Count";
            // 
            // lSoftware
            // 
            this.lSoftware.AutoSize = true;
            this.lSoftware.Location = new System.Drawing.Point(5, 144);
            this.lSoftware.Name = "lSoftware";
            this.lSoftware.Size = new System.Drawing.Size(49, 13);
            this.lSoftware.TabIndex = 17;
            this.lSoftware.Text = "Software";
            // 
            // lUptime
            // 
            this.lUptime.AutoSize = true;
            this.lUptime.Location = new System.Drawing.Point(5, 92);
            this.lUptime.Name = "lUptime";
            this.lUptime.Size = new System.Drawing.Size(40, 13);
            this.lUptime.TabIndex = 16;
            this.lUptime.Text = "Uptime";
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(5, 40);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(38, 13);
            this.lServer.TabIndex = 15;
            this.lServer.Text = "Server";
            // 
            // txMaxPlayers
            // 
            this.txMaxPlayers.Location = new System.Drawing.Point(489, 59);
            this.txMaxPlayers.Name = "txMaxPlayers";
            this.txMaxPlayers.ReadOnly = true;
            this.txMaxPlayers.Size = new System.Drawing.Size(76, 20);
            this.txMaxPlayers.TabIndex = 13;
            // 
            // tbSoftware
            // 
            this.tbSoftware.Location = new System.Drawing.Point(5, 163);
            this.tbSoftware.Name = "tbSoftware";
            this.tbSoftware.ReadOnly = true;
            this.tbSoftware.Size = new System.Drawing.Size(560, 20);
            this.tbSoftware.TabIndex = 11;
            // 
            // tbUptime
            // 
            this.tbUptime.Location = new System.Drawing.Point(5, 111);
            this.tbUptime.Name = "tbUptime";
            this.tbUptime.ReadOnly = true;
            this.tbUptime.Size = new System.Drawing.Size(560, 20);
            this.tbUptime.TabIndex = 9;
            // 
            // tbPlayers
            // 
            this.tbPlayers.Location = new System.Drawing.Point(392, 59);
            this.tbPlayers.Name = "tbPlayers";
            this.tbPlayers.ReadOnly = true;
            this.tbPlayers.Size = new System.Drawing.Size(72, 20);
            this.tbPlayers.TabIndex = 5;
            this.tbPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bRefreshServers
            // 
            this.bRefreshServers.Location = new System.Drawing.Point(489, 217);
            this.bRefreshServers.Name = "bRefreshServers";
            this.bRefreshServers.Size = new System.Drawing.Size(75, 23);
            this.bRefreshServers.TabIndex = 1;
            this.bRefreshServers.Text = "Refresh";
            this.bRefreshServers.UseVisualStyleBackColor = true;
            this.bRefreshServers.Click += new System.EventHandler(this.bRefreshServers_Click);
            // 
            // cbServer
            // 
            this.cbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(5, 59);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(380, 21);
            this.cbServer.TabIndex = 0;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 294);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ClassiCube API";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button bLookup;
		private System.Windows.Forms.TextBox tBSearch;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbLast5;
		private System.Windows.Forms.TextBox tbTotal;
		private System.Windows.Forms.TextBox tbSoftware;
		private System.Windows.Forms.TextBox tbUptime;
		private System.Windows.Forms.TextBox tbPlayers;
		private System.Windows.Forms.Button bRefreshServers;
		private System.Windows.Forms.ComboBox cbServer;
		private System.Windows.Forms.TextBox txMaxPlayers;
		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.TextBox tbFlags;
		private System.Windows.Forms.TextBox tbRegistered;
		private System.Windows.Forms.TextBox tbID;
		private System.Windows.Forms.Button bRefreshLast5;
		private System.Windows.Forms.Button bIDLookup;
		private System.Windows.Forms.Label lFlags;
		private System.Windows.Forms.Label lRegistered;
		private System.Windows.Forms.Label lID;
		private System.Windows.Forms.Label lUserName;
		private System.Windows.Forms.Label lTotal;
		private System.Windows.Forms.Label lLast5;
		private System.Windows.Forms.Label lof;
		private System.Windows.Forms.Label lPlayers;
		private System.Windows.Forms.Label lSoftware;
		private System.Windows.Forms.Label lUptime;
		private System.Windows.Forms.Label lServer;
        private System.Windows.Forms.Button bRawPlayer;
        private System.Windows.Forms.Button bRawLast5;
        private System.Windows.Forms.Button bRawServer;
    }
}

