using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using StocksApp.Server.AppDbContext;
using StocksApp.Server.DTOs;
using StocksApp.Server.Entities;
using StocksApp.Server.ExternalServices;
using StocksApp.Server.Services.Contracts;
using StocksApp.Server.Validations.Helpers;

namespace StocksApp.Server.Services
{
    public class OrdersPdfGenerator (IStockService _stockService) : IOrdersPdfGenerator
    {
        
        public async Task<byte[]> GenerateOrdersPdfAsync()
        {
            var buyOrders = (await _stockService.GetFilteredStocks<BuyOrder>(bo => bo.StockSymbol == "MSFT"))
                .Select(bo => bo.ToBuyOrderResponse());

            var sellOrders = (await _stockService.GetFilteredStocks<SellOrder>(so => so.StockSymbol == "MSFT"))
                .Select(so => so.ToSellOrderResponse());

            List<object> allOrders = [..buyOrders, ..sellOrders];

            var viewModel = OrdersReportViewModel.FromRowOrders(allOrders);

            var document = new OrdersReportDocument(viewModel);

            return document.GeneratePdf();
        }
    }
}
