using StocksApp.Server.DTOs;
using StocksApp.Server.Entities;
using StocksApp.Server.Services.Contracts;
using StocksApp.Server.Validations.Helpers;
using System.Runtime.InteropServices;
namespace StocksApp.Server.Services
{
    public class StockService : IStockService
    {
        private readonly List<BuyOrders> _buyOrders;
        private readonly List<SellOrders> _sellOrders;

        public StockService()
        {
            _buyOrders = new List<BuyOrders>();
            _sellOrders = new List<SellOrders>();
        }

        private async Task<TResponse> CreateOrder<TRequest, TEntity, TResponse>(
            TRequest? request,
            Func<TRequest, Guid, TEntity> entityFactory,
            Func<TEntity, TResponse> ToMapResponse
            ) where TRequest : class
        {
            if(request is null) throw new ArgumentNullException(nameof(request));

            ValidationHelper.ModelValidation(request);

            Guid newID = Guid.NewGuid();

            TEntity newOrder = entityFactory(request, newID);


            return ToMapResponse(newOrder);
        }
        public async Task<BuyOrderResponse> CreateBuyOrder(BuyOrderRequest? request)
        {
          return await CreateOrder<BuyOrderRequest, BuyOrders, BuyOrderResponse>(
              request,
              entityFactory: (req, id) =>
              {
                  BuyOrders order = req.ToBuyOrder();
                  order.BuyOrderID = id;
                  _buyOrders.Add(order);
                  return order;
              },
              ToMapResponse: buyOrder => buyOrder.ToBuyOrderResponse());
        }
            
        public async Task<SellOrderResponse> CreateSellOrder(SellOrderRequest? request)
        {
            return await CreateOrder<SellOrderRequest, SellOrders, SellOrderResponse>(
                request,
                entityFactory: (req, id) =>
                {
                    SellOrders sellOrder = req.ToSellOrder();
                    sellOrder.SellOrderID = id;
                    _sellOrders.Add(sellOrder);
                    return sellOrder;
                },
                ToMapResponse: entity => entity.ToSellOrderResponse());
        }

        public async Task<List<BuyOrderResponse>> GetAllBuyOrders()
        {
            List<BuyOrderResponse> buyOrders = _buyOrders.Select(o => o.ToBuyOrderResponse()).ToList();
            return await Task.FromResult(buyOrders); 
        }

        public Task<List<SellOrderResponse>> GetAllSellOrders()
        {
            return Task.FromResult(_sellOrders.Select(so => so.ToSellOrderResponse()).ToList());
        }
    }
}
