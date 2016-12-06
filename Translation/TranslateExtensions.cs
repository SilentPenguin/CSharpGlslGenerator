using System.Collections.Generic;
using System.IO;
using System.Linq;
using GlslGenerator.CodeAnalysis.Glsl;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using glsl = GlslGenerator.CodeAnalysis.Glsl.Syntax;
using cs = Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GlslGenerator.Translation
{
    public static partial class Translator
    {

        public static Microsoft.CodeAnalysis.SemanticModel model;

        public static GlslSyntaxTree Translate(this CSharpSyntaxTree tree)
        {
            var supportCode = File.ReadAllText("Shader.cs");
            supportCode += File.ReadAllText("Shader.Vectors.cs");
            supportCode += File.ReadAllText("Shader.Matrices.cs");
            var supportTree = CSharpSyntaxTree.ParseText(supportCode);
            var compilation = CSharpCompilation.Create("Shader").AddSyntaxTrees(tree, supportTree);
            model = compilation.GetSemanticModel(tree);
            return new GlslSyntaxTree(tree.GetRoot().Translate());
        }

        public static GlslSyntaxNode Translate(this CSharpSyntaxNode node)
        {
            if (node == null) return null;
            switch(node.Kind())
            {
                case SyntaxKind.CompilationUnit:
                    return Translate(node as cs.CompilationUnitSyntax);
                case SyntaxKind.ClassDeclaration:
                    return Translate(node as cs.ClassDeclarationSyntax);
                case SyntaxKind.MethodDeclaration:
                    return Translate(node as cs.MethodDeclarationSyntax);
                case SyntaxKind.FieldDeclaration:
                    return Translate(node as cs.FieldDeclarationSyntax);
                case SyntaxKind.LocalDeclarationStatement:
                    return Translate(node as cs.LocalDeclarationStatementSyntax);
                case SyntaxKind.ExpressionStatement:
                    return Translate(node as cs.ExpressionStatementSyntax);
                case SyntaxKind.ObjectCreationExpression:
                    return Translate(node as cs.ObjectCreationExpressionSyntax);
                case SyntaxKind.NumericLiteralExpression:
                    return Translate(node as cs.LiteralExpressionSyntax);
                case SyntaxKind.SimpleAssignmentExpression:
                    return Translate(node as cs.AssignmentExpressionSyntax);
                case SyntaxKind.ElementAccessExpression:
                    return Translate(node as cs.ElementAccessExpressionSyntax);
                case SyntaxKind.IdentifierName:
                    return Translate(node as cs.IdentifierNameSyntax);
                case SyntaxKind.MultiplyExpression:
                    return Translate(node as cs.BinaryExpressionSyntax);
                case SyntaxKind.InvocationExpression:
                    return Translate(node as cs.InvocationExpressionSyntax);
                default:
                    return null;
            }
        }

        public static glsl.CompilationUnitSyntax Translate(this cs.CompilationUnitSyntax node)
        {
            return new glsl.CompilationUnitSyntax()
            {
                Members = node.Members.Select(m => Translate(m)).Where(m => m != null).ToList()
            };
        }

        public static glsl.ClassDeclarationSyntax Translate(this cs.ClassDeclarationSyntax node)
        {
            return new glsl.ClassDeclarationSyntax()
            {
                Identifier = node.Identifier,
                Members = node.Members.Select(m => Translate(m)).Where(m => m != null).ToList(),
                OpenBraceToken = node.OpenBraceToken,
                CloseBraceToken = node.CloseBraceToken,
            };
        }

        public static glsl.FunctionDeclarationSyntax Translate(this cs.MethodDeclarationSyntax node)
        {
            var functionDeclaration = new glsl.FunctionDeclarationSyntax();
            return functionDeclaration.Update(
                Translate(node.ReturnType),
                node.Identifier,
                Translate(node.ParameterList),
                Translate(node.Body)
            );
        }

        public static glsl.FieldDeclarationSyntax Translate(this cs.FieldDeclarationSyntax node)
        {
            return new glsl.FieldDeclarationSyntax()
            {
                Qualifier = node.DescendantNodes().OfType<cs.AttributeSyntax>().Single().Translate(),
                Type = node.DescendantNodes().OfType<cs.VariableDeclarationSyntax>().Single().Type.Translate(),
                Identifier = node.DescendantNodes().OfType<cs.VariableDeclarationSyntax>().Single().Variables.Single().Identifier,
                SemicolonToken = node.SemicolonToken
            };
        }

        public static glsl.LocalDeclarationStatementSyntax Translate(this cs.LocalDeclarationStatementSyntax node)
        {
            return new glsl.LocalDeclarationStatementSyntax()
            {   
                Declaration = node.Declaration.Translate(),
                SemicolonToken = node.SemicolonToken,
            };
        }

        public static glsl.VariableDeclarationSyntax Translate(this cs.VariableDeclarationSyntax node)
        {
            return new glsl.VariableDeclarationSyntax()
            {
                Type = new glsl.TypeSyntax() { Name = model.GetSymbolInfo(node.Type).Symbol.Name },         
                Variables = node.Variables.Select(v => v.Translate()).ToList()
            };
        }

        public static glsl.VariableDeclaratorSyntax Translate(this cs.VariableDeclaratorSyntax node)
        {
            return new glsl.VariableDeclaratorSyntax().Update(
                node.Identifier,
                node.Initializer.Translate()
            );
        }

        public static glsl.EqualsValueClauseSyntax Translate(this cs.EqualsValueClauseSyntax node)
        {
            return new glsl.EqualsValueClauseSyntax().Update(
                node.EqualsToken,
                node.Value.Translate()
            );
        }

        public static glsl.ObjectCreationExpressionSyntax Translate(this cs.ObjectCreationExpressionSyntax node)
        {
            return new glsl.ObjectCreationExpressionSyntax().Update(
                node.Type.Translate(),
                node.ArgumentList.Translate()
            );
        }

        public static glsl.ArgumentListSyntax Translate(this cs.ArgumentListSyntax node)
        {
            return new glsl.ArgumentListSyntax().Update(
                node.OpenParenToken,
                node.Arguments.Translate(),
                node.CloseParenToken
            );
        }
        
        public static List<glsl.ArgumentSyntax> Translate(this SeparatedSyntaxList<cs.ArgumentSyntax> node)
        {
            return node.Select(a => a.Translate()).ToList();
        }

        public static glsl.ArgumentSyntax Translate(this cs.ArgumentSyntax node)
        {
            return new glsl.ArgumentSyntax().Update(
                node.Expression.Translate()
            );
        }

        public static glsl.LiteralExpressionSyntax Translate(this cs.LiteralExpressionSyntax node)
        {
            return new glsl.LiteralExpressionSyntax().Update(node.Token);
        }

        public static glsl.TypeSyntax Translate(this cs.TypeSyntax node)
        {
            return new glsl.TypeSyntax() { Name = node.ToString() };
        }

        public static glsl.ParameterListSyntax Translate(this cs.ParameterListSyntax node)
        {
            var parameters = new glsl.ParameterListSyntax();
            var parameterNodes = node.Parameters.Translate();
            return parameters.Update(node.OpenParenToken, parameterNodes, node.CloseParenToken);
        }

        public static glsl.BlockSyntax Translate(this cs.BlockSyntax node)
        {
            var body = new glsl.BlockSyntax();
            return body.Update(node.OpenBraceToken, node.Statements.Translate(), node.CloseBraceToken);
        }

        public static glsl.ExpressionStatementSyntax Translate(this cs.ExpressionStatementSyntax node)
        {
            var expression = new glsl.ExpressionStatementSyntax();
            return expression.Update(node.Expression.Translate(), node.SemicolonToken);
        }

        public static glsl.ExpressionSyntax Translate(this cs.ExpressionSyntax node)
        {
            return Translate(node as CSharpSyntaxNode) as glsl.ExpressionSyntax;
        }
        
        public static List<glsl.ParameterSyntax> Translate(this SeparatedSyntaxList<cs.ParameterSyntax> node)
        {
            return new List<glsl.ParameterSyntax>();
        }
        
        public static List<glsl.StatementSyntax> Translate(this SyntaxList<cs.StatementSyntax> node)
        {
            return node.Select(n => Translate(n)).Cast<glsl.StatementSyntax>().ToList();
        }

        public static glsl.QualifierSyntax Translate(this cs.AttributeSyntax node)
        {
            return new glsl.QualifierSyntax() { Name = node.Name };
        }

        public static glsl.AssignmentExpressionSyntax Translate(this cs.AssignmentExpressionSyntax node)
        {
            return new glsl.AssignmentExpressionSyntax().Update
            (
                node.Left.Translate(),
                node.OperatorToken,
                node.Right.Translate()
            );
        }

        public static glsl.ElementAccessExpressionSyntax Translate(this cs.ElementAccessExpressionSyntax node)
        {
            return new glsl.ElementAccessExpressionSyntax().Update(
                node.Expression.Translate(),
                node.ArgumentList.Translate()
            );
        }

        public static glsl.BracketedArgumentListSyntax Translate(this cs.BracketedArgumentListSyntax node)
        {
            return new glsl.BracketedArgumentListSyntax().Update(
                node.OpenBracketToken,
                node.Arguments.Translate(),
                node.CloseBracketToken
            );
        }

        public static glsl.IdentifierNameSyntax Translate(this cs.IdentifierNameSyntax node)
        {
            return new glsl.IdentifierNameSyntax().Update(
                node.Identifier
            );
        }

        public static glsl.BinaryExpressionSyntax Translate(this cs.BinaryExpressionSyntax node)
        {
            return new glsl.BinaryExpressionSyntax().Update(
                node.Left.Translate(),
                node.OperatorToken,
                node.Right.Translate()
            );
        }

        public static glsl.InvocationExpressionSyntax Translate(this cs.InvocationExpressionSyntax node)
        {
            return new glsl.InvocationExpressionSyntax().Update(
                node.Expression.Translate(),
                node.ArgumentList.Translate()
            );
        }
    }
}
