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
    class Program
    {
        static void Main(string[] args)
        {
            string path = null;
            string mode = null;
            bool randomNames = false;
            string outputPath = null;
            int iMode = 1;

            Console.WriteLine("Please provide project path:");
            do
            {
                path = Console.ReadLine();
            } while (path == null);

            Console.WriteLine("Please provide obfuscation mode path:");
            Console.WriteLine("1) In-place rewrite (default)");
            Console.WriteLine("2) Random names of output files");
            Console.WriteLine("3) Different output directory");
            mode = Console.ReadLine();

            switch (mode)
            {
                case "2":
                    iMode = 2;
                    randomNames = true;
                    Console.WriteLine("Please provide output direcory path:");
                    do
                    {
                        outputPath = Console.ReadLine();
                    } while (outputPath == null);
                break;
                case "3":
                    iMode = 3;
                    Console.WriteLine("Please provide output direcory path:");
                    do
                    {
                        outputPath = Console.ReadLine();
                    } while (outputPath == null);
                break;
                default:
                    outputPath = path;
                break;
            }

            SharedContainer instance = SharedContainer.Instance;
            instance.path = path;
            instance.outputPath = outputPath;
            instance.generalizeNames = randomNames;
            instance.mode = iMode;

            CompilationManager compilationManager = new CompilationManager();
            
            Priority.En_Priority[] priorityTable = { Priority.En_Priority.CLASS, Priority.En_Priority.CONSTRUCTOR, Priority.En_Priority.METHOD, Priority.En_Priority.VARIABLE, Priority.En_Priority.OCCURENCE, Priority.En_Priority.TYPE_INFERENCE, Priority.En_Priority.ENUM/*Priority.En_Priority.PARAMETER*/ };
            compilationManager.parseCompilationWithProvidedPriorities(priorityTable);
        }
    }
}
