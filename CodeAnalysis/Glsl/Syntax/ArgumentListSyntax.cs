using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class ArgumentListSyntax : GlslSyntaxNode
    {
        public SyntaxToken OpenParenToken { get; private set; }
        public List<ArgumentSyntax> Arguments { get; private set; }
        public SyntaxToken CloseParenToken { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(OpenParenToken);
            sb.Append(string.Join(", ", Arguments.Select(e => e.ToString())));
            sb.Append(CloseParenToken);
            return sb.ToString();
        }

        public ArgumentListSyntax AddArguments(params ArgumentSyntax[] items)
        {
            Arguments.AddRange(items);
            return Update(OpenParenToken, Arguments, CloseParenToken);
        }

        public ArgumentListSyntax Update(SyntaxToken openParenToken, List<ArgumentSyntax> parameters, SyntaxToken closeParenToken)
        {
            return new ArgumentListSyntax()
            {
                OpenParenToken = openParenToken,
                Arguments = parameters,
                CloseParenToken = closeParenToken
            };
        }
        
        public ArgumentListSyntax WithCloseParenToken(SyntaxToken closeParenToken)
        {
            return Update(OpenParenToken, Arguments, closeParenToken);
        }

        public ArgumentListSyntax WithOpenParenToken(SyntaxToken openParenToken)
        {
            return Update(openParenToken, Arguments, CloseParenToken);
        }

        public ArgumentListSyntax WithParameters(List<ArgumentSyntax> parameters)
        {
            return Update(OpenParenToken, parameters, CloseParenToken);
        }
    }
}