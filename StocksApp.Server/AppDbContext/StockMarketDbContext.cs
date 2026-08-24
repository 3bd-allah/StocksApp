using Microsoft.EntityFrameworkCore;
using StocksApp.Server.AppDbContext.Seeding.Fakers;
using StocksApp.Server.Entities;

namespace StocksApp.Server.AppDbContext
{
    public class StockMarketDbContext : DbContext
    {
        public DbSet<BuyOrder> BuyOrders { get; set; }
        public DbSet<SellOrder> SellOrders { get; set; }

        public StockMarketDbContext(DbContextOptions<StockMarketDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var (buyOrders, sellOrders) = DataGenerator.GenerateSeedData(0);
            
            modelBuilder.Entity<BuyOrder>()
                .ToTable("BuyOrders")
                .HasData(buyOrders);

            modelBuilder.Entity<SellOrder>()
                .ToTable("SellOrders")
                .HasData(sellOrders);

        }

    }
}
