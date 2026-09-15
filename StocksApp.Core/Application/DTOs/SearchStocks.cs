namespace StocksApp.Core.Application.DTOs
{
    public class SearchStocks
    {
        public int Count { get; set; }
        public List<Stock>? Result { get; set; }
    }
}
