using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class BracketedArgumentListSyntax : GlslSyntaxNode
    {
        public SyntaxToken OpenBracketToken { get; private set; }
        public List<ArgumentSyntax> Arguments { get; private set; }
        public SyntaxToken CloseBracketToken { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(OpenBracketToken);
            sb.Append(string.Join(", ", Arguments.Select(e => e.ToString())));
            sb.Append(CloseBracketToken);
            return sb.ToString();
        }

        public BracketedArgumentListSyntax AddArguments(params ArgumentSyntax[] items)
        {
            Arguments.AddRange(items);
            return Update(OpenBracketToken, Arguments, CloseBracketToken);
        }

        public BracketedArgumentListSyntax Update(SyntaxToken openBracketToken, List<ArgumentSyntax> arguments, SyntaxToken closeBracketToken)
        {
            return new BracketedArgumentListSyntax()
            {
                OpenBracketToken = openBracketToken,
                Arguments = arguments,
                CloseBracketToken = closeBracketToken
            };
        }
        
        public BracketedArgumentListSyntax WithOpenBracketToken(SyntaxToken openBracketToken)
        {
            return Update(openBracketToken, Arguments, CloseBracketToken);
        }

        public BracketedArgumentListSyntax WithArguments(List<ArgumentSyntax> arguments)
        {
            return Update(OpenBracketToken, arguments, CloseBracketToken);
        }
        
        public BracketedArgumentListSyntax WithCloseBracketToken(SyntaxToken closeBracketToken)
        {
            return Update(OpenBracketToken, Arguments, closeBracketToken);
        }
        
    }
}