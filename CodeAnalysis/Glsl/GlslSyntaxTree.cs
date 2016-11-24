using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using GlslGenerator.Translation;

namespace GlslGenerator.CodeAnalysis.Glsl
{
    public class GlslSyntaxTree
    {
        private GlslSyntaxNode root;

        internal GlslSyntaxTree(GlslSyntaxNode root)
        {
            this.root = root;
        }

        public GlslSyntaxNode GetRoot()
        {
            return root;
        }

        public static GlslSyntaxTree ParseCSText(string code)
        {
            var csTree = CSharpSyntaxTree.ParseText(code) as CSharpSyntaxTree;
            return csTree.Translate();
        }
    }
}