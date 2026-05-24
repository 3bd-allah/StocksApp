using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StocksApp.Server.Options;
using StocksApp.Server.Services.Contracts;
using StocksApp.Server.DTOs;
namespace StocksApp.Server.Controllers
{
    [ApiController]
    public class TradeController(IFinnhubService finnhub, IOptions<FinnhubSymbolOptions> finnhubOptions) : Controller
    {
        [Route("/company-profile")]
        public async Task<IActionResult> CompanyProfile()
        {
            var profileRes = await finnhub.GetCompanyProfileAsync(finnhubOptions.Value.DefaultFinnhubSymbol ?? "MSFT");
            var stockRes = await finnhub.GetStockPriceQuoteAsync(finnhubOptions.Value.DefaultFinnhubSymbol ?? "MSFT");

            return Json(new StockTradeDTO
            {
                StockName = profileRes["name"]?.ToString(),
                StockSymbol = profileRes["ticker"]?.ToString() ,
                Price = Convert.ToDouble(stockRes["h"]?.ToString()) 
            });
        }


    }
}
