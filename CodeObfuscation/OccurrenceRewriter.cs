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
    class OccurrenceRewriter : CSharpSyntaxRewriter
    {
        public OccurrenceRewriter() { }
        public override SyntaxNode Visit(SyntaxNode node)
        {
            if (node != null)
            {
                if (node is FieldDeclarationSyntax)
                {
                    FieldDeclarationSyntax declarationSyntax = (FieldDeclarationSyntax)node;
                    if (declarationSyntax.Declaration.Type is IdentifierNameSyntax)
                    {
                        IdentifierNameSyntax id = (IdentifierNameSyntax)declarationSyntax.Declaration.Type;
                        String name = id.Identifier.ValueText;
                        if (!SharedContainer.Instance.nameType.ContainsKey(name))
                        {

                            return node;

                        }
                    }
                }

                if (node is ParameterSyntax)
                {
                    ParameterSyntax parameterSyntax = (ParameterSyntax)node;
                    if (parameterSyntax.Type is IdentifierNameSyntax)
                    {
                        IdentifierNameSyntax id = (IdentifierNameSyntax)parameterSyntax.Type;
                        String name = id.Identifier.ValueText;
                        if (!SharedContainer.Instance.nameType.ContainsKey(name))
                        {
                            return node;
                        }
                    }
                }

                if (node is IdentifierNameSyntax)
                {
                    IdentifierNameSyntax oldNode = (IdentifierNameSyntax)node;
                    string name = oldNode.Identifier.ValueText;
                    if (SharedContainer.Instance.nameMap.ContainsKey(name))
                    {
                        IdentifierNameSyntax newNode = oldNode.WithIdentifier(Identifier(SharedContainer.Instance.nameMap[name])).WithLeadingTrivia(oldNode.GetLeadingTrivia()).WithTrailingTrivia(oldNode.GetTrailingTrivia());
                        return node.ReplaceNode(oldNode, newNode);
                    }

                }

                if (node is ForEachStatementSyntax)
                {
                    ForEachStatementSyntax oldNode = (ForEachStatementSyntax)node;
                    string name = oldNode.Identifier.ValueText;
                    if (SharedContainer.Instance.nameMap.ContainsKey(name))
                    {
                        ForEachStatementSyntax newNode = oldNode.WithIdentifier(Identifier(SharedContainer.Instance.nameMap[name] + " "));
                        return Visit(node.ReplaceNode(oldNode, newNode));
                    }

                }
                return base.Visit(node);
            }
            return base.Visit(node);
        }
    }
}
