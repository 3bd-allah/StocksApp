using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Serilog;
using StocksApp.Server.Filters.ActionFilters;
using StocksApp.Server.Filters.ExceptionFilters;
using StocksApp.Core.Application.DTOs;
using StocksApp.Core.ServiceContracts;
using StocksApp.Core.Application.Common.Options;
namespace StocksApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController(
        IFinnhubService _finnhubService,
        IStockService _stockService,
        IOrdersPdfGenerator _ordersPdfGenerator,
        IOptionsSnapshot<TradingOptions> tradingOptions,
        ILogger<TradeController> _logger,
        IDiagnosticContext diagnosticContext) : ControllerBase
    {
        [HttpGet("company-profile")]
        public async Task<ActionResult<StockTradeDTO>> CompanyProfile([FromQuery] string? stockSymbol)
        {
            _logger.LogInformation("Company Profile from Trade Controller");
            // Not Structured Logging
            _logger.LogDebug($"Finnhub Symbol:{tradingOptions.Value.DefaultFinnhubSymbol}");
            var profileResTask = _finnhubService.GetCompanyProfile(stockSymbol ?? tradingOptions.Value.DefaultFinnhubSymbol!);
            var stockResTask = _finnhubService.GetStockPriceQuote(stockSymbol ?? tradingOptions.Value.DefaultFinnhubSymbol!);
            
            // await both tasks to finish in parallel 
            await Task.WhenAll(profileResTask, stockResTask);

            var profileRes = profileResTask.Result;
            var stockRes = stockResTask.Result;

            if(profileRes is null || stockRes is null)
            {
                return NotFound(new {message = "you don't have access for this company profile" });
            }
            var stockTradeResponse = new StockTradeDTO
            {
                StockName = profileRes.Ticker,
                StockSymbol = profileRes.Name,
                Logo = profileRes.Logo,
                Exchange = profileRes.Exchange,
                FinnhubIndustry = profileRes.FinnhubIndustry,
                Price = Convert.ToDouble(stockRes!["h"]?.ToString()),
                Quantity = tradingOptions.Value.DefaultTradingQuantity
            };
            // Structured Logging
            _logger.LogInformation("Stock Object: {Stock}", stockTradeResponse);
            _logger.LogInformation("Stock Object: {@Stock}", stockTradeResponse);
            return Ok(stockTradeResponse);
        }

        [HttpPost("buyOrder")]
        [TypeFilter(typeof(CreateOrderActionFilter))]
        [TypeFilter(typeof(OrderRequestExceptionFitler))]
        public async Task<ActionResult<BuyOrderResponse>> BuyOrder([FromBody] BuyOrderRequest orderRequest)
        {
            // Implementation for buying orders
            BuyOrderResponse buyOrderResponse = await _stockService.CreateBuyOrder(orderRequest);
            return Created();
        }

        [HttpPost("sellOrder")]
        [TypeFilter(typeof(CreateOrderActionFilter))]
        public async Task<ActionResult<SellOrderResponse>> SellOrder([FromBody] SellOrderRequest orderRequest)
        {
            // Implementation for selling orders

            SellOrderResponse sellOrderResponse = await _stockService.CreateSellOrder(orderRequest);
            return Created();
        }

        // get: api/trade/orders
        [HttpGet("orders")]
        [TypeFilter(typeof(TradeOrdersActionFilter))]
        public async Task<ActionResult<Orders>> Orders()
        {
            // Implementation for retrieving orders
            var buyOrders = await _stockService.GetAllBuyOrders();
            _logger.LogInformation("About to hit diagnosticContext");
            diagnosticContext.Set("Buy Orders:", buyOrders, true);
            _logger.LogInformation("After logging the diagnosticContext");
            var sellOrders= await _stockService.GetAllSellOrders();


            return Ok(new Orders
            {
                BuyOrders = buyOrders,
                SellOrders = sellOrders
            });
        }


        //get: api/trade/orders-pdf
        [HttpGet("orders-pdf")]
        public async Task<IActionResult> OrdersPDF()
        {
            // Implementation for retrieving orders
            var pdfBytes = await _ordersPdfGenerator.GenerateOrdersPdfAsync();
            return File(pdfBytes, "application/pdf", "orders.pdf");
        }
    }
}
