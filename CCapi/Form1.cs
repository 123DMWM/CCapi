using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Text;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace CCapi {
	public partial class Form1 : Form {		
		public Form1() {
			InitializeComponent();
			getLastFive();
		}
		#region Players
		private void button1_Click(object sender, EventArgs e) {
			getPlayer(1);
		}

		private void button4_Click(object sender, EventArgs e) {
			getPlayer(2);
		}
		private void textBox1_Key(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				getPlayer(3);
			}
		}
		private void getPlayer(byte function) {
			string name = textBox1.Text;
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

			textBox24.Text = result.Get("username");
			textBox19.Text = result.Get("id");
			DateTime registered = epoch.AddSeconds(double.Parse(result.Get("registered"))).ToLocalTime();
			textBox21.Text = registered.ToLongDateString() + " at " + registered.ToLongTimeString();
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
			textBox23.Text = flags.Remove(flags.Length - 2, 2);
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
				textBox4.Text = nan.Replace(result.Get("lastfive"), "").Replace(",", Environment.NewLine);
				textBox2.Text = result.Get("playercount");
			} catch {
				MessageBox.Show("ClassiCube.net might be down!");
				return;
			}
		}
		private void button3_Click(object sender, EventArgs e) {
			getLastFive();
		}
		#endregion
		#region Servers
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			getServerInfo();
		}
		private void tabControl1_Change(object sender, EventArgs e) {
			if (tabControl1.TabIndex == 1) {
				getServers();
			}
		}
		private void button2_Click(object sender, EventArgs e) {
			getServers();
		}
		List<ccServer> servers;
		private void getServers() {
			string content = new StreamReader(new WebClient().OpenRead("http://www.classicube.net/api/serverlist")).ReadToEnd();
			servers = JsonConvert.DeserializeObject<List<ccServer>>(content);
			comboBox1.Items.Clear();
			textBox7.Text = "";
			textBox9.Text = "";
			textBox17.Text = "";
			textBox13.Text = "";
			textBox15.Text = "";
			for (int i = 0; i < servers.Count; i++) {
				comboBox1.Items.Add(servers[i].name);
			}
		}
		private void getServerInfo() {
			textBox7.Text = servers[comboBox1.SelectedIndex].name;
			textBox9.Text = servers[comboBox1.SelectedIndex].players;
			textBox17.Text = servers[comboBox1.SelectedIndex].maxplayers;
			textBox13.Text = timeToString(TimeSpan.FromSeconds(double.Parse(servers[comboBox1.SelectedIndex].uptime)));
			textBox15.Text = servers[comboBox1.SelectedIndex].software;
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

	}
	class ccServer {
		public String hash { get; set; }
		public String maxplayers { get; set; }
		public String name { get; set; }
		public String players { get; set; }
		public String software { get; set; }
		public String uptime { get; set; }
	}
		#endregion
}
