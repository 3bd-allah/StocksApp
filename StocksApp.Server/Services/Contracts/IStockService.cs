using StocksApp.Server.DTOs;

namespace StocksApp.Server.Services.Contracts
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
    }
}
