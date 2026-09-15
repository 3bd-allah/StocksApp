namespace StocksApp.Core.Application.DTOs
{
    public class StockTradeDTO
    {
        public string? StockSymbol { get; set; }
        public string? StockName { get; set; }
        public double Price { get; set; }
        public uint Quantity { get; set; }
        public string? Exchange { get; set; }
        public Uri? Logo { get; set; }
        public string? FinnhubIndustry { get; set; }

    }

}
