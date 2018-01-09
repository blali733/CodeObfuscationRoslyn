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

        public void parseCompilationWithProvidedPriorities(Priority.En_Priority[] prioritiesTablo) 
        {
            Tuple<Compilation, int> compilationTuple;
            Array.Sort(prioritiesTablo);

            foreach (Priority.En_Priority priority in prioritiesTablo)
            {
                compilationTuple = CreateCompilation();
                SyntaxNode finalNode = null;

                foreach (SyntaxTree sourceTree in compilationTuple.Item1.SyntaxTrees)
                {
                    CSharpSyntaxRewriter rewriter = Priority.GetInstancePriorityBased(priority, compilationTuple.Item1.GetSemanticModel(sourceTree));
                    if (rewriter != null)
                    {
                        finalNode = rewriter.Visit(sourceTree.GetRoot());
                        if (finalNode != null)
                        {
                            File.WriteAllText(sourceTree.FilePath, finalNode.ToFullString());
                        }
                    }
                    else
                    {

                        continue;

                    }
                }
            }
        }
        private Tuple<Compilation, int> CreateCompilation()
        {

            String programPath = @"..\..\Program.cs";
            String destinationProgramPath = @"..\..\Program.cs";
            String programText = File.ReadAllText(programPath);
            SyntaxTree programTree =
                           CSharpSyntaxTree.ParseText(programText)
                                           .WithFilePath(destinationProgramPath);

            String compilationManagerPath = @"..\..\CompilationManager.cs";
            String compilationManagerDestinationPath = @"..\..\CompilationManager.cs";
            String compilationManagerText = File.ReadAllText(compilationManagerPath);
            SyntaxTree compilationManagerTree =
                           CSharpSyntaxTree.ParseText(compilationManagerText)
                                           .WithFilePath(compilationManagerDestinationPath);

            String sharedContainterPath = @"..\..\SharedContainer.cs";
            String sharedContainterDestinationPath = @"..\..\SharedContainer.cs";
            String sharedContainterText = File.ReadAllText(sharedContainterPath);
            SyntaxTree sharedContainterTree =
                           CSharpSyntaxTree.ParseText(sharedContainterText)
                                           .WithFilePath(sharedContainterDestinationPath);

            String occurrenceRewriterPath = @"..\..\OccurrenceRewriter.cs";
            String occurrenceRewriterDestinationPath = @"..\..\OccurrenceRewriter.cs";
            String occurrenceRewriterText = File.ReadAllText(occurrenceRewriterPath);
            SyntaxTree occurrenceRewriterTree =
                           CSharpSyntaxTree.ParseText(occurrenceRewriterText)
                                           .WithFilePath(occurrenceRewriterDestinationPath);

            String methodRewriterPath = @"..\..\MethodRewriter.cs";
            String methodRewriterDestinationPath = @"..\..\MethodRewriter.cs";
            String methodRewriterText = File.ReadAllText(methodRewriterPath);
            SyntaxTree methodRewriterTree =
                           CSharpSyntaxTree.ParseText(methodRewriterText)
                                           .WithFilePath(methodRewriterDestinationPath);

            String classRewriterPath = @"..\..\ClassRewriter.cs";
            String classRewriterDestinationPath = @"..\..\ClassRewriter.cs";
            String classRewriterText = File.ReadAllText(classRewriterPath);
            SyntaxTree classRewriterTree =
                           CSharpSyntaxTree.ParseText(classRewriterText)
                                           .WithFilePath(classRewriterDestinationPath);

            String constructorRewriterPath = @"..\..\ConstructorRewriter.cs";
            String constructorRewriterDestinationPath = @"..\..\ConstructorRewriter.cs";
            String constructorRewriterText = File.ReadAllText(constructorRewriterPath);
            SyntaxTree constructorRewriterTree =
                           CSharpSyntaxTree.ParseText(constructorRewriterText)
                                           .WithFilePath(constructorRewriterDestinationPath);

            String variableRewriterPath = @"..\..\VariableRewriter.cs";
            String variableRewriterDestinationPath = @"..\..\VariableRewriter.cs";
            String variableRewriterText = File.ReadAllText(variableRewriterPath);
            SyntaxTree variableRewriterTree =
                           CSharpSyntaxTree.ParseText(variableRewriterText)
                                           .WithFilePath(variableRewriterDestinationPath);

            String typeInferenceRewriterPath = @"..\..\TypeInferenceRewriter.cs";
            String typeInferenceRewriterDestinationPath = @"..\..\TypeInferenceRewriter.cs";
            String typeInferenceRewriterText = File.ReadAllText(typeInferenceRewriterPath);
            SyntaxTree typeInferenceRewriterTree =
                           CSharpSyntaxTree.ParseText(typeInferenceRewriterText)
                                           .WithFilePath(typeInferenceRewriterDestinationPath);

            String priorityPath = @"..\..\Priority.cs";
            String priorityDestinationPath = @"..\..\Priority.cs";
            String priorityText = File.ReadAllText(priorityPath);
            SyntaxTree priorityTree =
                           CSharpSyntaxTree.ParseText(priorityText)
                                           .WithFilePath(priorityDestinationPath);

            String parameterRewriterPath = @"..\..\ParameterRewriter.cs";
            String parameterRewriterDestinationPath = @"..\..\ParameterRewriter.cs";
            String parameterRewriterText = File.ReadAllText(parameterRewriterPath);
            SyntaxTree parameterRewriterTree =
                           CSharpSyntaxTree.ParseText(parameterRewriterText)
                                           .WithFilePath(parameterRewriterDestinationPath);

            String enumRewriterPath = @"..\..\EnumRewriter.cs";
            String enumRewriterDestinationPath = @"..\..\EnumRewriter.cs";
            String enumRewriterText = File.ReadAllText(enumRewriterPath);
            SyntaxTree enumRewriterTree =
                           CSharpSyntaxTree.ParseText(enumRewriterText)
                                           .WithFilePath(enumRewriterDestinationPath);

            String abstractTestPath = @"..\..\AbstractTest.cs";
            String abstractTestDestinationPath = @"..\..\AbstractTest.cs";
            String abstractTestText = File.ReadAllText(abstractTestPath);
            SyntaxTree abstractTestTree =
                           CSharpSyntaxTree.ParseText(abstractTestText)
                                           .WithFilePath(abstractTestDestinationPath);

            SyntaxTree[] sourceTrees = {abstractTestTree, programTree, compilationManagerTree, sharedContainterTree, occurrenceRewriterTree, methodRewriterTree, classRewriterTree, constructorRewriterTree, variableRewriterTree, typeInferenceRewriterTree, priorityTree, parameterRewriterTree, enumRewriterTree};

            MetadataReference mscorlib =
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
            MetadataReference codeAnalysis =
                    MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location);
            MetadataReference csharpCodeAnalysis =
                   MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location);
            MetadataReference[] references = { mscorlib, codeAnalysis, csharpCodeAnalysis };

            return Tuple.Create(CSharpCompilation.Create("CodeObfuscation",
                                            sourceTrees,
                                            references,
                                            new CSharpCompilationOptions(
                                                    OutputKind.ConsoleApplication)) as Compilation, sourceTrees.Count());
        }
    }
}
