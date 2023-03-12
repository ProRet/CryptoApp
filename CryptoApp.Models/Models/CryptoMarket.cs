

namespace CryptoApp.Models.Models
{
    public class CryptoMarket
    {
        public string ExchangeId { get; set; }
        public string BaseId { get; set; }
        public double PriceUsd { get; set; }

        public CryptoMarket() { }
        public CryptoMarket(string exchangeId, string baseId,  double priceUsd)
        {
            ExchangeId = exchangeId;
            BaseId = baseId;
            PriceUsd = priceUsd;
        }
    }
}
