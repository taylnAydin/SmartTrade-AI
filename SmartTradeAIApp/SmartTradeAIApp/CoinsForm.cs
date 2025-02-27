using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SmartTradeAIApp
{
    public partial class CoinsForm : Form
    {
        private MainForm mainForm;

        public CoinsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.KeyPreview = true;
        }

        private async void CoinsForm_Load(object sender, EventArgs e)
        {
            if (!IsFlaskRunning())
            {
                StartFlaskAPI();
            }

            MessageBox.Show("Fetching top 25 coins by volume in the last 24 hours. This may take 15-20 seconds. Please wait...",
                            "Loading", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var coins = await GetTop25CoinsByVolume();

            if (coins != null && coins.Any())
            {
                listViewCoins.Items.Clear();
                foreach (var coin in coins)
                {
                    ListViewItem item = new ListViewItem(coin);
                    listViewCoins.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Failed to fetch coin data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<string>> GetTop25CoinsByVolume()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://api.binance.com/api/v3/ticker/24hr");
                var json = JsonConvert.DeserializeObject<List<dynamic>>(response);

                List<string> top25Coins = json
                    .Where(x => x.symbol.ToString().EndsWith("USDT"))
                    .OrderByDescending(x => decimal.Parse(x.quoteVolume.ToString()))
                    .Take(25)
                    .Select(x => (string)x.symbol.ToString())
                    .ToList();

                return top25Coins;
            }
        }

        private void CoinsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CoinsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                mainForm.Show();
            }
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private bool IsFlaskRunning()
        {
            try
            {
                using (var client = new WebClient())
                {
                    string response = client.DownloadString("http://127.0.0.1:5000/");
                    return response.Contains("SmartTrade AI Flask API is Running!");
                }
            }
            catch
            {
                return false;
            }
        }

        private void StartFlaskAPI()
        {
            try
            {
                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = @"C:\Users\Administrator\Desktop\SmartTrade-AI\venv\Scripts\python.exe",
                    Arguments = @"""C:\Users\Administrator\Desktop\SmartTrade-AI\ml Model\mlModel.py""",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };


                Process process = new Process { StartInfo = start };
                process.Start();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start Flask API: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
