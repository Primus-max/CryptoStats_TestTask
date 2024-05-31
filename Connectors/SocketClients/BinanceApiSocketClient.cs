using Binance.Net.Clients;
using Binance.Net.Interfaces.Clients;

using CryptoApp_TestTask.Connectors.Interfaces;

using CryptoExchange.Net.Objects.Sockets;

using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoApp_TestTask.Connectors.SocketClients
{
    public class BinanceApiSocketClient : IApiSocketClient
    {
        private readonly IBinanceSocketClient _client;
        private UpdateSubscription _subscription;

        public BinanceApiSocketClient()
        {
            _client = new BinanceSocketClient();
        }

        public async Task SubscribeToTickerUpdatesAsync(string symbol, Action<decimal> onPriceUpdate)
        {
            if (_subscription != null)
                await UnsubscribeToTickerUpdatesAsync();

            var result = await _client.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(symbol, data =>
            {
                onPriceUpdate(data.Data.LastPrice);
            });

            if (result.Success)
                _subscription = result.Data;
            else
                MessageBox.Show("Не удалось подписаться", "Warninng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        public async Task UnsubscribeToTickerUpdatesAsync()
        {
            if (_subscription != null)
            {
                await _client.UnsubscribeAsync(_subscription);
            }
        }
    }
}
