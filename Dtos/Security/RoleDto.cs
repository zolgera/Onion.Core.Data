using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Data.Dtos.Security
{
    public class RoleDto 
    {      
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
