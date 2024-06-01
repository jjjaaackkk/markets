using Bitget.Net.Clients;

namespace markets.Trading
{
    internal class BitgetTicker : Ticker
    {
        private BitgetSocketClient? Client { get; set; }

        public BitgetTicker()
        {
            Client = new BitgetSocketClient();
        }

        public override void load_ticker()
        {
            if (Client is null) return;

            var btcTicker = Client.SpotApi.SubscribeToTickerUpdatesAsync("BTCUSDT", (update) =>
            {
                BtcPrice = update.Data.LastPrice;
            });

            var ethTicker = Client.SpotApi.SubscribeToTickerUpdatesAsync("ETHUSDT", (update) =>
            {
                EthPrice = update.Data.LastPrice;
            });

            var dogeTicker = Client.SpotApi.SubscribeToTickerUpdatesAsync("DOGEUSDT", (update) =>
            {
                DogePrice = update.Data.LastPrice;
            });
        }
    }
}
