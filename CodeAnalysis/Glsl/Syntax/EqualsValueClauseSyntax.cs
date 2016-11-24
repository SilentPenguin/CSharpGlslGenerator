using System.Text;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{  
    public sealed class EqualsValueClauseSyntax : GlslSyntaxNode
    {
        public SyntaxToken EqualsToken { get; private set; }
        public ExpressionSyntax Value { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(EqualsToken);
            sb.Append(" ");
            sb.Append(Value);
            return sb.ToString();
        }

        public EqualsValueClauseSyntax Update(SyntaxToken equalsToken, ExpressionSyntax value)
        {
            return new EqualsValueClauseSyntax()
            {
                EqualsToken = equalsToken,
                Value = value
            };
        }

        public EqualsValueClauseSyntax WithEqualsToken(SyntaxToken equalsToken)
        {
            return Update(equalsToken, Value);
        }

        public EqualsValueClauseSyntax WithValue(ExpressionSyntax value)
        {
            return Update(EqualsToken, value);
        }
    }
}