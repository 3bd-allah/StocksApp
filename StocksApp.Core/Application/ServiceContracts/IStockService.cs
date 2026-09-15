using StocksApp.Core.Application.DTOs;
using System.Linq.Expressions;

namespace StocksApp.Core.ServiceContracts
{
    public interface IStockService
    {
        /// <summary>
        /// Inserts a new buy order into the database table called 'BuyOrders'. 
        /// </summary>
        /// <param name="request">object that hold data that you want to store in the BuyOrder entity</param>
        /// <returns>Returns an Object of BuyOrderReponse including generated newely id</returns>
        Task<BuyOrderResponse> CreateBuyOrder(BuyOrderRequest? request);

        /// <summary>
        /// Inserts a new sell order into the database table called 'SellOrders'.
        /// </summary>
        /// <param name="request">object that hold data that you want to store in the SellOrders entity</param>
        /// <returns></returns>
        Task<SellOrderResponse> CreateSellOrder(SellOrderRequest? request);

        /// <summary>
        /// get all the existing of all buy orders stored
        /// </summary>
        /// <returns>Returns the existing list of buy orders retrieved from database table called 'BuyOrders'.</returns>
        Task<List<BuyOrderResponse>> GetAllBuyOrders();


        /// <summary>
        /// get all the existing of all sell orders stored
        /// </summary>
        /// <returns>Returns the existing list of sell orders retrieved from database table called 'SellOrders'.</returns>
        Task<List<SellOrderResponse>> GetAllSellOrders();

        /// <summary>
        /// get all the existing of all T stored with filter
        /// </summary>
        /// <typeparam name="T"> db set that you want to filter </typeparam>
        /// <param name="predicate"> condition to filter by </param>
        /// <returns>List of filtered items</returns>
        Task<List<T>> GetFilteredStocks<T>(Expression<Func<T, bool>> predicate) where T : class;

        /// <summary>
        /// get the list of orders after the cursor
        /// </summary>
        /// <param name="cursor">encoded cursor to get page result after</param>
        /// <returns>returns the page result of buy orders after the encoded cursor</returns>
        Task <PagedResult<BuyOrderResponse>?> GetPaginatedBuyOrders(OrderCursor cursor);

        /// <summary>
        /// get the list of orders after the cursor
        /// </summary>
        /// <param name="cursor">encoded cursor to get page result after</param>
        /// <returns>returns the page result of sell orders after the encoded cursor</returns>
        Task<PagedResult<SellOrderResponse>?> GetPaginatedSellOrders(OrderCursor? cursor);

    }
}
