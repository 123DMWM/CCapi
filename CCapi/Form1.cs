using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ServiceStack.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using Jason;

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
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            JsonObject result = null;
            string api;
            if (function == 2) {
                api = "id/";
                int id;
                if (!int.TryParse(name, out id)) {
                    MessageBox.Show("That is not a valid ID!");
                    return;
                }
            } else {
                api = "player/";
            }
            bool retern = false;
            switch (function) {
                case 1:
                case 2:
                    try {
                        result = JsonObject.Parse((new WebClient()).DownloadString("http://www.classicube.net/api/" + api + name));
                        if (("User not found").Equals(result.Get("error"))) {
                            MessageBox.Show("No player found by that Name or ID!");
                            retern = true;
                            break;
                        }
                    } catch {
                        MessageBox.Show("ClassiCube.net might be down!");
                        retern = true;
                        break;
                    }
                    break;
                case 3:
                    try {
                        result = JsonObject.Parse((new WebClient()).DownloadString("http://www.classicube.net/api/player/" + name));
                    } catch {
                        MessageBox.Show("ClassiCube.net might be down!");
                        retern = true;
                        break;
                    }
                    if (result.Get("error").Equals("User not found")) {
                        result = JsonObject.Parse((new WebClient()).DownloadString("http://www.classicube.net/api/id/" + name));
                        if (result.Get("error").Equals("User not found")) {
                            MessageBox.Show("No player found by that Name or ID!");
                            retern = true;
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
            if (retern)
                return;

            tbUserName.Text = result.Get("username");
            tbID.Text = result.Get("id");
            DateTime registered = epoch.AddSeconds(double.Parse(result.Get("registered"))).ToLocalTime();
            tbRegistered.Text = registered.ToLongDateString() + " at " + registered.ToLongTimeString();
            string flagsResult = result.Get("flags");
            string flags = "ClassiCube User, ";
            if (flagsResult.Contains('b')) {
                flags += "Banned from forums, ";
            }
            if (flagsResult.Contains('d')) {
                flags += "ClassiCube Devloper, ";
            }
            if (flagsResult.Contains('m')) {
                flags += "Forum Moderator, ";
            }
            if (flagsResult.Contains('a')) {
                flags += "Forum Administrator, ";
            }
            if (flagsResult.Contains('e')) {
                flags += "ClassiCube Blog Editor, ";
            }
            tbFlags.Text = flags.Remove(flags.Length - 2, 2);
            pictureBox1.Image = getAvatar(result.Get("username"));
        }
        private Image getAvatar(string name) {
            WebClient client = new WebClient();
            Stream stream;
            try {
                stream = client.OpenRead("http://www.classicube.net/face/" + name);
                return Image.FromStream(stream);
            } catch {
                MessageBox.Show("Failed to get skin. ClassiCube.net might be down!");
                return null;
            }

        }

        private void getLastFive() {
            JsonObject result = null;
            Regex nan = new Regex("[^a-zA-Z0-9_.,]");
            try {
                result = JsonObject.Parse((new WebClient()).DownloadString("http://www.classicube.net/api/players"));
                tbLast5.Text = nan.Replace(result.Get("lastfive"), "").Replace(",", Environment.NewLine);
                tbTotal.Text = result.Get("playercount");
            } catch {
                MessageBox.Show("ClassiCube.net might be down!");
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
            string response = new StreamReader(new WebClient().OpenRead("http://www.classicube.net/api/servers")).ReadToEnd();
            int index = 0; bool success = true;
            Dictionary<string, object> root =
                (Dictionary<string, object>)Json.ParseValue(response, ref index, ref success);
            List<object> list = (List<object>)root["servers"];

            foreach (object server in list) {
                Dictionary<string, object> pairs = (Dictionary<string, object>)server;
                servers.Add(new ccServer(
                    (string)pairs["hash"], (string)pairs["name"],
                    (string)pairs["players"], (string)pairs["maxplayers"],
                    (string)pairs["uptime"], (string)pairs["software"]));
            }
            return servers;
        }
        private void getServerInfo() {
            tbPlayers.Text = servers[cbServer.SelectedIndex].Players;
            txMaxPlayers.Text = servers[cbServer.SelectedIndex].MaximumPlayers;
            tbUptime.Text = timeToString(TimeSpan.FromSeconds(double.Parse(servers[cbServer.SelectedIndex].Uptime)));
            tbSoftware.Text = servers[cbServer.SelectedIndex].Software;
            tbHash.Text = servers[cbServer.SelectedIndex].Hash;
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
            System.Diagnostics.Process.Start("http://www.classicube.net/api/players");
        }

        private void bRawPlayer_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://www.classicube.net/api/id/" + tbID.Text);
        }

        private void bRawServer_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://www.classicube.net/api/servers");
        }

        private void bOpenHash_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://www.classicube.net/server/play/" + servers[cbServer.SelectedIndex].Hash);
        }
    }
    public class ccServer {
        public string Hash { get; set; }
        public string MaximumPlayers { get; set; }
        public string Name { get; set; }
        public string Players { get; set; }
        public string Software { get; set; }
        public string Uptime { get; set; }

        public ccServer(string hash, string name, string players, string maxPlayers, string uptime, string software) {
            Hash = hash;
            Name = name;
            Players = players;
            MaximumPlayers = maxPlayers;
            Uptime = uptime;
            Software = software;
        }
    }
    #endregion
}
