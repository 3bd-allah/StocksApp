using System.ComponentModel.DataAnnotations;

namespace StocksApp.Core.Domain.Entities
{
    public class SellOrder
    {
        [Key]
        [Required(ErrorMessage = "Buy order ID is required.")]
        public Guid SellOrderID { get; set; }


        [Required(ErrorMessage = "Stock symbol is required.")]
        public string? StockSymbol { get; set; }


        [Required(ErrorMessage = "Stock name is required.")]
        public string? StockName { get; set; }

        public DateTime DateAndTimeOfOrder { get; set; }


        [Range(1,100000, ErrorMessage = "Quantity must be between 1 and 100,000.")]
        public uint Quantity { get; set; }


        [Range(1d,10000d, ErrorMessage ="Price must be between 1 and 10,000.")]
        public double? Price { get; set; }
    }
}
