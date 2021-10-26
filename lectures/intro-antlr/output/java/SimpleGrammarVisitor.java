// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
package Grammar;
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link SimpleGrammarParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface SimpleGrammarVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link SimpleGrammarParser#prog}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitProg(SimpleGrammarParser.ProgContext ctx);
	/**
	 * Visit a parse tree produced by {@link SimpleGrammarParser#expr}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitExpr(SimpleGrammarParser.ExprContext ctx);
	/**
	 * Visit a parse tree produced by {@link SimpleGrammarParser#term}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTerm(SimpleGrammarParser.TermContext ctx);
	/**
	 * Visit a parse tree produced by {@link SimpleGrammarParser#fact}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFact(SimpleGrammarParser.FactContext ctx);
}