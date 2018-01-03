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
    class VPXFFVMDHTXSTDEIHUXSLPQIRNSWSUTCNOHVPAQQHEOQCQBXCILMBJBFXPLPCNIK: CSharpSyntaxRewriter
    {
        public VPXFFVMDHTXSTDEIHUXSLPQIRNSWSUTCNOHVPAQQHEOQCQBXCILMBJBFXPLPCNIK() { }
        public override SyntaxNode Visit(SyntaxNode node)
        {
            if (node != null)
            {
                var XVEFTHRGEGLHBXFBLSUKJHAEMCVXMANRTEQELUESPEISVSEXJKDIRWBQUAQRKRSDR= node.DescendantTokens();

                if (XVEFTHRGEGLHBXFBLSUKJHAEMCVXMANRTEQELUESPEISVSEXJKDIRWBQUAQRKRSDR.Count() > 0)
                {
                    foreach (SyntaxToken token in XVEFTHRGEGLHBXFBLSUKJHAEMCVXMANRTEQELUESPEISVSEXJKDIRWBQUAQRKRSDR)
                    {
                        //Console.WriteLine(token.ValueText + " *** " + token.IsKeyword());
                        string RMVGBNPOCSEWFGSVVOCUFAUCAHLELIWKEBEGGQIVMSODURPRWTMCPHMQPSGRBLCSUR= token.ValueText;
                        if (APJLCOPVFGCPFMAAAGSKCPSOPXGFLIKUHECVBSCGGNFANVGOEMQWOUKJV.Instance.XRNRHKXMMBUFMHXQXJPQPHWNNRAJROEVIDRVAJVGSNJLNARWIVOUCJPPTXENJ.ContainsKey(RMVGBNPOCSEWFGSVVOCUFAUCAHLELIWKEBEGGQIVMSODURPRWTMCPHMQPSGRBLCSUR))
                        {
                            if (node is IdentifierNameSyntax)
                            {
                                IdentifierNameSyntax SDBLOFFFHKKQFHQSGQTTTVNMOMKPTBPUGDWLPKEHVKXBGXMXAGEKWBWVONUCSOJGTNJ= (IdentifierNameSyntax)node;
                                IdentifierNameSyntax CIFDTMMVIVMFPXLOMUEVFFBVBNBMGBQFQNKOTDJWKDNXBIFCHXUKPQEUGHBGKXPGEHNC= SDBLOFFFHKKQFHQSGQTTTVNMOMKPTBPUGDWLPKEHVKXBGXMXAGEKWBWVONUCSOJGTNJ.WithIdentifier(Identifier(APJLCOPVFGCPFMAAAGSKCPSOPXGFLIKUHECVBSCGGNFANVGOEMQWOUKJV.Instance.XRNRHKXMMBUFMHXQXJPQPHWNNRAJROEVIDRVAJVGSNJLNARWIVOUCJPPTXENJ[RMVGBNPOCSEWFGSVVOCUFAUCAHLELIWKEBEGGQIVMSODURPRWTMCPHMQPSGRBLCSUR])).WithLeadingTrivia(SDBLOFFFHKKQFHQSGQTTTVNMOMKPTBPUGDWLPKEHVKXBGXMXAGEKWBWVONUCSOJGTNJ.GetLeadingTrivia()).WithTrailingTrivia(SDBLOFFFHKKQFHQSGQTTTVNMOMKPTBPUGDWLPKEHVKXBGXMXAGEKWBWVONUCSOJGTNJ.GetTrailingTrivia());
                                return node.ReplaceNode(SDBLOFFFHKKQFHQSGQTTTVNMOMKPTBPUGDWLPKEHVKXBGXMXAGEKWBWVONUCSOJGTNJ, CIFDTMMVIVMFPXLOMUEVFFBVBNBMGBQFQNKOTDJWKDNXBIFCHXUKPQEUGHBGKXPGEHNC);
                            }

                        }
                    }
                }

            }

            return base.Visit(node);
        }
    }
}
