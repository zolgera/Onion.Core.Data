using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Dtos.Security
{
    public class TokenResponseDto
    {
        public TokenResponseDto()
        {

        }
        #region Properties
        public string Token { get; set; }
        public int Expiration { get; set; }
        public string RefreshToken { get; set; }
        #endregion
    }
}
