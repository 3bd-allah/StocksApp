namespace StocksApp.Server.Services.Contracts
{
    public interface IFinnhubService
    {
        Task<Dictionary<string, object?>> GetCompanyProfileAsync(string symbol);
        Task<Dictionary<string, object?>> GetStockPriceQuoteAsync(string symbol);
    }
}
