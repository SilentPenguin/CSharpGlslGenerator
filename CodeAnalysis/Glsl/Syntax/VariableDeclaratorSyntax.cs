using System.Text;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{  
    public class VariableDeclaratorSyntax : GlslSyntaxNode
    {
        public SyntaxToken Identifier {get; private set;}
        public EqualsValueClauseSyntax Initializer {get; private set;}

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Identifier);
            sb.Append(" ");
            sb.Append(Initializer);
            return sb.ToString();
        }

        public VariableDeclaratorSyntax Update(SyntaxToken identifier, EqualsValueClauseSyntax initializer)
        {
            return new VariableDeclaratorSyntax()
            {
                Identifier = identifier,
                Initializer = initializer
            };
        }

        public VariableDeclaratorSyntax WithIdentifier(SyntaxToken identifier)
        {
            return Update(identifier, Initializer);
        }
        
        public VariableDeclaratorSyntax WithInitializer(EqualsValueClauseSyntax initializer)
        {
            return Update(Identifier, initializer);
        }
    
    }
}