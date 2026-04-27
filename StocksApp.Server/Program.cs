using StocksApp.Server.Options;
using StocksApp.Server.Services;
using StocksApp.Server.Services.Contracts;

namespace StocksApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IFinnhubService, FinnhubService>();
            builder.Services.Configure<FinnhubSymbolOptions>(builder.Configuration.GetSection("FinnhubSymbols"));
            builder.Services.AddHttpClient();

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin();
                    policy.AllowAnyHeader();
                    policy.AllowAnyHeader();
                });
            });

            var app = builder.Build();

          
            app.UseStaticFiles();
            // Configure the HTTP request pipeline.
            app.UseRouting();
            app.UseCors();

            app.MapControllers();

            

            app.Run();
        }
    }
}
