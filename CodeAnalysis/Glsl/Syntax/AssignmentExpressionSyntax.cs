using System.Text;
using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public sealed class AssignmentExpressionSyntax : ExpressionSyntax
    {
        public ExpressionSyntax Left { get; private set; }
        public SyntaxToken OperatorToken { get; private set; }
        public ExpressionSyntax Right { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Left);
            sb.Append(" ");
            sb.Append(OperatorToken);
            sb.Append(" ");
            sb.Append(Right);
            return sb.ToString();
        }

        public AssignmentExpressionSyntax Update(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right)
        {
            return new AssignmentExpressionSyntax()
            {
                Left = left,
                OperatorToken = operatorToken,
                Right = right
            };
        }
        public AssignmentExpressionSyntax WithLeft(ExpressionSyntax left)
        {
            return Update(left, OperatorToken, Right);
        }
        public AssignmentExpressionSyntax WithOperatorToken(SyntaxToken operatorToken)
        {
            return Update(Left, operatorToken, Right);
        }
        public AssignmentExpressionSyntax WithRight(ExpressionSyntax right)
        {
            return Update(Left, OperatorToken, right);
        }
    } 
}