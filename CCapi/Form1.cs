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
        }
        #region Players
        private void bLookup_Click(object sender, EventArgs e) {
            getPlayer(1);
        }

        private void bIDLookup_Click(object sender, EventArgs e) {
            getPlayer(2);
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
            tbRegistered.Text = registered.ToLongDateString() + " at " + registered.ToLongTimeString();
            string flagsResult = result.Get("flags");
            string flags = "ClassiCube User, ";
            
            foreach (var kvp in Constants.UserFlags) {
                if (flagsResult.IndexOf(kvp.Key) >= 0)
                    flags += kvp.Value + ", ";
            }
            tbFlags.Text = flags.Remove(flags.Length - 2, 2);
            pictureBox1.Image = getAvatar(result.Get("username"));
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
        
        private Image getAvatar(string name) {
            try {
                Stream stream = new WebClient().OpenRead("https://www.classicube.net/face/" + name + ".png");
                return Image.FromStream(stream);
            } catch {
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
                    (string)pairs["country_abbr"]));
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

        public ccServer(string hash, string name, string players, string maxPlayers, string uptime, string software, string country_abbr) {
            Hash = hash;
            Name = name;
            Players = players;
            MaximumPlayers = maxPlayers;
            Uptime = uptime;
            Software = software;
            Country = country_abbr;
        }
    }
    #endregion
}
