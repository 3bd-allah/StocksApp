namespace StocksApp.Server.DTOs
{
    public class SearchStocks
    {
        public int Count { get; set; }
        public List<Stock>? Result { get; set; }
    }
}
