using System.Net;

namespace StocksApp.Core.Domain.Exceptions
{
    public class UnSupportedCompanyProfileException(string message) : AppException(message)
    {
    }
}
