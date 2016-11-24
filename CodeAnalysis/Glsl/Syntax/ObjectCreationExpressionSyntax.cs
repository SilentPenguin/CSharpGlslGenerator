using System.Text;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{  
    public sealed class ObjectCreationExpressionSyntax : ExpressionSyntax
    {
        public TypeSyntax Type { get; private set; }
        public ArgumentListSyntax ArgumentList { get; private set; }
        //public InitializerExpressionSyntax Initializer { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Type);
            sb.Append(ArgumentList);
            return sb.ToString();
        }

        public ObjectCreationExpressionSyntax Update(TypeSyntax type, ArgumentListSyntax argumentList)
        {
            return new ObjectCreationExpressionSyntax()
            {
                Type = type,
                ArgumentList = argumentList
            };
        }
        public ObjectCreationExpressionSyntax WithArgumentList(ArgumentListSyntax argumentList)
        {
            return Update(Type, argumentList);
        }
        //public ObjectCreationExpressionSyntax WithInitializer(InitializerExpressionSyntax initializer);
        public ObjectCreationExpressionSyntax WithType(TypeSyntax type)
        {
            return Update(type, ArgumentList);
        }
    }
}