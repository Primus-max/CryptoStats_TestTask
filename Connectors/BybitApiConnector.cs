using CryptoApp_TestTask.Connectors.Base;
using CryptoApp_TestTask.Connectors.SocketClients;

namespace CryptoApp_TestTask.Connectors
{
    public class BybitApiConnector : BaseCryptoApiConnector
    {
        public BybitApiConnector() : base(new BybitApiSocketClient())
        {
        }
    }
}
