using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StocksApp.Core.Application.DTOs;
using StocksApp.Core.ServiceContracts;
using StocksApp.Server.Filters.ActionFilters;
using StocksApp.Server.Filters.ExceptionFilters;
using StocksApp.Server.Filters.ResourceFilters;
using StocksApp.Server.Filters.ResultFilters;

namespace StocksApp.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    //[TypeFilter<ResponseHeaderActionFilter>(
    //    Arguments = new object[] { "MyKey-From-Controller", "MyValue-From-Controller" }, Order = -1)]
    public class StocksController (IFinnhubService _finnhubService,
        IStockService _stockService,
        ILogger<StocksController> _logger) : ControllerBase
    {
        // api/stocks
        [HttpGet]
        public async Task<ActionResult<List<Stock>>> Explore()
        {
            return await _finnhubService.GetAllPopularStocks();
        }

        // api/stocks/search?symbol={searchSymbol}
        [HttpGet("search")]
        [TypeFilter(typeof(SearchStocksActionFilter))]
        public async Task<ActionResult<SearchStocks?>> GetSpecificStocks(
            [FromQuery(Name ="symbol")] string stockNameToSearch)
        {
            
            return await _finnhubService.SearchStocks(stockNameToSearch);
        }


        [AcceptVerbs("Query")]
        [Route("buy-orders")]
        [TypeFilter(typeof(StocksCursorPaginationActionFilter))]
        [TypeFilter(typeof(OrderCursorExceptionFilter))]

        public async Task<ActionResult<PagedResult<BuyOrderResponse>>> CursorPaginationBuyOrders(
            [FromQuery(Name = "after")] OrderCursor? cursor)
        {
            _logger.LogInformation("{Controller}.{ActionMethod} method",
                nameof(StocksController),
                nameof(CursorPaginationBuyOrders));
            if (cursor!.OrderId.HasValue && cursor.CraetedAt.HasValue)
            {
                var pagedResult = await _stockService.GetPaginatedBuyOrders(cursor!);
                return Ok(pagedResult);
            }
            else
            {
                var pagedResult = await _stockService.GetPaginatedBuyOrders(null!);
                return Ok(pagedResult);
            }
        }

        [HttpGet("sell-orders")]
        [TypeFilter(typeof(StocksCursorPaginationActionFilter))]
        [TypeFilter(typeof(OrderCursorExceptionFilter))]
        //[TypeFilter(typeof(StocksCursorPaginationResultFilter))]
        public async Task<ActionResult<PagedResult<SellOrderResponse>>?> CursorPaginationSellOrders(
            [FromQuery(Name = "after")] OrderCursor? cursor)
        {
            if (cursor!.OrderId.HasValue && cursor.CraetedAt.HasValue)
            {
                var pagedResult = await _stockService.GetPaginatedSellOrders(cursor!);
                return Ok(pagedResult);
            }
            else
            {
                var pagedResult = await _stockService.GetPaginatedSellOrders(null!);
                return Ok(pagedResult);
            }


        }
    }
}
