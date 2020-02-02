using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Dtos.Security
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string StorageType { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
