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
            CompilationManager compilationManager = new CompilationManager();
            
            Priority.En_Priority[] priorityTable = { Priority.En_Priority.CLASS, Priority.En_Priority.CONSTRUCTOR, Priority.En_Priority.METHOD, Priority.En_Priority.VARIABLE, Priority.En_Priority.OCCURENCE, Priority.En_Priority.TYPE_INFERENCE };
            compilationManager.parseCompilationWithProvidedPriorities(priorityTable);
        }
    }
}
