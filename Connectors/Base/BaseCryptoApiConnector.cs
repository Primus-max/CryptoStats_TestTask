using CryptoApp_TestTask.Connectors.Interfaces;

using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoApp_TestTask.Connectors.Base
{
    public abstract class BaseCryptoApiConnector : ICryptoApiConnector
    {
        public abstract Task ConnectAsync(string symbol, Action<decimal> onPriceUpdate);
    }
}
