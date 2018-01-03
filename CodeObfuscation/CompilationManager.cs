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

            SyntaxTree[] sourceTrees = { programTree, compilationManagerTree, sharedContainterTree };

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
