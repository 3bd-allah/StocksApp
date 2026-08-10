namespace StocksApp.Server.DTOs
{
    public class OrderPdfItem
    {
        public string? CreeatedAt { get; set; }
        public string? Stock { get; set; }
        public string? OrderType { get; set; }
        public uint? Quantity { get; set; }
        public double? Price { get; set; }
        public double TradeAmount => Quantity.GetValueOrDefault() * Price.GetValueOrDefault(); 
    }
}
