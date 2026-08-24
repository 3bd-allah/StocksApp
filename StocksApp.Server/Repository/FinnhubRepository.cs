using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StocksApp.Server.DTOs;
using StocksApp.Server.IRepository;
using StocksApp.Server.Options;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace StocksApp.Server.Repository
{
    public class FinnhubRepository : IFinnhubRepository
    {
        private readonly IOptions<UserFinnhubTokenOptions> _tokenOptions;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<FinnhubRepository> _logger;
        private static readonly JsonSerializerOptions s_readOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public FinnhubRepository(IOptions<UserFinnhubTokenOptions> tokenOptions, IHttpClientFactory httpClientFactory, ILogger<FinnhubRepository> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _tokenOptions = tokenOptions;

        }
        private string Token { get => _tokenOptions.Value.UserToken!; }

        private async Task<T> GetFrom<T>(string link)
        {
            using (var httpClient = _httpClientFactory.CreateClient())
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(link);

                Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync();

                StreamReader streamReader = new StreamReader(stream);
                string response = await streamReader.ReadToEndAsync();

                T? responseDicitonary = JsonSerializer.Deserialize<T>(response, s_readOptions);

                return responseDicitonary!;
            }
        }

        public async Task<TradeCompanyProfile> GetCompanyProfileAsync(string stockSymbol)
        {
            _logger.LogInformation("GetCompanyProfileAsync form FinnhubRepository");
            _logger.LogInformation("Token: {@Token}", Token);
            string link = $"https://finnhub.io/api/v1/stock/profile2?symbol={stockSymbol}&token={Token}";
            return await GetFrom<TradeCompanyProfile>(link);
        }

        public async Task<Dictionary<string, object>?> GetStockPriceQuoteAsync(string stockSymbol)
        {
            _logger.LogInformation("GetStockPriceQuoteAsync form FinnhubRepository");

            string link = $"https://finnhub.io/api/v1/quote?symbol={stockSymbol}&token={Token}";
            return await GetFrom<Dictionary<string, object>>(link);
        }

        public async Task<List<Stock>?> GetAllStocksAsync()
        {
            string link = $"https://finnhub.io/api/v1/stock/symbol?exchange=US&token={Token}";
            return await GetFrom<List<Stock>?>(link);
        }

        public async Task<SearchStocks?> SearchStocksAsync(string stockSumbolToSearch)
        {
            string link = $"https://finnhub.io/api/v1/search?q={stockSumbolToSearch}&token={Token}";
            return await GetFrom<SearchStocks>(link);
        }
    }
}
