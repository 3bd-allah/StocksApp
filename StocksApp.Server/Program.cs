using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using QuestPDF.Infrastructure;
using StocksApp.Server.AppDbContext;
using StocksApp.Server.IRepository;
using StocksApp.Server.Options;
using StocksApp.Server.Repository;
using StocksApp.Server.Services;
using StocksApp.Server.Services.Contracts;
using Serilog;

namespace StocksApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // creates a temporary logger that captures any errors during startup
            // - before appsettings.json is even loaded. Without this, startup crashes vanish silently.
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateBootstrapLogger(); 

            
            var builder = WebApplication.CreateBuilder(args);

            
            
            
            /// Logging 
            ///
            // old way =>  ( Host.UseSerilog() ) 

            //builder.Host.UseSerilog((context, services, loggerConfiguration) =>
            //{
            //    loggerConfiguration.ReadFrom.Configuration(context.Configuration)
            //    .ReadFrom.Services(services);
            //});

            // Recommened approach for logging configuration => ( Services.AddSerilog() )

            builder.Services.AddSerilog((services, loggerConfiguration) =>
            {
                loggerConfiguration
                .ReadFrom.Configuration(builder.Configuration) // read configuration settings
                                                               // from built-in IConfiguration (appsettings.json)
                .ReadFrom.Services(services); // read out current app's services
                                              // and make them available to serilog
            });

            // Add services to the container.
            QuestPDF.Settings.License = LicenseType.Community;
            builder.Services.AddControllers();
            builder.Services.AddScoped<IFinnhubService, FinnhubService>();
            builder.Services.AddScoped<IStockService, StockService>();
            builder.Services.AddScoped<IStockRepository, StockRepository>();
            builder.Services.AddScoped<IOrdersPdfGenerator, OrdersPdfGenerator>();
            builder.Services.AddScoped<IFinnhubRepository, FinnhubRepository>();

            // options patterns
            builder.Services.Configure<TradingOptions>(builder.Configuration.GetSection("TradingOptions"));
            builder.Services.Configure<UserFinnhubTokenOptions>
                (builder.Configuration.GetSection(UserFinnhubTokenOptions.SectionName));
            

            builder.Services.AddHttpClient();
            builder.Services.AddDbContext<StockMarketDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                options.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            });
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin();
                    policy.AllowAnyHeader();
                    policy.AllowAnyMethod();
                });
            });

            builder.Services.AddLogging();
            builder.Services.AddHttpLogging(options =>
            {
                options.LoggingFields = HttpLoggingFields.All; // Not Recommended for performance drawbacks
                //options.LoggingFields = HttpLoggingFields.RequestPropertiesAndHeaders;
                //options.LoggingFields = HttpLoggingFields.ResponsePropertiesAndHeaders;
            });            



            var app = builder.Build();

            app.UseSerilogRequestLogging();
            //app.Logger.LogDebug("Debug-message");
            //app.Logger.LogInformation("Information-message");
            //app.Logger.LogWarning("Warning-message");
            //app.Logger.LogError("Error-message");
            //app.Logger.LogCritical("Crititcal-message");

            app.UseHttpLogging();
            app.UseStaticFiles();
            // Configure the HTTP request pipeline.
            app.UseRouting();
            app.UseCors();

            app.MapControllers();

            

            app.Run();
        }
    }
}

//public partial class Program { }
