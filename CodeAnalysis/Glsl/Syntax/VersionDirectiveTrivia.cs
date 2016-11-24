using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public class VersionDirectiveTrivia : DirectiveTriviaSyntax
    {
        public override SyntaxToken DirectiveNameToken { get{ return VersionKeyword; } }
        public override SyntaxToken HashToken { get; }
        public SyntaxToken VersionKeyword { get { return new SyntaxToken(); }}
        public override bool IsActive { get { return true; } }
    }
}