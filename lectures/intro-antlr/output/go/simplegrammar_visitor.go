// Code generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8. DO NOT EDIT.

package Grammar // SimpleGrammar
import "github.com/antlr/antlr4/runtime/Go/antlr"
// A complete Visitor for a parse tree produced by SimpleGrammarParser.
type SimpleGrammarVisitor interface {
	antlr.ParseTreeVisitor

	// Visit a parse tree produced by SimpleGrammarParser#prog.
	VisitProg(ctx *ProgContext) interface{}

	// Visit a parse tree produced by SimpleGrammarParser#expr.
	VisitExpr(ctx *ExprContext) interface{}

	// Visit a parse tree produced by SimpleGrammarParser#term.
	VisitTerm(ctx *TermContext) interface{}

	// Visit a parse tree produced by SimpleGrammarParser#fact.
	VisitFact(ctx *FactContext) interface{}

}