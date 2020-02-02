using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Interfaces.Audit
{
    public interface IAuditable
    {
        DateTime Created { get; set; }
        DateTime? Modified { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
    }
}
