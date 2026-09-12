using System.Net;

namespace StocksApp.Server.Exceptions
{
    public class UnSupportedCompanyProfileException(string message) : AppException(message)
    {
    }
}
