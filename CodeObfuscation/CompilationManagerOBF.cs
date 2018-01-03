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
    class HOAaPyzH    {
        public HOAaPyzH() { }

        public void uaOJKpkgD(GKqFtTINKPrntpRJhRBwOSCQbQLMRRdRvsdBlyTtvNMAgPeMDGwLmlpfHIILHcvztJClvQRJnWyAGCtojnIKlwSDBnzaVI.En_Priority[] prioritiesTablo) 
        {
            Tuple<Compilation, int> xGSeiEEXwMg= byVMvQqgfS();
            Array.Sort(prioritiesTablo);

            for (int KcKowhWbBEbR= 0; KcKowhWbBEbR < xGSeiEEXwMg.Item2; KcKowhWbBEbR++)
            {
                foreach (SyntaxTree sourceTree in xGSeiEEXwMg.Item1.SyntaxTrees)
                {
                    SyntaxNode jhQLiLbwcrKmB= null;
                    foreach (GKqFtTINKPrntpRJhRBwOSCQbQLMRRdRvsdBlyTtvNMAgPeMDGwLmlpfHIILHcvztJClvQRJnWyAGCtojnIKlwSDBnzaVI.En_Priority priority in prioritiesTablo)
                    {
                        var MHpEGKPwPdaKyU= GKqFtTINKPrntpRJhRBwOSCQbQLMRRdRvsdBlyTtvNMAgPeMDGwLmlpfHIILHcvztJClvQRJnWyAGCtojnIKlwSDBnzaVI.UARSVtNaPdhPNeMouFywVIfsBDknjbWpghBypgumTGoVVeLkjSSgEcdMNoQSfOzROFrXqpmlwuGPwPNwkmHVyaylChQBWLL(priority, xGSeiEEXwMg.Item1.GetSemanticModel(sourceTree));
                        if (MHpEGKPwPdaKyU != null)
                        {
                            if (jhQLiLbwcrKmB == null)
                            {
                                jhQLiLbwcrKmB = MHpEGKPwPdaKyU.Visit(sourceTree.GetRoot());
                            }
                            else
                            {
                                jhQLiLbwcrKmB = MHpEGKPwPdaKyU.Visit(jhQLiLbwcrKmB);
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    File.WriteAllText(sourceTree.FilePath, jhQLiLbwcrKmB.ToFullString());
                }
            }
        }
        private Tuple<Compilation, int> byVMvQqgfS()
        {

            var rCjsNbgtfOlXLtd= @"..\..\Program.cs";
            var loaLiNigzcxikwCo= @"..\..\ProgramOBF.cs";
            var BBjUXFlvBMpUTLonf= File.ReadAllText(rCjsNbgtfOlXLtd);
            var hWEmnnHcOvjTPbDsik=
                           CSharpSyntaxTree.ParseText(BBjUXFlvBMpUTLonf)
                                           .WithFilePath(loaLiNigzcxikwCo);

            var WVHNdjgJSyLTiMczBCb= @"..\..\CompilationManager.cs";
            var oCCpwJIBrsPuafUKryed= @"..\..\CompilationManagerOBF.cs";
            var OLgurpxOrXWcAfmgUfoEt= File.ReadAllText(WVHNdjgJSyLTiMczBCb);
            var gLqCneiLCSNwQpUNVFkOzq=
                           CSharpSyntaxTree.ParseText(OLgurpxOrXWcAfmgUfoEt)
                                           .WithFilePath(oCCpwJIBrsPuafUKryed);

            var DNTyvgijhbWHeAOrtGMDwFI= @"..\..\SharedContainer.cs";
            var UaEtwnikhaNHKpTyzuMtQCIG= @"..\..\SharedContainerOBF.cs";
            var TnzraBjmnEmxlJFkIGoXMzDxJ= File.ReadAllText(DNTyvgijhbWHeAOrtGMDwFI);
            var eSWNelRebIeEEGfxOJGaqfaqUU=
                           CSharpSyntaxTree.ParseText(TnzraBjmnEmxlJFkIGoXMzDxJ)
                                           .WithFilePath(UaEtwnikhaNHKpTyzuMtQCIG);

            var KUaxexmRHpRdWMiSxAyfDmcybab= @"..\..\OccurrenceRewriter.cs";
            var KahanlFobkDiiFdmEetdzCGzpxpR= @"..\..\OccurrenceRewriterOBF.cs";
            var LwFblvgoSnTzQyaejSbiQmjCSbEIt= File.ReadAllText(KUaxexmRHpRdWMiSxAyfDmcybab);
            var cADJgVWsGhaQEiFHsUNRyCObBALaDt=
                           CSharpSyntaxTree.ParseText(LwFblvgoSnTzQyaejSbiQmjCSbEIt)
                                           .WithFilePath(KahanlFobkDiiFdmEetdzCGzpxpR);

            var cluDWnParIMkayNPMSscoejjmlsGHgJ= @"..\..\MethodRewriter.cs";
            var forzksAIHkBlFFgSspdfzmIcSCjEuMJr= @"..\..\MethodRewriterOBF.cs";
            var hnqIHdVyMJrDiasaLqAWUAQgXiqhcctxo= File.ReadAllText(cluDWnParIMkayNPMSscoejjmlsGHgJ);
            var XCGuyKmMHqpVFNaRGzFLfGgodseLoaRioV=
                           CSharpSyntaxTree.ParseText(hnqIHdVyMJrDiasaLqAWUAQgXiqhcctxo)
                                           .WithFilePath(forzksAIHkBlFFgSspdfzmIcSCjEuMJr);

            var IitDoNBJNeoQSRjVhCWpcROXxzafuWHCgpF= @"..\..\ClassRewriter.cs";
            var DgCKlKrlMmTQIVKcOImwjRFJgtNykSuraLdp= @"..\..\ClassRewriterOBF.cs";
            var dkuWSwBXqreQUrlzhIPdpzWNbbBzTlibarIXt= File.ReadAllText(IitDoNBJNeoQSRjVhCWpcROXxzafuWHCgpF);
            var rHOPiaKCvJNedgecAmzTQwUqHEocyolSTPMAAU=
                           CSharpSyntaxTree.ParseText(dkuWSwBXqreQUrlzhIPdpzWNbbBzTlibarIXt)
                                           .WithFilePath(DgCKlKrlMmTQIVKcOImwjRFJgtNykSuraLdp);

            var CJLKAgfRpEFBarPDLBfjHeCPXOQxGUwexybaHFw= @"..\..\ConstructorRewriter.cs";
            var odjUtjrbOCPDKMKMwGvfsVlLMttGEuivGeFERFXq= @"..\..\ConstructorRewriterOBF.cs";
            var cQBlkRONaRVrLSjKztImLVzaVTbaHGcTpVkSTAUxN= File.ReadAllText(CJLKAgfRpEFBarPDLBfjHeCPXOQxGUwexybaHFw);
            var PVfIEafdcKgbXMXXRUVUuGtWCzheVjlINdvAGwQaJn=
                           CSharpSyntaxTree.ParseText(cQBlkRONaRVrLSjKztImLVzaVTbaHGcTpVkSTAUxN)
                                           .WithFilePath(odjUtjrbOCPDKMKMwGvfsVlLMttGEuivGeFERFXq);

            var McGWJIRcCynqpIzOGKxLOERupfQXQkEfLixpPuaiIeg= @"..\..\VariableRewriter.cs";
            var NKgDgGkTFhbaHrwgWlxyKwKNBOJneeNDgPETxptQqWnn= @"..\..\VariableRewriterOBF.cs";
            var NbdFhkMhOvtfAwBXbllywxvlXGzgNrEfrMAErEIaOqgkf= File.ReadAllText(McGWJIRcCynqpIzOGKxLOERupfQXQkEfLixpPuaiIeg);
            var QTToETiuSWTAxopnXwfljKgwvclaHPBFFEGfXGJHXHIhuD=
                           CSharpSyntaxTree.ParseText(NbdFhkMhOvtfAwBXbllywxvlXGzgNrEfrMAErEIaOqgkf)
                                           .WithFilePath(NKgDgGkTFhbaHrwgWlxyKwKNBOJneeNDgPETxptQqWnn);

            var pVwdjmBmbGuxsIrbWDVNchecqQPySoBnxlMUIVqCDFHAGyV= @"..\..\TypeInferenceRewriter.cs";
            var AuesFSRIzcyMXpVuOEoAlvGgBtSJhoegccPmkbvyeaSwtJBS= @"..\..\TypeInferenceRewriterOBF.cs";
            var owlcqyyEXfarmISLTjQtSWgRHCXHriKleArOhuOPQKwEMSuSQ= File.ReadAllText(pVwdjmBmbGuxsIrbWDVNchecqQPySoBnxlMUIVqCDFHAGyV);
            var HFflWAJdwfVFVrlrlAmuDVheAMHvaEhWEjUwWmEmRtOllKxpor=
                           CSharpSyntaxTree.ParseText(owlcqyyEXfarmISLTjQtSWgRHCXHriKleArOhuOPQKwEMSuSQ)
                                           .WithFilePath(AuesFSRIzcyMXpVuOEoAlvGgBtSJhoegccPmkbvyeaSwtJBS);

            var USufNsQLkKlNBUnmBuGQElvmNqHvpjRqNHpUkRrsJLIzHErzxzJ= @"..\..\Priority.cs";
            var NePWtWiqgrTrAzSmxdtHpCVHlpClIbOCjiDbbaFnKlgHjaIAgEoG= @"..\..\PriorityOBF.cs";
            var QswKEIuxThPkMRdShUBKiybkONQHwCDEOHdFGlzgDLtVevxXnhLSD= File.ReadAllText(USufNsQLkKlNBUnmBuGQElvmNqHvpjRqNHpUkRrsJLIzHErzxzJ);
            var WwdgpvklWSRsLrFuiMvrMGTBwORSzJsjaAkoARWcBvilLsPThlQrOk=
                           CSharpSyntaxTree.ParseText(QswKEIuxThPkMRdShUBKiybkONQHwCDEOHdFGlzgDLtVevxXnhLSD)
                                           .WithFilePath(NePWtWiqgrTrAzSmxdtHpCVHlpClIbOCjiDbbaFnKlgHjaIAgEoG);

            SyntaxTree[] jQFsMTyWnMoeBKdXuOhAwQwrjjmnyBlIelKweOEDQynSJaaEpQLCgNQ= {hWEmnnHcOvjTPbDsik, gLqCneiLCSNwQpUNVFkOzq, eSWNelRebIeEEGfxOJGaqfaqUU, cADJgVWsGhaQEiFHsUNRyCObBALaDt, XCGuyKmMHqpVFNaRGzFLfGgodseLoaRioV, rHOPiaKCvJNedgecAmzTQwUqHEocyolSTPMAAU, PVfIEafdcKgbXMXXRUVUuGtWCzheVjlINdvAGwQaJn, QTToETiuSWTAxopnXwfljKgwvclaHPBFFEGfXGJHXHIhuD, HFflWAJdwfVFVrlrlAmuDVheAMHvaEhWEjUwWmEmRtOllKxpor, WwdgpvklWSRsLrFuiMvrMGTBwORSzJsjaAkoARWcBvilLsPThlQrOk};

            MetadataReference qktcWUizbTqAIAKvPJsacRGSFFxOMhjUNedanTopsdAnaaeEWUczCtUG=
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
            MetadataReference aJhQwQuIyEdiNenveCmJRHpVyjllzvRaFumguQHSFlSubxjcVmQAyLgee=
                    MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location);
            MetadataReference SfsXgPofCwprJQKxuDwgDXambUzuQEzkWLMyWcRrszcSGSMpFGmINfXxCs=
                   MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location);
            MetadataReference[] eSVCUbolEbEiWsdbCJtQltIKwKFsragRedSmFpWbdNNOyXpOWPaNPslbJLr= { qktcWUizbTqAIAKvPJsacRGSFFxOMhjUNedanTopsdAnaaeEWUczCtUG, aJhQwQuIyEdiNenveCmJRHpVyjllzvRaFumguQHSFlSubxjcVmQAyLgee, SfsXgPofCwprJQKxuDwgDXambUzuQEzkWLMyWcRrszcSGSMpFGmINfXxCs };

            return Tuple.Create(CSharpCompilation.Create("CodeObfuscation",
                                            jQFsMTyWnMoeBKdXuOhAwQwrjjmnyBlIelKweOEDQynSJaaEpQLCgNQ,
                                            eSVCUbolEbEiWsdbCJtQltIKwKFsragRedSmFpWbdNNOyXpOWPaNPslbJLr,
                                            new CSharpCompilationOptions(
                                                    OutputKind.ConsoleApplication)) as Compilation, jQFsMTyWnMoeBKdXuOhAwQwrjjmnyBlIelKweOEDQynSJaaEpQLCgNQ.Count());
        }
    }
}
