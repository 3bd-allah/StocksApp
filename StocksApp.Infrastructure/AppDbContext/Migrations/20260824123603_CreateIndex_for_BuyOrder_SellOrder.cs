using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StocksApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateIndex_for_BuyOrder_SellOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SellOrders_CreatedAt_ID",
                table: "SellOrders",
                columns: new[] { "DateAndTimeOfOrder", "SellOrderID" });

            migrationBuilder.CreateIndex(
                name: "IX_BuyOrders_CreatedAt_ID",
                table: "BuyOrders",
                columns: new[] { "DateAndTimeOfOrder", "BuyOrderID" });
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
        }
    }
}
