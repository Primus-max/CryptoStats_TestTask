using CryptoApp_TestTask.Connectors;
using CryptoApp_TestTask.Connectors.Base;

using System.Collections.Generic;

namespace CryptoApp_TestTask.Factory
{
    public static class ApiConnectorFactory
    {
        public static List<BaseCryptoApiConnector> CreateApiConnectors()
        {
            return new List<BaseCryptoApiConnector>
            {
                new BinanceApiConnector(),
                new BybitApiConnector(),
                new KucoinApiConnector(),
                new BitgetApiConnector()
            };
        }
    }
}
