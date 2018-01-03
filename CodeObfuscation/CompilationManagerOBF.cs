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
    class KLJSRPOLQTIVLGVNWC    {
        public KLJSRPOLQTIVLGVNWC() { }
        public Compilation CFMKGGNJHCIWQJELCOP()
        {

            String KXUWXVDGFXHUUHWTMPXE= @"..\..\Program.cs";
            String CFHHLDSCWRADGWMCGHNND= @"..\..\ProgramOBF.cs";
            String AHJXGLOSOQUCJMEQNKTDAH= File.ReadAllText(KXUWXVDGFXHUUHWTMPXE);
            SyntaxTree MXENVSTNFBJBBWWHFPDHHAE=
                           CSharpSyntaxTree.ParseText(AHJXGLOSOQUCJMEQNKTDAH)
                                           .WithFilePath(CFHHLDSCWRADGWMCGHNND);

            String AUKIKQURKCQSJTQOTXALSRIK= @"..\..\CompilationManager.cs";
            String FRFFDXRAMTDQLKIUIHXWJDMMM= @"..\..\CompilationManagerOBF.cs";
            String BHIHNKHMXCQLONKJQGOPACJODC= File.ReadAllText(AUKIKQURKCQSJTQOTXALSRIK);
            SyntaxTree KRKBBFQRCQJQWJUELHQIRSMNQVV=
                           CSharpSyntaxTree.ParseText(BHIHNKHMXCQLONKJQGOPACJODC)
                                           .WithFilePath(FRFFDXRAMTDQLKIUIHXWJDMMM);

            String UMWVRDKXNBWALTVLRAXHETTPBWTI= @"..\..\SharedContainer.cs";
            String QEVIEHTFDSPNMJGCMGENUGSMQNQBQ= @"..\..\SharedContainerOBF.cs";
            String HTTICHIENUDXQHXJKTTMQCTRFMJKIQ= File.ReadAllText(UMWVRDKXNBWALTVLRAXHETTPBWTI);
            SyntaxTree OORMUXTFJCVWXKBNDWTDFSVMXEACCNV=
                           CSharpSyntaxTree.ParseText(HTTICHIENUDXQHXJKTTMQCTRFMJKIQ)
                                           .WithFilePath(QEVIEHTFDSPNMJGCMGENUGSMQNQBQ);

            String WUVGMFEKXNFJROSDJPQIKOEKUQEMQWRC= @"..\..\OccurrenceRewriter.cs";
            String TEXBBDMHXMTOAIEWFBPKKFLIPKJTAPSBT= @"..\..\OccurrenceRewriterOBF.cs";
            String CNMPQBFDIJWSOJLMGHPHHQOROKORQGHSSS= File.ReadAllText(WUVGMFEKXNFJROSDJPQIKOEKUQEMQWRC);
            SyntaxTree WSPGMXJGCTMOABWHSIDRMKWTAGKLKBBEXUL=
                           CSharpSyntaxTree.ParseText(CNMPQBFDIJWSOJLMGHPHHQOROKORQGHSSS)
                                           .WithFilePath(TEXBBDMHXMTOAIEWFBPKKFLIPKJTAPSBT);
            SyntaxTree[] RUXSPVAOSEAKNTJMXOAFLTTGGNWUASIODNEK= { MXENVSTNFBJBBWWHFPDHHAE, KRKBBFQRCQJQWJUELHQIRSMNQVV, OORMUXTFJCVWXKBNDWTDFSVMXEACCNV, WSPGMXJGCTMOABWHSIDRMKWTAGKLKBBEXUL };

            MetadataReference SOMUMTDPXUUPBMCNWOAVBRLBWDNAUKGAOXSIC=
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
            MetadataReference ERPPEGKQGTLQSPNNHJACKVIGDTNNUACSRKSVIF=
                    MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location);
            MetadataReference ULBIPIBIBSRLHNRGQGJJMJQUUGRRWIUPFBMNBBF=
                   MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location);
            MetadataReference[] XETRTUIRMAKSMMWRLSELJPIJRVBGGBDFOAJFQPVX= { SOMUMTDPXUUPBMCNWOAVBRLBWDNAUKGAOXSIC, ERPPEGKQGTLQSPNNHJACKVIGDTNNUACSRKSVIF, ULBIPIBIBSRLHNRGQGJJMJQUUGRRWIUPFBMNBBF };

            return CSharpCompilation.Create("CodeObfuscation",
                                            RUXSPVAOSEAKNTJMXOAFLTTGGNWUASIODNEK,
                                            XETRTUIRMAKSMMWRLSELJPIJRVBGGBDFOAJFQPVX,
                                            new CSharpCompilationOptions(
                                                    OutputKind.ConsoleApplication));
        }
    }
}
