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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CCTicker.CCTickerFrm;

namespace CCTicker
{
  public partial class CCTickerFrm : Form
  {
    public CCTickerFrm()
    {
      InitializeComponent();
      tmrDecred.Start();
      RequestCryptoInfo();
    }

    [Serializable]
    public class CryptoStats
    {
      [JsonProperty("id")]
      public string id { get; set; }
      [JsonProperty("name")]
      public string name { get; set; }
      [JsonProperty("symbol")]
      public string symbol { get; set; }
      [JsonProperty("rank")]
      public int rank { get; set; }
      [JsonProperty("price_usd")]
      public float price_usd { get; set; }
      [JsonProperty("price_btc")]
      public float price_btc { get; set; }
      [JsonProperty("24h_volume_usd")]
      public float day_volume_usd { get; set; }
      [JsonProperty("market_cap_usd")]
      public float market_cap_usd { get; set; }
      [JsonProperty("total_supply")]
      public float total_supply { get; set; }
      [JsonProperty("percent_change_1h")]
      public float percent_change_1h { get; set; }
      [JsonProperty("percent_change_24h")]
      public float percent_change_24h { get; set; }
      [JsonProperty("percent_change_7d")]
      public float percent_change_7d { get; set; }
      [JsonProperty("last_updated")]
      public double last_updated { get; set; }
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
          string decredjson = wc.DownloadString("https://api.coinmarketcap.com/v1/ticker/decred");
          string bitcoinjson = wc.DownloadString("https://api.coinmarketcap.com/v1/ticker/bitcoin");


          decredjson = StripArrayCharacters(decredjson);
          bitcoinjson = StripArrayCharacters(bitcoinjson);

          CryptoStats decred = JsonConvert.DeserializeObject<CryptoStats>(decredjson);
          CryptoStats bitcoin = JsonConvert.DeserializeObject<CryptoStats>(bitcoinjson);

          lblDecredUSDValueDisplay.Text = "$" + decred.price_usd.ToString();
          lblBitcoinUSDValueDisplay.Text = "$" + bitcoin.price_usd.ToString();
        }
      }
      catch(Exception)
      {
        tmrDecred.Stop();
        lblHTTPException.Visible = true;
      }
    }

    private string StripArrayCharacters(string json)
    {
      json = json.Replace("[", "");
      json = json.Replace("]", "");
      return json;
    }

    private void lblHTTPException_Click(object sender, EventArgs e)
    {
      lblHTTPException.Visible = false;
      tmrDecred.Start();
    }
  }
}
