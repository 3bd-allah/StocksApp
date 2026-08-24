using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StocksApp.Server.Options;
using StocksApp.Server.Services.Contracts;
using StocksApp.Server.DTOs;
using Serilog;
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
            _logger.LogDebug($"Finnhub Symbol:{tradingOptions.Value.DefaultFinnhubSymbol}");
            TradeCompanyProfile profileRes = await _finnhubService.GetCompanyProfile(stockSymbol ?? tradingOptions.Value.DefaultFinnhubSymbol!);
            var stockRes = await _finnhubService.GetStockPriceQuote(stockSymbol ?? tradingOptions.Value.DefaultFinnhubSymbol!);
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
            _logger.LogInformation("Stock Object: {Stock}", stockTradeResponse);
            _logger.LogInformation("Stock Object: {@Stock}", stockTradeResponse);
            return Ok(stockTradeResponse);
        }

        [HttpPost("buyOrder")]
        public async Task<ActionResult<BuyOrderResponse>> BuyOrder([FromBody] BuyOrderRequest buyOrderRequest)
        {
            // Implementation for buying orders
            BuyOrderResponse buyOrderResponse = await _stockService.CreateBuyOrder(buyOrderRequest);
            return Ok(buyOrderResponse);
        }

        [HttpPost("sellOrder")]
        public async Task<ActionResult<SellOrderResponse>> SellOrder([FromBody] SellOrderRequest sellOrderRequest)
        {
            // Implementation for selling orders

            SellOrderResponse sellOrderResponse = await _stockService.CreateSellOrder(sellOrderRequest);
            return Ok(sellOrderResponse);
        }

        // get: api/trade/orders
        [HttpGet("orders")]
        public async Task<ActionResult<Orders>> Orders()
        {
            // Implementation for retrieving orders
            var buyOrders = await _stockService.GetAllBuyOrders();
            _logger.LogInformation("About to hit diagnosticContext");
            diagnosticContext.Set("Buy Orders:", buyOrders, true);
            _logger.LogInformation("After logging the diagnosticContext");
            var sellOrders = await _stockService.GetAllSellOrders();
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
