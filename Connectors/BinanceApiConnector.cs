using CryptoApp_TestTask.Connectors.Base;
using CryptoApp_TestTask.Connectors.SocketClients;

namespace CryptoApp_TestTask.Connectors
{
    public class BinanceApiConnector : BaseCryptoApiConnector
    {
        public BinanceApiConnector() : base(new BinanceApiSocketClient()) { }
    }
}
