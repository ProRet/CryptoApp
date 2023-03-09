using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Models.Models
{
    public class CryptoMarket
    {
        public string ExchangeId { get; set; }
        public string BaseId { get; set; }

        public string QuoteId { get; set; }

        public string BaseSymbol { get; set; }

        public string QuoteSymbol { get; set; }

        public double VolumeUsd24Hr { get; set; }

        public double PriceUsd { get; set; }

        public double VolumePercent { get; set; }

        public CryptoMarket() { }
        public CryptoMarket(string exchangeId, string baseId, string quoteId, string baseSymbol, string quoteSymbol, double volumeUsd24Hr, double priceUsd, double volumePercent)
        {
            ExchangeId = exchangeId;
            BaseId = baseId;
            QuoteId = quoteId;
            BaseSymbol = baseSymbol;
            QuoteSymbol = quoteSymbol;
            VolumeUsd24Hr = volumeUsd24Hr;
            PriceUsd = priceUsd;
            VolumePercent = volumePercent;
        }
    }
}
