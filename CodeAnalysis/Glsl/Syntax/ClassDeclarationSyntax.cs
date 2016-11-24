using System.Text;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public class ClassDeclarationSyntax : GlslSyntaxNode
    {
        public SyntaxToken Identifier;
        public List<GlslSyntaxNode> Members;
        public SyntaxToken OpenBraceToken;
        public SyntaxToken CloseBraceToken;
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("#version 330");
            foreach(var member in Members)
                sb.Append(member);
            return sb.ToString();
        }
    }
} 