using System.Net;

namespace StocksApp.Server.Exceptions
{
    public abstract class AppException (string message, HttpStatusCode statucCode = HttpStatusCode.InternalServerError)
        : Exception(message)
    {
        public HttpStatusCode StatusCode { get; } = statucCode;
    }
}
