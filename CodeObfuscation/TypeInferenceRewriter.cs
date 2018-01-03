using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeObfuscation
{
    public class TypeInferenceRewriter : CSharpSyntaxRewriter
    {
        private string kTypeInference = "var";
        private string kExclusionModifier = "const";
        private readonly SemanticModel SemanticModel;

        public TypeInferenceRewriter(SemanticModel semanticModel)
        {
            this.SemanticModel = semanticModel;
        }

        public override SyntaxNode VisitLocalDeclarationStatement(
                                       LocalDeclarationStatementSyntax node)
        {
            if (node.Declaration.Variables.Count > 1)
            {
                return node;
            }
           if (node.Declaration.Variables[0].Initializer == null)
            {
                return node;
            }
            if (node.Modifiers.Count() > 0)
            {
                
                foreach(SyntaxToken token in node.Modifiers)
                {
                    if (token.ValueText.Equals(kExclusionModifier))
                    {
                        return node;
                    }
                }
            }

            VariableDeclaratorSyntax declarator = node.Declaration.Variables.First();
            TypeSyntax variableTypeName = node.Declaration.Type;

            ITypeSymbol variableType =
                           (ITypeSymbol)SemanticModel.GetSymbolInfo(variableTypeName)
                                                    .Symbol;

            TypeInfo initializerInfo =
                         SemanticModel.GetTypeInfo(declarator
                                                   .Initializer
                                                   .Value);

            if (variableType == initializerInfo.Type)
            {
                TypeSyntax varTypeName =
                               IdentifierName(kTypeInference)
                                     .WithLeadingTrivia(
                                          variableTypeName.GetLeadingTrivia())
                                     .WithTrailingTrivia(
                                          variableTypeName.GetTrailingTrivia());

                return node.ReplaceNode(variableTypeName, varTypeName);
            }
            else
            {
                return node;
            }
        }
    }
}
