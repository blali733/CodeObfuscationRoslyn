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
    class OccurrenceRewriter: CSharpSyntaxRewriter
    {
        public OccurrenceRewriter() { }
        public override SyntaxNode Visit(SyntaxNode node)
        {
            if (node != null)
            {
                var descendantTokens = node.DescendantTokens();
                if (node is FieldDeclarationSyntax)
                {
                    FieldDeclarationSyntax declarationSyntax = (FieldDeclarationSyntax)node;
                    if (declarationSyntax.Declaration.Type is IdentifierNameSyntax)
                    {
                        IdentifierNameSyntax id = (IdentifierNameSyntax)declarationSyntax.Declaration.Type;
                        String name = id.Identifier.ValueText;
                        if (SharedContainer.Instance.nameType.ContainsKey(name))
                        {
                            if (!SharedContainer.Instance.nameType[name].Equals(Priority.En_Priority.CLASS))
                            {
                                return node;
                            }
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
                        if (SharedContainer.Instance.nameType.ContainsKey(name))
                        {
                            if (!SharedContainer.Instance.nameType[name].Equals(Priority.En_Priority.CLASS))
                            {
                                return node;
                            }
                        }
                    }
                }

                if (descendantTokens.Count() > 0)
                {
                    foreach (SyntaxToken token in descendantTokens)
                    {
                        //Console.WriteLine(token.ValueText + " *** " + token.IsKeyword());
                        string name = token.ValueText;
                        if (SharedContainer.Instance.nameMap.ContainsKey(name))
                        {
                            if (node is IdentifierNameSyntax)
                            {
                                IdentifierNameSyntax oldNode = (IdentifierNameSyntax)node;
                                IdentifierNameSyntax newNode = oldNode.WithIdentifier(Identifier(SharedContainer.Instance.nameMap[name])).WithLeadingTrivia(oldNode.GetLeadingTrivia()).WithTrailingTrivia(oldNode.GetTrailingTrivia());
                                return node.ReplaceNode(oldNode, newNode);
                            }

                        }
                    }
                }

               /* if (isParameter)
                {
                    ParameterSyntax oldNode = (ParameterSyntax)node;
                    string name = oldNode.Identifier.ValueText;
                    if (SharedContainer.Instance.nameMap.ContainsKey(name))
                    {
                        ParameterSyntax newNode = oldNode.WithIdentifier(Identifier(SharedContainer.Instance.nameMap[name])).WithLeadingTrivia(oldNode.GetLeadingTrivia()).WithTrailingTrivia(oldNode.GetTrailingTrivia());
                        return node.ReplaceNode(oldNode, newNode);
                    }
                    else
                    {
                        SharedContainer.Instance.nameMap[name] = SharedContainer.Instance.RandomString(SharedContainer.Instance.nameMap.Count() + 1);
                        SharedContainer.Instance.nameType[name] = Priority.En_Priority.VARIABLE;
                        ParameterSyntax newNode = oldNode.WithIdentifier(Identifier(SharedContainer.Instance.nameMap[name])).WithLeadingTrivia(oldNode.GetLeadingTrivia()).WithTrailingTrivia(oldNode.GetTrailingTrivia());
                        return node.ReplaceNode(oldNode, newNode);
                    }
                    
                }*/

            }

            return base.Visit(node);
        }
    }
}
