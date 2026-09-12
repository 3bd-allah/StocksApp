using System.Net;

namespace StocksApp.Server.Exceptions
{
    public sealed class NotFoundException (string resourceName, object key)
        : AppException($"{resourceName} with key '{key}' was not found.", HttpStatusCode.NotFound)
    {
    }
}
