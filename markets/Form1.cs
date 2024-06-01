using markets.Trading;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace markets
{
    public partial class Form1 : Form
    {
        private BackgroundWorker worker;
        // экземпл€ры классов бирж
        private BinanceTicker binance;
        private ByBitTicker bybit;
        private KucoinTicker kucoin;
        private BitgetTicker bitget;

        private string Pair { get; set; }

        public Form1()
        {
            InitializeComponent();

            string version = "1.0";
            txtAppName.Text = $"Markets v{version}";

            load_pairs();
        }

        // заполн€ем combobox парами
        void load_pairs()
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                { "BTC/USDT", "btc" },
                { "ETH/USDT", "eth" },
                { "DOGE/USDT", "doge" }
            };

            cbPairs.DataSource = new BindingSource(data, null);
            cbPairs.DisplayMember = "Key";
            cbPairs.ValueMember = "Value";
        }


        // кнопки захвата дл€ перемещени€ формочки
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pTouchable_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtAppName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void load_tickers()
        {
            // btc
            binance = new BinanceTicker();
            binance.load_ticker();

            // bybit
            bybit = new ByBitTicker();
            bybit.load_ticker();

            // kucoin
            kucoin = new KucoinTicker();
            kucoin.load_ticker();

            // bitget
            bitget = new BitgetTicker();
            bitget.load_ticker();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // выберем дефольную пару по пор€дку в combobox
            Pair = get_pairs_value();

            // загрузим все биржи и их тикеры
            load_tickers();

            // загрузим worker
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true,
            };

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            // метод дл€ передачи результатов
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_PriceChanged);

            worker.RunWorkerAsync();
        }

        private void worker_PriceChanged(object sender, ProgressChangedEventArgs e)
        {
            object data = e.UserState;

            if (data is null) return;

            // раскидаем строку результатов на разные TextBox
            var values = data.ToString();
            if (string.IsNullOrEmpty(values) || !values.Contains('|')) return;

            var v = values.Split('|');

            tbBinancePrice.Text = v[0];
            tbBybitPrice.Text = v[1];
            tbKucoinPrice.Text = v[2];
            tbBitgetPrice.Text = v[3];
        }

        private string format_price(decimal price)
        {
            return price.ToString("C", new CultureInfo("en-US"));
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                if (string.IsNullOrEmpty(Pair)) continue;

                var result = new List<string>();

                // добавим цены по биржам
                if (binance != null)
                {
                    var price = binance.get_price(Pair);
                    result.Add(format_price(price));
                }
                else result.Add("");

                if (bybit != null)
                {
                    var price = bybit.get_price(Pair);
                    result.Add(format_price(price));
                }
                else result.Add("");

                if (kucoin != null)
                {
                    var price = kucoin.get_price(Pair);
                    result.Add(format_price(price));
                }
                else result.Add("");

                if (bitget != null)
                {
                    var price = bitget.get_price(Pair);
                    result.Add(format_price(price));
                }
                else result.Add("");

                if (!result.Any()) continue;

                worker.ReportProgress(0, string.Join('|', result));

                Thread.Sleep(5000);
            }

        }

        // отпарсим значение ComboBox
        private string get_pairs_value()
        {
            return ((KeyValuePair<string, string>)cbPairs.SelectedItem).Value;
        }

        private void cbPairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pair = get_pairs_value();

            // чтобы не висела старое значение другой пары, подкиним актуальное
            if (binance != null)
            {
                tbBinancePrice.Text = format_price(binance.get_price(Pair));
            }
            if (bybit != null)
            {
                tbBybitPrice.Text = format_price(bybit.get_price(Pair));
            }
            if (bybit != null)
            {
                tbKucoinPrice.Text = format_price(kucoin.get_price(Pair));
            }
            if (bitget != null)
            {
                tbBitgetPrice.Text = format_price(bitget.get_price(Pair));
            }
        }
    }
}
