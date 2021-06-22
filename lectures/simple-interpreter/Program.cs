using System;

namespace simple_interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var strProgram = "x = 2 + 2;" + '\n' +
                             "y = 2 / 10;" + '\n' +
                             "z = x + y;" + '\n' +
                             "print(z);";

            var lexer = new SimpleLexer(strProgram);
            var parser = new SimpleParser(lexer);
            // try {
                var res = parser.Expr();
                //Console.WriteLine(parser.Output);
                Console.WriteLine(res);
            // } catch (Exception e) {
            //     Console.WriteLine("Error: "+ e.Message);
            // }
        }

        private static void TestLexer(SimpleLexer lexer)
        {
            while (lexer.HasInput)
            {
                var token = lexer.NextToken();
                Console.WriteLine("<"+token.Type+ (token.HasValue?","+token.Attribute.Value:"")+">");
            }
        }
    }
}