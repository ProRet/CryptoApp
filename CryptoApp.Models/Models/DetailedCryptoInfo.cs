using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Models.Models
{
    public class DetailedCryptoInfo
    {
        public CryptoCoin CryptoCoin { get; set; }
        public CryptoMarket CryptoMarket { get; set; }
        public DetailedCryptoInfo(CryptoCoin cryptoCoin,CryptoMarket cryptoMarket) { 
            CryptoCoin = cryptoCoin;
            CryptoMarket = cryptoMarket;
        }
    }
}
