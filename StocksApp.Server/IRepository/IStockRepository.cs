using StocksApp.Server.DTOs;
using StocksApp.Server.Entities;
using System.Linq.Expressions;

namespace StocksApp.Server.IRepository
{
    public interface IStockRepository
    {
        /// <summary>
        /// Inserts a new buy order into the database table called 'BuyOrders'. 
        /// </summary>
        /// <param name="request">object that hold data that you want to store in the BuyOrder entity</param>
        /// <returns>Returns an Object of BuyOrderReponse including generated newely id</returns>
        Task<BuyOrder> AddBuyOrder(BuyOrder buyOrder);

        /// <summary>
        /// Inserts a new sell order into the database table called 'SellOrders'.
        /// </summary>
        /// <param name="request">object that hold data that you want to store in the SellOrders entity</param>
        /// <returns></returns>
        Task<SellOrder> AddSellOrder(SellOrder sellOrder);

        /// <summary>
        /// get all the existing of all buy orders stored
        /// </summary>
        /// <returns>Returns the existing list of buy orders retrieved from database table called 'BuyOrders'.</returns>
        Task<List<BuyOrder>> GetAllBuyOrders();


        /// <summary>
        /// get all the existing of all sell orders stored
        /// </summary>
        /// <returns>Returns the existing list of sell orders retrieved from database table called 'SellOrders'.</returns>
        Task<List<SellOrder>> GetAllSellOrders();

        /// <summary>
        /// get all the existing of all T stored with filter
        /// </summary>
        /// <typeparam name="T"> db set that you want to filter </typeparam>
        /// <param name="predicate"> condition to filter by </param>
        /// <returns>List of filtered items</returns>
        Task<List<T>> GetFilteredStocks<T>(Expression<Func<T, bool>> predicate) where T : class;
    }
}
