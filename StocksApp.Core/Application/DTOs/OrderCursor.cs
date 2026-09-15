using StocksApp.Core.Domain.Entities;
using System.Text;
using System.Text.Json;

namespace StocksApp.Core.Application.DTOs
{
    public record OrderCursor(DateTime? CraetedAt, Guid? OrderId);
    
    public static class CursorEncoder
    {
        public static string Encode(OrderCursor plainCursor)
        {
            string json = JsonSerializer.Serialize(plainCursor);
            byte[] bytes = Encoding.UTF8.GetBytes(json);

            string encodedCursor = Convert.ToBase64String(bytes);
                                            //.TrimEnd('=')
                                            //.Replace('+','-')
                                            //.Replace('/','_');
            return encodedCursor;
        }

        public static OrderCursor? Decode(string encodedCursor)
        {
            if(string.IsNullOrWhiteSpace(encodedCursor)) return null;

            byte[] encodedTextBytes = Convert.FromBase64String(encodedCursor);
            string json = Encoding.UTF8.GetString(encodedTextBytes);

            OrderCursor? orderCursor = JsonSerializer.Deserialize<OrderCursor>(json);

            return orderCursor;

        }
 
    }

    public static partial class BuyOrderExtensions
    {
        public static OrderCursor ToOrderCursor (this BuyOrder buyOrder)
        {
            return new OrderCursor(buyOrder.DateAndTimeOfOrder, buyOrder.BuyOrderID);
        }
    }
   
}
