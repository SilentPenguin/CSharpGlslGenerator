using System.Text;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public class CompilationUnitSyntax : GlslSyntaxNode
    {
        public List<GlslSyntaxNode> Members;

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var member in Members)
                sb.Append(member.ToString());
            return sb.ToString();
        }
    }
} 