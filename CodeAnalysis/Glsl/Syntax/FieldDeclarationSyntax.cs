using System.Text;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public class FieldDeclarationSyntax : GlslSyntaxNode
    {
        public QualifierSyntax Qualifier;
        public TypeSyntax Type; 
        public SyntaxToken Identifier;
        public SyntaxToken SemicolonToken;
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Qualifier);
            sb.Append(" ");
            sb.Append(Type);
            sb.Append(" ");
            sb.Append(Identifier);
            sb.Append(SemicolonToken);
            sb.Append("\n");
            return sb.ToString();
        }
    }
} 