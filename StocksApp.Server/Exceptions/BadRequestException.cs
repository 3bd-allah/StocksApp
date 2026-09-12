using System.Net;
namespace StocksApp.Server.Exceptions
{
    public class BadRequestException(string message) 
        : AppException(message, HttpStatusCode.BadRequest)
    {
    }
}
