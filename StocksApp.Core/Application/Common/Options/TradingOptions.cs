namespace StocksApp.Core.Application.Common.Options
{
    public class TradingOptions
    {
        public string? DefaultFinnhubSymbol { get; set; }
        public uint DefaultTradingQuantity { get; set; }
        public string? Top25PopularStocks { get; set; }

        public HashSet<string>? PopularStocks { get =>
                [.. Top25PopularStocks!.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)];}

       

        
    }
}
