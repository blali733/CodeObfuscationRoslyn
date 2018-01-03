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
    class VariableRewriter: CSharpSyntaxRewriter
    {
        public VariableRewriter() { }

        public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            String name = node.Identifier.ValueText;
            String replaceName = "";

            if (SharedContainer.Instance.nameMap.ContainsKey(name))
            {
                replaceName = SharedContainer.Instance.nameMap[name];
            }
            else
            {
                replaceName = SharedContainer.Instance.RandomString(SharedContainer.Instance.nameMap.Count() + 1);
                SharedContainer.Instance.nameType[name] = Priority.En_Priority.VARIABLE;
                SharedContainer.Instance.nameMap[name] = replaceName;
            }

            VariableDeclaratorSyntax newSyntax = node.WithIdentifier(Identifier(replaceName)).WithLeadingTrivia(node.GetLeadingTrivia()).WithTrailingTrivia(node.GetTrailingTrivia());
            return node.ReplaceNode(node, newSyntax);
        }
    }
}
