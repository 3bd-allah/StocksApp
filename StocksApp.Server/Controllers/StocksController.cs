using Microsoft.AspNetCore.Mvc;
using StocksApp.Server.DTOs;
using StocksApp.Server.Services.Contracts;
using System.Runtime.CompilerServices;

namespace StocksApp.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class StocksController (IFinnhubService _finnhubService) : ControllerBase
    {
        // api/stocks
        [HttpGet]
        public async Task<ActionResult<List<Stock>>> Explore()
       {
            return await _finnhubService.GetAllPopularStocks();
        }

        // api/stocks/search?symbol={searchSymbol}
        [HttpGet("search")]
        public async Task<ActionResult<SearchStocks?>> GetSpecificStocks([FromQuery(Name ="symbol")] string stockNameToSearch)
        {
            return await _finnhubService.SearchStocks(stockNameToSearch.ToUpper());
        }
    }
}
