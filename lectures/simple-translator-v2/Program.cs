using System;

namespace simple_translator_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lexer = new SimpleLexer("225 + 968   - 78879    + 1564564");
            var parser = new SimpleParser(lexer);
            parser.Expr();
            Console.WriteLine(parser.Output);
            //TestLexer(lexer);
        }

        private static void TestLexer(SimpleLexer lexer)
        {
            while (lexer.HasInput)
            {
                var token = lexer.NextToken();
                Console.WriteLine("<"+token.Type+ (token.HasValue?","+token.Value:"")+">");
            }
        }
    }
}
