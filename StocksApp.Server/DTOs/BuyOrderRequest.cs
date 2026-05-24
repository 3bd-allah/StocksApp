using StocksApp.Server.Entities;
using StocksApp.Server.Validations.CustomAttributes;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Server.DTOs
{
    public class BuyOrderRequest
    {
        [Required(ErrorMessage = "Stock symbol is required.")]
        public string? StcokSymbol { get; set; }


        [Required(ErrorMessage = "Stock name is required.")]
        public string? StockName { get; set; }


        [MinimumDate("01-01-2000")]
        public DateTime DateAndTimeOfOrder { get; set; }


        [Range(1, 100000, ErrorMessage = "Quantity must be between 1 and 100,000.")]
        public uint Quantity { get; set; }


        [Range(1d, 10000d, ErrorMessage = "Price must be between 1 and 10,000.")]
        public double? Price { get; set; }

        public BuyOrders ToBuyOrder()
        {
            return new BuyOrders
            {
                StcokSymbol = this.StcokSymbol,
                StockName = this.StockName,
                DateAndTimeOfOrder = this.DateAndTimeOfOrder,
                Quantity = this.Quantity,
                Price = this.Price
            };
        }
    }
}
