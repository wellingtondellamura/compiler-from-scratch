// Code generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8. DO NOT EDIT.

package Grammar // SimpleGrammar
import "github.com/antlr/antlr4/runtime/Go/antlr"

// BaseSimpleGrammarListener is a complete listener for a parse tree produced by SimpleGrammarParser.
type BaseSimpleGrammarListener struct{}

var _ SimpleGrammarListener = &BaseSimpleGrammarListener{}

// VisitTerminal is called when a terminal node is visited.
func (s *BaseSimpleGrammarListener) VisitTerminal(node antlr.TerminalNode) {}

// VisitErrorNode is called when an error node is visited.
func (s *BaseSimpleGrammarListener) VisitErrorNode(node antlr.ErrorNode) {}

// EnterEveryRule is called when any rule is entered.
func (s *BaseSimpleGrammarListener) EnterEveryRule(ctx antlr.ParserRuleContext) {}

// ExitEveryRule is called when any rule is exited.
func (s *BaseSimpleGrammarListener) ExitEveryRule(ctx antlr.ParserRuleContext) {}

// EnterProg is called when production prog is entered.
func (s *BaseSimpleGrammarListener) EnterProg(ctx *ProgContext) {}

// ExitProg is called when production prog is exited.
func (s *BaseSimpleGrammarListener) ExitProg(ctx *ProgContext) {}

// EnterExpr is called when production expr is entered.
func (s *BaseSimpleGrammarListener) EnterExpr(ctx *ExprContext) {}

// ExitExpr is called when production expr is exited.
func (s *BaseSimpleGrammarListener) ExitExpr(ctx *ExprContext) {}

// EnterTerm is called when production term is entered.
func (s *BaseSimpleGrammarListener) EnterTerm(ctx *TermContext) {}

// ExitTerm is called when production term is exited.
func (s *BaseSimpleGrammarListener) ExitTerm(ctx *TermContext) {}

// EnterFact is called when production fact is entered.
func (s *BaseSimpleGrammarListener) EnterFact(ctx *FactContext) {}

// ExitFact is called when production fact is exited.
func (s *BaseSimpleGrammarListener) ExitFact(ctx *FactContext) {}
