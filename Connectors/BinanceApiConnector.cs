using Binance.Net.Clients;

using CryptoApp_TestTask.Connectors.Base;

namespace CryptoApp_TestTask.Connectors
{
    public class BinanceApiConnector : BaseCryptoApiConnector
    {
        public BinanceApiConnector() : base(new BinanceSocketClient()) { }
    }
}
