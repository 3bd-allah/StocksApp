using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace StocksApp.Server.Filters.ResourceFilters
{
    public class FeatureDisableResourceFilter : IAsyncResourceFilter
    {
        private readonly ILogger<FeatureDisableResourceFilter> _logger;
        private readonly bool _isDisabled;

        public FeatureDisableResourceFilter(ILogger<FeatureDisableResourceFilter> logger, bool isDisabled = true)
        {
            _logger = logger;
            _isDisabled = isDisabled;
        }

        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            _logger.LogInformation("{FilterName}.{MethodName} method before",
                nameof(FeatureDisableResourceFilter),
                nameof(OnResourceExecutionAsync));
            if (_isDisabled)
            {
                //context.Result = new NotFoundResult(); // 404 - Not found

                context.Result = new StatusCodeResult(501); // 501 - Not implemented
            }
            else
            { 
                await next();
            }

            _logger.LogInformation("{FilterName}.{MethodName} method after",
                nameof(FeatureDisableResourceFilter),
                nameof(OnResourceExecutionAsync));
        }
    }
}
