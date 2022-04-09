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
            Console.Write("Entrada: ");
            var text = Console.ReadLine();
            
            AntlrInputStream inputStream = new AntlrInputStream(text);
            SimpleGrammarLexer lexer = new SimpleGrammarLexer(inputStream);

            BufferedTokenStream tokenStream = new BufferedTokenStream(lexer);
            SimpleGrammarParser parser = new SimpleGrammarParser(tokenStream);
            parser.RemoveErrorListeners();
            var el = new MyErrorListener();
            parser.AddErrorListener(el);
            var pl = new MyListener();
            parser.AddParseListener(pl);
            
            try {
                var expr = parser.expr();
                if (pl.SemanticErrors.Count > 0){
                    
                }
                if (el.HasErrors){

                }
                var visitor= new MyVisitor();
                visitor.Visit(expr);

                Console.WriteLine("Resultado: "+ expr.value);
            } catch(Exception e){
                Console.WriteLine("Erro Sintático:" + e.Message);
            }
        }
    }
}
