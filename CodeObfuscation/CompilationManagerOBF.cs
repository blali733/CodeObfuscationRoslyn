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
    class BITFNJFX    {
        public BITFNJFX() { }

        public void WVUWXHTKD(OBGNINJHRGAXUHQPWBSQJHJVFILETRQNGRNSOWSWMHMWKCQXHENBATFGPJIACFMXNKQDRVAXHTEBT.En_Priority[] prioritiesTablo) 
        {
            Tuple<Compilation, int> JJRUFDNSAQJ= HMCAGNLSJK();
            Array.Sort(prioritiesTablo);

            for (int VMQJWTHPBBTG= 0; VMQJWTHPBBTG < JJRUFDNSAQJ.Item2; VMQJWTHPBBTG++)
            {
                foreach (SyntaxTree sourceTree in JJRUFDNSAQJ.Item1.SyntaxTrees)
                {
                    SyntaxNode CHFDNTTIKDWUO= null;
                    foreach (OBGNINJHRGAXUHQPWBSQJHJVFILETRQNGRNSOWSWMHMWKCQXHENBATFGPJIACFMXNKQDRVAXHTEBT.En_Priority priority in prioritiesTablo)
                    {
                        CSharpSyntaxRewriter FBPTKMSSRJAKPI= OBGNINJHRGAXUHQPWBSQJHJVFILETRQNGRNSOWSWMHMWKCQXHENBATFGPJIACFMXNKQDRVAXHTEBT.LKDPLUPEONLLGDFORTGTNIAJNGKDNSEPDLDWFIPIVSXVEPKRSJNXVGFCKRCFKLPUIUITXHIJEVWSJC(priority, JJRUFDNSAQJ.Item1.GetSemanticModel(sourceTree));
                        if (FBPTKMSSRJAKPI != null)
                        {
                            if (CHFDNTTIKDWUO == null)
                            {
                                CHFDNTTIKDWUO = FBPTKMSSRJAKPI.Visit(sourceTree.GetRoot());
                            }
                            else
                            {
                                CHFDNTTIKDWUO = FBPTKMSSRJAKPI.Visit(CHFDNTTIKDWUO);
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    File.WriteAllText(sourceTree.FilePath, CHFDNTTIKDWUO.ToFullString());
                }
            }
        }
        private Tuple<Compilation, int> HMCAGNLSJK()
        {

            String REDIINCOMXXAXFH= @"..\..\Program.cs";
            String XSNTSRSPUPNAMIVF= @"..\..\ProgramOBF.cs";
            String RVLCEHSOGMOMPUJNN= File.ReadAllText(REDIINCOMXXAXFH);
            SyntaxTree KSPKOVOWMGRTMNFPSF=
                           CSharpSyntaxTree.ParseText(RVLCEHSOGMOMPUJNN)
                                           .WithFilePath(XSNTSRSPUPNAMIVF);

            String DMDDPAXNGCGAAFALBNG= @"..\..\CompilationManager.cs";
            String TDXUEPAASRWIUVOFAKHD= @"..\..\CompilationManagerOBF.cs";
            String PKAPMPLGMTBMQJWCDQXLP= File.ReadAllText(DMDDPAXNGCGAAFALBNG);
            SyntaxTree XETHRJDKAXBSKPICIIMDRM=
                           CSharpSyntaxTree.ParseText(PKAPMPLGMTBMQJWCDQXLP)
                                           .WithFilePath(TDXUEPAASRWIUVOFAKHD);

            String XQKQLWLBIKTLPFFHSFIUMTX= @"..\..\SharedContainer.cs";
            String SFROATIKHVLFDVAVEWWPOWXX= @"..\..\SharedContainerOBF.cs";
            String CUANGTUAEQPLRIKGAAMNDACJR= File.ReadAllText(XQKQLWLBIKTLPFFHSFIUMTX);
            SyntaxTree HEWODJTGSLDSSDMBLAKFNETLPP=
                           CSharpSyntaxTree.ParseText(CUANGTUAEQPLRIKGAAMNDACJR)
                                           .WithFilePath(SFROATIKHVLFDVAVEWWPOWXX);

            String OKJUBSPUXOWKAHUFXVHMFUXMPAP= @"..\..\OccurrenceRewriter.cs";
            String DEDIKWMSJUVJIDWEVCBADJHEWECJ= @"..\..\OccurrenceRewriterOBF.cs";
            String SKVEBCLPTFMLLMKJBLWJHPBJNXLSU= File.ReadAllText(OKJUBSPUXOWKAHUFXVHMFUXMPAP);
            SyntaxTree XJFTDAXXQIGPGJQOOMPWWCLFRBCILO=
                           CSharpSyntaxTree.ParseText(SKVEBCLPTFMLLMKJBLWJHPBJNXLSU)
                                           .WithFilePath(DEDIKWMSJUVJIDWEVCBADJHEWECJ);

            String COQSUUGPILLKICQRBGJTXKUTWUWXCBV= @"..\..\MethodRewriter.cs";
            String PLCFPWLMUHWEDLMRINAXUWPPPSVUXVGN= @"..\..\MethodRewriterOBF.cs";
            String GNUWGVBSORNLBFRHKDNKBCBQTLOUBONWB= File.ReadAllText(COQSUUGPILLKICQRBGJTXKUTWUWXCBV);
            SyntaxTree IWNPNKLMFJCIDNJBNKTIULEMDDTGERXDPK=
                           CSharpSyntaxTree.ParseText(GNUWGVBSORNLBFRHKDNKBCBQTLOUBONWB)
                                           .WithFilePath(PLCFPWLMUHWEDLMRINAXUWPPPSVUXVGN);

            String QHDPUQBWUQWHPVETLESNFVRBMKOEHLJWRRV= @"..\..\ClassRewriter.cs";
            String CVVNCGWPLNTLWCIGTJBFTOCDKCVOIGXOWXCV= @"..\..\ClassRewriterOBF.cs";
            String NOPHGFFLQWQCXFONPLCLTSDAIHGENENXAKQES= File.ReadAllText(QHDPUQBWUQWHPVETLESNFVRBMKOEHLJWRRV);
            SyntaxTree RWNIOLLJTODQKXLUOCTLOWWXBWLJRBMNJTVMND=
                           CSharpSyntaxTree.ParseText(NOPHGFFLQWQCXFONPLCLTSDAIHGENENXAKQES)
                                           .WithFilePath(CVVNCGWPLNTLWCIGTJBFTOCDKCVOIGXOWXCV);

            String EGQPNRDMCFBCKIVRDTXNHQXBQRCOGPBWHKVMSXJ= @"..\..\ConstructorRewriter.cs";
            String FUMTFHPPEPQQCMXUMHPXUONFLEDSXKIXDKSRSURR= @"..\..\ConstructorRewriterOBF.cs";
            String ACWWOXXKHOIEDANPGHHBEUPRGRMQSFCQNVWRPPOME= File.ReadAllText(EGQPNRDMCFBCKIVRDTXNHQXBQRCOGPBWHKVMSXJ);
            SyntaxTree RLJBETCVCKKMPMEKFPVKGPBMQPFCTXPQTULJGPCVKT=
                           CSharpSyntaxTree.ParseText(ACWWOXXKHOIEDANPGHHBEUPRGRMQSFCQNVWRPPOME)
                                           .WithFilePath(FUMTFHPPEPQQCMXUMHPXUONFLEDSXKIXDKSRSURR);

            String PSPDWJSHKXRCWBJUJNOABDTRRSBSDNMAALAGUMQUIMM= @"..\..\VariableRewriter.cs";
            String QXQWKAKFNGJRMXVKDIXDVKQCLBCAUUSQNODSATOSRHXR= @"..\..\VariableRewriterOBF.cs";
            String ORLHWCNMIIPFGOLJVJIRMREVUDJHREKNLXLRNTBSGGHFX= File.ReadAllText(PSPDWJSHKXRCWBJUJNOABDTRRSBSDNMAALAGUMQUIMM);
            SyntaxTree VLKIFUHWFEUNNKTRGSEWBRHCSTCIOLGKWWWQXXLHCOGSOE=
                           CSharpSyntaxTree.ParseText(ORLHWCNMIIPFGOLJVJIRMREVUDJHREKNLXLRNTBSGGHFX)
                                           .WithFilePath(QXQWKAKFNGJRMXVKDIXDVKQCLBCAUUSQNODSATOSRHXR);

           /* String typeInferenceRewriterPath = @"..\..\TypeInferenceRewriter.cs";
            String typeInferenceRewriterDestinationPath = @"..\..\TypeInferenceRewriterOBF.cs";
            String typeInferenceRewriterText = File.ReadAllText(typeInferenceRewriterPath);
            SyntaxTree typeInferenceRewriterTree =
                           CSharpSyntaxTree.ParseText(typeInferenceRewriterText)
                                           .WithFilePath(typeInferenceRewriterDestinationPath);*/

            String XIGAALCHVEEHOKSXISVKOPLDSGHUTLLMMNURCNKTHPASLPI= @"..\..\Priority.cs";
            String BNDGLVENHUCGREFLKQPTAOAVSICCWPQPCWGHQFXPIXMVXHQP= @"..\..\PriorityOBF.cs";
            String BEOCTUIKMGLDSBPQELETWWTEQALACDVLPLBSAOTFNTSJRUUGI= File.ReadAllText(XIGAALCHVEEHOKSXISVKOPLDSGHUTLLMMNURCNKTHPASLPI);
            SyntaxTree TRMCVRDIJJTJHIJIAMGXUQNPWFCDKLUDEQGKJISSVKOFATGKJA=
                           CSharpSyntaxTree.ParseText(BEOCTUIKMGLDSBPQELETWWTEQALACDVLPLBSAOTFNTSJRUUGI)
                                           .WithFilePath(BNDGLVENHUCGREFLKQPTAOAVSICCWPQPCWGHQFXPIXMVXHQP);

            SyntaxTree[] QHNGLDDUDPOXWWMPFPCXXQSMBKBIPDXQSJSMOVEDGMECEWLQQJO= {KSPKOVOWMGRTMNFPSF, XETHRJDKAXBSKPICIIMDRM, HEWODJTGSLDSSDMBLAKFNETLPP, XJFTDAXXQIGPGJQOOMPWWCLFRBCILO, IWNPNKLMFJCIDNJBNKTIULEMDDTGERXDPK, RWNIOLLJTODQKXLUOCTLOWWXBWLJRBMNJTVMND, RLJBETCVCKKMPMEKFPVKGPBMQPFCTXPQTULJGPCVKT, VLKIFUHWFEUNNKTRGSEWBRHCSTCIOLGKWWWQXXLHCOGSOE/*, typeInferenceRewriterTree*/, TRMCVRDIJJTJHIJIAMGXUQNPWFCDKLUDEQGKJISSVKOFATGKJA};

            MetadataReference PHJBANBEABTFAQVENDABIKXQLLPIDXJPFMIIJIRXMQEBKGDKGRWM=
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
            MetadataReference QHFEIQNNVQBBQDXMHMTEKBMPGVGEIFCJAUXVGDXQSEBUOCJGGPCRV=
                    MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location);
            MetadataReference SCOTOWLKIFQOPBTECFEMDKFXQBDLXVQDIMGRICQFMFJXJFXBNCEKWE=
                   MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location);
            MetadataReference[] SHVPDMTXLKMMGDSBTXMWAVAGOKBBWURGEDRWURWDKMSWKUXUGLHEWXE= { PHJBANBEABTFAQVENDABIKXQLLPIDXJPFMIIJIRXMQEBKGDKGRWM, QHFEIQNNVQBBQDXMHMTEKBMPGVGEIFCJAUXVGDXQSEBUOCJGGPCRV, SCOTOWLKIFQOPBTECFEMDKFXQBDLXVQDIMGRICQFMFJXJFXBNCEKWE };

            return Tuple.Create(CSharpCompilation.Create("CodeObfuscation",
                                            QHNGLDDUDPOXWWMPFPCXXQSMBKBIPDXQSJSMOVEDGMECEWLQQJO,
                                            SHVPDMTXLKMMGDSBTXMWAVAGOKBBWURGEDRWURWDKMSWKUXUGLHEWXE,
                                            new CSharpCompilationOptions(
                                                    OutputKind.ConsoleApplication)) as Compilation, QHNGLDDUDPOXWWMPFPCXXQSMBKBIPDXQSJSMOVEDGMECEWLQQJO.Count());
        }
    }
}
