using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using StocksApp.Server.Controllers;
using StocksApp.Server.DTOs;
using StocksApp.Server.Exceptions;

namespace StocksApp.Server.Filters.ActionFilters
{
    public class StocksCursorPaginationActionFilter : IActionFilter
    {
        private readonly ILogger<StocksCursorPaginationActionFilter> _logger;

        public StocksCursorPaginationActionFilter(ILogger<StocksCursorPaginationActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
            _logger.LogInformation("{FilterName}.{MethodName} method before",
                nameof(StocksCursorPaginationActionFilter),
                nameof(OnActionExecuting));

            if (context.Controller is nameof(StocksController))
            {
                var actionMethodName = context.ActionDescriptor.DisplayName;
                if (actionMethodName is not null and not (nameof(StocksController.CursorPaginationBuyOrders) or nameof(StocksController.CursorPaginationSellOrders)))
                {
                    return;
                }
            }

            if (context.HttpContext.Request.Query.TryGetValue("after", out StringValues prevCursor))
            {
                try
                {
                    var correctOrderCursor = CursorEncoder.Decode(prevCursor!.ToString()!);
                    context.ActionArguments["cursor"] = correctOrderCursor;
                }
                catch
                {
                    throw new InvalidCursorException("Invalid cursor format.");
                }
            }

            //context.ActionArguments["cursor"] = context.HttpContext.Items["cursor"];
        }

        
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("{FilterName}.{MethodName} method after",
                nameof(StocksCursorPaginationActionFilter),
                nameof(OnActionExecuted));

            if(context.Controller.GetType().Name is nameof(StocksController))
            {
                var descriptor = context.ActionDescriptor as ControllerActionDescriptor;
                var actionMethodName = descriptor?.ActionName;
                if (actionMethodName is null )
                {
                    return;
                }

                var result = context.Result;

                if(result is OkObjectResult okObjectResult)
                {
                    var resultValue = okObjectResult.Value;

                    if(resultValue is not null)
                    {
                        if(actionMethodName is nameof(StocksController.CursorPaginationBuyOrders))
                        {
                            var resultFromActionMethod = (PagedResult<BuyOrderResponse>)resultValue;

                            var cursorObject = resultFromActionMethod.Cursor;
                            string encodedCursor = CursorEncoder.Encode(cursorObject!);
                            var finalResult = new
                            {
                                items = resultFromActionMethod.Items,
                                cursor = encodedCursor,
                                hasNextPage = resultFromActionMethod.HasNextPage
                            };
                            context.Result = new OkObjectResult(finalResult);
                        }
                        else
                        {
                            var resultFromActionMethod = (PagedResult<SellOrderResponse>)resultValue;

                            var cursorObject = resultFromActionMethod.Cursor;
                            string encodedCursor = CursorEncoder.Encode(cursorObject!);
                            var finalResult = new
                            {
                                items = resultFromActionMethod.Items,
                                cursor = encodedCursor,
                                hasNextPage = resultFromActionMethod.HasNextPage
                            };
                            context.Result = new OkObjectResult(finalResult);
                        }
                    }
                }

            }
        }

    }
}
