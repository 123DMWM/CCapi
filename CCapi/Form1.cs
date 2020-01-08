using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Jason;
using ServiceStack.Text;

namespace CCapi {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            getLastFive();
            setRegisteredDateTime(DateTime.Now);
        }
        #region Players
        private DateTime userRegisteredDate = DateTime.Now;
        private void bLookup_Click(object sender, EventArgs e) {
            getPlayer(1);
        }

        private void bIDLookup_Click(object sender, EventArgs e) {
            getPlayer(2);
        }
        private void tBSearch_GotFocus(object sender, EventArgs e) {
            if (tBSearch.Text == "Player Name/ID") {
                tBSearch.Text = "";
            }
        }

        private void bSkinDownload_Click(object sender, EventArgs e) {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://classicube.s3.amazonaws.com/skins/" + tbUserName.Text + ".png");
            request.Method = "HEAD";
            try {
                request.GetResponse();
                System.Diagnostics.Process.Start("https://classicube.s3.amazonaws.com/skins/" + tbUserName.Text + ".png");
            }
            catch {
                MessageBox.Show("This player has no custom skin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void tBSearch_Key(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                getPlayer(3);
            }
        }
        private void getPlayer(byte function) {
            string name = tBSearch.Text;
            JsonObject result = null;
            string api;

            if (function == 2) {
                api = "id/";
                if (!int.TryParse(name, out _)) {
                    MessageBox.Show("That is not a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else {
                api = "player/";
            }

            switch (function) {
                case 1:
                case 2:
                    result = GetUserData(api + name);
                    if (result == null) return;
                    
                    if (result.Get("error") == Constants.NotFound) {
                        MessageBox.Show("No player found by that username or ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 3:
                    result = GetUserData("player/" + name);
                    if (result == null) return;
                    if (result.Get("error") != Constants.NotFound) break;
                    
                    result = GetUserData("id/" + name);
                    if (result == null) return;
                    
                    if (result.Get("error") == Constants.NotFound) {
                        MessageBox.Show("No player found by that username or ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }

            tbUserName.Text = result.Get("username");
            tbID.Text = result.Get("id");
            DateTime registered = Constants.Epoch.AddSeconds(double.Parse(result.Get("registered"))).ToLocalTime();
            userRegisteredDate = registered;
            dtpRegistered.Enabled = true;
            setRegisteredDateTime(registered);
            tbForumTitle.Text = result.Get("forum_title");
            string flagsResult = result.Get("flags");
            string flags = "";
            
            foreach (var kvp in Constants.UserFlags) {
                if (flagsResult.IndexOf(kvp.Key) >= 0)
                    flags += kvp.Value + ", ";
            }
            tbFlags.Text = flags != "" ? flags.Remove(flags.Length - 2, 2) + " " + flagsResult : flags;
            pictureBox1.Image = getAvatar(result.Get("username"));
            bSkinDownload.Enabled = true;
        }
        
        JsonObject GetUserData(string apiPoint) {
            try {
                string raw = new WebClient().DownloadString("https://www.classicube.net/api/" + apiPoint);
                return JsonObject.Parse(raw);
            } catch {
                MessageBox.Show("Failed to retrieve API data. ClassiCube.net might be down!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        private void setRegisteredDateTime(DateTime date) {            
            if (tbUserName.Text == "") date = DateTime.Now;
            if (cbUTC.Checked) date = date.ToUniversalTime();
            if (dtpRegistered.Value != date) {
                if (dtpRegistered.Enabled) {
                    dtpRegistered.MaxDate = cbUTC.Enabled ? DateTime.UtcNow : DateTime.Now;
                    dtpRegistered.Value = date;
                }
                tbRegistered.Text = date.ToLongTimeString();
            }
        }
        private void dtpRegistered_Changed(object sender, EventArgs e) {
            setRegisteredDateTime(userRegisteredDate);
        }
        private void cbUTC_CheckedChanged(object sender, EventArgs e) {
            setRegisteredDateTime(userRegisteredDate);
        }

        private Image getAvatar(string name) {
            try {
                Stream stream = new WebClient().OpenRead("https://classicube.s3.amazonaws.com/face/" + name + ".png");
                return Image.FromStream(stream);
            } catch {
                MessageBox.Show("Failed to retrieve skin. ClassiCube.net might be down!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        private Image getCountry(string name) {
            try {
                Stream stream = new WebClient().OpenRead("https://static.classicube.net/img/flags/" + name.ToLower() + ".png");
                return Image.FromStream(stream);
            }
            catch {
                MessageBox.Show("Failed to retrieve skin. ClassiCube.net might be down!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void getLastFive() {
            JsonObject result = null;
            Regex nan = new Regex("[^a-zA-Z0-9_.,]");
            try {
                result = JsonObject.Parse((new WebClient()).DownloadString("https://www.classicube.net/api/players"));
                tbLast5.Text = nan.Replace(result.Get("lastfive"), "").Replace(",", Environment.NewLine);
                tbTotal.Text = result.Get("playercount");
            } catch {
                MessageBox.Show("Failed to retrieve last five accounts. ClassiCube.net might be down!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void bRefreshLast5_Click(object sender, EventArgs e) {
            getLastFive();
        }
        #endregion
        #region Servers
        private void cbServer_SelectedIndexChanged(object sender, EventArgs e) {
            getServerInfo();
        }
        private void tabControl1_Change(object sender, EventArgs e) {
            if (tabs.TabIndex == 1) {
                getServers();
            }
        }
        private void bRefreshServers_Click(object sender, EventArgs e) {
            getServers();
        }
        List<ccServer> servers;
        private void getServers() {
            servers = GetPublicServers();
            cbServer.Items.Clear();
            tbPlayers.Text = "";
            txMaxPlayers.Text = "";
            tbUptime.Text = "";
            tbSoftware.Text = "";
            tbFeatured.Text = "";
            tbHash.Text = "";
            tbCountry.Text = "";
            pbCountry.Image = null;
            for (int i = 0; i < servers.Count; i++) {
                cbServer.Items.Add(servers[i].Name);
            }
        }

        public List<ccServer> GetPublicServers() {
            List<ccServer> servers = new List<ccServer>();
            string response = new WebClient().DownloadString("https://www.classicube.net/api/servers");
            int index = 0; bool success = true;
            Dictionary<string, object> root =
                (Dictionary<string, object>)Json.ParseValue(response, ref index, ref success);
            List<object> list = (List<object>)root["servers"];

            foreach (object server in list) {
                Dictionary<string, object> pairs = (Dictionary<string, object>)server;
                servers.Add(new ccServer(
                    (string)pairs["hash"], (string)pairs["name"],
                    (string)pairs["players"], (string)pairs["maxplayers"],
                    (string)pairs["uptime"], (string)pairs["software"],
                    (string)pairs["country_abbr"], (bool)pairs["featured"]));
            }
            return servers;
        }
        private void getServerInfo() {
            tbPlayers.Text = servers[cbServer.SelectedIndex].Players;
            txMaxPlayers.Text = servers[cbServer.SelectedIndex].MaximumPlayers;
            tbUptime.Text = timeToString(TimeSpan.FromSeconds(double.Parse(servers[cbServer.SelectedIndex].Uptime)));
            tbSoftware.Text = servers[cbServer.SelectedIndex].Software;
            tbHash.Text = servers[cbServer.SelectedIndex].Hash;
            tbCountry.Text = servers[cbServer.SelectedIndex].Country;
            pbCountry.Image = getCountry(servers[cbServer.SelectedIndex].Country);
            tbFeatured.Text = servers[cbServer.SelectedIndex].Featured.ToString();
            return;
        }
        private string timeToString(TimeSpan span) {
            if (span.TotalSeconds < 60) {
                return String.Format("{0} seconds", span.Seconds);
            } else if (span.TotalMinutes < 60) {
                return String.Format("{0} minutes {1} seconds", span.Minutes, span.Seconds);
            } else if (span.TotalHours < 48) {
                return String.Format("{0} hours {1} minutes", (int)Math.Floor(span.TotalHours), span.Minutes);
            } else if (span.TotalDays < 15) {
                return String.Format("{0} days {1} hours", span.Days, span.Hours);
            } else {
                return String.Format("{0:0} weeks {1:0} days", Math.Floor(span.TotalDays / 7), Math.Floor(span.TotalDays) % 7);
            }
        }

        private void bRawLast5_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.classicube.net/api/players");
        }

        private void bRawPlayer_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.classicube.net/api/id/" + tbID.Text);
        }

        private void bDownloadSkin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.classicube.net/skins/" + tbUserName.Text + ".png");
        }

        private void bRawServer_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.classicube.net/api/servers");
        }

        private void bOpenHash_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.classicube.net/server/play/" + servers[cbServer.SelectedIndex].Hash);
        }
    }
    public class ccServer {
        public string Hash { get; set; }
        public string MaximumPlayers { get; set; }
        public string Name { get; set; }
        public string Players { get; set; }
        public string Software { get; set; }
        public string Uptime { get; set; }
        public string Country { get; set; }
        public bool Featured { get; set; }

        public ccServer(string hash, string name, string players, string maxPlayers, string uptime, string software, string country_abbr, bool featured) {
            Hash = hash;
            Name = name;
            Players = players;
            MaximumPlayers = maxPlayers;
            Uptime = uptime;
            Software = software;
            Country = country_abbr;
            Featured = featured;
        }
    }
    #endregion
}
