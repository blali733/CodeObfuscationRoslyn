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
    class EnumRewriter : CSharpSyntaxRewriter
    {
        public EnumRewriter() { }

        public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
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
                SharedContainer.Instance.nameType[name] = Priority.En_Priority.CLASS;
                SharedContainer.Instance.nameMap[name] = replaceName;
            }

            EnumDeclarationSyntax newSyntax = node.WithIdentifier(Identifier(replaceName)).WithLeadingTrivia(node.GetLeadingTrivia()).WithTrailingTrivia(node.GetTrailingTrivia());
            return base.VisitEnumDeclaration(node.ReplaceNode(node, newSyntax));
        }

        public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
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
                SharedContainer.Instance.nameMap[name] = replaceName;
            }

            EnumMemberDeclarationSyntax newSyntax = node.WithIdentifier(Identifier(replaceName)).WithLeadingTrivia(node.GetLeadingTrivia()).WithTrailingTrivia(node.GetTrailingTrivia());
            return node.ReplaceNode(node, newSyntax);
        }
    }

}