using System.Net;

namespace StocksApp.Server.Exceptions
{
    public class InvalidCursorException(string message) 
        : AppException(message, HttpStatusCode.BadRequest)
    {
    }
}
