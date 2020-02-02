using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Data.Entitys.Security
{
    public class Token : BaseDocument
    {
        [Required]
        public string ClientId { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public Guid UserId { get; set; }
    }
}
