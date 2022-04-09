//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\MyCompiler\Parser\MyParser.g4 by ANTLR 4.8

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
/// This class provides an empty implementation of <see cref="IMyParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class MyParserBaseListener : IMyParserListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>programStmt</c>
	/// labeled alternative in <see cref="MyParserParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgramStmt([NotNull] MyParserParser.ProgramStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>programStmt</c>
	/// labeled alternative in <see cref="MyParserParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgramStmt([NotNull] MyParserParser.ProgramStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtPrint</c>
	/// labeled alternative in <see cref="MyParserParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmtPrint([NotNull] MyParserParser.StmtPrintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtPrint</c>
	/// labeled alternative in <see cref="MyParserParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmtPrint([NotNull] MyParserParser.StmtPrintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtRead</c>
	/// labeled alternative in <see cref="MyParserParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmtRead([NotNull] MyParserParser.StmtReadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtRead</c>
	/// labeled alternative in <see cref="MyParserParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmtRead([NotNull] MyParserParser.StmtReadContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtAttr</c>
	/// labeled alternative in <see cref="MyParserParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmtAttr([NotNull] MyParserParser.StmtAttrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtAttr</c>
	/// labeled alternative in <see cref="MyParserParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmtAttr([NotNull] MyParserParser.StmtAttrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtCond</c>
	/// labeled alternative in <see cref="MyParserParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmtCond([NotNull] MyParserParser.StmtCondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtCond</c>
	/// labeled alternative in <see cref="MyParserParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmtCond([NotNull] MyParserParser.StmtCondContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ifStmt</c>
	/// labeled alternative in <see cref="MyParserParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStmt([NotNull] MyParserParser.IfStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ifStmt</c>
	/// labeled alternative in <see cref="MyParserParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStmt([NotNull] MyParserParser.IfStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ifElseStmt</c>
	/// labeled alternative in <see cref="MyParserParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfElseStmt([NotNull] MyParserParser.IfElseStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ifElseStmt</c>
	/// labeled alternative in <see cref="MyParserParser.cond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfElseStmt([NotNull] MyParserParser.IfElseStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>condExpresion</c>
	/// labeled alternative in <see cref="MyParserParser.condExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondExpresion([NotNull] MyParserParser.CondExpresionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>condExpresion</c>
	/// labeled alternative in <see cref="MyParserParser.condExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondExpresion([NotNull] MyParserParser.CondExpresionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>condRelOp</c>
	/// labeled alternative in <see cref="MyParserParser.condExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondRelOp([NotNull] MyParserParser.CondRelOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>condRelOp</c>
	/// labeled alternative in <see cref="MyParserParser.condExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondRelOp([NotNull] MyParserParser.CondRelOpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>blockStmt</c>
	/// labeled alternative in <see cref="MyParserParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockStmt([NotNull] MyParserParser.BlockStmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>blockStmt</c>
	/// labeled alternative in <see cref="MyParserParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockStmt([NotNull] MyParserParser.BlockStmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>printStr</c>
	/// labeled alternative in <see cref="MyParserParser.print"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintStr([NotNull] MyParserParser.PrintStrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>printStr</c>
	/// labeled alternative in <see cref="MyParserParser.print"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintStr([NotNull] MyParserParser.PrintStrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="MyParserParser.print"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintExpr([NotNull] MyParserParser.PrintExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="MyParserParser.print"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintExpr([NotNull] MyParserParser.PrintExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>readVar</c>
	/// labeled alternative in <see cref="MyParserParser.read"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReadVar([NotNull] MyParserParser.ReadVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>readVar</c>
	/// labeled alternative in <see cref="MyParserParser.read"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReadVar([NotNull] MyParserParser.ReadVarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>attrExpr</c>
	/// labeled alternative in <see cref="MyParserParser.attr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttrExpr([NotNull] MyParserParser.AttrExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>attrExpr</c>
	/// labeled alternative in <see cref="MyParserParser.attr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttrExpr([NotNull] MyParserParser.AttrExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprPlus</c>
	/// labeled alternative in <see cref="MyParserParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprPlus([NotNull] MyParserParser.ExprPlusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprPlus</c>
	/// labeled alternative in <see cref="MyParserParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprPlus([NotNull] MyParserParser.ExprPlusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprMinus</c>
	/// labeled alternative in <see cref="MyParserParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprMinus([NotNull] MyParserParser.ExprMinusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprMinus</c>
	/// labeled alternative in <see cref="MyParserParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprMinus([NotNull] MyParserParser.ExprMinusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expr1Empty</c>
	/// labeled alternative in <see cref="MyParserParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr1Empty([NotNull] MyParserParser.Expr1EmptyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expr1Empty</c>
	/// labeled alternative in <see cref="MyParserParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr1Empty([NotNull] MyParserParser.Expr1EmptyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expr1Mult</c>
	/// labeled alternative in <see cref="MyParserParser.expr1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr1Mult([NotNull] MyParserParser.Expr1MultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expr1Mult</c>
	/// labeled alternative in <see cref="MyParserParser.expr1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr1Mult([NotNull] MyParserParser.Expr1MultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expr1Div</c>
	/// labeled alternative in <see cref="MyParserParser.expr1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr1Div([NotNull] MyParserParser.Expr1DivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expr1Div</c>
	/// labeled alternative in <see cref="MyParserParser.expr1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr1Div([NotNull] MyParserParser.Expr1DivContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expr2Empty</c>
	/// labeled alternative in <see cref="MyParserParser.expr1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr2Empty([NotNull] MyParserParser.Expr2EmptyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expr2Empty</c>
	/// labeled alternative in <see cref="MyParserParser.expr1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr2Empty([NotNull] MyParserParser.Expr2EmptyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expr2Par</c>
	/// labeled alternative in <see cref="MyParserParser.expr2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr2Par([NotNull] MyParserParser.Expr2ParContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expr2Par</c>
	/// labeled alternative in <see cref="MyParserParser.expr2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr2Par([NotNull] MyParserParser.Expr2ParContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expr2Num</c>
	/// labeled alternative in <see cref="MyParserParser.expr2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr2Num([NotNull] MyParserParser.Expr2NumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expr2Num</c>
	/// labeled alternative in <see cref="MyParserParser.expr2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr2Num([NotNull] MyParserParser.Expr2NumContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expr2Var</c>
	/// labeled alternative in <see cref="MyParserParser.expr2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr2Var([NotNull] MyParserParser.Expr2VarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expr2Var</c>
	/// labeled alternative in <see cref="MyParserParser.expr2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr2Var([NotNull] MyParserParser.Expr2VarContext context) { }

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
