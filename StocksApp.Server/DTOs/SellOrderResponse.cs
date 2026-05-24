using StocksApp.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace StocksApp.Server.DTOs
{
    public record SellOrderResponse
    {
        public Guid SellOrderID { get; set; }

        [Required(ErrorMessage = "Stock symbol is required.")]
        public string? StcokSymbol { get; set; }

        [Required(ErrorMessage = "Stock name is required.")]
        public string? StockName { get; set; }

        public DateTime DateAndTimeOfOrder { get; set; }


        [Range(1, 100000, ErrorMessage = "Quantity must be between 1 and 100,000.")]
        public uint Quantity { get; set; }


        [Range(1d, 10000d, ErrorMessage = "Price must be between 1 and 10,000.")]
        public double? Price { get; set; }

        public double TradeAmount { get; set; }

    }
    public static class SellOrderExtenstions
    {
        public static SellOrderResponse ToSellOrderResponse(this SellOrders sellOrder)
        {
            return new SellOrderResponse
            {
                SellOrderID = sellOrder.SellOrderID,
                StockName = sellOrder.StockName,
                StcokSymbol = sellOrder.StcokSymbol,
                Quantity = sellOrder.Quantity,
                Price = sellOrder.Price,
                DateAndTimeOfOrder = sellOrder.DateAndTimeOfOrder,
                TradeAmount = Convert.ToDouble(sellOrder.Quantity * sellOrder.Price)
            };
        }
    }
}
