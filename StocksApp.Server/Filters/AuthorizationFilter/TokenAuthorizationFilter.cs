using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace StocksApp.Server.Filters.AuthorizationFilter
{
    public class TokenAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(context.HttpContext.Request.Cookies.ContainsKey("Auth-Key"))
            {
                // Token is present, allow the request
            }
            else
            {
                // Token is missing, deny the request
                context.Result = new UnauthorizedObjectResult(new
                {
                    Message = "Unauthorized: Missing Auth-Key cookie.",
                    Detail= "Please ensure that the Auth-Key cookie is present in the request."
                });
            }
        }
    }
}
