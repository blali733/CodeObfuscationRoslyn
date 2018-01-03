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
    class QHFQKTHUVUQGGQEOGX    {
        public QHFQKTHUVUQGGQEOGX() { }
        public Compilation GGCOJORTHJTXJLIMONX()
        {

            String JCSWLOXBIDIDXMDKUXBV= @"..\..\Program.cs";
            String OXPMWAVKFWSCPOUULIPAK= @"..\..\ProgramOBF.cs";
            String MIPXGULFAMNMPIKLGXKQMU= File.ReadAllText(JCSWLOXBIDIDXMDKUXBV);
            SyntaxTree KIFLIPHWMHBLCOAMPEKFFJF=
                           CSharpSyntaxTree.ParseText(MIPXGULFAMNMPIKLGXKQMU)
                                           .WithFilePath(OXPMWAVKFWSCPOUULIPAK);

            String NXGKJFIEHVQWGRSLTWBAFLEF= @"..\..\CompilationManager.cs";
            String TKRIFGGOADPMBFVRDDRNKQRTU= @"..\..\CompilationManagerOBF.cs";
            String ROHDJACSAPWLAWAOBVDBGJOBIU= File.ReadAllText(NXGKJFIEHVQWGRSLTWBAFLEF);
            SyntaxTree BROTCRWLMPXLOCNRBNWFDEQWITO=
                           CSharpSyntaxTree.ParseText(ROHDJACSAPWLAWAOBVDBGJOBIU)
                                           .WithFilePath(TKRIFGGOADPMBFVRDDRNKQRTU);

            String ROHAFTNWIDEMFMMKJONGAMNIACCR= @"..\..\SharedContainer.cs";
            String VAQLHDFVFPSQBEENVAQRORHHSMNFA= @"..\..\SharedContainerOBF.cs";
            String WXDQTAILRFCHPESUVFUHXLXJJCDRIQ= File.ReadAllText(ROHAFTNWIDEMFMMKJONGAMNIACCR);
            SyntaxTree SNAUGPOAFDUBESOJXNNLVHQVBLARHQV=
                           CSharpSyntaxTree.ParseText(WXDQTAILRFCHPESUVFUHXLXJJCDRIQ)
                                           .WithFilePath(VAQLHDFVFPSQBEENVAQRORHHSMNFA);

            String PDALMHSWDFVXRLVHETADODVTKUCTTPVR= @"..\..\OccurrenceRewriter.cs";
            String MGFWDHCBFPKFAIXJDETVGNGLGFBPEXCMI= @"..\..\OccurrenceRewriterOBF.cs";
            String EKKGXDVRWWXRPSCVQPPTXKXXRPWGKUGMWU= File.ReadAllText(PDALMHSWDFVXRLVHETADODVTKUCTTPVR);
            SyntaxTree UVMDEAVEIPGSOKWSLHLQIRLKMHEPGBQLSTW=
                           CSharpSyntaxTree.ParseText(EKKGXDVRWWXRPSCVQPPTXKXXRPWGKUGMWU)
                                           .WithFilePath(MGFWDHCBFPKFAIXJDETVGNGLGFBPEXCMI);

            String EINKOWSBHRXBMHQJWAGMCKCOVTGWHXTXTLRK= @"..\..\MethodRewriter.cs";
            String WVVSNQDRNFQHOQSKMGTSGXMSPURIVXFANGKAD= @"..\..\MethodRewriterOBF.cs";
            String MWJGIAQCXIPFIKMQXEXJCCRWSUNXQRIFRHAIKL= File.ReadAllText(EINKOWSBHRXBMHQJWAGMCKCOVTGWHXTXTLRK);
            SyntaxTree VWUPQLCDMNRIOBLPAJFKLMKQKFAJLBKEFLGAMKK=
                           CSharpSyntaxTree.ParseText(MWJGIAQCXIPFIKMQXEXJCCRWSUNXQRIFRHAIKL)
                                           .WithFilePath(WVVSNQDRNFQHOQSKMGTSGXMSPURIVXFANGKAD);

            String FUPHAGIDGSCGOCXXJLEFKLRQKDNCCTKCOXXOUEJJ= @"..\..\ClassRewriter.cs";
            String CCSPJSTBGLUMIFXRCWUVRFAKHXQPDIDFBSCIRBHPH= @"..\..\ClassRewriterOBF.cs";
            String MTPWWSIAGMWHMQUBHIJCEWWIPKOCOABPENFJJMIFIO= File.ReadAllText(FUPHAGIDGSCGOCXXJLEFKLRQKDNCCTKCOXXOUEJJ);
            SyntaxTree UUFVNBFHKRVNDNVGGLDFKFKGCWLLQSXDSNBCDSVMUHO=
                           CSharpSyntaxTree.ParseText(MTPWWSIAGMWHMQUBHIJCEWWIPKOCOABPENFJJMIFIO)
                                           .WithFilePath(CCSPJSTBGLUMIFXRCWUVRFAKHXQPDIDFBSCIRBHPH);

            String HSPKPMCGVBCEPJWSPNSOPSRTOMTDMOPJDPDMLMUXNMBC= @"..\..\ConstructorRewriter.cs";
            String QJKQEXFXBQWNATTCQXSHKQBXGKGDRTBDQPDECCWMIPHLR= @"..\..\ConstructorRewriterOBF.cs";
            String NMPQRGOSSPXIKKSQCGGOTUIQPANBFWSJOGQWPLXNLIWAEU= File.ReadAllText(HSPKPMCGVBCEPJWSPNSOPSRTOMTDMOPJDPDMLMUXNMBC);
            SyntaxTree PQDTGJBUVQDXBRRMMTUNSERUBPGRDKWIMSJUVKQIIRIXSPJ=
                           CSharpSyntaxTree.ParseText(NMPQRGOSSPXIKKSQCGGOTUIQPANBFWSJOGQWPLXNLIWAEU)
                                           .WithFilePath(QJKQEXFXBQWNATTCQXSHKQBXGKGDRTBDQPDECCWMIPHLR);

            String GUWUCDOCKWHRODIQLSTKGHUPCCMFAUSBJFAUFOTEVPXWNQBF= @"..\..\VariableRewriter.cs";
            String ABVFXFDWXHRXPJCNEGIJCLLUWOMPIVBJAGEWXNBECBUVUTNMN= @"..\..\VariableRewriterOBF.cs";
            String JRHIQDNNAGJQLOCFIXJEDOPEDGAONXCAACXERBICPJXGPLOLSQ= File.ReadAllText(GUWUCDOCKWHRODIQLSTKGHUPCCMFAUSBJFAUFOTEVPXWNQBF);
            SyntaxTree MUEHJSCCEJCWAADJQJPVMGOGMSPJNPQNTVLFUQQEBOUWAQJWCGT=
                           CSharpSyntaxTree.ParseText(JRHIQDNNAGJQLOCFIXJEDOPEDGAONXCAACXERBICPJXGPLOLSQ)
                                           .WithFilePath(ABVFXFDWXHRXPJCNEGIJCLLUWOMPIVBJAGEWXNBECBUVUTNMN);
            SyntaxTree[] FUUDGGWSPDRNMRNDCNWNXQKUVJQGTJRGHUKQWRFXVVBBIAIEKNGJ= { KIFLIPHWMHBLCOAMPEKFFJF, BROTCRWLMPXLOCNRBNWFDEQWITO, SNAUGPOAFDUBESOJXNNLVHQVBLARHQV, UVMDEAVEIPGSOKWSLHLQIRLKMHEPGBQLSTW, VWUPQLCDMNRIOBLPAJFKLMKQKFAJLBKEFLGAMKK, UUFVNBFHKRVNDNVGGLDFKFKGCWLLQSXDSNBCDSVMUHO, PQDTGJBUVQDXBRRMMTUNSERUBPGRDKWIMSJUVKQIIRIXSPJ, MUEHJSCCEJCWAADJQJPVMGOGMSPJNPQNTVLFUQQEBOUWAQJWCGT };

            MetadataReference EQTNJAGUNPXGKKGQHVEJIWPCOJLUBLTGCHCOAVGVLJKFWTPVSPVNI=
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
            MetadataReference VAGBQWANJSBUQDCIQPKOHVXMJETRNCJOGVFHTMIWGIBOIJFQNNCAKX=
                    MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location);
            MetadataReference BXBSPMCGXHIKNTVTMDHLHWUIDXWDEAAJEGUGFBVTUXJSGVTKSSAWRXP=
                   MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location);
            MetadataReference[] CDQOPOXBWHWGGWPNLGLPINCBFELJKABPEPRDMKFFUVKKHPMLCEMQFIHN= { EQTNJAGUNPXGKKGQHVEJIWPCOJLUBLTGCHCOAVGVLJKFWTPVSPVNI, VAGBQWANJSBUQDCIQPKOHVXMJETRNCJOGVFHTMIWGIBOIJFQNNCAKX, BXBSPMCGXHIKNTVTMDHLHWUIDXWDEAAJEGUGFBVTUXJSGVTKSSAWRXP };

            return CSharpCompilation.Create("CodeObfuscation",
                                            FUUDGGWSPDRNMRNDCNWNXQKUVJQGTJRGHUKQWRFXVVBBIAIEKNGJ,
                                            CDQOPOXBWHWGGWPNLGLPINCBFELJKABPEPRDMKFFUVKKHPMLCEMQFIHN,
                                            new CSharpCompilationOptions(
                                                    OutputKind.ConsoleApplication));
        }
    }
}
