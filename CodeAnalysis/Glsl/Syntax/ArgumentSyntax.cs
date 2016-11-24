using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class ArgumentSyntax : GlslSyntaxNode
    {
        public ExpressionSyntax Expression { get; private set; }

        public override string ToString()
        {
            return Expression.ToString();
        }

        public ArgumentSyntax Update(ExpressionSyntax expression)
        {
            return new ArgumentSyntax() { Expression = expression };
        }
        
        public ArgumentSyntax WithExpression(ExpressionSyntax expression)
        {
            return Update(expression);
        }
    } 
}