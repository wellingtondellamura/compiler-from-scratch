// Code generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8. DO NOT EDIT.

package Grammar // SimpleGrammar
import (
	"fmt"
	"reflect"
	"strconv"

	"github.com/antlr/antlr4/runtime/Go/antlr"
)

// Suppress unused import errors
var _ = fmt.Printf
var _ = reflect.Copy
var _ = strconv.Itoa


var parserATN = []uint16{
	3, 24715, 42794, 33075, 47597, 16764, 15335, 30598, 22884, 3, 14, 40, 4, 
	2, 9, 2, 4, 3, 9, 3, 4, 4, 9, 4, 4, 5, 9, 5, 3, 2, 3, 2, 3, 2, 6, 2, 14, 
	10, 2, 13, 2, 14, 2, 15, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 5, 3, 23, 10, 3, 
	3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 5, 4, 30, 10, 4, 3, 5, 3, 5, 3, 5, 3, 5, 
	3, 5, 3, 5, 5, 5, 38, 10, 5, 3, 5, 2, 2, 6, 2, 4, 6, 8, 2, 4, 3, 2, 9, 
	10, 3, 2, 6, 8, 2, 40, 2, 13, 3, 2, 2, 2, 4, 22, 3, 2, 2, 2, 6, 29, 3, 
	2, 2, 2, 8, 37, 3, 2, 2, 2, 10, 11, 5, 4, 3, 2, 11, 12, 7, 3, 2, 2, 12, 
	14, 3, 2, 2, 2, 13, 10, 3, 2, 2, 2, 14, 15, 3, 2, 2, 2, 15, 13, 3, 2, 2, 
	2, 15, 16, 3, 2, 2, 2, 16, 3, 3, 2, 2, 2, 17, 18, 5, 6, 4, 2, 18, 19, 9, 
	2, 2, 2, 19, 20, 5, 4, 3, 2, 20, 23, 3, 2, 2, 2, 21, 23, 5, 6, 4, 2, 22, 
	17, 3, 2, 2, 2, 22, 21, 3, 2, 2, 2, 23, 5, 3, 2, 2, 2, 24, 25, 5, 8, 5, 
	2, 25, 26, 9, 3, 2, 2, 26, 27, 5, 6, 4, 2, 27, 30, 3, 2, 2, 2, 28, 30, 
	5, 8, 5, 2, 29, 24, 3, 2, 2, 2, 29, 28, 3, 2, 2, 2, 30, 7, 3, 2, 2, 2, 
	31, 38, 7, 12, 2, 2, 32, 38, 7, 11, 2, 2, 33, 34, 7, 4, 2, 2, 34, 35, 5, 
	4, 3, 2, 35, 36, 7, 5, 2, 2, 36, 38, 3, 2, 2, 2, 37, 31, 3, 2, 2, 2, 37, 
	32, 3, 2, 2, 2, 37, 33, 3, 2, 2, 2, 38, 9, 3, 2, 2, 2, 6, 15, 22, 29, 37,
}
var deserializer = antlr.NewATNDeserializer(nil)
var deserializedATN = deserializer.DeserializeFromUInt16(parserATN)

var literalNames = []string{
	"", "';'", "'('", "')'", "'%'", "'/'", "'*'", "'-'", "'+'",
}
var symbolicNames = []string{
	"", "EOL", "OPEN", "CLOSE", "MOD", "DIV", "MUL", "SUB", "ADD", "NUM", "VAR", 
	"COMMENTS", "WS",
}

var ruleNames = []string{
	"prog", "expr", "term", "fact",
}
var decisionToDFA = make([]*antlr.DFA, len(deserializedATN.DecisionToState))

func init() {
	for index, ds := range deserializedATN.DecisionToState {
		decisionToDFA[index] = antlr.NewDFA(ds, index)
	}
}

type SimpleGrammarParser struct {
	*antlr.BaseParser
}

func NewSimpleGrammarParser(input antlr.TokenStream) *SimpleGrammarParser {
	this := new(SimpleGrammarParser)

	this.BaseParser = antlr.NewBaseParser(input)

	this.Interpreter = antlr.NewParserATNSimulator(this, deserializedATN, decisionToDFA, antlr.NewPredictionContextCache())
	this.RuleNames = ruleNames
	this.LiteralNames = literalNames
	this.SymbolicNames = symbolicNames
	this.GrammarFileName = "SimpleGrammar.g4"

	return this
}

// SimpleGrammarParser tokens.
const (
	SimpleGrammarParserEOF = antlr.TokenEOF
	SimpleGrammarParserEOL = 1
	SimpleGrammarParserOPEN = 2
	SimpleGrammarParserCLOSE = 3
	SimpleGrammarParserMOD = 4
	SimpleGrammarParserDIV = 5
	SimpleGrammarParserMUL = 6
	SimpleGrammarParserSUB = 7
	SimpleGrammarParserADD = 8
	SimpleGrammarParserNUM = 9
	SimpleGrammarParserVAR = 10
	SimpleGrammarParserCOMMENTS = 11
	SimpleGrammarParserWS = 12
)

// SimpleGrammarParser rules.
const (
	SimpleGrammarParserRULE_prog = 0
	SimpleGrammarParserRULE_expr = 1
	SimpleGrammarParserRULE_term = 2
	SimpleGrammarParserRULE_fact = 3
)

// IProgContext is an interface to support dynamic dispatch.
type IProgContext interface {
	antlr.ParserRuleContext

	// GetParser returns the parser.
	GetParser() antlr.Parser

	// IsProgContext differentiates from other interfaces.
	IsProgContext()
}

type ProgContext struct {
	*antlr.BaseParserRuleContext
	parser antlr.Parser
}

func NewEmptyProgContext() *ProgContext {
	var p = new(ProgContext)
	p.BaseParserRuleContext = antlr.NewBaseParserRuleContext(nil, -1)
	p.RuleIndex = SimpleGrammarParserRULE_prog
	return p
}

func (*ProgContext) IsProgContext() {}

func NewProgContext(parser antlr.Parser, parent antlr.ParserRuleContext, invokingState int) *ProgContext {
	var p = new(ProgContext)

	p.BaseParserRuleContext = antlr.NewBaseParserRuleContext(parent, invokingState)

	p.parser = parser
	p.RuleIndex = SimpleGrammarParserRULE_prog

	return p
}

func (s *ProgContext) GetParser() antlr.Parser { return s.parser }

func (s *ProgContext) AllExpr() []IExprContext {
	var ts = s.GetTypedRuleContexts(reflect.TypeOf((*IExprContext)(nil)).Elem())
	var tst = make([]IExprContext, len(ts))

	for i, t := range ts {
		if t != nil {
			tst[i] = t.(IExprContext)
		}
	}

	return tst
}

func (s *ProgContext) Expr(i int) IExprContext {
	var t = s.GetTypedRuleContext(reflect.TypeOf((*IExprContext)(nil)).Elem(), i)

	if t == nil {
		return nil
	}

	return t.(IExprContext)
}

func (s *ProgContext) AllEOL() []antlr.TerminalNode {
	return s.GetTokens(SimpleGrammarParserEOL)
}

func (s *ProgContext) EOL(i int) antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserEOL, i)
}

func (s *ProgContext) GetRuleContext() antlr.RuleContext {
	return s
}

func (s *ProgContext) ToStringTree(ruleNames []string, recog antlr.Recognizer) string {
	return antlr.TreesStringTree(s, ruleNames, recog)
}


func (s *ProgContext) EnterRule(listener antlr.ParseTreeListener) {
	if listenerT, ok := listener.(SimpleGrammarListener); ok {
		listenerT.EnterProg(s)
	}
}

func (s *ProgContext) ExitRule(listener antlr.ParseTreeListener) {
	if listenerT, ok := listener.(SimpleGrammarListener); ok {
		listenerT.ExitProg(s)
	}
}

func (s *ProgContext) Accept(visitor antlr.ParseTreeVisitor) interface{} {
	switch t := visitor.(type) {
	case SimpleGrammarVisitor:
		return t.VisitProg(s)

	default:
		return t.VisitChildren(s)
	}
}




func (p *SimpleGrammarParser) Prog() (localctx IProgContext) {
	localctx = NewProgContext(p, p.GetParserRuleContext(), p.GetState())
	p.EnterRule(localctx, 0, SimpleGrammarParserRULE_prog)
	var _la int


	defer func() {
		p.ExitRule()
	}()

	defer func() {
		if err := recover(); err != nil {
			if v, ok := err.(antlr.RecognitionException); ok {
				localctx.SetException(v)
				p.GetErrorHandler().ReportError(p, v)
				p.GetErrorHandler().Recover(p, v)
			} else {
				panic(err)
			}
		}
	}()

	p.EnterOuterAlt(localctx, 1)
	p.SetState(11)
	p.GetErrorHandler().Sync(p)
	_la = p.GetTokenStream().LA(1)


	for ok := true; ok; ok = (((_la) & -(0x1f+1)) == 0 && ((1 << uint(_la)) & ((1 << SimpleGrammarParserOPEN) | (1 << SimpleGrammarParserNUM) | (1 << SimpleGrammarParserVAR))) != 0) {
		{
			p.SetState(8)
			p.Expr()
		}
		{
			p.SetState(9)
			p.Match(SimpleGrammarParserEOL)
		}


		p.SetState(13)
		p.GetErrorHandler().Sync(p)
		_la = p.GetTokenStream().LA(1)
	}



	return localctx
}


// IExprContext is an interface to support dynamic dispatch.
type IExprContext interface {
	antlr.ParserRuleContext

	// GetParser returns the parser.
	GetParser() antlr.Parser

	// IsExprContext differentiates from other interfaces.
	IsExprContext()
}

type ExprContext struct {
	*antlr.BaseParserRuleContext
	parser antlr.Parser
}

func NewEmptyExprContext() *ExprContext {
	var p = new(ExprContext)
	p.BaseParserRuleContext = antlr.NewBaseParserRuleContext(nil, -1)
	p.RuleIndex = SimpleGrammarParserRULE_expr
	return p
}

func (*ExprContext) IsExprContext() {}

func NewExprContext(parser antlr.Parser, parent antlr.ParserRuleContext, invokingState int) *ExprContext {
	var p = new(ExprContext)

	p.BaseParserRuleContext = antlr.NewBaseParserRuleContext(parent, invokingState)

	p.parser = parser
	p.RuleIndex = SimpleGrammarParserRULE_expr

	return p
}

func (s *ExprContext) GetParser() antlr.Parser { return s.parser }

func (s *ExprContext) Term() ITermContext {
	var t = s.GetTypedRuleContext(reflect.TypeOf((*ITermContext)(nil)).Elem(), 0)

	if t == nil {
		return nil
	}

	return t.(ITermContext)
}

func (s *ExprContext) Expr() IExprContext {
	var t = s.GetTypedRuleContext(reflect.TypeOf((*IExprContext)(nil)).Elem(), 0)

	if t == nil {
		return nil
	}

	return t.(IExprContext)
}

func (s *ExprContext) ADD() antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserADD, 0)
}

func (s *ExprContext) SUB() antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserSUB, 0)
}

func (s *ExprContext) GetRuleContext() antlr.RuleContext {
	return s
}

func (s *ExprContext) ToStringTree(ruleNames []string, recog antlr.Recognizer) string {
	return antlr.TreesStringTree(s, ruleNames, recog)
}


func (s *ExprContext) EnterRule(listener antlr.ParseTreeListener) {
	if listenerT, ok := listener.(SimpleGrammarListener); ok {
		listenerT.EnterExpr(s)
	}
}

func (s *ExprContext) ExitRule(listener antlr.ParseTreeListener) {
	if listenerT, ok := listener.(SimpleGrammarListener); ok {
		listenerT.ExitExpr(s)
	}
}

func (s *ExprContext) Accept(visitor antlr.ParseTreeVisitor) interface{} {
	switch t := visitor.(type) {
	case SimpleGrammarVisitor:
		return t.VisitExpr(s)

	default:
		return t.VisitChildren(s)
	}
}




func (p *SimpleGrammarParser) Expr() (localctx IExprContext) {
	localctx = NewExprContext(p, p.GetParserRuleContext(), p.GetState())
	p.EnterRule(localctx, 2, SimpleGrammarParserRULE_expr)
	var _la int


	defer func() {
		p.ExitRule()
	}()

	defer func() {
		if err := recover(); err != nil {
			if v, ok := err.(antlr.RecognitionException); ok {
				localctx.SetException(v)
				p.GetErrorHandler().ReportError(p, v)
				p.GetErrorHandler().Recover(p, v)
			} else {
				panic(err)
			}
		}
	}()

	p.SetState(20)
	p.GetErrorHandler().Sync(p)
	switch p.GetInterpreter().AdaptivePredict(p.GetTokenStream(), 1, p.GetParserRuleContext()) {
	case 1:
		p.EnterOuterAlt(localctx, 1)
		{
			p.SetState(15)
			p.Term()
		}
		{
			p.SetState(16)
			_la = p.GetTokenStream().LA(1)

			if !(_la == SimpleGrammarParserSUB || _la == SimpleGrammarParserADD) {
				p.GetErrorHandler().RecoverInline(p)
			} else {
				p.GetErrorHandler().ReportMatch(p)
				p.Consume()
			}
		}
		{
			p.SetState(17)
			p.Expr()
		}


	case 2:
		p.EnterOuterAlt(localctx, 2)
		{
			p.SetState(19)
			p.Term()
		}

	}


	return localctx
}


// ITermContext is an interface to support dynamic dispatch.
type ITermContext interface {
	antlr.ParserRuleContext

	// GetParser returns the parser.
	GetParser() antlr.Parser

	// IsTermContext differentiates from other interfaces.
	IsTermContext()
}

type TermContext struct {
	*antlr.BaseParserRuleContext
	parser antlr.Parser
}

func NewEmptyTermContext() *TermContext {
	var p = new(TermContext)
	p.BaseParserRuleContext = antlr.NewBaseParserRuleContext(nil, -1)
	p.RuleIndex = SimpleGrammarParserRULE_term
	return p
}

func (*TermContext) IsTermContext() {}

func NewTermContext(parser antlr.Parser, parent antlr.ParserRuleContext, invokingState int) *TermContext {
	var p = new(TermContext)

	p.BaseParserRuleContext = antlr.NewBaseParserRuleContext(parent, invokingState)

	p.parser = parser
	p.RuleIndex = SimpleGrammarParserRULE_term

	return p
}

func (s *TermContext) GetParser() antlr.Parser { return s.parser }

func (s *TermContext) Fact() IFactContext {
	var t = s.GetTypedRuleContext(reflect.TypeOf((*IFactContext)(nil)).Elem(), 0)

	if t == nil {
		return nil
	}

	return t.(IFactContext)
}

func (s *TermContext) Term() ITermContext {
	var t = s.GetTypedRuleContext(reflect.TypeOf((*ITermContext)(nil)).Elem(), 0)

	if t == nil {
		return nil
	}

	return t.(ITermContext)
}

func (s *TermContext) MUL() antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserMUL, 0)
}

func (s *TermContext) DIV() antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserDIV, 0)
}

func (s *TermContext) MOD() antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserMOD, 0)
}

func (s *TermContext) GetRuleContext() antlr.RuleContext {
	return s
}

func (s *TermContext) ToStringTree(ruleNames []string, recog antlr.Recognizer) string {
	return antlr.TreesStringTree(s, ruleNames, recog)
}


func (s *TermContext) EnterRule(listener antlr.ParseTreeListener) {
	if listenerT, ok := listener.(SimpleGrammarListener); ok {
		listenerT.EnterTerm(s)
	}
}

func (s *TermContext) ExitRule(listener antlr.ParseTreeListener) {
	if listenerT, ok := listener.(SimpleGrammarListener); ok {
		listenerT.ExitTerm(s)
	}
}

func (s *TermContext) Accept(visitor antlr.ParseTreeVisitor) interface{} {
	switch t := visitor.(type) {
	case SimpleGrammarVisitor:
		return t.VisitTerm(s)

	default:
		return t.VisitChildren(s)
	}
}




func (p *SimpleGrammarParser) Term() (localctx ITermContext) {
	localctx = NewTermContext(p, p.GetParserRuleContext(), p.GetState())
	p.EnterRule(localctx, 4, SimpleGrammarParserRULE_term)
	var _la int


	defer func() {
		p.ExitRule()
	}()

	defer func() {
		if err := recover(); err != nil {
			if v, ok := err.(antlr.RecognitionException); ok {
				localctx.SetException(v)
				p.GetErrorHandler().ReportError(p, v)
				p.GetErrorHandler().Recover(p, v)
			} else {
				panic(err)
			}
		}
	}()

	p.SetState(27)
	p.GetErrorHandler().Sync(p)
	switch p.GetInterpreter().AdaptivePredict(p.GetTokenStream(), 2, p.GetParserRuleContext()) {
	case 1:
		p.EnterOuterAlt(localctx, 1)
		{
			p.SetState(22)
			p.Fact()
		}
		{
			p.SetState(23)
			_la = p.GetTokenStream().LA(1)

			if !((((_la) & -(0x1f+1)) == 0 && ((1 << uint(_la)) & ((1 << SimpleGrammarParserMOD) | (1 << SimpleGrammarParserDIV) | (1 << SimpleGrammarParserMUL))) != 0)) {
				p.GetErrorHandler().RecoverInline(p)
			} else {
				p.GetErrorHandler().ReportMatch(p)
				p.Consume()
			}
		}
		{
			p.SetState(24)
			p.Term()
		}


	case 2:
		p.EnterOuterAlt(localctx, 2)
		{
			p.SetState(26)
			p.Fact()
		}

	}


	return localctx
}


// IFactContext is an interface to support dynamic dispatch.
type IFactContext interface {
	antlr.ParserRuleContext

	// GetParser returns the parser.
	GetParser() antlr.Parser

	// IsFactContext differentiates from other interfaces.
	IsFactContext()
}

type FactContext struct {
	*antlr.BaseParserRuleContext
	parser antlr.Parser
}

func NewEmptyFactContext() *FactContext {
	var p = new(FactContext)
	p.BaseParserRuleContext = antlr.NewBaseParserRuleContext(nil, -1)
	p.RuleIndex = SimpleGrammarParserRULE_fact
	return p
}

func (*FactContext) IsFactContext() {}

func NewFactContext(parser antlr.Parser, parent antlr.ParserRuleContext, invokingState int) *FactContext {
	var p = new(FactContext)

	p.BaseParserRuleContext = antlr.NewBaseParserRuleContext(parent, invokingState)

	p.parser = parser
	p.RuleIndex = SimpleGrammarParserRULE_fact

	return p
}

func (s *FactContext) GetParser() antlr.Parser { return s.parser }

func (s *FactContext) VAR() antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserVAR, 0)
}

func (s *FactContext) NUM() antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserNUM, 0)
}

func (s *FactContext) OPEN() antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserOPEN, 0)
}

func (s *FactContext) Expr() IExprContext {
	var t = s.GetTypedRuleContext(reflect.TypeOf((*IExprContext)(nil)).Elem(), 0)

	if t == nil {
		return nil
	}

	return t.(IExprContext)
}

func (s *FactContext) CLOSE() antlr.TerminalNode {
	return s.GetToken(SimpleGrammarParserCLOSE, 0)
}

func (s *FactContext) GetRuleContext() antlr.RuleContext {
	return s
}

func (s *FactContext) ToStringTree(ruleNames []string, recog antlr.Recognizer) string {
	return antlr.TreesStringTree(s, ruleNames, recog)
}


func (s *FactContext) EnterRule(listener antlr.ParseTreeListener) {
	if listenerT, ok := listener.(SimpleGrammarListener); ok {
		listenerT.EnterFact(s)
	}
}

func (s *FactContext) ExitRule(listener antlr.ParseTreeListener) {
	if listenerT, ok := listener.(SimpleGrammarListener); ok {
		listenerT.ExitFact(s)
	}
}

func (s *FactContext) Accept(visitor antlr.ParseTreeVisitor) interface{} {
	switch t := visitor.(type) {
	case SimpleGrammarVisitor:
		return t.VisitFact(s)

	default:
		return t.VisitChildren(s)
	}
}




func (p *SimpleGrammarParser) Fact() (localctx IFactContext) {
	localctx = NewFactContext(p, p.GetParserRuleContext(), p.GetState())
	p.EnterRule(localctx, 6, SimpleGrammarParserRULE_fact)

	defer func() {
		p.ExitRule()
	}()

	defer func() {
		if err := recover(); err != nil {
			if v, ok := err.(antlr.RecognitionException); ok {
				localctx.SetException(v)
				p.GetErrorHandler().ReportError(p, v)
				p.GetErrorHandler().Recover(p, v)
			} else {
				panic(err)
			}
		}
	}()

	p.SetState(35)
	p.GetErrorHandler().Sync(p)

	switch p.GetTokenStream().LA(1) {
	case SimpleGrammarParserVAR:
		p.EnterOuterAlt(localctx, 1)
		{
			p.SetState(29)
			p.Match(SimpleGrammarParserVAR)
		}


	case SimpleGrammarParserNUM:
		p.EnterOuterAlt(localctx, 2)
		{
			p.SetState(30)
			p.Match(SimpleGrammarParserNUM)
		}


	case SimpleGrammarParserOPEN:
		p.EnterOuterAlt(localctx, 3)
		{
			p.SetState(31)
			p.Match(SimpleGrammarParserOPEN)
		}
		{
			p.SetState(32)
			p.Expr()
		}
		{
			p.SetState(33)
			p.Match(SimpleGrammarParserCLOSE)
		}



	default:
		panic(antlr.NewNoViableAltException(p, nil, nil, nil, nil, nil))
	}


	return localctx
}


