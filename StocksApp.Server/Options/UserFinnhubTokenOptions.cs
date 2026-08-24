using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace StocksApp.Server.Options
{
    public class UserFinnhubTokenOptions
    {
        public const string SectionName = "TokenSettings";
        public string? UserToken { get; set; } 
    }
}
