using StocksApp.Server.Entities;
using StocksApp.Server.IRepository;
using StocksApp.Server.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace StocksApp.Server.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly StockMarketDbContext _db;
        public StockRepository(StockMarketDbContext db)
        {
            _db = db;
        }

        public async Task<BuyOrder> AddBuyOrder(BuyOrder buyOrder)
        {
            _db.BuyOrders.Add(buyOrder);
            await _db.SaveChangesAsync();
            return buyOrder;
        }

        public async Task<SellOrder> AddSellOrder(SellOrder sellOrder)
        {
            _db.SellOrders.Add(sellOrder);
            await _db.SaveChangesAsync();
            return sellOrder;
        }

        public async Task<List<BuyOrder>> GetAllBuyOrders()
        {
            return await _db.BuyOrders.ToListAsync();
        }

        public async Task<List<SellOrder>> GetAllSellOrders()
        {
            return await _db.SellOrders.ToListAsync();
        }

        public async Task<List<T>> GetFilteredStocks<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await _db.Set<T>().Where(predicate).ToListAsync();
        }
    }
}
