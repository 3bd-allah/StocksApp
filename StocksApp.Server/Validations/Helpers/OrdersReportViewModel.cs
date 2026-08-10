using StocksApp.Server.DTOs;
using StocksApp.Server.Entities;
using System.Globalization;

namespace StocksApp.Server.Validations.Helpers
{
    public class OrdersReportViewModel
    {

        public static List<OrderPdfItem> FromRowOrders(List<object> rowOrders)
        {
            List<OrderPdfItem> ordersPdfItems = new List<OrderPdfItem>();

            foreach (object rowOrder in rowOrders)
            {
                if(rowOrder is BuyOrderResponse buyOrder)
                {
                    ordersPdfItems.Add(new OrderPdfItem
                    {
                        CreeatedAt = buyOrder.DateAndTimeOfOrder.ToString("dd MMMM yyyy hh:mm:ss tt", CultureInfo.InvariantCulture.DateTimeFormat),
                        Stock = $"{buyOrder.StockName} ({buyOrder.StockSymbol})",
                        OrderType = "BuyOrder",
                        Price = buyOrder.Price,
                        Quantity = buyOrder.Quantity,
                    });
                }
                else
                {
                    SellOrderResponse sellOrder = (SellOrderResponse)rowOrder;
                    ordersPdfItems.Add(new OrderPdfItem
                    {
                        CreeatedAt = sellOrder.DateAndTimeOfOrder.ToString("dd MMMM yyyy hh:mm:ss tt", CultureInfo.InvariantCulture),
                        Stock = $"{sellOrder.StockName} ({sellOrder.StockSymbol})",
                        OrderType = "SellOrder",
                        Price = sellOrder.Price,
                        Quantity = sellOrder.Quantity,
                    });
                }
                
            }
            return ordersPdfItems; 
        }

    }
}
