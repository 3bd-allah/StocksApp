using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Serilog;
using StocksApp.Server.AppDbContext;
using StocksApp.Server.Handlers;
using StocksApp.Server.Repository;
using StocksApp.Core.ServiceContracts;
using StocksApp.Core.Application.Common.Options;
using StocksApp.Core.Domain.IRepository;
using StocksApp.Core.Application.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StocksApp.Core.Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;

namespace StocksApp.Presentation.StartupExtensions
{
    public static class ConfigureServicesExtension
    {
        public static void ConfigureServices(this IServiceCollection services, IConfigurationManager configuration)
        {
            // Add services to the container.

            services.AddProblemDetails(options =>
            {
                options.CustomizeProblemDetails = context =>
                {
                    context.ProblemDetails.Extensions["traceId"] = context.HttpContext.TraceIdentifier;
                    context.ProblemDetails.Extensions["timeStamp"] = DateTime.UtcNow;
                };
            });

            services.AddExceptionHandler<GlobalExceptionHandler>();
            /// Logging 
            ///
            // old way =>  ( Host.UseSerilog() ) 

            //builder.Host.UseSerilog((context, services, loggerConfiguration) =>
            //{
            //    loggerConfiguration.ReadFrom.Configuration(context.Configuration)
            //    .ReadFrom.Services(services);
            //});

            // Recommened approach for logging configuration => ( Services.AddSerilog() )


            services.AddSerilog((services, loggerConfiguration) =>
            {
                loggerConfiguration
                .ReadFrom.Configuration(configuration) // read configuration settings
                                                               // from built-in IConfiguration (appsettings.json)
                .ReadFrom.Services(services); // read out current app's services
                                              // and make them available to serilog
            }, preserveStaticLogger: true);

            services.AddControllers(options =>
            {
                /// Global filters
                //options.Filters.Add<ResponseHeaderActionFilter>();

                //var logger = services.BuildServiceProvider()
                //.GetRequiredService<ILogger<ResponseHeaderActionFilter>>();

                //options.Filters.Add(new ResponseHeaderActionFilter(logger, "My-Key-From-Global", "MyValue-From-Global"));
            });
            services.AddScoped<IFinnhubService, FinnhubService>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IStockRepository, StockRepository>();
            services.AddScoped<IOrdersPdfGenerator, OrdersPdfGenerator>();
            services.AddScoped<IFinnhubRepository, FinnhubRepository>();

            // options patterns
            services.Configure<TradingOptions>(configuration.GetSection("TradingOptions"));
            services.Configure<UserFinnhubTokenOptions>
                (configuration.GetSection(UserFinnhubTokenOptions.SectionName));


            services.AddHttpClient();
            services.AddDbContext<StockMarketDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                options.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            });

            // Enable Identity in this project

            services.AddIdentity<ApplicationUser, ApplicationRole>()

                // this for using the default Identity tables in the database.
                .AddEntityFrameworkStores<StockMarketDbContext>()
                .AddDefaultTokenProviders()
                .AddUserStore<UserStore<ApplicationUser, ApplicationRole, StockMarketDbContext, Guid>>()
                .AddRoleStore<RoleStore<ApplicationRole, StockMarketDbContext, Guid>>();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin();
                    policy.AllowAnyHeader();
                    policy.AllowAnyMethod();
                });
            });

            services.AddLogging();
            services.AddHttpLogging(options =>
            {
                //options.LoggingFields = HttpLoggingFields.All; // Not Recommended for performance drawbacks
                options.LoggingFields = HttpLoggingFields.RequestPropertiesAndHeaders;
                options.LoggingFields = HttpLoggingFields.ResponsePropertiesAndHeaders;
            });

        }
    }
}
