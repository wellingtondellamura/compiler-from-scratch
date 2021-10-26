<?php

/*
 * Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
 */

namespace Grammar;
use Antlr\Antlr4\Runtime\Tree\AbstractParseTreeVisitor;

/**
 * This class provides an empty implementation of {@see SimpleGrammarVisitor},
 * which can be extended to create a visitor which only needs to handle a subset
 * of the available methods.
 */
class SimpleGrammarBaseVisitor extends AbstractParseTreeVisitor implements SimpleGrammarVisitor
{
	/**
	 * {@inheritdoc}
	 *
	 * The default implementation returns the result of calling
	 * {@see self::visitChildren()} on `context`.
	 */
	public function visitProg(Context\ProgContext $context)
	{
	    return $this->visitChildren($context);
	}

	/**
	 * {@inheritdoc}
	 *
	 * The default implementation returns the result of calling
	 * {@see self::visitChildren()} on `context`.
	 */
	public function visitExpr(Context\ExprContext $context)
	{
	    return $this->visitChildren($context);
	}

	/**
	 * {@inheritdoc}
	 *
	 * The default implementation returns the result of calling
	 * {@see self::visitChildren()} on `context`.
	 */
	public function visitTerm(Context\TermContext $context)
	{
	    return $this->visitChildren($context);
	}

	/**
	 * {@inheritdoc}
	 *
	 * The default implementation returns the result of calling
	 * {@see self::visitChildren()} on `context`.
	 */
	public function visitFact(Context\FactContext $context)
	{
	    return $this->visitChildren($context);
	}
}