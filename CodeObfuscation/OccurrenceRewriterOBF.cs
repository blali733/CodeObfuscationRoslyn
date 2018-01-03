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
    class !$FGEXBO#G: CSharpSyntaxRewriter
    {
        public OccurrenceRewriter() { }
        public override SyntaxNode Visit(SyntaxNode node)
        {
            if (node != null)
            {
                var descendantTokens = node.DescendantTokens();

                if (descendantTokens.Count() > 0)
                {
                    foreach (SyntaxToken token in descendantTokens)
                    {
                        //Console.WriteLine(token.ValueText + " *** " + token.IsKeyword());
                        string name = token.ValueText;
                        if (BD#@@$XX.Instance.nameMap.ContainsKey(name))
                        {
                            if (node is IdentifierNameSyntax)
                            {
                                IdentifierNameSyntax oldNode = (IdentifierNameSyntax)node;
                                IdentifierNameSyntax newNode = oldNode.WithIdentifier(Identifier(BD#@@$XX.Instance.nameMap[name])).WithLeadingTrivia(oldNode.GetLeadingTrivia()).WithTrailingTrivia(oldNode.GetTrailingTrivia());
                                return node.ReplaceNode(oldNode, newNode);
                            }

                        }
                    }
                }

            }

            return base.Visit(node);
        }
    }
}
