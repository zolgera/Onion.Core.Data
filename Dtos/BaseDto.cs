using Core.Data.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Dtos
{
    public abstract class BaseDto : BaseAuditClass
    {
        protected void SetBaseDto(BaseEntity entity)
        {
            Created = entity.Created;
            CreatedBy = entity.CreatedBy;
            Id = entity.Id;
            Modified = entity.Modified;
            ModifiedBy = entity.ModifiedBy;
        }
    }
}
