using Core.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Entitys
{
    public abstract class BaseEntity : BaseAuditClass
    {
        protected virtual void SetDto(BaseDto dto)
        {
            Id = dto.Id;
            Created = dto.Created;
            CreatedBy = dto.CreatedBy;
            Modified = dto.Modified;
            ModifiedBy = dto.ModifiedBy;
        }
    }
}
