using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeObfuscation
{
    class WhitespaceRewriter : CSharpSyntaxRewriter
    {
        public WhitespaceRewriter() { }

        public override SyntaxTrivia VisitTrivia(SyntaxTrivia trivia)
        {
            if (trivia.IsKind(SyntaxKind.WhitespaceTrivia))
            {
                 trivia = SyntaxFactory.SyntaxTrivia(SyntaxKind.WhitespaceTrivia, " ");
            }
            else if(trivia.IsKind(SyntaxKind.EndOfLineTrivia))
            {
                trivia = SyntaxFactory.SyntaxTrivia(SyntaxKind.EndOfLineTrivia, "");
            }
            return trivia;
        }
    }
}