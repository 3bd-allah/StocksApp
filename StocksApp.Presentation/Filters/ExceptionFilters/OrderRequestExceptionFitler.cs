using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace StocksApp.Server.Filters.ExceptionFilters
{
    public class OrderRequestExceptionFitler : IExceptionFilter
    {
        private readonly ILogger<OrderRequestExceptionFitler> _logger;

        public OrderRequestExceptionFitler(ILogger<OrderRequestExceptionFitler> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError("Exception Filter {FilterName}.{MethodName}\n {ExceptionType}\n{ExceptionMessage}",
                nameof(OrderRequestExceptionFitler),
                nameof(OnException),
                context.Exception.GetType().Name,
                context.Exception.Message);

            if (context.Exception != null)
            {
                context.Result = new BadRequestObjectResult(new
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Title = "Invalid Order Request",
                    Detail = context.Exception.Message
                });
            }
        }
    }
}
