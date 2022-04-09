using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Grammar;

namespace csharp_project
{
    public class MyVisitor : Grammar.ISimpleGrammarVisitor<object>
    {
        public object Visit(IParseTree tree)
        {
            throw new System.NotImplementedException();
        }

        public object VisitChildren(IRuleNode node)
        {
            throw new System.NotImplementedException();
        }

        public object VisitErrorNode(IErrorNode node)
        {
            throw new System.NotImplementedException();
        }

        public object VisitExpr([NotNull] SimpleGrammarParser.ExprContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitFact([NotNull] SimpleGrammarParser.FactContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitTerm([NotNull] SimpleGrammarParser.TermContext context)
        {
            throw new System.NotImplementedException();
        }

        public object VisitTerminal(ITerminalNode node)
        {
            throw new System.NotImplementedException();
        }
    }
}