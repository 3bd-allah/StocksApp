using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StocksApp.Server.Options;
using StocksApp.Server.Services.Contracts;
using StocksApp.Server.DTOs;
namespace StocksApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController(
        IFinnhubService _finnhubService,
        IStockService _stockService,
        IOrdersPdfGenerator _ordersPdfGenerator,
        IOptionsSnapshot<TradingOptions> tradingOptions) : ControllerBase
    {
        [HttpGet("company-profile")]
        public async Task<ActionResult<StockTradeDTO>> CompanyProfile()
        {
            var profileRes = await _finnhubService.GetCompanyProfileAsync(tradingOptions.Value.DefaultFinnhubSymbol ?? "MSFT");
            var stockRes = await _finnhubService.GetStockPriceQuoteAsync(tradingOptions.Value.DefaultFinnhubSymbol ?? "MSFT");

            return Ok(new StockTradeDTO
            {
                StockName = profileRes.Ticker,
                StockSymbol = profileRes.Name,
                Price = Convert.ToDouble(stockRes["h"]?.ToString()),
                Quantity = tradingOptions.Value.DefaultTradingQuantity 
            });
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

        [HttpGet("orders")]
        public async Task<IActionResult> Orders()
        {
            // Implementation for retrieving orders
            var buyOrders = await _stockService.GetAllBuyOrders();
            var sellOrders = await _stockService.GetAllSellOrders();
            return Ok(new { BuyOrders = buyOrders, SellOrders = sellOrders });
        }

        [HttpGet("orders-pdf")]
        public async Task<IActionResult> OrdersPDF()
        {
            // Implementation for retrieving orders
            var pdfBytes = await _ordersPdfGenerator.GenerateOrdersPdfAsync();
            return File(pdfBytes, "application/pdf", "orders.pdf");
        }
    }
}
