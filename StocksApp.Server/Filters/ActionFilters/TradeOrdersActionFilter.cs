using Microsoft.AspNetCore.Mvc.Filters;

namespace StocksApp.Server.Filters.ActionFilters
{
    public class TradeOrdersActionFilter : IActionFilter
    {
        private readonly ILogger<TradeOrdersActionFilter> _logger;

        public TradeOrdersActionFilter(ILogger<TradeOrdersActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("TradeOrdersActionFilter.OnActionExecuted method");
            _logger.LogDebug("Orders return from orders action method {Orders}", context.Result);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("TradeOrdersActionFilter.OnActionExecuting method");
        }
    }
}
