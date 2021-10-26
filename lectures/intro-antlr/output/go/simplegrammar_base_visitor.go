// Code generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8. DO NOT EDIT.

package Grammar // SimpleGrammar
import "github.com/antlr/antlr4/runtime/Go/antlr"

type BaseSimpleGrammarVisitor struct {
	*antlr.BaseParseTreeVisitor
}

func (v *BaseSimpleGrammarVisitor) VisitProg(ctx *ProgContext) interface{} {
	return v.VisitChildren(ctx)
}

func (v *BaseSimpleGrammarVisitor) VisitExpr(ctx *ExprContext) interface{} {
	return v.VisitChildren(ctx)
}

func (v *BaseSimpleGrammarVisitor) VisitTerm(ctx *TermContext) interface{} {
	return v.VisitChildren(ctx)
}

func (v *BaseSimpleGrammarVisitor) VisitFact(ctx *FactContext) interface{} {
	return v.VisitChildren(ctx)
}
