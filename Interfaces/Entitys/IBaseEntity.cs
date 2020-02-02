using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Interfaces.Entitys
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime Created { get; set; }
        DateTime? Modified { get; set; }
    }
}
