using Bogus;
using StocksApp.Server.Entities;

namespace StocksApp.Server.AppDbContext.Seeding.Fakers
{
    public static class DataGenerator
    {
        public static (List<BuyOrder> BuyOrders, List<SellOrder> SellOrders) GenerateSeedData(int count = 10)
        {
            // Enforce deterministic random generation for EF Migrations
            Randomizer.Seed = new Random(42);

            var buyOrderFaker = new Faker<BuyOrder>()
                .RuleFor(b => b.BuyOrderID, f => f.Random.Guid())
                .RuleFor(b => b.StockSymbol, f => f.Finance.Currency().Symbol)
                .RuleFor(b => b.StockName, f => f.Company.CompanyName())
                .RuleFor(s => s.DateAndTimeOfOrder, f => f.Date.Future(1, refDate: DateTime.UtcNow.AddHours(1)))
                .RuleFor(s => s.Quantity, f => f.Random.UInt(1, 100000))
                .RuleFor(s => s.Price, f => Math.Round(f.Random.Double(1.0, 10000.0), 2));

            var sellOrderFaker = new Faker<SellOrder>()
                .RuleFor(s => s.SellOrderID, f => f.Random.Guid())
                .RuleFor(s => s.StockSymbol, f => f.Finance.Currency().Symbol)
                .RuleFor(s => s.StockName, f => f.Company.CompanyName())
                .RuleFor(s => s.DateAndTimeOfOrder, f => f.Date.Future(1, refDate: DateTime.UtcNow.AddHours(1)))
                .RuleFor(s => s.Quantity, f => f.Random.UInt(1, 100000))    
                .RuleFor(s => s.Price, f => Math.Round(f.Random.Double(1.0, 10000.0), 2));

            return (buyOrderFaker.Generate(count), sellOrderFaker.Generate(count));
        }

        
    }
}
