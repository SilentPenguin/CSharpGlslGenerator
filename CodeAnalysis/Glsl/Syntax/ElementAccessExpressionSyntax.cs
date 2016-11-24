using System.Text;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class ElementAccessExpressionSyntax : ExpressionSyntax
    {
        public BracketedArgumentListSyntax ArgumentList { get; private set; }
        public ExpressionSyntax Expression { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Expression);
            sb.Append(ArgumentList);
            return sb.ToString();
        }

        public ElementAccessExpressionSyntax AddArgumentListArguments(params ArgumentSyntax[] items)
        {
            return WithArgumentList(ArgumentList.AddArguments(items));
        }

        public ElementAccessExpressionSyntax Update(ExpressionSyntax expression, BracketedArgumentListSyntax argumentList)
        {
            return new ElementAccessExpressionSyntax()
            {
                Expression = expression,
                ArgumentList = argumentList
            };
        }
        
        public ElementAccessExpressionSyntax WithArgumentList(BracketedArgumentListSyntax argumentList)
        {
            return Update(Expression, argumentList);
        }
        
        public ElementAccessExpressionSyntax WithExpression(ExpressionSyntax expression)
        {
            return Update(expression, ArgumentList);
        }
    }
}