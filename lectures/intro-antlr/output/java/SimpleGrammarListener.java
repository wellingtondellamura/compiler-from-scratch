// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
package Grammar;
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link SimpleGrammarParser}.
 */
public interface SimpleGrammarListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link SimpleGrammarParser#prog}.
	 * @param ctx the parse tree
	 */
	void enterProg(SimpleGrammarParser.ProgContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleGrammarParser#prog}.
	 * @param ctx the parse tree
	 */
	void exitProg(SimpleGrammarParser.ProgContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleGrammarParser#expr}.
	 * @param ctx the parse tree
	 */
	void enterExpr(SimpleGrammarParser.ExprContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleGrammarParser#expr}.
	 * @param ctx the parse tree
	 */
	void exitExpr(SimpleGrammarParser.ExprContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleGrammarParser#term}.
	 * @param ctx the parse tree
	 */
	void enterTerm(SimpleGrammarParser.TermContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleGrammarParser#term}.
	 * @param ctx the parse tree
	 */
	void exitTerm(SimpleGrammarParser.TermContext ctx);
	/**
	 * Enter a parse tree produced by {@link SimpleGrammarParser#fact}.
	 * @param ctx the parse tree
	 */
	void enterFact(SimpleGrammarParser.FactContext ctx);
	/**
	 * Exit a parse tree produced by {@link SimpleGrammarParser#fact}.
	 * @param ctx the parse tree
	 */
	void exitFact(SimpleGrammarParser.FactContext ctx);
}