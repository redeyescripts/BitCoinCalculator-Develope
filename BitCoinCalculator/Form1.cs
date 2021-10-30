using Newtonsoft.Json;
using Simple.OData.Client.V3.Adapter;
using Simple.OData.Client.V4.Adapter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitCoinCalculator
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RatesBtn_Click(object sender, EventArgs e)
        {
            if (currencyMenu.SelectedItem.ToString() == "EUR")
            {
                result.Visible = true;

                BitCoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBtc.Text);
                float currentRate = resultRates.cpi.EUR.rate_float;
                float btcResult = userCoins * currentRate;
                result.Text = $"{btcResult} {resultRates.cpi.EUR.code}";
            }
            if (currencyMenu.SelectedItem.ToString() == "USD")
            {
                result.Visible = true;
                BitCoinRates resultRates = GetRates();
                int userCoins = Int32.Parse(amountOfBtc.Text);


                float currentRate = resultRates.cpi.USD.rate_float;
                float btcResult = userCoins * currentRate;
                result.Text = $"{btcResult} {resultRates.cpi.USD.code}";
            }
        }
        public static BitCoinRates GetRates()
        {

            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            BitCoinRates bitcoin;
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitCoinRates>(response);
            }

            return bitcoin;
        }










        private void tulemus_TextChanged(object sender, EventArgs e)
        {

        }

        private void result1_TextChanged(object sender, EventArgs e)
        {

        }

        private void currency2_click(object sender, EventArgs e)
        {
            if (currency2.SelectedItem.ToString() == "EUR")
            {
                result.Visible = true;

                DogeCoinRates resultRates =GetDoge();
                int userCoins = Int32.Parse(currencyshow.Text);
                float currentRate = resultRates.dpi.EURO.rate_float;
                float DogeResult = userCoins * currentRate;
                result.Text = $"{DogeResult} {resultRates.dpi.EURO.code}";
            }
            if (currency2.SelectedItem.ToString() == "USD")
            {
                result.Visible = true;
                DogeCoinRates resultRates = GetDoge();
                int userCoins = Int32.Parse(currencyshow.Text);


                float currentRate = resultRates.dpi.US.rate_float;
                float DogeResult = userCoins * currentRate;
                result.Text = $"{DogeResult} {resultRates.dpi.US.code}";
            }
        }

        private void amountOfDoge_TextChanged(object sender, EventArgs e)
        {

        }
        public static DogeCoinRates GetDoge()
        {




            string url = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            DogeCoinRates dogecoin;
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                dogecoin = JsonConvert.DeserializeObject<DogeCoinRates>(response);
            }


            return dogecoin;
        }

        private void result2_Click(object sender, EventArgs e)
        {

        }

        private void currencyMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
