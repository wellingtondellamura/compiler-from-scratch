using System.IO;
using System;
using Antlr4.Runtime;

namespace csharp_project
{
    public class MyErrorListener:BaseErrorListener
    {
        public override void SyntaxError(TextWriter output, 
                                        IRecognizer recognizer, 
                                        IToken offendingSymbol, 
                                        int line, int charPositionInLine, 
                                        string msg, 
                                        RecognitionException e)
        {
            Console.WriteLine($"Erro na linha {line} e posição {charPositionInLine}. Não era esperado o símbolo {offendingSymbol.Text}");
        }
    }
    
}