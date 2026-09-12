namespace StocksApp.Server.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            this.next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var startTime = DateTime.UtcNow;
            _logger.LogInformation("Incoming {Method} {Path}", context.Request.Method, context.Request.Path);

            await next(context);

            var elapsed = DateTime.UtcNow - startTime;
            _logger.LogInformation("Completed {Method} {Path} with {StatusCode} in {Elapsed} ms",
                context.Request.Method, context.Request.Path, context.Response.StatusCode, elapsed.TotalMilliseconds);

        }
    }

}
