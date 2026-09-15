using QuestPDF.Fluent;
using StocksApp.Core.Application.DTOs;
using StocksApp.Core.Domain.Entities;
using StocksApp.Core.Helpers;
using StocksApp.Core.ServiceContracts;
using StocksApp.Infrastructure.ExternalServices;

namespace StocksApp.Core.Application.Services
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
