using StocksApp.Server.DTOs;

namespace StocksApp.Server.Services.Contracts
{
    public interface IFinnhubService
    {
        /// <summary>
        /// returns a dictionary of key-value pairs containing the company profile 
        /// information for the specified stock symbol.
        /// </summary>
        /// <param name="symbol">The stock symbol for which to retrieve profile information.</param>
        /// <returns>A dictionary containing the company profile information.</returns>
        Task<TradeCompanyProfile> GetCompanyProfileAsync(string symbol);

        /// <summary>
        /// returns a dictionary of key-value pairs containing the stock price quote
        /// </summary>
        /// <param name="symbol">The stock symbol for which to retrieve price information.</param>
        /// <returns>A dictionary containing the stock price quote.</returns>
        Task<Dictionary<string, object?>> GetStockPriceQuoteAsync(string symbol);
    }
}
