using System.Net;

namespace StocksApp.Core.Domain.Exceptions
{
    public class InvalidCursorException(string message) 
        : AppException(message, HttpStatusCode.BadRequest)
    {
    }
}
