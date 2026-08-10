using StocksApp.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Server.DTOs
{
    public class SellOrderRequest
    {

        [Required(ErrorMessage = "Stock symbol is required.")]
        public string? StockSymbol { get; set; }

        [Required(ErrorMessage = "Stock name is required.")]
        public string? StockName { get; set; }


        [DataType(DataType.Date)]
        public DateTime DateAndTimeOfOrder { get; set; } = DateTime.UtcNow; 


        [Range(1, 100000, ErrorMessage = "Quantity must be between 1 and 100,000.")]
        public uint Quantity { get; set; }


        [Range(1d, 10000d, ErrorMessage = "Price must be between 1 and 10,000.")]
        public double? Price { get; set; }


        public SellOrder ToSellOrder()
        {
            return new SellOrder
            {
                StockSymbol = this.StockSymbol,
                StockName = this.StockName,
                Quantity = this.Quantity,
                Price = this.Price,
                DateAndTimeOfOrder = this.DateAndTimeOfOrder
            };
        }
    }
}
