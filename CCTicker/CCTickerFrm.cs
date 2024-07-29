using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CCTicker.CCTickerFrm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CCTicker
{
    public partial class CCTickerFrm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public CCTickerFrm()
        {
            InitializeComponent();
            tmrDecred.Start();
            RequestCryptoInfo();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        public class CryptoPrice
        {
            [JsonProperty("usd")]
            public decimal Usd { get; set; }
        }

        public class DecredResponse
        {
            [JsonProperty("decred")]
            public CryptoPrice Decred { get; set; }
        }

        public class BitcoinResponse
        {
            [JsonProperty("bitcoin")]
            public CryptoPrice Bitcoin { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrDecred_Tick(object sender, EventArgs e)
        {
            RequestCryptoInfo();
        }

        private void RequestCryptoInfo()
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string decredjson = wc.DownloadString("https://api.coingecko.com/api/v3/simple/price?ids=decred&vs_currencies=usd");
                    string bitcoinjson = wc.DownloadString("https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd");

                    DecredResponse decred = JsonConvert.DeserializeObject<DecredResponse>(decredjson);
                    BitcoinResponse bitcoin = JsonConvert.DeserializeObject<BitcoinResponse>(bitcoinjson);

                    lblDecredUSDValueDisplay.Text = "$" + decred.Decred.Usd.ToString("N");
                    lblBitcoinUSDValueDisplay.Text = "$" + bitcoin.Bitcoin.Usd.ToString("N");
                }
            }
            catch (Exception)
            {
                tmrDecred.Stop();
                lblHTTPException.Visible = true;
            }
        }

        private void lblHTTPException_Click(object sender, EventArgs e)
        {
            lblHTTPException.Visible = false;
            tmrDecred.Start();
        }
    }
}
