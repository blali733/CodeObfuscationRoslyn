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
    class XMPOLRHNKIOSPKIMWXJPPDRLRIEPSHJPGDCFGDJAAKHXNNJXVBGAIKUTSDUCMPSDW: CSharpSyntaxRewriter
    {
        public XMPOLRHNKIOSPKIMWXJPPDRLRIEPSHJPGDCFGDJAAKHXNNJXVBGAIKUTSDUCMPSDW() { }
        public override SyntaxNode Visit(SyntaxNode node)
        {
            if (node != null)
            {
                var XMLICGTOIOFUSWEWERRBJGTHGLCGGLJPEBOAWPTSKJXUPXAFQDIVBCMQQDCPENHVEN= node.DescendantTokens();

                if (XMLICGTOIOFUSWEWERRBJGTHGLCGGLJPEBOAWPTSKJXUPXAFQDIVBCMQQDCPENHVEN.Count() > 0)
                {
                    foreach (SyntaxToken token in XMLICGTOIOFUSWEWERRBJGTHGLCGGLJPEBOAWPTSKJXUPXAFQDIVBCMQQDCPENHVEN)
                    {
                        //Console.WriteLine(token.ValueText + " *** " + token.IsKeyword());
                        string QRIDANWXOXHXQGLUOCDMOBMVISMDOVCCPBHHVMDSWCLMJQLTEHXESQWOEKTGATJQVEI= token.ValueText;
                        if (CRMJFJNCCELINXAQEUMIJBVLJKAIGORNTTKWABLMHSMLTAOUKXCIGRQATB.Instance.EFPPBVBEPWQUAUDRHGWSMXHHEALKSSSLSUKHIWKDSAARQQHGGDWDEKTEVILAKO.ContainsKey(QRIDANWXOXHXQGLUOCDMOBMVISMDOVCCPBHHVMDSWCLMJQLTEHXESQWOEKTGATJQVEI))
                        {
                            if (node is IdentifierNameSyntax)
                            {
                                IdentifierNameSyntax OXDXBXINMNXMPGRWGWWHXCRCKQVRCRTPEIUUAIVEJCKAEWDXHUCRXUIMFBNJCPKTSIHH= (IdentifierNameSyntax)node;
                                IdentifierNameSyntax KVWWBRWUPQVMNVKGOBQHXIOXTMCSPPFUOUMJWEQGWLUNDATEEEEQPAHCHWDNOEFALAVQJ= OXDXBXINMNXMPGRWGWWHXCRCKQVRCRTPEIUUAIVEJCKAEWDXHUCRXUIMFBNJCPKTSIHH.WithIdentifier(Identifier(CRMJFJNCCELINXAQEUMIJBVLJKAIGORNTTKWABLMHSMLTAOUKXCIGRQATB.Instance.EFPPBVBEPWQUAUDRHGWSMXHHEALKSSSLSUKHIWKDSAARQQHGGDWDEKTEVILAKO[QRIDANWXOXHXQGLUOCDMOBMVISMDOVCCPBHHVMDSWCLMJQLTEHXESQWOEKTGATJQVEI])).WithLeadingTrivia(OXDXBXINMNXMPGRWGWWHXCRCKQVRCRTPEIUUAIVEJCKAEWDXHUCRXUIMFBNJCPKTSIHH.GetLeadingTrivia()).WithTrailingTrivia(OXDXBXINMNXMPGRWGWWHXCRCKQVRCRTPEIUUAIVEJCKAEWDXHUCRXUIMFBNJCPKTSIHH.GetTrailingTrivia());
                                return node.ReplaceNode(OXDXBXINMNXMPGRWGWWHXCRCKQVRCRTPEIUUAIVEJCKAEWDXHUCRXUIMFBNJCPKTSIHH, KVWWBRWUPQVMNVKGOBQHXIOXTMCSPPFUOUMJWEQGWLUNDATEEEEQPAHCHWDNOEFALAVQJ);
                            }

                        }
                    }
                }

            }

            return base.Visit(node);
        }
    }
}
