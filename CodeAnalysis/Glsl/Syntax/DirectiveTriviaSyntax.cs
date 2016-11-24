using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public abstract class DirectiveTriviaSyntax  //: StructuredTriviaSyntax
    {
        public abstract SyntaxToken DirectiveNameToken { get; }
        public abstract SyntaxToken HashToken { get; }
        public abstract bool IsActive { get; }
    }
} 