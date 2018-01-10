using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeObfuscation
{
    class CommentRemover : CSharpSyntaxRewriter
    {
        public CommentRemover() { }

        public override SyntaxTrivia VisitTrivia(SyntaxTrivia trivia)
        {
            SyntaxTrivia mTrivia;
            if(trivia.IsKind(SyntaxKind.SingleLineCommentTrivia) ||
                trivia.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) ||
                trivia.IsKind(SyntaxKind.MultiLineCommentTrivia) ||
                trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
            {
                mTrivia = SyntaxFactory.CarriageReturn;
            }
            else
            {
                mTrivia = trivia;
            }
            return mTrivia;
        }
    }
}
