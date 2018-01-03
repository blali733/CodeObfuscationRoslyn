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
    class MECSJWFNXVLRHFIPDJISROLSFJMWVJQKMPDIWTBUPHRWFFIOGVPMUKTVQIMAJHP: CSharpSyntaxRewriter
    {
        public MECSJWFNXVLRHFIPDJISROLSFJMWVJQKMPDIWTBUPHRWFFIOGVPMUKTVQIMAJHP() { }
        public override SyntaxNode Visit(SyntaxNode node)
        {
            if (node != null)
            {
                var NEBEPCAQIILCKUMMXBVPXRDOCUFPOGBKHPDSDAQMFFHEIHIADTNXMPQUALCTUICC= node.DescendantTokens();

                if (NEBEPCAQIILCKUMMXBVPXRDOCUFPOGBKHPDSDAQMFFHEIHIADTNXMPQUALCTUICC.Count() > 0)
                {
                    foreach (SyntaxToken token in NEBEPCAQIILCKUMMXBVPXRDOCUFPOGBKHPDSDAQMFFHEIHIADTNXMPQUALCTUICC)
                    {
                        //Console.WriteLine(token.ValueText + " *** " + token.IsKeyword());
                        string HBSSRSJXIJJSKXFSMELSRBWQXGRQWVPVDFVHMOHJKNODFWKBGHGQUHIFCCSKBRBKR= token.ValueText;
                        if (MBGMJQWCXPFDPXCVOOOJFMELNMBISPXGJROTPDJTMNCWCVBDKEKIITIX.Instance.HVIPMSGNAAKLKRDVSPOFDJECEXDXOOVMCUBMJQARAGWJVJGHALOXHFMWRGKN.ContainsKey(HBSSRSJXIJJSKXFSMELSRBWQXGRQWVPVDFVHMOHJKNODFWKBGHGQUHIFCCSKBRBKR))
                        {
                            if (node is IdentifierNameSyntax)
                            {
                                IdentifierNameSyntax MOEBVFWVCIDKTKBUPJOOXAUUPFJTUHQMDJQHFXIBITRWFSHQROJHKUSMSIKQTCATPO= (IdentifierNameSyntax)node;
                                IdentifierNameSyntax GJRSOQBMFEGVOVVRCFWJCHPENVNPGFSWGPMVWWARFWONGURMSCATVGMXRNERCJGXKIO= MOEBVFWVCIDKTKBUPJOOXAUUPFJTUHQMDJQHFXIBITRWFSHQROJHKUSMSIKQTCATPO.WithIdentifier(Identifier(MBGMJQWCXPFDPXCVOOOJFMELNMBISPXGJROTPDJTMNCWCVBDKEKIITIX.Instance.HVIPMSGNAAKLKRDVSPOFDJECEXDXOOVMCUBMJQARAGWJVJGHALOXHFMWRGKN[HBSSRSJXIJJSKXFSMELSRBWQXGRQWVPVDFVHMOHJKNODFWKBGHGQUHIFCCSKBRBKR])).WithLeadingTrivia(MOEBVFWVCIDKTKBUPJOOXAUUPFJTUHQMDJQHFXIBITRWFSHQROJHKUSMSIKQTCATPO.GetLeadingTrivia()).WithTrailingTrivia(MOEBVFWVCIDKTKBUPJOOXAUUPFJTUHQMDJQHFXIBITRWFSHQROJHKUSMSIKQTCATPO.GetTrailingTrivia());
                                return node.ReplaceNode(MOEBVFWVCIDKTKBUPJOOXAUUPFJTUHQMDJQHFXIBITRWFSHQROJHKUSMSIKQTCATPO, GJRSOQBMFEGVOVVRCFWJCHPENVNPGFSWGPMVWWARFWONGURMSCATVGMXRNERCJGXKIO);
                            }

                        }
                    }
                }

            }

            return base.Visit(node);
        }
    }
}
