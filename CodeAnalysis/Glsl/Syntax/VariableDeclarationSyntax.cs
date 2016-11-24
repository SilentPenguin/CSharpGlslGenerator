using System.Text;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{  
    public class VariableDeclarationSyntax : GlslSyntaxNode
    {
        public TypeSyntax Type;
        public List<VariableDeclaratorSyntax> Variables;

        public override string ToString()
        {
            var i = 0;
            var sb = new StringBuilder();
            sb.Append(Type);
            sb.Append(" ");
            foreach(var variable in Variables)
            {
                sb.Append(variable);
                if (i++ > 0)
                    sb.Append(", ");
            }
            return sb.ToString();
        }
    }
}