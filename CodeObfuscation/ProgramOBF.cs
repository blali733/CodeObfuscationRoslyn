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
    class IIBUH    {
        static void Main(string[] args)
        {
            CompilationManager VPVSBO= new CompilationManager();
            Compilation QFIHALF= VPVSBO.CreateCompilation();

            foreach (SyntaxTree sourceTree in QFIHALF.SyntaxTrees)
            {
                ClassRewriter KMXVIHHX= new ClassRewriter();
                SyntaxNode TVTMGKNDX= KMXVIHHX.Visit(sourceTree.GetRoot());
                ConstructorRewriter NTFLDXSPQV= new ConstructorRewriter();
                SyntaxNode XAKNOTPTAIK= NTFLDXSPQV.Visit(TVTMGKNDX);
                MethodRewriter ASMHCRBGTDCB= new MethodRewriter();
                SyntaxNode ISEFSGNFFPJHX= ASMHCRBGTDCB.Visit(XAKNOTPTAIK);
                VariableRewriter JIFROPMTMNBQDB= new VariableRewriter();
                SyntaxNode FRJVSVWBSJNVMKD= JIFROPMTMNBQDB.Visit(ISEFSGNFFPJHX);
                OccurrenceRewriter FIIFIRJTNELOGUEC= new OccurrenceRewriter();
                SyntaxNode NOFIMTSPKAHNTDRDB= FIIFIRJTNELOGUEC.Visit(FRJVSVWBSJNVMKD);
                /*if (occurenceRewritedNode != sourceTree.GetRoot())
                {
                    File.WriteAllText(sourceTree.FilePath, occurenceRewritedNode.ToFullString());
                }*/
                //save without condition
                File.WriteAllText(sourceTree.FilePath, NOFIMTSPKAHNTDRDB.ToFullString());
            }
        }
    }
}
