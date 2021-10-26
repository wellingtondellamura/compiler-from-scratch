using System;
using System.IO;
using Antlr4.Runtime;
using Grammar;
namespace csharp_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "1  +2 ;";
            AntlrInputStream inputStream = new AntlrInputStream(text);
            SimpleGrammarLexer lexer = new SimpleGrammarLexer(inputStream);
            // var tokens = lexer.GetAllTokens();
            // foreach (var t in tokens)
            // {
            //     Console.WriteLine(t);
            // }
            BufferedTokenStream tokenStream = new BufferedTokenStream(lexer);
            SimpleGrammarParser parser = new SimpleGrammarParser(tokenStream);
            
            parser.AddParseListener(new MyListener());

            var prog = parser.prog();
        }
    }
}
