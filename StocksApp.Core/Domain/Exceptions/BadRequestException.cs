using System.Net;
namespace StocksApp.Core.Domain.Exceptions
{
    public class BadRequestException(string message) 
        : AppException(message, HttpStatusCode.BadRequest)
    {
    }
}
