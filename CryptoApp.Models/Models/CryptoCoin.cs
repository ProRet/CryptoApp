using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Models
{
    public class CryptoCoin
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Rank { get; set; }

        public string PercentTotalVolume { get; set; }

        public string VolumeUsd { get; set; }

        public string ExchangeUrl { get; set; }

        CryptoCoin(string id, string name, string rank, string percentTotalVolume, string volumeUsd, string exchangeUrl)
        {
            Id = id;
            Name = name;
            Rank = rank;
            PercentTotalVolume = percentTotalVolume;
            VolumeUsd = volumeUsd;
            ExchangeUrl = exchangeUrl;
        }
    }
}
