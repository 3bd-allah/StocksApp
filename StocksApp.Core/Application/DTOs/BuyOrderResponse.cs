using StocksApp.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Core.Application.DTOs
{
    public record BuyOrderResponse
    {

        public Guid? BuyOrderID { get; set; }

        [Required(ErrorMessage = "Stock symbol is required.")]
        public string? StockSymbol { get; set; }

        [Required(ErrorMessage = "Stock name is required.")]
        public string? StockName { get; set; }

        public DateTime DateAndTimeOfOrder { get; set; }


        [Range(1, 100000, ErrorMessage = "Quantity must be between 1 and 100,000.")]
        public uint Quantity { get; set; }


        [Range(1d, 10000d, ErrorMessage = "Price must be between 1 and 10,000.")]
        public double? Price { get; set; }

        public double TradeAmount{ get; set; }
    }


    public static partial class BuyOrderExtensions{ 
        
        public static BuyOrderResponse ToBuyOrderResponse(this BuyOrder buyOrder)
        {
            return new BuyOrderResponse
            {
                BuyOrderID = buyOrder.BuyOrderID,
                StockSymbol = buyOrder.StockSymbol,
                StockName = buyOrder.StockName,
                DateAndTimeOfOrder = buyOrder.DateAndTimeOfOrder,
                Quantity = buyOrder.Quantity,
                Price = buyOrder.Price,
                TradeAmount  = Convert.ToDouble(buyOrder.Price * buyOrder.Quantity)
            };
        }
    }
}
