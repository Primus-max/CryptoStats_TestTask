using Binance.Net.Clients;

using Bitget.Net.Clients;

using Kucoin.Net.Clients;

using System.Threading.Tasks;
using System.Windows.Forms;


namespace CryptoApp_TestTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListViews();
            LoadTestData();

            BinanceConnectAsync();
            BybitConnectAsync();
            KucoinConnectAsync();
            BitgetConnectAsync();
        }


        private void LoadTestData()
        {

            listView1.Items.Add(new ListViewItem(new[] { "Price", "$50000" }));
            listView1.Items.Add(new ListViewItem(new[] { "Volume", "1000 BTC" }));
            listView1.Items.Add(new ListViewItem(new[] { "Change", "+2%" }));


            listView2.Items.Add(new ListViewItem(new[] { "High", "$52000" }));
            listView2.Items.Add(new ListViewItem(new[] { "Low", "$48000" }));
            listView2.Items.Add(new ListViewItem(new[] { "Open", "$49500" }));


            listView3.Items.Add(new ListViewItem(new[] { "Bid", "$49900" }));
            listView3.Items.Add(new ListViewItem(new[] { "Ask", "$50100" }));
            listView3.Items.Add(new ListViewItem(new[] { "Spread", "$200" }));


            listView4.Items.Add(new ListViewItem(new[] { "Market Cap", "$1 Trillion" }));
            listView4.Items.Add(new ListViewItem(new[] { "24h Volume", "$50 Billion" }));
            listView4.Items.Add(new ListViewItem(new[] { "Circulating Supply", "18 Million BTC" }));
        }

        public async Task BinanceConnectAsync()
        {
            // Subscribe to ETH/USDT ticker updates via the websocket API
            var socketClient = new BinanceSocketClient();
            var tickerSubscriptionResult = socketClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync("ETHUSDT", (update) =>
            {
                var lastPrice = update.Data.LastPrice;
            });
        }

        public async Task BybitConnectAsync()
        {
            // Subscribe to ETH/USDT ticker updates via the websocket API
            var socketClient = new KucoinSocketClient();
            var tickerSubscriptionResult = socketClient.SpotApi.SubscribeToTickerUpdatesAsync("ETH-USDT", (update) =>
            {
                var lastPrice = update.Data.LastPrice;
            });
        }

        public async Task KucoinConnectAsync()
        {
            // Subscribe to ETH/USDT ticker updates via the websocket API
            var socketClient = new KucoinSocketClient();
            var tickerSubscriptionResult = socketClient.SpotApi.SubscribeToTickerUpdatesAsync("ETH-USDT", (update) =>
            {
                var lastPrice = update.Data.LastPrice;
            });
        }


        public async Task BitgetConnectAsync()
        {
            var socketClient = new BitgetSocketClient();
            var tickerSubscriptionResult = socketClient.SpotApi.SubscribeToTickerUpdatesAsync("ETHUSDT", (update) =>
            {
                var lastPrice = update.Data.LastPrice;
            });
        }
    }
}
