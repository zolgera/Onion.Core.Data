using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Interfaces.Entitys
{
    public interface IBaseDocument : IBaseEntity
    {
        string Code { get; set; }
        string Name { get; set; }
    }
}
