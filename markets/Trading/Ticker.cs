using System.Diagnostics;
using System.Globalization;

namespace markets.Trading
{
    abstract class Ticker
    {
        public decimal BtcPrice { get; set; }
        public decimal EthPrice { get; set; }
        public decimal DogePrice { get; set; }

        public abstract void load_ticker();

        public decimal get_price(string coin)
        {
            if (coin == "btc") return BtcPrice;
            else if (coin == "eth") return EthPrice;
            else if (coin == "doge") return DogePrice;
            else return 0m;
        }
    }
}
