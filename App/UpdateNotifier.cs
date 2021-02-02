using System;
using System.Net.Http;
using System.Windows.Forms;

namespace tarkov_settings
{
    public partial class UpdateNotifier : Form
    {
        private Version current, latest;
        private string downloadUrl = @"https://github.com/incheon-kim/tarkov-settings/releases/latest";
        private string checkUrl = @"https://raw.githubusercontent.com/incheon-kim/tarkov-settings/main/version";
        public UpdateNotifier(Version current)
        {
            InitializeComponent();
            this.current = current;
            this.CurrentVersionLabel.Text = current.ToString();
            CheckUpdate();
        }

        private async void CheckUpdate()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(checkUrl);
                    response.EnsureSuccessStatusCode();

                    string version = await response.Content.ReadAsStringAsync();
                    this.LatestVersionLabel.Text = version;
                    latest = new Version(version);
                    if(latest > current)
                    {
                        this.ShowDialog();
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void UpdateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(downloadUrl);
            Application.Exit();
        }
    }
}
