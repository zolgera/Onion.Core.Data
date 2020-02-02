using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Dtos.Security
{
    public class TokenModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public long ExpiresIn { get; set; }
        public string TokenType { get; set; }
    }
}
