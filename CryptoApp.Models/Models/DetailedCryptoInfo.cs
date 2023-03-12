using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Models.Models
{
    public class DetailedCryptoInfo
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public double PriceChange { get; set; }

        public string Supply { get; set; }

        public string Market { get; set; }

        public double MarketPrice { get; set; }

        public DetailedCryptoInfo() { }

        public DetailedCryptoInfo(string name, double price, double priceChange,string supply, string market, double marketPrice)
        {
            Name = name;
            Price = price;
            PriceChange = priceChange;
            Supply = supply;
            Market = market;
            MarketPrice = marketPrice;
        }
    }
}
