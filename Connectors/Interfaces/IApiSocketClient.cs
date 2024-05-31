using CryptoExchange.Net.Objects.Sockets;

using System;
using System.Threading.Tasks;

namespace CryptoApp_TestTask.Connectors.Interfaces
{
    public interface IApiSocketClient
    {
        Task SubscribeToTickerUpdatesAsync(string symbol, Action<decimal> onPriceUpdate);
        Task UnsubscribeToTickerUpdatesAsync();
    }
}
