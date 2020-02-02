using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Dtos.Security
{
    public class JwtConfiguration
    {
        public string JwtKey { get; set; }
        public string JwtIssuer { get; set; }
        public string JwtAudiance { get; set; }
        public int JwtExpireDays { get; set; }
    }
}
