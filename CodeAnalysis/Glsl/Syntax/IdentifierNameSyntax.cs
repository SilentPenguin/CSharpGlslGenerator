using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class IdentifierNameSyntax : ExpressionSyntax
    {
        public SyntaxToken Identifier { get; private set; }

        public override string ToString()
        {
            return Identifier.ToString();
        }

        public IdentifierNameSyntax Update(SyntaxToken identifier)
        {
            return new IdentifierNameSyntax()
            {
                Identifier = identifier
            };
        }

        public IdentifierNameSyntax WithIdentifier(SyntaxToken identifier)
        {
            return Update(identifier);
        }
    }
}