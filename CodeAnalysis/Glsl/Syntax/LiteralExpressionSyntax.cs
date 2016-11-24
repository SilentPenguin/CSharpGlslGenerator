using System.Text;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class LiteralExpressionSyntax : ExpressionSyntax
    {
        public SyntaxToken Token { get; private set; }

        public override string ToString()
        {
            return Token.ToString();
        }

        public LiteralExpressionSyntax Update(SyntaxToken token)
        {
            return new LiteralExpressionSyntax()
            {
                Token = token
            };
        }
        public LiteralExpressionSyntax WithToken(SyntaxToken token)
        {
            return Update(token);
        }
    }
}