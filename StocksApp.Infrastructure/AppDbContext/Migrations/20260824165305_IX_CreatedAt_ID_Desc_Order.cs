using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class IX_CreatedAt_ID_Desc_Order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SellOrders_CreatedAt_ID",
                table: "SellOrders");

            migrationBuilder.DropIndex(
                name: "IX_BuyOrders_CreatedAt_ID",
                table: "BuyOrders");

            migrationBuilder.CreateIndex(
                name: "IX_SellOrders_CreatedAt_ID",
                table: "SellOrders",
                columns: new[] { "DateAndTimeOfOrder", "SellOrderID" },
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_BuyOrders_CreatedAt_ID",
                table: "BuyOrders",
                columns: new[] { "DateAndTimeOfOrder", "BuyOrderID" },
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SellOrders_CreatedAt_ID",
                table: "SellOrders");

            migrationBuilder.DropIndex(
                name: "IX_BuyOrders_CreatedAt_ID",
                table: "BuyOrders");

            migrationBuilder.CreateIndex(
                name: "IX_SellOrders_CreatedAt_ID",
                table: "SellOrders",
                columns: new[] { "DateAndTimeOfOrder", "SellOrderID" });

            migrationBuilder.CreateIndex(
                name: "IX_BuyOrders_CreatedAt_ID",
                table: "BuyOrders",
                columns: new[] { "DateAndTimeOfOrder", "BuyOrderID" });
        }
    }
}
