using Bybit.Net.Clients;

namespace markets.Trading
{
    internal class ByBitTicker : Ticker
    {
        private BybitSocketClient? Client { get; set; }

        public ByBitTicker()
        {
            Client = new BybitSocketClient();
        }

        public override void load_ticker()
        {
            if (Client is null) return;

            var btcTicker = Client.V5SpotApi.SubscribeToTickerUpdatesAsync("BTCUSDT", (update) =>
            {
                BtcPrice = update.Data.LastPrice;
            });

            var ethTicker = Client.V5SpotApi.SubscribeToTickerUpdatesAsync("ETHUSDT", (update) =>
            {
                EthPrice = update.Data.LastPrice;
            });

            var dogeTicker = Client.V5SpotApi.SubscribeToTickerUpdatesAsync("DOGEUSDT", (update) =>
            {
                DogePrice = update.Data.LastPrice;
            });
        }
    }
}
