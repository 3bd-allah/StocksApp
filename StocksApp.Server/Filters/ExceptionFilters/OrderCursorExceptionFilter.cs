using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace StocksApp.Server.Filters.ExceptionFilters
{
    public class OrderCursorExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<OrderCursorExceptionFilter> _logger;

        public OrderCursorExceptionFilter(ILogger<OrderCursorExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError("Exception Filter {FilterName}.{MethodName}\n {ExceptionType}\n{ExceptionMessage}",
                nameof(OrderCursorExceptionFilter),
                nameof(OnException),
                context.Exception.GetType().Name,
                context.Exception.Message);

            if (context.Exception != null)
            {
                context.Result = new BadRequestObjectResult(new
                {
                    Title = "An error occurred while processing your request.",
                    Details = context.Exception.Message,
                });  
            }
        }
    }
}
