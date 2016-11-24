using System.Text;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{  
    public sealed class BlockSyntax : StatementSyntax
    {
        public SyntaxToken OpenBraceToken { get; private set;}
        public List<StatementSyntax> Statements { get; private set; }
        public SyntaxToken CloseBraceToken { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(OpenBraceToken);
            sb.Append("\n");
            foreach(var statement in Statements)
            {
                sb.Append(statement);
                sb.Append("\n");
            }
            sb.Append(CloseBraceToken);
            return sb.ToString();
        }

        public BlockSyntax AddStatements(params StatementSyntax[] items)
        {
            Statements.AddRange(items);
            return Update(OpenBraceToken, Statements, CloseBraceToken);
        }

        public BlockSyntax Update(SyntaxToken openBraceToken, List<StatementSyntax> statements, SyntaxToken closeBraceToken)
        {
            return new BlockSyntax(){
                OpenBraceToken = openBraceToken,
                Statements = statements,
                CloseBraceToken = closeBraceToken,
            };
        }

        public BlockSyntax WithOpenBraceToken(SyntaxToken openBraceToken)
        {
            return Update(openBraceToken, Statements, CloseBraceToken);
        }

        public BlockSyntax WithStatements(List<StatementSyntax> statements)
        {
            return Update(OpenBraceToken, statements, CloseBraceToken);
        }
        
        public BlockSyntax WithCloseBraceToken(SyntaxToken closeBraceToken)
        {
            return Update(OpenBraceToken, Statements, closeBraceToken);
        }
    }
}