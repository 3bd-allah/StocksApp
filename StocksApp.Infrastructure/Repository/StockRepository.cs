using StocksApp.Server.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using StocksApp.Core.Domain.IRepository;
using StocksApp.Core.Domain.Entities;
using StocksApp.Core.Application.DTOs;

namespace StocksApp.Server.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly StockMarketDbContext _db;
        public StockRepository(StockMarketDbContext db)
        {
            _db = db;
        }

        const int pageSize = 20;
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
            return await _db.BuyOrders
                .AsNoTracking()
                .OrderByDescending(bo => bo.DateAndTimeOfOrder)
                .ToListAsync();
        }

        public async Task<List<SellOrder>> GetAllSellOrders()
        {
            return await _db.SellOrders
                .AsNoTracking()
                .OrderByDescending(so => so.DateAndTimeOfOrder)
                .ToListAsync();
        }

        public async Task<List<T>> GetFilteredStocksAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            // Immediate Execution => i think if we change it to IQueryable it's better for performace 
            //whicn is Defferred Execution
            return await _db.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<bool> HasNext<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await _db.Set<T>().AnyAsync(predicate);
        }

        public async Task<PagedResult<BuyOrder>> GetBuyOrdersPagedResultAsync(OrderCursor cursor)
        {

            var query = _db.BuyOrders.AsNoTracking();

            if(cursor is not null)
            {
                query = query.Where(bo => bo.DateAndTimeOfOrder < cursor.CraetedAt ||
                (bo.DateAndTimeOfOrder == cursor.CraetedAt && bo.BuyOrderID < cursor.OrderId));
            }

            var rawItems = await query
                .OrderByDescending(bo => bo.DateAndTimeOfOrder)
                .ThenByDescending(bo => bo.BuyOrderID)
                .Take(pageSize + 1)
                .ToListAsync();

            PagedResult<BuyOrder> buyOrdersPagedResult = new PagedResult<BuyOrder>();
                
            buyOrdersPagedResult.HasNextPage = rawItems.Count > pageSize;
            buyOrdersPagedResult.Items = rawItems.Take(pageSize).ToList();
            buyOrdersPagedResult.Cursor = buyOrdersPagedResult.Items.Last().ToOrderCursor();
            
            return buyOrdersPagedResult;
        }

        public async Task<PagedResult<SellOrder>> GetSellOrdersPagedResultAsync(OrderCursor cursor)
        {
            var query = _db.SellOrders.AsNoTracking();

            if(cursor is not null)
            {
                query = query.Where(so => so.DateAndTimeOfOrder < cursor.CraetedAt ||
                (so.DateAndTimeOfOrder == cursor.CraetedAt && so.SellOrderID < cursor.OrderId));
            }

            var rawItems = await query.OrderByDescending(so => so.DateAndTimeOfOrder)
                .ThenByDescending(so => so.SellOrderID)
                .Take(pageSize + 1)
                .ToListAsync();

            PagedResult<SellOrder> sellOrderspagedResult = new PagedResult<SellOrder>();

            sellOrderspagedResult.HasNextPage = rawItems.Count > pageSize;
            sellOrderspagedResult.Items = rawItems.Take(pageSize).ToList();
            sellOrderspagedResult.Cursor = sellOrderspagedResult.Items.
                Select(so => new OrderCursor(so.DateAndTimeOfOrder, so.SellOrderID)).Last();

            return sellOrderspagedResult;
        }
    }
}
