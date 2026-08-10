using StocksApp.Server.DTOs;
using StocksApp.Server.Services.Contracts;
using System.Text.Json;

namespace StocksApp.Server.Services
{
    public class FinnhubService : IFinnhubService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;
        public FinnhubService (IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        private string Token { get => _configuration.GetValue<string>("FinnhubToken")!; }

        private async Task<T> GetFrom<T>(string link)
        {
            using (var httpClient = _httpClientFactory.CreateClient())
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(link);

                
                Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync();

                StreamReader streamReader = new StreamReader(stream);
                string response = await streamReader.ReadToEndAsync();

                T? responseDicitonary = JsonSerializer.Deserialize<T>(response, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })!;

                return responseDicitonary;
            }
        }
        public async Task<TradeCompanyProfile> GetCompanyProfileAsync(string symbol)
        {
            
            string link = $"https://finnhub.io/api/v1/stock/profile2?symbol={symbol}&token={Token}";
            return await GetFrom<TradeCompanyProfile>(link) ;
        }

        public async Task<Dictionary<string, object?>> GetStockPriceQuoteAsync(string symbol)
        {
            
            string link = $"https://finnhub.io/api/v1/quote?symbol={symbol}&token={Token}";
            return await GetFrom<Dictionary<string, object?>>(link); 
        }
    }
}
