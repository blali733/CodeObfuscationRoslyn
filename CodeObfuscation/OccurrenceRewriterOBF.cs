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
    class IINNSLQHXAFMRSMSHVUOBICPJUFVDXHTXUNGEBIPMOHXQQCNIRINXUCXGWEWFTD: CSharpSyntaxRewriter
    {
        public IINNSLQHXAFMRSMSHVUOBICPJUFVDXHTXUNGEBIPMOHXQQCNIRINXUCXGWEWFTD() { }
        public override SyntaxNode Visit(SyntaxNode node)
        {
            if (node != null)
            {
                var ARKNUEFNGNEBLACWQRPNKORTCRNAGUJJQKHGGDFJCDCASSPXDXLENGQJXOKDOFGJ= node.DescendantTokens();

                if (ARKNUEFNGNEBLACWQRPNKORTCRNAGUJJQKHGGDFJCDCASSPXDXLENGQJXOKDOFGJ.Count() > 0)
                {
                    foreach (SyntaxToken token in ARKNUEFNGNEBLACWQRPNKORTCRNAGUJJQKHGGDFJCDCASSPXDXLENGQJXOKDOFGJ)
                    {
                        //Console.WriteLine(token.ValueText + " *** " + token.IsKeyword());
                        string DTJAQTQNMGLGLQBHCOUHJFTKRWGQQBSUVRVXJOHHHVPHTKVHNCBAIXAVXWGRMXVLL= token.ValueText;
                        if (UHOARLRBORGHCJUEBBIMLCBURKFTKNMIFWUOGRFQRLEFDMVKKGFDNLRS.Instance.GUNBGHMJVWTVMQAPXGCETNOTETLNKAHDQXJVTGGLUHPVFXFNLFIGNKKRGRUK.ContainsKey(DTJAQTQNMGLGLQBHCOUHJFTKRWGQQBSUVRVXJOHHHVPHTKVHNCBAIXAVXWGRMXVLL))
                        {
                            if (node is IdentifierNameSyntax)
                            {
                                IdentifierNameSyntax OJSTBWLHMALNMPHBXDOASMVQXAKINTHAETEACLLDNRTXMIKHWQMUGKRBLBTBLDRRQK= (IdentifierNameSyntax)node;
                                IdentifierNameSyntax IQKHWMQKKBRWEPNDJUGLRRCDMBQJQKXBGCXSUPSAEUAPINVEMIRULFRPNHSUUGSXBPP= OJSTBWLHMALNMPHBXDOASMVQXAKINTHAETEACLLDNRTXMIKHWQMUGKRBLBTBLDRRQK.WithIdentifier(Identifier(UHOARLRBORGHCJUEBBIMLCBURKFTKNMIFWUOGRFQRLEFDMVKKGFDNLRS.Instance.GUNBGHMJVWTVMQAPXGCETNOTETLNKAHDQXJVTGGLUHPVFXFNLFIGNKKRGRUK[DTJAQTQNMGLGLQBHCOUHJFTKRWGQQBSUVRVXJOHHHVPHTKVHNCBAIXAVXWGRMXVLL])).WithLeadingTrivia(OJSTBWLHMALNMPHBXDOASMVQXAKINTHAETEACLLDNRTXMIKHWQMUGKRBLBTBLDRRQK.GetLeadingTrivia()).WithTrailingTrivia(OJSTBWLHMALNMPHBXDOASMVQXAKINTHAETEACLLDNRTXMIKHWQMUGKRBLBTBLDRRQK.GetTrailingTrivia());
                                return node.ReplaceNode(OJSTBWLHMALNMPHBXDOASMVQXAKINTHAETEACLLDNRTXMIKHWQMUGKRBLBTBLDRRQK, IQKHWMQKKBRWEPNDJUGLRRCDMBQJQKXBGCXSUPSAEUAPINVEMIRULFRPNHSUUGSXBPP);
                            }

                        }
                    }
                }

            }

            return base.Visit(node);
        }
    }
}
