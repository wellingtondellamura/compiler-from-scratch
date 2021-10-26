<?php

/*
 * Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
 */

namespace Grammar;
use Antlr\Antlr4\Runtime\Tree\ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@see SimpleGrammarParser}.
 */
interface SimpleGrammarListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@see SimpleGrammarParser::prog()}.
	 * @param $context The parse tree.
	 */
	public function enterProg(Context\ProgContext $context) : void;
	/**
	 * Exit a parse tree produced by {@see SimpleGrammarParser::prog()}.
	 * @param $context The parse tree.
	 */
	public function exitProg(Context\ProgContext $context) : void;
	/**
	 * Enter a parse tree produced by {@see SimpleGrammarParser::expr()}.
	 * @param $context The parse tree.
	 */
	public function enterExpr(Context\ExprContext $context) : void;
	/**
	 * Exit a parse tree produced by {@see SimpleGrammarParser::expr()}.
	 * @param $context The parse tree.
	 */
	public function exitExpr(Context\ExprContext $context) : void;
	/**
	 * Enter a parse tree produced by {@see SimpleGrammarParser::term()}.
	 * @param $context The parse tree.
	 */
	public function enterTerm(Context\TermContext $context) : void;
	/**
	 * Exit a parse tree produced by {@see SimpleGrammarParser::term()}.
	 * @param $context The parse tree.
	 */
	public function exitTerm(Context\TermContext $context) : void;
	/**
	 * Enter a parse tree produced by {@see SimpleGrammarParser::fact()}.
	 * @param $context The parse tree.
	 */
	public function enterFact(Context\FactContext $context) : void;
	/**
	 * Exit a parse tree produced by {@see SimpleGrammarParser::fact()}.
	 * @param $context The parse tree.
	 */
	public function exitFact(Context\FactContext $context) : void;
}