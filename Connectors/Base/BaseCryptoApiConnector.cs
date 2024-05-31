using CryptoApp_TestTask.Connectors.Interfaces;

using System;
using System.Threading.Tasks;

namespace CryptoApp_TestTask.Connectors.Base
{
    public abstract class BaseCryptoApiConnector : ICryptoApiConnector
    {
        protected object socketClient;
        public BaseCryptoApiConnector(object client)
        {
            socketClient = client;
        }
        public async Task ConnectAsync(string symbol, Action<decimal> onPriceUpdate)
        {
            var spotApiProperty = socketClient.GetType().GetProperty("SpotApi");
            var spotApi = spotApiProperty.GetValue(socketClient);

            var subscribeMethod = spotApi.GetType().GetMethod("SubscribeToTickerUpdatesAsync");
            var parameters = new object[] { symbol, new Action<dynamic>(data => onPriceUpdate(data.Data.LastPrice)) };

            await (Task)subscribeMethod.Invoke(spotApi, parameters);
        }
    }
}
