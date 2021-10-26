using Antlr4.Runtime.Misc;
using Grammar;
using System;
namespace csharp_project
{
    public class MyListener: SimpleGrammarBaseListener
    {
        public override void EnterFact([NotNull] SimpleGrammarParser.FactContext context)
        {
            Console.WriteLine("Entrou no fact");
        }

        public override void ExitFact([NotNull] SimpleGrammarParser.FactContext context)
        {
           Console.WriteLine("Saiu do Fact");
           Console.WriteLine(context.NUM().ToString());
        }
    }
}