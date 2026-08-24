using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SerilogTimings;
using StocksApp.Server.DTOs;
using StocksApp.Server.Entities;
using StocksApp.Server.IRepository;
using StocksApp.Server.Services.Contracts;
using StocksApp.Server.Validations.Helpers;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
namespace StocksApp.Server.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly ILogger<StockService> _logger;
        public StockService(IStockRepository stockRepository, ILogger<StockService> logger)
        {
            _stockRepository = stockRepository;
            _logger = logger;
        }

        private async Task<TResponse> CreateOrder<TRequest, TEntity, TResponse>(
            TRequest? request,
            Func<TRequest, Guid, Task<TEntity>> entityFactory,
            Func<TEntity, TResponse> ToMapResponse
            ) where TRequest : class
        {
            if(request is null) throw new ArgumentNullException(nameof(request));

            ValidationHelper.ModelValidation(request);

            Guid newID = Guid.CreateVersion7();

            TEntity newOrder = await entityFactory(request, newID);


            return ToMapResponse(newOrder);
        }
        public async Task<BuyOrderResponse> CreateBuyOrder(BuyOrderRequest? request)
        {
            return await CreateOrder<BuyOrderRequest, BuyOrder, BuyOrderResponse>(
                request,
                entityFactory: async (req, id) =>
                {
                    BuyOrder order = req.ToBuyOrder();
                    order.BuyOrderID = id;
                    await _stockRepository.AddBuyOrder(order);
                    return order;
                },
                ToMapResponse: buyOrder => buyOrder.ToBuyOrderResponse());
        }

        public async Task<SellOrderResponse> CreateSellOrder(SellOrderRequest? request)
        {
            return await CreateOrder<SellOrderRequest, SellOrder, SellOrderResponse>(
                request,
                entityFactory: async (req, id) =>
                {
                    SellOrder sellOrder = req.ToSellOrder();
                    sellOrder.SellOrderID = id;
                    await _stockRepository.AddSellOrder(sellOrder);
                    return sellOrder;
                },
                ToMapResponse: entity => entity.ToSellOrderResponse());
        }

        public async Task<List<BuyOrderResponse>> GetAllBuyOrders()
        {
            List<BuyOrder> buyOrders;
            using (Operation.Time("Time of Getting all Buy Orders from Database"))
            {
                buyOrders = await _stockRepository.GetAllBuyOrders();
            }
            return buyOrders.Select(o => o.ToBuyOrderResponse()).ToList();
        }

        public async Task<List<SellOrderResponse>> GetAllSellOrders()
        {
            _logger.LogInformation("From Get All Sell Orders method");
            var sellOrders = await _stockRepository.GetAllSellOrders();
            return sellOrders.Select(o => o.ToSellOrderResponse()).ToList();
        }

        public async Task<List<T>> GetFilteredStocks<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await _stockRepository.GetFilteredStocks<T>(predicate);
        }
    }
}

