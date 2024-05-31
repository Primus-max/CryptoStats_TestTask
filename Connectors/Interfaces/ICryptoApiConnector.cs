using System;
using System.Threading.Tasks;

namespace CryptoApp_TestTask.Connectors.Interfaces
{
    public interface ICryptoApiConnector
    {
        Task ConnectAsync(string symbol, Action<decimal> noPriceUpdate);
        Task DisconnectAsync();
    }
}
