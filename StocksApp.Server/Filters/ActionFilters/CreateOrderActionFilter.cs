using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using StocksApp.Server.Controllers;
using StocksApp.Server.Validations.Helpers;

namespace StocksApp.Server.Filters.ActionFilters
{
    public class CreateOrderActionFilter : IActionFilter
    {
        private readonly ILogger<CreateOrderActionFilter> _logger;
        public CreateOrderActionFilter(ILogger<CreateOrderActionFilter> logger)
        {
            _logger = logger;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("{FilterName}.{MethodName} method before",
                nameof(CreateOrderActionFilter),
                nameof(OnActionExecuting));

            if(context.Controller.GetType().Name == nameof(TradeController))
            {
                if(context.ActionArguments.ContainsKey("orderRequest"))
                {
                    if(context.ModelState.IsValid)
                        return;
                }
                else
                {
                    context.Result = new BadRequestObjectResult(new { 
                        Message = "Order request is missing." 
                    });
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("{FilterName}.{MethodName} method after",
                nameof(CreateOrderActionFilter),
                nameof(OnActionExecuted));
        }

    }
}
