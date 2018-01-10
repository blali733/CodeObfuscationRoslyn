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
            TYPE_INFERENCE = 0, COMMENT, CLASS, ENUM, CONSTRUCTOR, METHOD, VARIABLE, PARAMETER, OCCURENCE, NOT_DEFINED
        }

        public static CSharpSyntaxRewriter GetInstancePriorityBased(En_Priority priority, SemanticModel model)
        {
            switch (priority)
            {
                case En_Priority.COMMENT:
                    return new CommentRemover();
                case En_Priority.TYPE_INFERENCE:
                    return new TypeInferenceRewriter(model);
                case En_Priority.CLASS:
                    return new ClassRewriter();
                case En_Priority.ENUM:
                    return new EnumRewriter();
                case En_Priority.CONSTRUCTOR:
                    return new ConstructorRewriter();
                case En_Priority.METHOD:
                    return new MethodRewriter();
                case En_Priority.VARIABLE:
                    return new VariableRewriter();
                case En_Priority.PARAMETER:
                    return new ParameterRewriter();
                case En_Priority.OCCURENCE:
                    return new OccurrenceRewriter();
                
            }

            return null;
        }
    }
}
