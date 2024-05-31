using CryptoApp_TestTask.Connectors.Base;
using CryptoApp_TestTask.Extensions;
using CryptoApp_TestTask.Factory;
using CryptoApp_TestTask.Managers;

using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CryptoApp_TestTask
{
    public partial class Form1 : Form
    {
        private readonly List<BaseCryptoApiConnector> apis;
        private readonly PriceLabelManager priceLabelManager;

        public Form1()
        {
            InitializeComponent();


            apis = ApiConnectorFactory.CreateApiConnectors();
            priceLabelManager = new PriceLabelManager(labelBinance, labelBybit, labelKucoin, labelBitget);

            comboBoxSymbol.Items.AddRange(new string[] { "BTC-USDT", "ETH-USDT", "BNB-USDT" });
            comboBoxSymbol.SelectedIndex = 0;
        }

        private async void buttonStart_Click(object sender, System.EventArgs e)
        {
            var selectedSymbol = comboBoxSymbol.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedSymbol)) return;

            foreach (var api in apis)
            {
                var apiName = api.GetType().Name.Replace("ApiConnector", "");
                await api.ConnectAsync(selectedSymbol.FormatSymbol(apiName), price =>
                {
                    this.Invoke(new Action(() =>
                    {
                        priceLabelManager.UpdateLabel(apiName, price);
                    }));
                });
            }
        }

    }
}
