using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;

namespace CodeObfuscation
{
    class GBWEK    {
        static void Main(string[] args)
        {
            CompilationManager DRTLDO= new CompilationManager();
            Compilation SUFSVJU= DRTLDO.CreateCompilation();

            foreach (SyntaxTree sourceTree in SUFSVJU.SyntaxTrees)
            {
                ClassRewriter BSTNVFPD= new ClassRewriter();
                SyntaxNode NWGWFFWUK= BSTNVFPD.Visit(sourceTree.GetRoot());
                ConstructorRewriter KECTBAJCOF= new ConstructorRewriter();
                SyntaxNode ASTVUCQRRJQ= KECTBAJCOF.Visit(NWGWFFWUK);
                MethodRewriter EQMGOSNNWJUX= new MethodRewriter();
                SyntaxNode THQHBXRJLHXPI= EQMGOSNNWJUX.Visit(ASTVUCQRRJQ);
                VariableRewriter RAJTNLEKRGLONL= new VariableRewriter();
                SyntaxNode GUMQUDSXODTPRAA= RAJTNLEKRGLONL.Visit(THQHBXRJLHXPI);
                OccurrenceRewriter FVQVVUSERIWPMCAF= new OccurrenceRewriter();
                SyntaxNode QMMLNWODLNRKFAWRE= FVQVVUSERIWPMCAF.Visit(GUMQUDSXODTPRAA);
                /*if (occurenceRewritedNode != sourceTree.GetRoot())
                {
                    File.WriteAllText(sourceTree.FilePath, occurenceRewritedNode.ToFullString());
                }*/
                //save without condition
                File.WriteAllText(sourceTree.FilePath, QMMLNWODLNRKFAWRE.ToFullString());
            }
        }
    }
}
