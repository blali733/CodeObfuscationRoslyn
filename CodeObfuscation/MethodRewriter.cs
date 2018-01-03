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
    class MethodRewriter: CSharpSyntaxRewriter
    {
        private string kModifierExclusion = "override";
        private string kDescriptionExclusion = "Main";

        public MethodRewriter() { }

        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            String name = node.Identifier.ValueText;
            Boolean exceptionFlag = false;
            foreach (SyntaxToken modifier in node.Modifiers)
            {
                if (modifier.ValueText.Equals(kModifierExclusion))
                {
                    exceptionFlag = true;
                    break;
                }
            }

            if (name.Equals(kDescriptionExclusion) || exceptionFlag)
            {
                return base.VisitMethodDeclaration(node);
            }
            else
            {
                String replaceName = "";
                if (SharedContainer.Instance.nameMap.ContainsKey(name))
                {
                    replaceName = SharedContainer.Instance.nameMap[name];
                }
                else
                {
                    replaceName = SharedContainer.Instance.RandomString(SharedContainer.Instance.nameMap.Count() + 1);
                    SharedContainer.Instance.nameMap[name] = replaceName;
                }
                MethodDeclarationSyntax newNode = node.WithIdentifier(Identifier(replaceName)).WithLeadingTrivia(node.GetLeadingTrivia()).WithTrailingTrivia(node.GetTrailingTrivia());
                return node.ReplaceNode(node, newNode);
            }

        }
    }
}
