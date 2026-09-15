namespace StocksApp.Core.Application.DTOs
{
    public class TradeCompanyProfile
    {
        public string? Ticker { get; set; }
        public string? Name{ get; set; }
        public string? Country{ get; set; }
        public string? Currency { get; set; }
        public string? Exchange{ get; set; }
        public Uri? Logo{ get; set; }
        public string? FinnhubIndustry { get; set; }
        public string? Error { get; set; }

        public bool IsSuccess => Error is null;

    }
}
