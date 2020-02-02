using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Query
{
    public class PageInfo
    {
        public PageInfo(long total, int? skip, int? size)
        {
            TotalCount = total;
            if(skip != null && size != null)
            {
                Page = (int)Math.Ceiling(Decimal.Divide(skip.Value + size.Value, size.Value));
                Size = size.Value;
                PageCount = (int)Math.Ceiling(Decimal.Divide(total, size.Value));
            }
            else if(size != null)
            {
                Page = (int)Math.Ceiling(Decimal.Divide((skip??0) + size.Value, size.Value));
                Size = size.Value;
                PageCount = (int)Math.Ceiling(Decimal.Divide(total, size.Value));
            }
        }
        public long TotalCount { get; private set; }
        public int PageCount { get; private set; }
        public int Page { get; private set; }
        public int Size { get; private set; }
        public int Skip { get; private set; }
    }
}
