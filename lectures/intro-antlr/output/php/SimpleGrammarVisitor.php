<?php

/*
 * Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
 */

namespace Grammar;

use Antlr\Antlr4\Runtime\Tree\ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced by {@see SimpleGrammarParser}.
 */
interface SimpleGrammarVisitor extends ParseTreeVisitor
{
	/**
	 * Visit a parse tree produced by {@see SimpleGrammarParser::prog()}.
	 *
	 * @param Context\ProgContext $context The parse tree.
	 *
	 * @return mixed The visitor result.
	 */
	public function visitProg(Context\ProgContext $context);

	/**
	 * Visit a parse tree produced by {@see SimpleGrammarParser::expr()}.
	 *
	 * @param Context\ExprContext $context The parse tree.
	 *
	 * @return mixed The visitor result.
	 */
	public function visitExpr(Context\ExprContext $context);

	/**
	 * Visit a parse tree produced by {@see SimpleGrammarParser::term()}.
	 *
	 * @param Context\TermContext $context The parse tree.
	 *
	 * @return mixed The visitor result.
	 */
	public function visitTerm(Context\TermContext $context);

	/**
	 * Visit a parse tree produced by {@see SimpleGrammarParser::fact()}.
	 *
	 * @param Context\FactContext $context The parse tree.
	 *
	 * @return mixed The visitor result.
	 */
	public function visitFact(Context\FactContext $context);
}