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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISimpleGrammarListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class SimpleGrammarBaseListener : ISimpleGrammarListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] SimpleGrammarParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] SimpleGrammarParser.ProgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine([NotNull] SimpleGrammarParser.LineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine([NotNull] SimpleGrammarParser.LineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.atrib"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtrib([NotNull] SimpleGrammarParser.AtribContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.atrib"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtrib([NotNull] SimpleGrammarParser.AtribContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.print"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrint([NotNull] SimpleGrammarParser.PrintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.print"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrint([NotNull] SimpleGrammarParser.PrintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] SimpleGrammarParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] SimpleGrammarParser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleGrammarParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTerm([NotNull] SimpleGrammarParser.TermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleGrammarParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTerm([NotNull] SimpleGrammarParser.TermContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>factNum</c>
	/// labeled alternative in <see cref="SimpleGrammarParser.fact"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactNum([NotNull] SimpleGrammarParser.FactNumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>factNum</c>
	/// labeled alternative in <see cref="SimpleGrammarParser.fact"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactNum([NotNull] SimpleGrammarParser.FactNumContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>factVar</c>
	/// labeled alternative in <see cref="SimpleGrammarParser.fact"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactVar([NotNull] SimpleGrammarParser.FactVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>factVar</c>
	/// labeled alternative in <see cref="SimpleGrammarParser.fact"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactVar([NotNull] SimpleGrammarParser.FactVarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>factExpr</c>
	/// labeled alternative in <see cref="SimpleGrammarParser.fact"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactExpr([NotNull] SimpleGrammarParser.FactExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>factExpr</c>
	/// labeled alternative in <see cref="SimpleGrammarParser.fact"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactExpr([NotNull] SimpleGrammarParser.FactExprContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Grammar