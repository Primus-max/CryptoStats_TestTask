using Binance.Net.Clients;
using Binance.Net.Interfaces.Clients;

using CryptoApp_TestTask.Connectors.Base;

using System.Threading.Tasks;

using System;

namespace CryptoApp_TestTask.Connectors
{
    public class BinanceApiConnector : BaseCryptoApiConnector
    {
        private readonly IBinanceSocketClient socketClient;

        public BinanceApiConnector()
        {
            socketClient = new BinanceSocketClient();
        }

        public override async Task ConnectAsync(string symbol, Action<decimal> onPriceUpdate)
        {
            await socketClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(symbol, data =>
            {
                onPriceUpdate(data.Data.LastPrice);
            });
        }
    }
}
