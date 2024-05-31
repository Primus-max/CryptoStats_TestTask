using System.Collections.Generic;
using System.Windows.Forms;

namespace CryptoApp_TestTask.Managers
{
    public class PriceLabelManager
    {
        private readonly Dictionary<string, Label> priceLabels;

        public PriceLabelManager(Label binanceLabel, Label bybitLabel, Label kucoinLabel, Label bitgetLabel)
        {
            priceLabels = new Dictionary<string, Label>
            {
                { "Binance", binanceLabel },
                { "Bybit", bybitLabel },
                { "Kucoin", kucoinLabel },
                { "Bitget", bitgetLabel }
            };
        }


        public Label GetLabel(string name)
        {
            return priceLabels.ContainsKey(name) ? priceLabels[name] : null;
        }

        public void UpdateLabel(string name, decimal price)
        {
            if (!priceLabels.ContainsKey(name)) return;
            priceLabels[name].Text = $"{name}: {price}";
        }
    }
}
