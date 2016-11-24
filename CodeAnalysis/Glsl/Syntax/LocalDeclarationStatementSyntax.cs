using System.Text;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{  
    public class LocalDeclarationStatementSyntax : StatementSyntax
    {
        public VariableDeclarationSyntax Declaration;
        public SyntaxToken SemicolonToken;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Declaration);
            sb.Append(SemicolonToken);
            return sb.ToString();
        }
    }
}