using CryptoApp_TestTask.Connectors.Base;
using CryptoApp_TestTask.Connectors.SocketClients;

namespace CryptoApp_TestTask.Connectors
{
    public class BitgetApiConnector : BaseCryptoApiConnector
    {
        public BitgetApiConnector() : base(new BitgetApiSocketClient())
        {
        }
    }
}
