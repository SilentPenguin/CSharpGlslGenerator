using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class ParameterSyntax : GlslSyntaxNode
    {
        public TypeSyntax Type { get; private set; }
        public SyntaxToken Identifier { get; private set; }

        public ParameterSyntax Update(TypeSyntax type, SyntaxToken identifier)
        {
            return new ParameterSyntax() {Type = type, Identifier = identifier};
        }
        
        public ParameterSyntax WithIdentifier(SyntaxToken identifier)
        {
            return Update(Type, identifier);
        }

        public ParameterSyntax WithType(TypeSyntax type)
        {
            return Update(type, Identifier);
        }
    } 
}