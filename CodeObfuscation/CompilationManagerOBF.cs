using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;

namespace CodeObfuscation
{
    class NELTLHRD    {
        public NELTLHRD() { }

        public void CSDACULKM(GBSKQCQWCVQQNAQLHSCJDJMOMMGCGLHPCSIXWVSPGCQWDCDUKCVMGGQUNEWDTOPONBOTQRNJXLCBQ.En_Priority[] prioritiesTablo) 
        {
            Tuple<Compilation, int> ELICWFCKFKX= OCSTUTAPSQ();
            Array.Sort(prioritiesTablo);

            for (int NLHLVEVDIBCD= 0; NLHLVEVDIBCD < ELICWFCKFKX.Item2; NLHLVEVDIBCD++)
            {
                foreach (SyntaxTree sourceTree in ELICWFCKFKX.Item1.SyntaxTrees)
                {
                    SyntaxNode LVWOTQJKERPNP= null;
                    foreach (GBSKQCQWCVQQNAQLHSCJDJMOMMGCGLHPCSIXWVSPGCQWDCDUKCVMGGQUNEWDTOPONBOTQRNJXLCBQ.En_Priority priority in prioritiesTablo)
                    {
                        CSharpSyntaxRewriter RPFTAJFXMAOKIX= GBSKQCQWCVQQNAQLHSCJDJMOMMGCGLHPCSIXWVSPGCQWDCDUKCVMGGQUNEWDTOPONBOTQRNJXLCBQ.NKKIJPEOTJTBLJRXOTQKBICLIEQNLNSDPEXRLTKWLASQTSFHTJIQKOOEIWAFWPCFOPJGKALTJRWBOJ(priority);
                        if (RPFTAJFXMAOKIX != null)
                        {
                            if (LVWOTQJKERPNP == null)
                            {
                                LVWOTQJKERPNP = RPFTAJFXMAOKIX.Visit(sourceTree.GetRoot());
                            }
                            else
                            {
                                LVWOTQJKERPNP = RPFTAJFXMAOKIX.Visit(LVWOTQJKERPNP);
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    File.WriteAllText(sourceTree.FilePath, LVWOTQJKERPNP.ToFullString());
                }
            }
        }
        private Tuple<Compilation, int> OCSTUTAPSQ()
        {

            String PDLJOBIVFXOGSUA= @"..\..\Program.cs";
            String TTUSTENQIIQUDWVH= @"..\..\ProgramOBF.cs";
            String ELRRGQIALHUJFEROI= File.ReadAllText(PDLJOBIVFXOGSUA);
            SyntaxTree XRESPNSCLCBWFEWIPK=
                           CSharpSyntaxTree.ParseText(ELRRGQIALHUJFEROI)
                                           .WithFilePath(TTUSTENQIIQUDWVH);

            String TBCRCLTHMHDKDPBLEFQ= @"..\..\CompilationManager.cs";
            String NMWWPTNHCGCVBNSVNGGO= @"..\..\CompilationManagerOBF.cs";
            String QWIAKWAXKVRARPCWVDKVM= File.ReadAllText(TBCRCLTHMHDKDPBLEFQ);
            SyntaxTree ERBJKCUJRLFVOAODVLRSOU=
                           CSharpSyntaxTree.ParseText(QWIAKWAXKVRARPCWVDKVM)
                                           .WithFilePath(NMWWPTNHCGCVBNSVNGGO);

            String ENCDJLTAKTIBLFHPAUENQJL= @"..\..\SharedContainer.cs";
            String CCPLSAPRDWHMMGGQJOQBKMMM= @"..\..\SharedContainerOBF.cs";
            String JUFLUOBETBXARXAASBFDEQTJR= File.ReadAllText(ENCDJLTAKTIBLFHPAUENQJL);
            SyntaxTree DSXXIAOODCWSEVNUDRKHFXKNQG=
                           CSharpSyntaxTree.ParseText(JUFLUOBETBXARXAASBFDEQTJR)
                                           .WithFilePath(CCPLSAPRDWHMMGGQJOQBKMMM);

            String JHJIRAURQUCEKBJKNVCFODQHAWJ= @"..\..\OccurrenceRewriter.cs";
            String CLEIKHBPGETIVWKERSWGIVSJMKKQ= @"..\..\OccurrenceRewriterOBF.cs";
            String FPBHSPSFMLQVIKCFSMEHDWXNBPAEQ= File.ReadAllText(JHJIRAURQUCEKBJKNVCFODQHAWJ);
            SyntaxTree STXUJJPCLOGDFQFBBWWSMPXGDMGPMF=
                           CSharpSyntaxTree.ParseText(FPBHSPSFMLQVIKCFSMEHDWXNBPAEQ)
                                           .WithFilePath(CLEIKHBPGETIVWKERSWGIVSJMKKQ);

            String CONMRPQBXAKDGWVEWGRLARCJDDTQRUC= @"..\..\MethodRewriter.cs";
            String XOFLPNQWNIAWVHJIBIXOAVBFIMEJOUAI= @"..\..\MethodRewriterOBF.cs";
            String CWKNAKFOFHECATECRSSIRGCCMADDJHIRI= File.ReadAllText(CONMRPQBXAKDGWVEWGRLARCJDDTQRUC);
            SyntaxTree PUXUUIPDIIQRXFNIBPUBPOUTIAXHCEWXLR=
                           CSharpSyntaxTree.ParseText(CWKNAKFOFHECATECRSSIRGCCMADDJHIRI)
                                           .WithFilePath(XOFLPNQWNIAWVHJIBIXOAVBFIMEJOUAI);

            String IWEFVJDFJVJINTNSHQLPQBADLUIIADKRGFU= @"..\..\ClassRewriter.cs";
            String PDUSKWKEWKALERIVGLTAGVBRABSEFLPCHWWO= @"..\..\ClassRewriterOBF.cs";
            String LVARGUBQLIDOQGDFKFNRCDRJDGXLTVDFSRKIK= File.ReadAllText(IWEFVJDFJVJINTNSHQLPQBADLUIIADKRGFU);
            SyntaxTree CSKUIFPVEMWHJQCJFMHEPNXVOVOFWUWUSSIKDV=
                           CSharpSyntaxTree.ParseText(LVARGUBQLIDOQGDFKFNRCDRJDGXLTVDFSRKIK)
                                           .WithFilePath(PDUSKWKEWKALERIVGLTAGVBRABSEFLPCHWWO);

            String SVBLXRAEJFBUNFCDTMSMFKPKXINCMPHQFHRJDDO= @"..\..\ConstructorRewriter.cs";
            String GUJMJEBGRSOXTPOPIGOMPEWPSVIOGLQAPWMQUVFG= @"..\..\ConstructorRewriterOBF.cs";
            String VBTIVPMAOQJDMPWCWRSLTLXGBOHVDWTKAIPNIOSCJ= File.ReadAllText(SVBLXRAEJFBUNFCDTMSMFKPKXINCMPHQFHRJDDO);
            SyntaxTree IXNBNLAXJSCDSLKBNGHHOUQVXCEXJRIXPCKLKEMCHW=
                           CSharpSyntaxTree.ParseText(VBTIVPMAOQJDMPWCWRSLTLXGBOHVDWTKAIPNIOSCJ)
                                           .WithFilePath(GUJMJEBGRSOXTPOPIGOMPEWPSVIOGLQAPWMQUVFG);

            String REQHGVFLTHLSSLHQCKHANQKCLPAWPISEAPDMEQTHSVW= @"..\..\VariableRewriter.cs";
            String AMVHXDRBBTGJBROTPUGTKMGSDISMKPAGPRJOOHBSWHRJ= @"..\..\VariableRewriterOBF.cs";
            String SGBSNUEKLBMLFCEPJEOJTARIIXEHTLVCTVAUGXWOLNSNE= File.ReadAllText(REQHGVFLTHLSSLHQCKHANQKCLPAWPISEAPDMEQTHSVW);
            SyntaxTree VJLDJJSQHOSNRKOPUPAEJQHCHJJFAWFFDDKOREJCCKLHFH=
                           CSharpSyntaxTree.ParseText(SGBSNUEKLBMLFCEPJEOJTARIIXEHTLVCTVAUGXWOLNSNE)
                                           .WithFilePath(AMVHXDRBBTGJBROTPUGTKMGSDISMKPAGPRJOOHBSWHRJ);

            String MNIWOWSJSFBITAANPIIMKNXXWQFWBXEAVAUTUBIHLRIFNII= @"..\..\Priority.cs";
            String IBNSDWRVWNJAVQTHTAALTEEQOABBQESKNIUUMEBCDCVGLBKO= @"..\..\PriorityOBF.cs";
            String PKNEMUMEVVECUQFRTWKNTXTOXWIRGVEMOLJFPNVQUQWPAWFLV= File.ReadAllText(MNIWOWSJSFBITAANPIIMKNXXWQFWBXEAVAUTUBIHLRIFNII);
            SyntaxTree ELMOUSPPWFOMTWXQPMJGXCFBSRDADOARUTCKQVRQRNQHHDBSXW=
                           CSharpSyntaxTree.ParseText(PKNEMUMEVVECUQFRTWKNTXTOXWIRGVEMOLJFPNVQUQWPAWFLV)
                                           .WithFilePath(IBNSDWRVWNJAVQTHTAALTEEQOABBQESKNIUUMEBCDCVGLBKO);

            SyntaxTree[] IKTFVBFLUDOPLIFUQXTMXSSQMJJVROQIBFFNWPVAFFAOBCCICLL= {XRESPNSCLCBWFEWIPK, ERBJKCUJRLFVOAODVLRSOU, DSXXIAOODCWSEVNUDRKHFXKNQG, STXUJJPCLOGDFQFBBWWSMPXGDMGPMF, PUXUUIPDIIQRXFNIBPUBPOUTIAXHCEWXLR, CSKUIFPVEMWHJQCJFMHEPNXVOVOFWUWUSSIKDV, IXNBNLAXJSCDSLKBNGHHOUQVXCEXJRIXPCKLKEMCHW, VJLDJJSQHOSNRKOPUPAEJQHCHJJFAWFFDDKOREJCCKLHFH, ELMOUSPPWFOMTWXQPMJGXCFBSRDADOARUTCKQVRQRNQHHDBSXW};

            MetadataReference BWKXOQCQMQHRGLFNGCQWBBTHSRDOJHBTGCOKOFPUTWJIVLSDTMTF=
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
            MetadataReference JMKXDCEUMLGEPLKEUTWALTDCQKKHXATULTJRQPHMBSIHPFRJAOHAO=
                    MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location);
            MetadataReference TSOJHHQQVVMQJQTBQLEMKWQLTKKRAGJRSGQATIIHOTEUUOGMVHHCCL=
                   MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location);
            MetadataReference[] DUCDOUUWQOMSWCXTGICVVPSTOEEWUQWGOHDUWPSLLQCOIBQDNBBXXFN= { BWKXOQCQMQHRGLFNGCQWBBTHSRDOJHBTGCOKOFPUTWJIVLSDTMTF, JMKXDCEUMLGEPLKEUTWALTDCQKKHXATULTJRQPHMBSIHPFRJAOHAO, TSOJHHQQVVMQJQTBQLEMKWQLTKKRAGJRSGQATIIHOTEUUOGMVHHCCL };

            return Tuple.Create(CSharpCompilation.Create("CodeObfuscation",
                                            IKTFVBFLUDOPLIFUQXTMXSSQMJJVROQIBFFNWPVAFFAOBCCICLL,
                                            DUCDOUUWQOMSWCXTGICVVPSTOEEWUQWGOHDUWPSLLQCOIBQDNBBXXFN,
                                            new CSharpCompilationOptions(
                                                    OutputKind.ConsoleApplication)) as Compilation, IKTFVBFLUDOPLIFUQXTMXSSQMJJVROQIBFFNWPVAFFAOBCCICLL.Count());
        }
    }
}
