using StocksApp.Core.Domain.Entities;
using StocksApp.Core.Validations;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Core.Application.DTOs
{
    public class BuyOrderRequest
    {
        [Required(ErrorMessage = "Stock symbol is required.")]
        public string? StockSymbol { get; set; }


        [Required(ErrorMessage = "Stock name is required.")]
        public string? StockName { get; set; }


        [MinimumDate("01-01-2000")]
        public DateTime DateAndTimeOfOrder { get; set; } = DateTime.UtcNow;


        [Range(1, 100000, ErrorMessage = "Quantity must be between 1 and 100,000.")]
        public uint Quantity { get; set; }


        [Range(1d, 10000d, ErrorMessage = "Price must be between 1 and 10,000.")]
        public double? Price { get; set; }

        public BuyOrder ToBuyOrder()
        {
            return new BuyOrder
            {
                StockSymbol = this.StockSymbol,
                StockName = this.StockName,
                DateAndTimeOfOrder = this.DateAndTimeOfOrder,
                Quantity = this.Quantity,
                Price = this.Price
            };
        }
    }
}
