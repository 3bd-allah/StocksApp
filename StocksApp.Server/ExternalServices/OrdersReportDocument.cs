using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using StocksApp.Server.DTOs;

namespace StocksApp.Server.ExternalServices
{
    public class OrdersReportDocument : IDocument
    {
        private readonly List<OrderPdfItem> _orderItems;
        public OrdersReportDocument(List<OrderPdfItem> orderItems)
        {
            _orderItems = orderItems;
        }
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);
                page.Size(PageSizes.A4);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(10).FontFamily(Fonts.Arial));

                page.Content().Column(column =>
                {
                    column.Spacing(15);

                    // Section Title
                    column.Item().Text("Orders")
                        .FontSize(24)
                        .Bold()
                        .FontColor(Colors.Black);

                    // Table Layout
                    column.Item().Table(table =>
                    {
                        // 1. Define Column Widths
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(160); // Date and Time
                            columns.RelativeColumn(2.5f); // Stock
                            columns.RelativeColumn(1.5f); // Order Type
                            columns.RelativeColumn(1.2f); // Quantity
                            columns.RelativeColumn(1.2f); // Price
                            columns.RelativeColumn(1.8f); // Trade Amount
                        });

                        // 2. Define Table Header
                        table.Header(header =>
                        {
                            var headerColor = "#C5D8C7"; // Soft Sage Green

                            header.Cell().Background(headerColor).Padding(6).Text("Date and Time").Bold();
                            header.Cell().Background(headerColor).Padding(6).Text("Stock").Bold();
                            header.Cell().Background(headerColor).Padding(6).Text("Order Type").Bold();
                            header.Cell().Background(headerColor).Padding(6).Text("Quantity").Bold();
                            header.Cell().Background(headerColor).Padding(6).Text("Price").Bold();
                            header.Cell().Background(headerColor).Padding(6).AlignRight().Text("Trade Amount").Bold();
                        });

                        // 3. Populate Rows
                        for (int i = 0; i < _orderItems.Count; i++)
                        {
                            var order = _orderItems[i];
                            // Subtle alternating background color
                            var backgroundColor = i % 2 == 0 ? "#F8F9FA" : "#FFFFFF";

                            table.Cell().Background(backgroundColor).Padding(6).Text(order.CreeatedAt);
                            table.Cell().Background(backgroundColor).Padding(6).Text(order.Stock);
                            table.Cell().Background(backgroundColor).Padding(6).Text(order.OrderType);
                            table.Cell().Background(backgroundColor).Padding(6).Text(order.Quantity.ToString());
                            table.Cell().Background(backgroundColor).Padding(6).Text($"$ {order.Price:N2}");
                            table.Cell().Background(backgroundColor).Padding(6).AlignRight().Text($"{order.TradeAmount:N2}");
                        }
                    });
                });
            });
        }
    }
}
