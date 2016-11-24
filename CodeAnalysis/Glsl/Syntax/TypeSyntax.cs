namespace GlslGenerator.CodeAnalysis.Glsl.Syntax
{
    public class TypeSyntax : GlslSyntaxNode {
        public string Name;
        public override string ToString()
        {
            return Name;
        }
    }
}