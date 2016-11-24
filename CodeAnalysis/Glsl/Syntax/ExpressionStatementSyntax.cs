using Microsoft.CodeAnalysis;
using System.Text;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class ExpressionStatementSyntax : StatementSyntax
    {
        public ExpressionSyntax Expression { get; private set; }
        public SyntaxToken SemicolonToken { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Expression);
            sb.Append(SemicolonToken);
            return sb.ToString();
        }

        public ExpressionStatementSyntax Update(ExpressionSyntax expression, SyntaxToken semicolonToken)
        {
            return new ExpressionStatementSyntax()
            {
                Expression = expression,
                SemicolonToken = semicolonToken
            };
        }
        
        public ExpressionStatementSyntax WithExpression(ExpressionSyntax expression)
        {
            return Update(expression, SemicolonToken);
        }

        public ExpressionStatementSyntax WithSemicolonToken(SyntaxToken semicolonToken)
        {
            return Update(Expression, semicolonToken);
        }
    }
}