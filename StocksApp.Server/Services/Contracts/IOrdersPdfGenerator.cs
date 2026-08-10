using StocksApp.Server.DTOs;

namespace StocksApp.Server.Services.Contracts
{
    public interface IOrdersPdfGenerator
    {
        /// <summary>
        /// Generates a PDF document containing all buy and sell orders.
        /// </summary>
        /// <returns> A byte array representing the PDF document. </returns>
        Task<byte[]> GenerateOrdersPdfAsync();
    }
}
