using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class ParameterListSyntax : GlslSyntaxNode
    {
        public SyntaxToken OpenParenToken { get; private set; }
        public List<ParameterSyntax> Parameters { get; private set; }
        public SyntaxToken CloseParenToken { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(OpenParenToken);
            sb.Append(string.Join(", ", Parameters.Select(e => e.ToString())));
            sb.Append(CloseParenToken);
            return sb.ToString();
        }

        public ParameterListSyntax AddParameters(params ParameterSyntax[] items)
        {
            Parameters.AddRange(items);
            return Update(OpenParenToken, Parameters, CloseParenToken);
        }

        public ParameterListSyntax Update(SyntaxToken openParenToken, List<ParameterSyntax> parameters, SyntaxToken closeParenToken)
        {
            return new ParameterListSyntax()
            {
                OpenParenToken = openParenToken,
                Parameters = parameters,
                CloseParenToken = closeParenToken
            };
        }
        
        public ParameterListSyntax WithCloseParenToken(SyntaxToken closeParenToken)
        {
            return Update(OpenParenToken, Parameters, closeParenToken);
        }

        public ParameterListSyntax WithOpenParenToken(SyntaxToken openParenToken)
        {
            return Update(openParenToken, Parameters, CloseParenToken);
        }

        public ParameterListSyntax WithParameters(List<ParameterSyntax> parameters)
        {
            return Update(OpenParenToken, parameters, CloseParenToken);
        }
    }
}