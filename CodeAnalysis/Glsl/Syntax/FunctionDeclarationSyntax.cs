using System.Text;
using Microsoft.CodeAnalysis;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public class FunctionDeclarationSyntax : GlslSyntaxNode
    {
        public TypeSyntax ReturnType { get; private set; }
        public SyntaxToken Identifier { get; private set; }
        public ParameterListSyntax ParameterList { get; private set; }
        public BlockSyntax Body { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(ReturnType.Name);
            sb.Append(" ");
            sb.Append(Identifier);
            sb.Append(ParameterList);
            sb.Append("\n");
            sb.Append(Body);
            return sb.ToString();
        }

        public FunctionDeclarationSyntax AddParameterListParameters(params ParameterSyntax[] items)
        {
            return Update(ReturnType, Identifier, ParameterList.AddParameters(items), Body);
        }
        
        public FunctionDeclarationSyntax Update(TypeSyntax returnType, SyntaxToken identifier, ParameterListSyntax parameterList, BlockSyntax body)
        {
            return new FunctionDeclarationSyntax() { ReturnType = returnType, Identifier = identifier, ParameterList = parameterList, Body = body};
        }

        public FunctionDeclarationSyntax AddBodyStatements(params StatementSyntax[] items)
        {
            return Update(ReturnType, Identifier, ParameterList, Body.AddStatements(items));
        }

        public FunctionDeclarationSyntax WithReturnType(TypeSyntax returnType)
        {
            return Update(returnType, Identifier, ParameterList, Body);
        }

        public FunctionDeclarationSyntax WithIdentifier(SyntaxToken identifier)
        {
            return Update(ReturnType, identifier, ParameterList, Body);
        }

        public FunctionDeclarationSyntax WithParameterList(ParameterListSyntax parameters)
        {
            return Update(ReturnType, Identifier, parameters, Body);
        }

        public FunctionDeclarationSyntax WithBody(BlockSyntax body)
        {
            return Update(ReturnType, Identifier, ParameterList, body);
        }
    }
}