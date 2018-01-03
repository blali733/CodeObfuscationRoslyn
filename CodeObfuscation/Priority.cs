using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
namespace CodeObfuscation
{
    class Priority
    {
        public enum En_Priority: int
        {
            CLASS = 0, CONSTRUCTOR, METHOD, VARIABLE, OCCURENCE
        }

        public static CSharpSyntaxRewriter GetInstancePriorityBased(En_Priority priority)
        {
            switch (priority)
            {
                case En_Priority.CLASS:
                    return new ClassRewriter();
                case En_Priority.CONSTRUCTOR:
                    return new ConstructorRewriter();
                case En_Priority.METHOD:
                    return new MethodRewriter();
                case En_Priority.VARIABLE:
                    return new VariableRewriter();
                case En_Priority.OCCURENCE:
                    return new OccurrenceRewriter();
            }
            return null;
        }
    }
}
