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
    class ERALIPSKVHUCGQRNQFAKGRBJQXLHMMCFNBMXWDPLCKBIHMOW: CSharpSyntaxRewriter
    {
        public ERALIPSKVHUCGQRNQFAKGRBJQXLHMMCFNBMXWDPLCKBIHMOW() { }
        public override SyntaxNode Visit(SyntaxNode node)
        {
            if (node != null)
            {
                var NBOEXTAKPOSIELWJEPMFERONNNITQRBEINRLVVFSABHHIGGOM= node.DescendantTokens();

                if (NBOEXTAKPOSIELWJEPMFERONNNITQRBEINRLVVFSABHHIGGOM.Count() > 0)
                {
                    foreach (SyntaxToken token in NBOEXTAKPOSIELWJEPMFERONNNITQRBEINRLVVFSABHHIGGOM)
                    {
                        //Console.WriteLine(token.ValueText + " *** " + token.IsKeyword());
                        string PDQAIRTKBOKLESVNOAORLMGJSEDKHEHGRHBOIEATVATGTGUHKR= token.ValueText;
                        if (MNFQMOIDGHBTUOUITKAVTCKKVFDMDRATUEXUJQVCN.Instance.PITENLVXSAAPSWIWLTUUCHCIAEBDIOLOLVQUFALHJBOAR.ContainsKey(PDQAIRTKBOKLESVNOAORLMGJSEDKHEHGRHBOIEATVATGTGUHKR))
                        {
                            if (node is IdentifierNameSyntax)
                            {
                                IdentifierNameSyntax SGPVBDVGFEOJDUHDRVRHEJXTUKQXNLHTANJAOUFVRCWUFLVXXQM= (IdentifierNameSyntax)node;
                                IdentifierNameSyntax XOCMJGUAOLVRSUSJNLHMVPTOCKDNINRAVWIFVBARRTOKTJEXKCHM= SGPVBDVGFEOJDUHDRVRHEJXTUKQXNLHTANJAOUFVRCWUFLVXXQM.WithIdentifier(Identifier(MNFQMOIDGHBTUOUITKAVTCKKVFDMDRATUEXUJQVCN.Instance.PITENLVXSAAPSWIWLTUUCHCIAEBDIOLOLVQUFALHJBOAR[PDQAIRTKBOKLESVNOAORLMGJSEDKHEHGRHBOIEATVATGTGUHKR])).WithLeadingTrivia(SGPVBDVGFEOJDUHDRVRHEJXTUKQXNLHTANJAOUFVRCWUFLVXXQM.GetLeadingTrivia()).WithTrailingTrivia(SGPVBDVGFEOJDUHDRVRHEJXTUKQXNLHTANJAOUFVRCWUFLVXXQM.GetTrailingTrivia());
                                return node.ReplaceNode(SGPVBDVGFEOJDUHDRVRHEJXTUKQXNLHTANJAOUFVRCWUFLVXXQM, XOCMJGUAOLVRSUSJNLHMVPTOCKDNINRAVWIFVBARRTOKTJEXKCHM);
                            }

                        }
                    }
                }

            }

            return base.Visit(node);
        }
    }
}
