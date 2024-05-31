using CryptoApp_TestTask.Connectors.Interfaces;

using CryptoExchange.Net.Objects.Sockets;
using CryptoExchange.Net.Sockets;

using Kucoin.Net.Clients;
using Kucoin.Net.Interfaces.Clients;

using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoApp_TestTask.Connectors.SocketClients
{
    public class KucoinApiSocketClient : IApiSocketClient
    {
        private readonly IKucoinSocketClient _client;
        private UpdateSubscription _subscription;

        public KucoinApiSocketClient()
        {
            _client = new KucoinSocketClient();
        }

        public async Task SubscribeToTickerUpdatesAsync(string symbol, Action<decimal> onPriceUpdate)
        {
            if (_subscription != null)
                await UnsubscribeToTickerUpdatesAsync();

            var result = await _client.SpotApi.SubscribeToTickerUpdatesAsync(symbol, data =>
            {
                onPriceUpdate((decimal)data.Data.LastPrice);
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
