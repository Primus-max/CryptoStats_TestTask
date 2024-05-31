namespace CryptoApp_TestTask.Extensions
{
    public static class SymbolFormatter
    {
        public static string FormatSymbol(this string src, string apiName)
        {
            return !apiName.Contains("Kucoin") ? src.Replace("-", "") : src;
        }
    }
}
