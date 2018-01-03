using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;

namespace CodeObfuscation
{
    class HKMDV    {
        static void Main(string[] args)
        {
            CompilationManager compilationManager = new CompilationManager();
            Compilation compilation = compilationManager.CreateCompilation();

            foreach (SyntaxTree sourceTree in compilation.SyntaxTrees)
            {
                /*SemanticModel model = test.GetSemanticModel(sourceTree);
                NameRewriter nameRewriter = new NameRewriter(model);
                SyntaxNode nameNode = nameRewriter.Visit(sourceTree.GetRoot());
                TypeInferenceRewriter typeInferenceRewriter = new TypeInferenceRewriter(model);
                SyntaxNode inferenceNode = typeInferenceRewriter.Visit(nameNode);
                if (inferenceNode != sourceTree.GetRoot())
                {
                    File.WriteAllText(sourceTree.FilePath, inferenceNode.ToFullString());
                }*/

                ClassRewriter classRewriter = new ClassRewriter();
                SyntaxNode classRewritedNode = classRewriter.Visit(sourceTree.GetRoot());
                OccurrenceRewriter occurrenceRewriter = new OccurrenceRewriter();
                SyntaxNode occurenceRewritedNode = occurrenceRewriter.Visit(classRewritedNode);
                if (occurenceRewritedNode != sourceTree.GetRoot())
                {
                    File.WriteAllText(sourceTree.FilePath, occurenceRewritedNode.ToFullString());
                }
            }
        }
    }
}
