using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class InvocationExpressionSyntax : ExpressionSyntax
    {
        public ArgumentListSyntax ArgumentList { get; private set; }
        public ExpressionSyntax Expression { get; private set; }

        public override string ToString()
        {
            return Expression.ToString() + ArgumentList.ToString();
        }

        public InvocationExpressionSyntax Update(ExpressionSyntax expression, ArgumentListSyntax argumentList)
        {
            return new InvocationExpressionSyntax(){
                Expression = expression,
                ArgumentList = argumentList
            };
        }

        public InvocationExpressionSyntax WithArgumentList(ArgumentListSyntax argumentList)
        {
            return Update(Expression, argumentList);
        }

        public InvocationExpressionSyntax WithExpression(ExpressionSyntax expression)
        {
            return Update(expression, ArgumentList);
        }
    }
}