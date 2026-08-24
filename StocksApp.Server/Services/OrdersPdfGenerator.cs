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
            Orders allOrders = new();
            allOrders.BuyOrders = (await _stockService.GetFilteredStocks<BuyOrder>(bo => bo.StockSymbol == "MSFT"))
                .Select(bo => bo.ToBuyOrderResponse()).ToList();

            allOrders.SellOrders = (await _stockService.GetFilteredStocks<SellOrder>(so => so.StockSymbol == "MSFT"))
                .Select(so => so.ToSellOrderResponse()).ToList();


            var viewModel = OrdersReportViewModel.FromRowOrders(allOrders);

            var document = new OrdersReportDocument(viewModel);

            return document.GeneratePdf();
        }
    }
}
