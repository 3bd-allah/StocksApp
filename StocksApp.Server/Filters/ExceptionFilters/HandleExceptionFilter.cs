using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace StocksApp.Server.Filters.ExceptionFilters
{
    public class HandleExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<HandleExceptionFilter> _logger;
        private readonly IHostEnvironment _hostEnvironment;

        public HandleExceptionFilter(ILogger<HandleExceptionFilter> logger, IHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError("Exception Filter {FilterName}.{MethodName}\n {ExceptionType}\n{ExceptionMessage}",
                nameof(HandleExceptionFilter), nameof(OnException), context.Exception.GetType().Name, context.Exception.Message);

            if(_hostEnvironment.IsDevelopment())
            {
                context.Result = new ContentResult
                {
                    Content = $"Exception: {context.Exception.Message}",
                    ContentType = "text/plain",
                    StatusCode = 500
                };
            }
        }
    }
}
