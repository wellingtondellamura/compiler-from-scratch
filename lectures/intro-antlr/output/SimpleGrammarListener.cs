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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SimpleGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface ISimpleGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] SimpleGrammarParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] SimpleGrammarParser.ProgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] SimpleGrammarParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] SimpleGrammarParser.LineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.code"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCode([NotNull] SimpleGrammarParser.CodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.code"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCode([NotNull] SimpleGrammarParser.CodeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElement([NotNull] SimpleGrammarParser.ElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElement([NotNull] SimpleGrammarParser.ElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutput([NotNull] SimpleGrammarParser.OutputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutput([NotNull] SimpleGrammarParser.OutputContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.show"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShow([NotNull] SimpleGrammarParser.ShowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.show"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShow([NotNull] SimpleGrammarParser.ShowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.follow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFollow([NotNull] SimpleGrammarParser.FollowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.follow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFollow([NotNull] SimpleGrammarParser.FollowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipo([NotNull] SimpleGrammarParser.TipoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipo([NotNull] SimpleGrammarParser.TipoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.equals"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquals([NotNull] SimpleGrammarParser.EqualsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.equals"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquals([NotNull] SimpleGrammarParser.EqualsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.cont"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCont([NotNull] SimpleGrammarParser.ContContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.cont"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCont([NotNull] SimpleGrammarParser.ContContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] SimpleGrammarParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] SimpleGrammarParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.rest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRest([NotNull] SimpleGrammarParser.RestContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.rest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRest([NotNull] SimpleGrammarParser.RestContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.fact"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFact([NotNull] SimpleGrammarParser.FactContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.fact"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFact([NotNull] SimpleGrammarParser.FactContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.more"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMore([NotNull] SimpleGrammarParser.MoreContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.more"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMore([NotNull] SimpleGrammarParser.MoreContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] SimpleGrammarParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] SimpleGrammarParser.TermContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.uif"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUif([NotNull] SimpleGrammarParser.UifContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.uif"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUif([NotNull] SimpleGrammarParser.UifContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] SimpleGrammarParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] SimpleGrammarParser.ConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.comp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComp([NotNull] SimpleGrammarParser.CompContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.comp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComp([NotNull] SimpleGrammarParser.CompContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.other"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOther([NotNull] SimpleGrammarParser.OtherContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.other"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOther([NotNull] SimpleGrammarParser.OtherContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.uelse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUelse([NotNull] SimpleGrammarParser.UelseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.uelse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUelse([NotNull] SimpleGrammarParser.UelseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.uwhile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUwhile([NotNull] SimpleGrammarParser.UwhileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.uwhile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUwhile([NotNull] SimpleGrammarParser.UwhileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.ufor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUfor([NotNull] SimpleGrammarParser.UforContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.ufor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUfor([NotNull] SimpleGrammarParser.UforContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl([NotNull] SimpleGrammarParser.DeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl([NotNull] SimpleGrammarParser.DeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.incr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIncr([NotNull] SimpleGrammarParser.IncrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.incr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIncr([NotNull] SimpleGrammarParser.IncrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] SimpleGrammarParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] SimpleGrammarParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.par"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPar([NotNull] SimpleGrammarParser.ParContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.par"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPar([NotNull] SimpleGrammarParser.ParContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.cfunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCfunction([NotNull] SimpleGrammarParser.CfunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.cfunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCfunction([NotNull] SimpleGrammarParser.CfunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.cpar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCpar([NotNull] SimpleGrammarParser.CparContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.cpar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCpar([NotNull] SimpleGrammarParser.CparContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInput([NotNull] SimpleGrammarParser.InputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInput([NotNull] SimpleGrammarParser.InputContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] SimpleGrammarParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] SimpleGrammarParser.ValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.umath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUmath([NotNull] SimpleGrammarParser.UmathContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.umath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUmath([NotNull] SimpleGrammarParser.UmathContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.mathpar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMathpar([NotNull] SimpleGrammarParser.MathparContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.mathpar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMathpar([NotNull] SimpleGrammarParser.MathparContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.floor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloor([NotNull] SimpleGrammarParser.FloorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.floor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloor([NotNull] SimpleGrammarParser.FloorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.ceil"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCeil([NotNull] SimpleGrammarParser.CeilContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.ceil"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCeil([NotNull] SimpleGrammarParser.CeilContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.sqrt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSqrt([NotNull] SimpleGrammarParser.SqrtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.sqrt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSqrt([NotNull] SimpleGrammarParser.SqrtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.pot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPot([NotNull] SimpleGrammarParser.PotContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.pot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPot([NotNull] SimpleGrammarParser.PotContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.fmax"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFmax([NotNull] SimpleGrammarParser.FmaxContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.fmax"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFmax([NotNull] SimpleGrammarParser.FmaxContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.fmin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFmin([NotNull] SimpleGrammarParser.FminContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.fmin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFmin([NotNull] SimpleGrammarParser.FminContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.rint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRint([NotNull] SimpleGrammarParser.RintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.rint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRint([NotNull] SimpleGrammarParser.RintContext context);
}
} // namespace Grammar
