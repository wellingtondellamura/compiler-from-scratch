//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Grammar {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class SimpleGrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		EOL=1, OPEN=2, CLOSE=3, MOD=4, DIV=5, MUL=6, SUB=7, ADD=8, NUM=9, VAR=10, 
		COMMENTS=11, WS=12;
	public const int
		RULE_prog = 0, RULE_expr = 1, RULE_term = 2, RULE_fact = 3;
	public static readonly string[] ruleNames = {
		"prog", "expr", "term", "fact"
	};

	private static readonly string[] _LiteralNames = {
		null, "';'", "'('", "')'", "'%'", "'/'", "'*'", "'-'", "'+'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "EOL", "OPEN", "CLOSE", "MOD", "DIV", "MUL", "SUB", "ADD", "NUM", 
		"VAR", "COMMENTS", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "SimpleGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SimpleGrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public SimpleGrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public SimpleGrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgContext : ParserRuleContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ITerminalNode[] EOL() { return GetTokens(SimpleGrammarParser.EOL); }
		public ITerminalNode EOL(int i) {
			return GetToken(SimpleGrammarParser.EOL, i);
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISimpleGrammarListener typedListener = listener as ISimpleGrammarListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISimpleGrammarListener typedListener = listener as ISimpleGrammarListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISimpleGrammarVisitor<TResult> typedVisitor = visitor as ISimpleGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(Context, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 11;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 8; expr();
				State = 9; Match(EOL);
				}
				}
				State = 13;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << OPEN) | (1L << NUM) | (1L << VAR))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode ADD() { return GetToken(SimpleGrammarParser.ADD, 0); }
		public ITerminalNode SUB() { return GetToken(SimpleGrammarParser.SUB, 0); }
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISimpleGrammarListener typedListener = listener as ISimpleGrammarListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISimpleGrammarListener typedListener = listener as ISimpleGrammarListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISimpleGrammarVisitor<TResult> typedVisitor = visitor as ISimpleGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(Context, State);
		EnterRule(_localctx, 2, RULE_expr);
		int _la;
		try {
			State = 20;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 15; term();
				State = 16;
				_la = TokenStream.LA(1);
				if ( !(_la==SUB || _la==ADD) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 17; expr();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 19; term();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		public FactContext fact() {
			return GetRuleContext<FactContext>(0);
		}
		public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		public ITerminalNode MUL() { return GetToken(SimpleGrammarParser.MUL, 0); }
		public ITerminalNode DIV() { return GetToken(SimpleGrammarParser.DIV, 0); }
		public ITerminalNode MOD() { return GetToken(SimpleGrammarParser.MOD, 0); }
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISimpleGrammarListener typedListener = listener as ISimpleGrammarListener;
			if (typedListener != null) typedListener.EnterTerm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISimpleGrammarListener typedListener = listener as ISimpleGrammarListener;
			if (typedListener != null) typedListener.ExitTerm(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISimpleGrammarVisitor<TResult> typedVisitor = visitor as ISimpleGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTerm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		TermContext _localctx = new TermContext(Context, State);
		EnterRule(_localctx, 4, RULE_term);
		int _la;
		try {
			State = 27;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 22; fact();
				State = 23;
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MOD) | (1L << DIV) | (1L << MUL))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 24; term();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 26; fact();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FactContext : ParserRuleContext {
		public ITerminalNode VAR() { return GetToken(SimpleGrammarParser.VAR, 0); }
		public ITerminalNode NUM() { return GetToken(SimpleGrammarParser.NUM, 0); }
		public ITerminalNode OPEN() { return GetToken(SimpleGrammarParser.OPEN, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode CLOSE() { return GetToken(SimpleGrammarParser.CLOSE, 0); }
		public FactContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fact; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISimpleGrammarListener typedListener = listener as ISimpleGrammarListener;
			if (typedListener != null) typedListener.EnterFact(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISimpleGrammarListener typedListener = listener as ISimpleGrammarListener;
			if (typedListener != null) typedListener.ExitFact(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISimpleGrammarVisitor<TResult> typedVisitor = visitor as ISimpleGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFact(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FactContext fact() {
		FactContext _localctx = new FactContext(Context, State);
		EnterRule(_localctx, 6, RULE_fact);
		try {
			State = 35;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case VAR:
				EnterOuterAlt(_localctx, 1);
				{
				State = 29; Match(VAR);
				}
				break;
			case NUM:
				EnterOuterAlt(_localctx, 2);
				{
				State = 30; Match(NUM);
				}
				break;
			case OPEN:
				EnterOuterAlt(_localctx, 3);
				{
				State = 31; Match(OPEN);
				State = 32; expr();
				State = 33; Match(CLOSE);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\xE', '(', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x6', '\x2', '\xE', '\n', '\x2', '\r', 
		'\x2', '\xE', '\x2', '\xF', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '\x17', '\n', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', 
		'\x4', '\x1E', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '&', '\n', '\x5', 
		'\x3', '\x5', '\x2', '\x2', '\x6', '\x2', '\x4', '\x6', '\b', '\x2', '\x4', 
		'\x3', '\x2', '\t', '\n', '\x3', '\x2', '\x6', '\b', '\x2', '(', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x4', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '\x6', '\x1D', '\x3', '\x2', '\x2', '\x2', '\b', '%', '\x3', '\x2', 
		'\x2', '\x2', '\n', '\v', '\x5', '\x4', '\x3', '\x2', '\v', '\f', '\a', 
		'\x3', '\x2', '\x2', '\f', '\xE', '\x3', '\x2', '\x2', '\x2', '\r', '\n', 
		'\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\xF', '\r', '\x3', '\x2', '\x2', '\x2', '\xF', '\x10', '\x3', '\x2', 
		'\x2', '\x2', '\x10', '\x3', '\x3', '\x2', '\x2', '\x2', '\x11', '\x12', 
		'\x5', '\x6', '\x4', '\x2', '\x12', '\x13', '\t', '\x2', '\x2', '\x2', 
		'\x13', '\x14', '\x5', '\x4', '\x3', '\x2', '\x14', '\x17', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\x17', '\x5', '\x6', '\x4', '\x2', '\x16', '\x11', 
		'\x3', '\x2', '\x2', '\x2', '\x16', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x17', '\x5', '\x3', '\x2', '\x2', '\x2', '\x18', '\x19', '\x5', '\b', 
		'\x5', '\x2', '\x19', '\x1A', '\t', '\x3', '\x2', '\x2', '\x1A', '\x1B', 
		'\x5', '\x6', '\x4', '\x2', '\x1B', '\x1E', '\x3', '\x2', '\x2', '\x2', 
		'\x1C', '\x1E', '\x5', '\b', '\x5', '\x2', '\x1D', '\x18', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1E', '\a', 
		'\x3', '\x2', '\x2', '\x2', '\x1F', '&', '\a', '\f', '\x2', '\x2', ' ', 
		'&', '\a', '\v', '\x2', '\x2', '!', '\"', '\a', '\x4', '\x2', '\x2', '\"', 
		'#', '\x5', '\x4', '\x3', '\x2', '#', '$', '\a', '\x5', '\x2', '\x2', 
		'$', '&', '\x3', '\x2', '\x2', '\x2', '%', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '%', ' ', '\x3', '\x2', '\x2', '\x2', '%', '!', '\x3', '\x2', '\x2', 
		'\x2', '&', '\t', '\x3', '\x2', '\x2', '\x2', '\x6', '\xF', '\x16', '\x1D', 
		'%',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Grammar
