using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public class QualifierSyntax : GlslSyntaxNode
    {
        public NameSyntax Name;
        
        public override string ToString()
        {
            return Name.ToString().ToLower();
        }
    }
} 