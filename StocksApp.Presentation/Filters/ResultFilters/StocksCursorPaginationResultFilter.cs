using Microsoft.AspNetCore.Mvc.Filters;

namespace StocksApp.Server.Filters.ResultFilters
{
    public class StocksCursorPaginationResultFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            var result = context.Result;
            context.HttpContext.Response.Cookies.Append("cursor", result.ToString()!);
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            return;
        }
    }
}
