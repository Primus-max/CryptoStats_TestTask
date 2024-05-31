using CryptoApp_TestTask.Connectors.Base;
using CryptoApp_TestTask.Connectors.SocketClients;

namespace CryptoApp_TestTask.Connectors
{
    public class KucoinApiConnector : BaseCryptoApiConnector
    {
        public KucoinApiConnector() : base(new KucoinApiSocketClient())
        {
        }
    }
}
