using Binance.Net.Clients;

using Bitget.Net.Clients;

using CryptoApp_TestTask.Connectors.Base;
using CryptoApp_TestTask.Factory;
using CryptoApp_TestTask.Managers;

using Kucoin.Net.Clients;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CryptoApp_TestTask
{
    public partial class Form1 : Form
    {
        private readonly List<BaseCryptoApiConnector> apis;
        private readonly PriceLabelManager priceLabelManager;

        public Form1()
        {
            InitializeComponent();


            apis = ApiConnectorFactory.CreateApiConnectors();
            priceLabelManager = new PriceLabelManager(labelBinance, labelBybit, labelKucoin, labelBitget);

            comboBoxSymbol.Items.AddRange(new string[] { "BTCUSDT", "ETHUSDT", "BNBUSDT" });
            comboBoxSymbol.SelectedIndex = 0;
        }

        private async void buttonStart_Click(object sender, System.EventArgs e)
        {
            var selectedSymbol = comboBoxSymbol.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedSymbol)) return;

            foreach (var api in apis)
            {
                var apiName = api.GetType().Name.Replace("ApiConnector", "");
                await api.ConnectAsync(selectedSymbol, price =>
                {
                    this.Invoke(new Action(() =>
                    {
                        priceLabelManager.UpdateLabel(apiName, price);
                    }));
                });
            }
        }




        //    public async Task BinanceConnectAsync()
        //    {
        //        // Subscribe to ETH/USDT ticker updates via the websocket API
        //        var socketClient = new BinanceSocketClient();
        //        var tickerSubscriptionResult = socketClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync("ETHUSDT", (update) =>
        //        {
        //            var lastPrice = update.Data.LastPrice;
        //        });
        //    }

        //    public async Task BybitConnectAsync()
        //    {
        //        // Subscribe to ETH/USDT ticker updates via the websocket API
        //        var socketClient = new KucoinSocketClient();
        //        var tickerSubscriptionResult = socketClient.SpotApi.SubscribeToTickerUpdatesAsync("ETH-USDT", (update) =>
        //        {
        //            var lastPrice = update.Data.LastPrice;
        //        });
        //    }

        //    public async Task KucoinConnectAsync()
        //    {
        //        // Subscribe to ETH/USDT ticker updates via the websocket API
        //        var socketClient = new KucoinSocketClient();
        //        var tickerSubscriptionResult = socketClient.SpotApi.SubscribeToTickerUpdatesAsync("ETH-USDT", (update) =>
        //        {
        //            var lastPrice = update.Data.LastPrice;
        //        });
        //    }


        //    public async Task BitgetConnectAsync()
        //    {
        //        var socketClient = new BitgetSocketClient();
        //        var tickerSubscriptionResult = socketClient.SpotApi.SubscribeToTickerUpdatesAsync("ETHUSDT", (update) =>
        //        {
        //            var lastPrice = update.Data.LastPrice;
        //        });
        //    }
        //}
    }
}
