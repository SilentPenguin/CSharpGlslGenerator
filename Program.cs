using System;
using System.IO;
using System.Linq;
using GlslGenerator.CodeAnalysis.Glsl;
using glsl = GlslGenerator.CodeAnalysis.Glsl.Syntax;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var file = "TestShaders";

            var codeFilePath = string.Format("Examples/{0}.cs", file);
            var vertFilePath = string.Format("Examples/{0}.vert.glsl", file);
            var fragFilePath = string.Format("Examples/{0}.frag.glsl", file);
            
            var code = File.ReadAllText(codeFilePath);
            var vertFile = File.Create(vertFilePath);
            var fragFile = File.Create(fragFilePath);

            var tree = GlslSyntaxTree.ParseCSText(code);
            var root = tree.GetRoot() as glsl.CompilationUnitSyntax;

            var vertShader = root.Members[0];
            var fragShader = root.Members[1];

            using(var stream = new StreamWriter(vertFile))
                stream.WriteLine(vertShader.ToString());
            using(var stream = new StreamWriter(fragFile))
                stream.WriteLine(fragShader.ToString());
        }
    }
}
