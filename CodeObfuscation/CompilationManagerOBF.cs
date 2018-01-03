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
    class MXHEJIISXODEPXRWVSA    {
        public MXHEJIISXODEPXRWVSA() { }
        public Tuple<Compilation, int> WJJRCUPKEFLFOSEAQRMK()
        {

            String KTCNUBNKIEKNRPWICFEIS= @"..\..\Program.cs";
            String VDMLJNJKWAFJHNDHUVBGEC= @"..\..\ProgramOBF.cs";
            String ASWLWTUWLNEQNQNBKLDXJDF= File.ReadAllText(KTCNUBNKIEKNRPWICFEIS);
            SyntaxTree DKCTAGHDBNTCRNWPNOAMQEPX=
                           CSharpSyntaxTree.ParseText(ASWLWTUWLNEQNQNBKLDXJDF)
                                           .WithFilePath(VDMLJNJKWAFJHNDHUVBGEC);

            String KSSKNDFQVNSATATPDJCDSNTMM= @"..\..\CompilationManager.cs";
            String UNJJPNWSCIGMVNWICFETVTNSJI= @"..\..\CompilationManagerOBF.cs";
            String GCMFVXFWRNTGFATGRPNCGUDTPIO= File.ReadAllText(KSSKNDFQVNSATATPDJCDSNTMM);
            SyntaxTree ROBAOXGHUGVLGGWUJMTXEXPBVFHC=
                           CSharpSyntaxTree.ParseText(GCMFVXFWRNTGFATGRPNCGUDTPIO)
                                           .WithFilePath(UNJJPNWSCIGMVNWICFETVTNSJI);

            String JWRNNIMHPNFHXQWXTEGTHASGUIKRX= @"..\..\SharedContainer.cs";
            String XCJQDVWNIWVSPETGMXLAPGRWLSJDKR= @"..\..\SharedContainerOBF.cs";
            String EWTIPKUOUTAKLGIBQUXAHIWQHRIKEJM= File.ReadAllText(JWRNNIMHPNFHXQWXTEGTHASGUIKRX);
            SyntaxTree SDPRXWHMIKVDQAFSLNKBMEJJTADAWCJJ=
                           CSharpSyntaxTree.ParseText(EWTIPKUOUTAKLGIBQUXAHIWQHRIKEJM)
                                           .WithFilePath(XCJQDVWNIWVSPETGMXLAPGRWLSJDKR);

            String KGFHUMJCJHOOJFFPCWVVSHXORFVWTGOGA= @"..\..\OccurrenceRewriter.cs";
            String LQKSWWWEHQFOTAOSLVXEMPDGPNPPKHCQHN= @"..\..\OccurrenceRewriterOBF.cs";
            String VMTVEAXRKPRXWFGEHJPCMUNDCIHHRANNGGC= File.ReadAllText(KGFHUMJCJHOOJFFPCWVVSHXORFVWTGOGA);
            SyntaxTree CWORWFTFMMPPJIGARBFABXQSTRPXJBERPCEG=
                           CSharpSyntaxTree.ParseText(VMTVEAXRKPRXWFGEHJPCMUNDCIHHRANNGGC)
                                           .WithFilePath(LQKSWWWEHQFOTAOSLVXEMPDGPNPPKHCQHN);

            String RQQVROAOKRVWLAULBFADFTVFNTTKIWXGEAGAI= @"..\..\MethodRewriter.cs";
            String HHKWCHBURMJEQPKCBAVSLHVTNGMSOSLRTDRVNE= @"..\..\MethodRewriterOBF.cs";
            String DLTJUHJGPHMECXJGUXKPIUTHFWBQJNVNMUUKXCL= File.ReadAllText(RQQVROAOKRVWLAULBFADFTVFNTTKIWXGEAGAI);
            SyntaxTree NJHOFFJQLINGSKVUHPLDWGRUCJXQGCWHSMUGAFOC=
                           CSharpSyntaxTree.ParseText(DLTJUHJGPHMECXJGUXKPIUTHFWBQJNVNMUUKXCL)
                                           .WithFilePath(HHKWCHBURMJEQPKCBAVSLHVTNGMSOSLRTDRVNE);

            String UGNITGDCOXNSLXNHPKMTFRJIJGMFOPTCBJHPQJBTG= @"..\..\ClassRewriter.cs";
            String VBGNEUTWMPNQTUDUFWNSVLXELRBPVPGJRMIPDTFKQG= @"..\..\ClassRewriterOBF.cs";
            String BAGKGNETKKMBIJCCBKSDBUIEWGLLRKRCBOKXVBLLLCF= File.ReadAllText(UGNITGDCOXNSLXNHPKMTFRJIJGMFOPTCBJHPQJBTG);
            SyntaxTree UVQDXMARSPNFEPBLXCQBARJXSWDEAXHPWPMGGCLXQQWK=
                           CSharpSyntaxTree.ParseText(BAGKGNETKKMBIJCCBKSDBUIEWGLLRKRCBOKXVBLLLCF)
                                           .WithFilePath(VBGNEUTWMPNQTUDUFWNSVLXELRBPVPGJRMIPDTFKQG);

            String LIFHTOLJTAECLQJAIURSIVGMDTEVOQIHSWMJRUIKMVTWK= @"..\..\ConstructorRewriter.cs";
            String JSOQLOUXDCNCQDAJNTCPVHNEAHMLHGLBICRAOECCMIPUWH= @"..\..\ConstructorRewriterOBF.cs";
            String AQHAWCRGNBFKQDBJQVPLROJATJQADMQRFRHTDGHIIBMQSDM= File.ReadAllText(LIFHTOLJTAECLQJAIURSIVGMDTEVOQIHSWMJRUIKMVTWK);
            SyntaxTree WADQREKNJGHFNJRCBIMEWUGFJNGDPCRFPURXAUWMTEVNUBSX=
                           CSharpSyntaxTree.ParseText(AQHAWCRGNBFKQDBJQVPLROJATJQADMQRFRHTDGHIIBMQSDM)
                                           .WithFilePath(JSOQLOUXDCNCQDAJNTCPVHNEAHMLHGLBICRAOECCMIPUWH);

            String PWLHGXNCSVHEWGVGNCOQPRCEKXJSWQIITHLQPKWPGPFCNSOMG= @"..\..\VariableRewriter.cs";
            String OASKBHVUGVHOTDBMWIOTFPCDWJAMXPPIUMIQOVRXOUINOBLMDN= @"..\..\VariableRewriterOBF.cs";
            String OJXRBXVOMQGJUOFWRHTIWBPOEJGNMUWMJJAGJDLJTAJBQFXRHQI= File.ReadAllText(PWLHGXNCSVHEWGVGNCOQPRCEKXJSWQIITHLQPKWPGPFCNSOMG);
            SyntaxTree ERSPNSIMQQHBPRSALOXNOTJMWPOVXJMFUMSTOSLLAOTQMWSHWEMD=
                           CSharpSyntaxTree.ParseText(OJXRBXVOMQGJUOFWRHTIWBPOEJGNMUWMJJAGJDLJTAJBQFXRHQI)
                                           .WithFilePath(OASKBHVUGVHOTDBMWIOTFPCDWJAMXPPIUMIQOVRXOUINOBLMDN);
            SyntaxTree[] ICRIHGRVDLMGDBFCXXKQCLNXARAXVGXSVIVRSJLIBNINBMMKRPIWS= {DKCTAGHDBNTCRNWPNOAMQEPX, ROBAOXGHUGVLGGWUJMTXEXPBVFHC, SDPRXWHMIKVDQAFSLNKBMEJJTADAWCJJ, CWORWFTFMMPPJIGARBFABXQSTRPXJBERPCEG, NJHOFFJQLINGSKVUHPLDWGRUCJXQGCWHSMUGAFOC, UVQDXMARSPNFEPBLXCQBARJXSWDEAXHPWPMGGCLXQQWK, WADQREKNJGHFNJRCBIMEWUGFJNGDPCRFPURXAUWMTEVNUBSX, ERSPNSIMQQHBPRSALOXNOTJMWPOVXJMFUMSTOSLLAOTQMWSHWEMD};

            MetadataReference TBUNSIOFRAVLRITDLHNLBPMDAVLENFFVAACHADABVCHNKBIERGGISK=
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
            MetadataReference QDMRNUUJPLSXKRGLDHHMOXIXQWNHKHXVDOHWTHOEELKTSKOOWGDWBGU=
                    MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location);
            MetadataReference RTNAOGNXILVUUKHQTRDHCMMEGHXIDDBUURNCFHXVPMCHVOSEOOHFWXSE=
                   MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location);
            MetadataReference[] GISHHETEKAXDUEKMRFPNJFGPNSSNTUWVWIUVNQNKQVVUOPHJDTLQHESBC= { TBUNSIOFRAVLRITDLHNLBPMDAVLENFFVAACHADABVCHNKBIERGGISK, QDMRNUUJPLSXKRGLDHHMOXIXQWNHKHXVDOHWTHOEELKTSKOOWGDWBGU, RTNAOGNXILVUUKHQTRDHCMMEGHXIDDBUURNCFHXVPMCHVOSEOOHFWXSE };

            return Tuple.Create(CSharpCompilation.Create("CodeObfuscation",
                                            ICRIHGRVDLMGDBFCXXKQCLNXARAXVGXSVIVRSJLIBNINBMMKRPIWS,
                                            GISHHETEKAXDUEKMRFPNJFGPNSSNTUWVWIUVNQNKQVVUOPHJDTLQHESBC,
                                            new CSharpCompilationOptions(
                                                    OutputKind.ConsoleApplication)) as Compilation, ICRIHGRVDLMGDBFCXXKQCLNXARAXVGXSVIVRSJLIBNINBMMKRPIWS.Count());
        }
    }
}
