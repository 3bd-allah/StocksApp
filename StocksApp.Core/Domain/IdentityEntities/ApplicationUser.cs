using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity; 
namespace StocksApp.Core.Domain.IdentityEntities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string?  DisplayName { get; set; }
    }
}
