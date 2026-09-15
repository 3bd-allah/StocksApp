using StocksApp.Core.Application.DTOs;
namespace StocksApp.Core.Domain.IRepository
{
    public interface IFinnhubRepository
    {
        /// <summary>
        /// returns a dictionary of key-value pairs containing the company profile 
        /// information for the specified stock symbol.
        /// </summary>
        /// <param name="stockSymbol">The stock symbol for which to retrieve profile information.</param>
        /// <returns>A dictionary containing the company profile information.</returns>
        Task<TradeCompanyProfile> GetCompanyProfileAsync(string stockSymbol);

        /// <summary>
        /// returns a dictionary of key-value pairs containing the stock price quote
        /// </summary>
        /// <param name="stockSymbol">The stock symbol for which to retrieve price information.</param>
        /// <returns>A dictionary containing the stock price quote.</returns>
        Task<Dictionary<string, object>> GetStockPriceQuoteAsync(string stockSymbol);

        /// <summary>
        /// fetch all available stocks in the market
        /// </summary>
        /// <returns>returns list of all popular stocks</returns>
        Task<List<Stock>?> GetAllStocksAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stockSumbolToSearch"></param>
        /// <returns></returns>
        Task<SearchStocks?> SearchStocksAsync(string stockSumbolToSearch);
    }
}
