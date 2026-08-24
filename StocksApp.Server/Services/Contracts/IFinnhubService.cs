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
        Task<TradeCompanyProfile> GetCompanyProfile(string symbol);


        /// <summary>
        /// returns a dictionary of key-value pairs containing the stock price quote
        /// </summary>
        /// <param name="symbol">The stock symbol for which to retrieve price information.</param>
        /// <returns>A dictionary containing the stock price quote.</returns>
        Task<Dictionary<string, object>?> GetStockPriceQuote(string symbol);


        /// <summary>
        /// get popular stocks in the market
        /// </summary>
        /// <returns>returns top 25 popular stocks in the market</returns>
        Task<List<Stock>> GetAllPopularStocks();


        /// <summary>
        /// returns all search stocks that matches entered symbol
        /// </summary>
        /// <param name="symbolName">symbol name that you want to search based on</param>
        /// <returns>returns object of SearchStocks type (contain count of stocks and list of them)</returns>
        Task<SearchStocks?> SearchStocks(string symbolName);

    }
}
