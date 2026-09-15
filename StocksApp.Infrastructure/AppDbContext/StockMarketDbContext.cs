using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StocksApp.Core.Domain.Entities;
using StocksApp.Core.Domain.IdentityEntities;
using StocksApp.Server.AppDbContext.Seeding.Fakers;

namespace StocksApp.Server.AppDbContext
{
    public class StockMarketDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public DbSet<BuyOrder> BuyOrders { get; set; }
        public DbSet<SellOrder> SellOrders { get; set; }

        public StockMarketDbContext(DbContextOptions<StockMarketDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var (buyOrders, sellOrders) = DataGenerator.GenerateSeedData(0);
            
            modelBuilder.Entity<BuyOrder>()
                .ToTable("BuyOrders")
                .HasData(buyOrders);

            modelBuilder.Entity<SellOrder>()
                .ToTable("SellOrders")
                .HasData(sellOrders);

            modelBuilder.Entity<BuyOrder>()
                .HasIndex(bo => new { bo.DateAndTimeOfOrder, bo.BuyOrderID }, "IX_BuyOrders_CreatedAt_ID")
                .IsDescending(true, true);

            modelBuilder.Entity<SellOrder>()
                .HasIndex(so => new { so.DateAndTimeOfOrder, so.SellOrderID }, "IX_SellOrders_CreatedAt_ID")
                .IsDescending(true, true);

            modelBuilder.Entity<ApplicationUser>()
                .ToTable("Users");

            modelBuilder.Entity<ApplicationRole>()
                .ToTable("Roles");
                
        }

    }
}
