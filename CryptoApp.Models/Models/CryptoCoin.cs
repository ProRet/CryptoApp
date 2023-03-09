

namespace CryptoApp.Models
{
    public class CryptoCoin
    {
        public string Id { get; set; }
        public int Rank { get; set; }

        public string Symbol { get; set; }

        public string Name { get; set; }

        public double Supply { get; set; }

        public double MaxSupply { get; set; }

        public double MarketCapUsd { get; set; }

        public double VolumeUsd24Hr { get; set; }

        public double PriceUsd { get; set; }

        public double ChangePercent24Hr { get; set; }

        public double Vwap24Hr { get; set; }



        public CryptoCoin() { }
       public CryptoCoin(string id, int rank, string symbol, string name, double supply, double maxSupply, double marketCapUsd, double volumeUsd24Hr, double priceUsd, double changePercent24Hr, double vwap24Hr)
        {
            Id = id;
            Rank = rank;
            Symbol = symbol;
            Name = name;
            Supply = supply;
            MaxSupply = maxSupply;
            MarketCapUsd = marketCapUsd;
            VolumeUsd24Hr = volumeUsd24Hr;
            PriceUsd = priceUsd;
            ChangePercent24Hr = changePercent24Hr;
            Vwap24Hr = vwap24Hr;
        }
    }
}
