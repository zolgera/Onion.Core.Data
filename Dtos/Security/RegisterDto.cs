using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Data.Dtos.Security
{
    public class RegisterDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "PASSWORD_MIN_LENGTH", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "CONFIRM_PASSWORD_MIN_LENGTH", MinimumLength = 6)]
        public string ConfirmPassword { get; set; }
    }
}
