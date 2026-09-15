using Microsoft.AspNetCore.Mvc.Filters;

namespace StocksApp.Server.Filters.ActionFilters
{
    public class SearchStocksActionFilter : IActionFilter
    {
        private readonly ILogger<SearchStocksActionFilter> _logger;

        public SearchStocksActionFilter(ILogger<SearchStocksActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("SearchStocksActionFilter.OnActionExecuted method");
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("SearchStocksActionFilter.OnActionExecuting method");
            if (context.ActionArguments.ContainsKey("stockNameToSearch"))
            {
                string searchStock = Convert.ToString(context.ActionArguments["stockNameToSearch"])!;
                _logger.LogInformation("Stock Name to search before is {searchStock}", searchStock);
                context.ActionArguments["StockNameToSearch"] = searchStock.ToUpper().Trim();
                _logger.LogInformation("Stock Name to search after is {searchStock}", context
                    .ActionArguments["stockNameToSearch"]);

            }
            else
            {
                context.ActionArguments["StockNameToSearch"] = "MSFT";
                
            }

            
        }
    }
}
