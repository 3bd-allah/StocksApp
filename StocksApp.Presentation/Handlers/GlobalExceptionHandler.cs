using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StocksApp.Core.Domain.Exceptions;


namespace StocksApp.Server.Handlers
{
    public sealed class GlobalExceptionHandler(
        ILogger<GlobalExceptionHandler> logger,
        IProblemDetailsService problemDetailsService
        ) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(
            HttpContext httpContext,
            Exception exception,
            CancellationToken cancellationToken)
        {

            logger.LogError(exception, "An unhandled exception occurred. TraceId: {TraceId}", httpContext.TraceIdentifier);

            var (statusCode, title) = MapException(exception);

            var problemDetails = new ProblemDetails()
            {
                Status = statusCode,
                Title = title,
                Instance = httpContext.Request.Path,
                Type = GetProblemType(statusCode),
                Detail = GetSafeErrorMessage(httpContext, exception)
            };

            return await problemDetailsService.TryWriteAsync(new ProblemDetailsContext
            {
                HttpContext = httpContext,
                ProblemDetails = problemDetails
            });

        }


        private static (int, string) MapException(Exception exception)
        {
            return exception switch
            {
                AppException appEx => ((int)appEx.StatusCode, exception.Message),
                ArgumentNullException => (StatusCodes.Status400BadRequest, "Invalid argument provided"),
                ArgumentException => (StatusCodes.Status400BadRequest, "Invalid argument provided"),
                UnauthorizedAccessException => (StatusCodes.Status401Unauthorized, "Unauthorized"),
                _ => (StatusCodes.Status500InternalServerError, "An unexpected error occurred")
            };
        }

        private static string GetProblemType(int statusCode) => statusCode switch
        {
            400 => "https://tools.ietf.org/html/rfc9110#section-15.5.1",
            401 => "https://tools.ietf.org/html/rfc9110#section-15.5.2",
            403 => "https://tools.ietf.org/html/rfc9110#section-15.5.4",
            404 => "https://tools.ietf.org/html/rfc9110#section-15.5.5",
            409 => "https://tools.ietf.org/html/rfc9110#section-15.5.10",
            _ => "https://tools.ietf.org/html/rfc9110#section-15.6.1"
        };

        private static string GetSafeErrorMessage(HttpContext context, Exception exception)
        {
            // In development, return the full exception message for debugging purposes.
            var env = context.RequestServices.GetRequiredService<IHostEnvironment>();
            if (env.IsDevelopment())
            {
                return exception.Message;
            }

            // In production, return a generic error message to avoid exposing sensitive information.
            return exception is AppException ? exception.Message : null!;
        }
    }
}
