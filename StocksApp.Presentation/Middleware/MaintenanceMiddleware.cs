using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace StocksApp.Server.Middleware
{
    public class MaintenanceMiddleware (RequestDelegate next, IConfiguration configuration)
    {
        public async Task Invoke(HttpContext context)
        {
            var isMaintenanceMode = configuration.GetValue<bool>("MaintenanceMode");

            if (isMaintenanceMode)
            {
                context.Response.StatusCode = StatusCodes.Status503ServiceUnavailable;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(new
                {
                    Status = 503,
                    Message = "The application is currently under maintenance. Please try again later."
                });
                return; 
            }

            await next(context);
        }
    }

   
}
