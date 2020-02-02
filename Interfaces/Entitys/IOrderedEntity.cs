using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Interfaces.Entitys
{
    public interface IOrderedEntity
    {
        int Order { get; set; }
    }
}
