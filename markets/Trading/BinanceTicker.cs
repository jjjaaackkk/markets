using Binance.Net.Clients;
using System.Collections.Generic;

namespace markets.Trading
{
    internal class BinanceTicker : Ticker
    {
        private BinanceSocketClient? Client { get; set; }

        public BinanceTicker()
        {
            Client = new BinanceSocketClient();
        }

        public override void load_ticker()
        {
            if (Client is null) return;
            
            var btcTicker = Client.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync("BTCUSDT", (update) =>
            {
                BtcPrice = update.Data.LastPrice;
            });
            
            var ethTicker = Client.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync("ETHUSDT", (update) =>
            {
                EthPrice = update.Data.LastPrice;
            });

            var dogeTicker = Client.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync("DOGEUSDT", (update) =>
            {
                DogePrice = update.Data.LastPrice;
            });
        }

        public async Task<List<string>?> get_all_pairs()
        {
            if (Client == null) return null;

            var result = await Client.SpotApi.ExchangeData.GetExchangeInfoAsync();
            if (result == null || !result.Success ) return null;

            try
            {
                var symbols = new List<string>(); 
                foreach (var pair in result.Data.Result.Symbols)
                {
                    symbols.Add(pair.Name);
                }
                return symbols;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
