using QuestPDF.Infrastructure;
using Serilog;
using StocksApp.Server.StartupExtensions;
using StocksApp.Server.Middleware;

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
            
            QuestPDF.Settings.License = LicenseType.Community;


            // Configure services and logging

            builder.Services.ConfigureServices(builder.Configuration);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseExceptionHandler();

            app.UseSerilogRequestLogging();
            
            app.UseHttpLogging();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();

            
            // Custom Middlewares
            app.UseRequestLogging();
            app.UseMaintenanceMode();

            app.MapControllers();

            

            app.Run();
        }
    }
}

//public partial class Program { }
