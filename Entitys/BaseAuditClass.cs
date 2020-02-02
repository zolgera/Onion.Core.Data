using Core.Data.Interfaces.Audit;
using Core.Data.Interfaces.Entitys;
using System;

namespace Core.Data.Entitys
{
    public abstract class BaseAuditClass : IBaseEntity, IAuditable
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public BaseAuditClass()
        {
        }
    }
}
