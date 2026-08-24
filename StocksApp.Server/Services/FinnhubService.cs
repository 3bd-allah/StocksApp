using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using StocksApp.Server.DTOs;
using StocksApp.Server.IRepository;
using StocksApp.Server.Options;
using StocksApp.Server.Services.Contracts;
using System.Text.Json;

namespace StocksApp.Server.Services
{
    public class FinnhubService : IFinnhubService
    {
        private readonly ILogger<FinnhubService> _logger;
        private readonly IFinnhubRepository _finnhubRepository;
        private readonly IOptions<TradingOptions> _tradingOptions;
        public FinnhubService (
            ILogger<FinnhubService> logger,
            IFinnhubRepository finnhubRepository,
            IOptions<TradingOptions> tradingOptions)
        {
            _logger = logger;
            _finnhubRepository = finnhubRepository;
            _tradingOptions = tradingOptions;
        }


        public async Task<TradeCompanyProfile> GetCompanyProfile(string symbol)
        {
            _logger.LogInformation("GetCompanyProfileAsync form FinnhubService");
            _logger.LogDebug("Symbol of Company: {symbol}", symbol);
            return await _finnhubRepository.GetCompanyProfileAsync(symbol);
        }

        public async Task<Dictionary<string, object>?> GetStockPriceQuote(string symbol)
        {
            _logger.LogInformation("GetStockPriceQuoteAsync form FinnhubService");
            
            return await _finnhubRepository.GetStockPriceQuoteAsync(symbol); 
        }

        public async Task<List<Stock>> GetAllPopularStocks()
        {
            var listAllStocks = await _finnhubRepository.GetAllStocksAsync();
            // TODO: filter top popular stocks
            var top25PopularStocks = new List<Stock>();
            foreach (var stock in listAllStocks!)
            {
                if (stock.Symbol is not null)
                {
                    if (_tradingOptions.Value.PopularStocks!.Contains(stock.Symbol))
                    {
                        top25PopularStocks.Add(stock);
                    }
                }
            }
            return top25PopularStocks;
        }

        public async Task<SearchStocks?> SearchStocks(string symbolName)
        {
            return await _finnhubRepository.SearchStocksAsync(symbolName);
        }
    }
}
