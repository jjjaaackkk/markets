using Kucoin.Net.Clients;
using Kucoin.Net.Objects;

namespace markets.Trading
{
    internal class KucoinTicker : Ticker
    {
        private KucoinSocketClient? Client { get; set; }

        public KucoinTicker()
        {
            Client = new KucoinSocketClient();
        }

        public override void load_ticker()
        {
            if (Client is null) return;

            var btcTicker = Client.SpotApi.SubscribeToTickerUpdatesAsync("BTCUSDT", (update) =>
            {
                BtcPrice = (decimal)update.Data.LastPrice;
            });

            var ethTicker = Client.SpotApi.SubscribeToTickerUpdatesAsync("ETHUSDT", (update) =>
            {
                EthPrice = (decimal)update.Data.LastPrice;
            });

            var dogeTicker = Client.SpotApi.SubscribeToTickerUpdatesAsync("DOGEUSDT", (update) =>
            {
                DogePrice = (decimal)update.Data.LastPrice;
            });
        }
    }
}
