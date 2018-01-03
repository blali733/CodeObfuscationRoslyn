using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;

namespace CodeObfuscation
{
    class CompilationManager
    {
        public CompilationManager() { }
        public Compilation CreateCompilation()
        {

            String programPath = @"..\..\Program.cs";
            String destinationProgramPath = @"..\..\ProgramOBF.cs";
            String programText = File.ReadAllText(programPath);
            SyntaxTree programTree =
                           CSharpSyntaxTree.ParseText(programText)
                                           .WithFilePath(destinationProgramPath);

            String compilationManagerPath = @"..\..\CompilationManager.cs";
            String compilationManagerDestinationPath = @"..\..\CompilationManagerOBF.cs";
            String compilationManagerText = File.ReadAllText(compilationManagerPath);
            SyntaxTree compilationManagerTree =
                           CSharpSyntaxTree.ParseText(compilationManagerText)
                                           .WithFilePath(compilationManagerDestinationPath);

            String sharedContainterPath = @"..\..\SharedContainer.cs";
            String sharedContainterDestinationPath = @"..\..\SharedContainerOBF.cs";
            String sharedContainterText = File.ReadAllText(sharedContainterPath);
            SyntaxTree sharedContainterTree =
                           CSharpSyntaxTree.ParseText(sharedContainterText)
                                           .WithFilePath(sharedContainterDestinationPath);

            String occurrenceRewriterPath = @"..\..\OccurrenceRewriter.cs";
            String occurrenceRewriterDestinationPath = @"..\..\OccurrenceRewriterOBF.cs";
            String occurrenceRewriterText = File.ReadAllText(occurrenceRewriterPath);
            SyntaxTree occurrenceRewriterTree =
                           CSharpSyntaxTree.ParseText(occurrenceRewriterText)
                                           .WithFilePath(occurrenceRewriterDestinationPath);

            String methodRewriterPath = @"..\..\MethodRewriter.cs";
            String methodRewriterDestinationPath = @"..\..\MethodRewriterOBF.cs";
            String methodRewriterText = File.ReadAllText(methodRewriterPath);
            SyntaxTree methodRewriterTree =
                           CSharpSyntaxTree.ParseText(methodRewriterText)
                                           .WithFilePath(methodRewriterDestinationPath);

            String classRewriterPath = @"..\..\ClassRewriter.cs";
            String classRewriterDestinationPath = @"..\..\ClassRewriterOBF.cs";
            String classRewriterText = File.ReadAllText(classRewriterPath);
            SyntaxTree classRewriterTree =
                           CSharpSyntaxTree.ParseText(classRewriterText)
                                           .WithFilePath(classRewriterDestinationPath);

            String constructorRewriterPath = @"..\..\ConstructorRewriter.cs";
            String constructorRewriterDestinationPath = @"..\..\ConstructorRewriterOBF.cs";
            String constructorRewriterText = File.ReadAllText(constructorRewriterPath);
            SyntaxTree constructorRewriterTree =
                           CSharpSyntaxTree.ParseText(constructorRewriterText)
                                           .WithFilePath(constructorRewriterDestinationPath);

            String variableRewriterPath = @"..\..\VariableRewriter.cs";
            String variableRewriterDestinationPath = @"..\..\VariableRewriterOBF.cs";
            String variableRewriterText = File.ReadAllText(variableRewriterPath);
            SyntaxTree variableRewriterTree =
                           CSharpSyntaxTree.ParseText(variableRewriterText)
                                           .WithFilePath(variableRewriterDestinationPath);
            SyntaxTree[] sourceTrees = { programTree, compilationManagerTree, sharedContainterTree, occurrenceRewriterTree, methodRewriterTree, classRewriterTree, constructorRewriterTree, variableRewriterTree };

            MetadataReference mscorlib =
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
            MetadataReference codeAnalysis =
                    MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location);
            MetadataReference csharpCodeAnalysis =
                   MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location);
            MetadataReference[] references = { mscorlib, codeAnalysis, csharpCodeAnalysis };

            return CSharpCompilation.Create("CodeObfuscation",
                                            sourceTrees,
                                            references,
                                            new CSharpCompilationOptions(
                                                    OutputKind.ConsoleApplication));
        }
    }
}
