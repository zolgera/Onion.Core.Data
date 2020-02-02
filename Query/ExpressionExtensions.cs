using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Data.Query
{
    public static class ExpressionExtensions
    {
        public static Expression Unquote(this Expression quote)
        {
            return quote.NodeType == ExpressionType.Quote
            ? ((UnaryExpression)quote).Operand.Unquote()
            : quote;
        }
    }
}
