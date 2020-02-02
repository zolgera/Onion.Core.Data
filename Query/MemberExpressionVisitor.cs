using Core.Data.Dtos;
using System;
using System.Linq.Expressions;

namespace Core.Data.Query
{
    public class MemberExpressionVisitor<TPublicEntity> : ExpressionVisitor where TPublicEntity : BaseDto
    {
        public ParameterExpression Parameter { get; set; }

        public MemberExpressionVisitor(ParameterExpression parameter)
        {
            Parameter = parameter ?? throw new ArgumentNullException(nameof(parameter));
;
        }

        public Expression Replace(Expression expression)
        {
            return Visit(expression);
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Member.ReflectedType != typeof(TPublicEntity))
            {
                return base.VisitMember(node);
            }

            var result = Expression.Property
            (
              Parameter,
              node.Member.Name
            );
            return result;
        }
    }
}
