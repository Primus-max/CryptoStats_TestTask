using CryptoApp_TestTask.Connectors.Interfaces;

using CryptoExchange.Net.Objects.Sockets;

using System;
using System.Threading.Tasks;

namespace CryptoApp_TestTask.Connectors.Base
{
    public abstract class BaseCryptoApiConnector : ICryptoApiConnector
    {
        protected IApiSocketClient _socketClient;
        protected UpdateSubscription _subscription;

        public BaseCryptoApiConnector(IApiSocketClient client)
        {
            _socketClient = client;
        }

        public async Task ConnectAsync(string symbol, Action<decimal> noPriceUpdate)
        {
            await _socketClient.SubscribeToTickerUpdatesAsync(symbol, noPriceUpdate);
        }

        public Task DisconnectAsync()
        {
            // Реализация отключения от биржи
            return null;
        }
         
    }
}
