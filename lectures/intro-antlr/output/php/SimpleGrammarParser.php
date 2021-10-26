<?php

/*
 * Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
 */

namespace Grammar {
	use Antlr\Antlr4\Runtime\Atn\ATN;
	use Antlr\Antlr4\Runtime\Atn\ATNDeserializer;
	use Antlr\Antlr4\Runtime\Atn\ParserATNSimulator;
	use Antlr\Antlr4\Runtime\Dfa\DFA;
	use Antlr\Antlr4\Runtime\Error\Exceptions\FailedPredicateException;
	use Antlr\Antlr4\Runtime\Error\Exceptions\NoViableAltException;
	use Antlr\Antlr4\Runtime\PredictionContexts\PredictionContextCache;
	use Antlr\Antlr4\Runtime\Error\Exceptions\RecognitionException;
	use Antlr\Antlr4\Runtime\RuleContext;
	use Antlr\Antlr4\Runtime\Token;
	use Antlr\Antlr4\Runtime\TokenStream;
	use Antlr\Antlr4\Runtime\Vocabulary;
	use Antlr\Antlr4\Runtime\VocabularyImpl;
	use Antlr\Antlr4\Runtime\RuntimeMetaData;
	use Antlr\Antlr4\Runtime\Parser;

	final class SimpleGrammarParser extends Parser
	{
		public const EOL = 1, OPEN = 2, CLOSE = 3, MOD = 4, DIV = 5, MUL = 6, 
               SUB = 7, ADD = 8, NUM = 9, VAR = 10, COMMENTS = 11, WS = 12;

		public const RULE_prog = 0, RULE_expr = 1, RULE_term = 2, RULE_fact = 3;

		/**
		 * @var array<string>
		 */
		public const RULE_NAMES = [
			'prog', 'expr', 'term', 'fact'
		];

		/**
		 * @var array<string|null>
		 */
		private const LITERAL_NAMES = [
		    null, "';'", "'('", "')'", "'%'", "'/'", "'*'", "'-'", "'+'"
		];

		/**
		 * @var array<string>
		 */
		private const SYMBOLIC_NAMES = [
		    null, "EOL", "OPEN", "CLOSE", "MOD", "DIV", "MUL", "SUB", "ADD", "NUM", 
		    "VAR", "COMMENTS", "WS"
		];

		/**
		 * @var string
		 */
		private const SERIALIZED_ATN =
			"\u{3}\u{608B}\u{A72A}\u{8133}\u{B9ED}\u{417C}\u{3BE7}\u{7786}\u{5964}" .
		    "\u{3}\u{E}\u{28}\u{4}\u{2}\u{9}\u{2}\u{4}\u{3}\u{9}\u{3}\u{4}\u{4}" .
		    "\u{9}\u{4}\u{4}\u{5}\u{9}\u{5}\u{3}\u{2}\u{3}\u{2}\u{3}\u{2}\u{6}" .
		    "\u{2}\u{E}\u{A}\u{2}\u{D}\u{2}\u{E}\u{2}\u{F}\u{3}\u{3}\u{3}\u{3}" .
		    "\u{3}\u{3}\u{3}\u{3}\u{3}\u{3}\u{5}\u{3}\u{17}\u{A}\u{3}\u{3}\u{4}" .
		    "\u{3}\u{4}\u{3}\u{4}\u{3}\u{4}\u{3}\u{4}\u{5}\u{4}\u{1E}\u{A}\u{4}" .
		    "\u{3}\u{5}\u{3}\u{5}\u{3}\u{5}\u{3}\u{5}\u{3}\u{5}\u{3}\u{5}\u{5}" .
		    "\u{5}\u{26}\u{A}\u{5}\u{3}\u{5}\u{2}\u{2}\u{6}\u{2}\u{4}\u{6}\u{8}" .
		    "\u{2}\u{4}\u{3}\u{2}\u{9}\u{A}\u{3}\u{2}\u{6}\u{8}\u{2}\u{28}\u{2}" .
		    "\u{D}\u{3}\u{2}\u{2}\u{2}\u{4}\u{16}\u{3}\u{2}\u{2}\u{2}\u{6}\u{1D}" .
		    "\u{3}\u{2}\u{2}\u{2}\u{8}\u{25}\u{3}\u{2}\u{2}\u{2}\u{A}\u{B}\u{5}" .
		    "\u{4}\u{3}\u{2}\u{B}\u{C}\u{7}\u{3}\u{2}\u{2}\u{C}\u{E}\u{3}\u{2}" .
		    "\u{2}\u{2}\u{D}\u{A}\u{3}\u{2}\u{2}\u{2}\u{E}\u{F}\u{3}\u{2}\u{2}" .
		    "\u{2}\u{F}\u{D}\u{3}\u{2}\u{2}\u{2}\u{F}\u{10}\u{3}\u{2}\u{2}\u{2}" .
		    "\u{10}\u{3}\u{3}\u{2}\u{2}\u{2}\u{11}\u{12}\u{5}\u{6}\u{4}\u{2}\u{12}" .
		    "\u{13}\u{9}\u{2}\u{2}\u{2}\u{13}\u{14}\u{5}\u{4}\u{3}\u{2}\u{14}\u{17}" .
		    "\u{3}\u{2}\u{2}\u{2}\u{15}\u{17}\u{5}\u{6}\u{4}\u{2}\u{16}\u{11}\u{3}" .
		    "\u{2}\u{2}\u{2}\u{16}\u{15}\u{3}\u{2}\u{2}\u{2}\u{17}\u{5}\u{3}\u{2}" .
		    "\u{2}\u{2}\u{18}\u{19}\u{5}\u{8}\u{5}\u{2}\u{19}\u{1A}\u{9}\u{3}\u{2}" .
		    "\u{2}\u{1A}\u{1B}\u{5}\u{6}\u{4}\u{2}\u{1B}\u{1E}\u{3}\u{2}\u{2}\u{2}" .
		    "\u{1C}\u{1E}\u{5}\u{8}\u{5}\u{2}\u{1D}\u{18}\u{3}\u{2}\u{2}\u{2}\u{1D}" .
		    "\u{1C}\u{3}\u{2}\u{2}\u{2}\u{1E}\u{7}\u{3}\u{2}\u{2}\u{2}\u{1F}\u{26}" .
		    "\u{7}\u{C}\u{2}\u{2}\u{20}\u{26}\u{7}\u{B}\u{2}\u{2}\u{21}\u{22}\u{7}" .
		    "\u{4}\u{2}\u{2}\u{22}\u{23}\u{5}\u{4}\u{3}\u{2}\u{23}\u{24}\u{7}\u{5}" .
		    "\u{2}\u{2}\u{24}\u{26}\u{3}\u{2}\u{2}\u{2}\u{25}\u{1F}\u{3}\u{2}\u{2}" .
		    "\u{2}\u{25}\u{20}\u{3}\u{2}\u{2}\u{2}\u{25}\u{21}\u{3}\u{2}\u{2}\u{2}" .
		    "\u{26}\u{9}\u{3}\u{2}\u{2}\u{2}\u{6}\u{F}\u{16}\u{1D}\u{25}";

		protected static $atn;
		protected static $decisionToDFA;
		protected static $sharedContextCache;

		public function __construct(TokenStream $input)
		{
			parent::__construct($input);

			self::initialize();

			$this->interp = new ParserATNSimulator($this, self::$atn, self::$decisionToDFA, self::$sharedContextCache);
		}

		private static function initialize() : void
		{
			if (self::$atn !== null) {
				return;
			}

			RuntimeMetaData::checkVersion('4.8', RuntimeMetaData::VERSION);

			$atn = (new ATNDeserializer())->deserialize(self::SERIALIZED_ATN);

			$decisionToDFA = [];
			for ($i = 0, $count = $atn->getNumberOfDecisions(); $i < $count; $i++) {
				$decisionToDFA[] = new DFA($atn->getDecisionState($i), $i);
			}

			self::$atn = $atn;
			self::$decisionToDFA = $decisionToDFA;
			self::$sharedContextCache = new PredictionContextCache();
		}

		public function getGrammarFileName() : string
		{
			return "SimpleGrammar.g4";
		}

		public function getRuleNames() : array
		{
			return self::RULE_NAMES;
		}

		public function getSerializedATN() : string
		{
			return self::SERIALIZED_ATN;
		}

		public function getATN() : ATN
		{
			return self::$atn;
		}

		public function getVocabulary() : Vocabulary
        {
            static $vocabulary;

			return $vocabulary = $vocabulary ?? new VocabularyImpl(self::LITERAL_NAMES, self::SYMBOLIC_NAMES);
        }

		/**
		 * @throws RecognitionException
		 */
		public function prog() : Context\ProgContext
		{
		    $localContext = new Context\ProgContext($this->ctx, $this->getState());

		    $this->enterRule($localContext, 0, self::RULE_prog);

		    try {
		        $this->enterOuterAlt($localContext, 1);
		        $this->setState(11); 
		        $this->errorHandler->sync($this);

		        $_la = $this->input->LA(1);
		        do {
		        	$this->setState(8);
		        	$this->expr();
		        	$this->setState(9);
		        	$this->match(self::EOL);
		        	$this->setState(13); 
		        	$this->errorHandler->sync($this);
		        	$_la = $this->input->LA(1);
		        } while (((($_la) & ~0x3f) === 0 && ((1 << $_la) & ((1 << self::OPEN) | (1 << self::NUM) | (1 << self::VAR))) !== 0));
		    } catch (RecognitionException $exception) {
		        $localContext->exception = $exception;
		        $this->errorHandler->reportError($this, $exception);
		        $this->errorHandler->recover($this, $exception);
		    } finally {
		        $this->exitRule();
		    }

		    return $localContext;
		}

		/**
		 * @throws RecognitionException
		 */
		public function expr() : Context\ExprContext
		{
		    $localContext = new Context\ExprContext($this->ctx, $this->getState());

		    $this->enterRule($localContext, 2, self::RULE_expr);

		    try {
		        $this->setState(20);
		        $this->errorHandler->sync($this);

		        switch ($this->getInterpreter()->adaptivePredict($this->input, 1, $this->ctx)) {
		        	case 1:
		        	    $this->enterOuterAlt($localContext, 1);
		        	    $this->setState(15);
		        	    $this->term();
		        	    $this->setState(16);

		        	    $_la = $this->input->LA(1);

		        	    if (!($_la === self::SUB || $_la === self::ADD)) {
		        	    $this->errorHandler->recoverInline($this);
		        	    } else {
		        	    	if ($this->input->LA(1) === Token::EOF) {
		        	    	    $this->matchedEOF = true;
		        	        }

		        	    	$this->errorHandler->reportMatch($this);
		        	    	$this->consume();
		        	    }
		        	    $this->setState(17);
		        	    $this->expr();
		        	break;

		        	case 2:
		        	    $this->enterOuterAlt($localContext, 2);
		        	    $this->setState(19);
		        	    $this->term();
		        	break;
		        }
		    } catch (RecognitionException $exception) {
		        $localContext->exception = $exception;
		        $this->errorHandler->reportError($this, $exception);
		        $this->errorHandler->recover($this, $exception);
		    } finally {
		        $this->exitRule();
		    }

		    return $localContext;
		}

		/**
		 * @throws RecognitionException
		 */
		public function term() : Context\TermContext
		{
		    $localContext = new Context\TermContext($this->ctx, $this->getState());

		    $this->enterRule($localContext, 4, self::RULE_term);

		    try {
		        $this->setState(27);
		        $this->errorHandler->sync($this);

		        switch ($this->getInterpreter()->adaptivePredict($this->input, 2, $this->ctx)) {
		        	case 1:
		        	    $this->enterOuterAlt($localContext, 1);
		        	    $this->setState(22);
		        	    $this->fact();
		        	    $this->setState(23);

		        	    $_la = $this->input->LA(1);

		        	    if (!(((($_la) & ~0x3f) === 0 && ((1 << $_la) & ((1 << self::MOD) | (1 << self::DIV) | (1 << self::MUL))) !== 0))) {
		        	    $this->errorHandler->recoverInline($this);
		        	    } else {
		        	    	if ($this->input->LA(1) === Token::EOF) {
		        	    	    $this->matchedEOF = true;
		        	        }

		        	    	$this->errorHandler->reportMatch($this);
		        	    	$this->consume();
		        	    }
		        	    $this->setState(24);
		        	    $this->term();
		        	break;

		        	case 2:
		        	    $this->enterOuterAlt($localContext, 2);
		        	    $this->setState(26);
		        	    $this->fact();
		        	break;
		        }
		    } catch (RecognitionException $exception) {
		        $localContext->exception = $exception;
		        $this->errorHandler->reportError($this, $exception);
		        $this->errorHandler->recover($this, $exception);
		    } finally {
		        $this->exitRule();
		    }

		    return $localContext;
		}

		/**
		 * @throws RecognitionException
		 */
		public function fact() : Context\FactContext
		{
		    $localContext = new Context\FactContext($this->ctx, $this->getState());

		    $this->enterRule($localContext, 6, self::RULE_fact);

		    try {
		        $this->setState(35);
		        $this->errorHandler->sync($this);

		        switch ($this->input->LA(1)) {
		            case self::VAR:
		            	$this->enterOuterAlt($localContext, 1);
		            	$this->setState(29);
		            	$this->match(self::VAR);
		            	break;

		            case self::NUM:
		            	$this->enterOuterAlt($localContext, 2);
		            	$this->setState(30);
		            	$this->match(self::NUM);
		            	break;

		            case self::OPEN:
		            	$this->enterOuterAlt($localContext, 3);
		            	$this->setState(31);
		            	$this->match(self::OPEN);
		            	$this->setState(32);
		            	$this->expr();
		            	$this->setState(33);
		            	$this->match(self::CLOSE);
		            	break;

		        default:
		        	throw new NoViableAltException($this);
		        }
		    } catch (RecognitionException $exception) {
		        $localContext->exception = $exception;
		        $this->errorHandler->reportError($this, $exception);
		        $this->errorHandler->recover($this, $exception);
		    } finally {
		        $this->exitRule();
		    }

		    return $localContext;
		}
	}
}

namespace Grammar\Context {
	use Antlr\Antlr4\Runtime\ParserRuleContext;
	use Antlr\Antlr4\Runtime\Token;
	use Antlr\Antlr4\Runtime\Tree\ParseTreeVisitor;
	use Antlr\Antlr4\Runtime\Tree\TerminalNode;
	use Antlr\Antlr4\Runtime\Tree\ParseTreeListener;
	use Grammar\SimpleGrammarParser;
	use Grammar\SimpleGrammarVisitor;
	use Grammar\SimpleGrammarListener;

	class ProgContext extends ParserRuleContext
	{
		public function __construct(?ParserRuleContext $parent, ?int $invokingState = null)
		{
			parent::__construct($parent, $invokingState);
		}

		public function getRuleIndex() : int
		{
		    return SimpleGrammarParser::RULE_prog;
	    }

	    /**
	     * @return array<ExprContext>|ExprContext|null
	     */
	    public function expr(?int $index = null)
	    {
	    	if ($index === null) {
	    		return $this->getTypedRuleContexts(ExprContext::class);
	    	}

	        return $this->getTypedRuleContext(ExprContext::class, $index);
	    }

	    /**
	     * @return array<TerminalNode>|TerminalNode|null
	     */
	    public function EOL(?int $index = null)
	    {
	    	if ($index === null) {
	    		return $this->getTokens(SimpleGrammarParser::EOL);
	    	}

	        return $this->getToken(SimpleGrammarParser::EOL, $index);
	    }

		public function enterRule(ParseTreeListener $listener) : void
		{
			if ($listener instanceof SimpleGrammarListener) {
			    $listener->enterProg($this);
		    }
		}

		public function exitRule(ParseTreeListener $listener) : void
		{
			if ($listener instanceof SimpleGrammarListener) {
			    $listener->exitProg($this);
		    }
		}

		public function accept(ParseTreeVisitor $visitor)
		{
			if ($visitor instanceof SimpleGrammarVisitor) {
			    return $visitor->visitProg($this);
		    }

			return $visitor->visitChildren($this);
		}
	} 

	class ExprContext extends ParserRuleContext
	{
		public function __construct(?ParserRuleContext $parent, ?int $invokingState = null)
		{
			parent::__construct($parent, $invokingState);
		}

		public function getRuleIndex() : int
		{
		    return SimpleGrammarParser::RULE_expr;
	    }

	    public function term() : ?TermContext
	    {
	    	return $this->getTypedRuleContext(TermContext::class, 0);
	    }

	    public function expr() : ?ExprContext
	    {
	    	return $this->getTypedRuleContext(ExprContext::class, 0);
	    }

	    public function ADD() : ?TerminalNode
	    {
	        return $this->getToken(SimpleGrammarParser::ADD, 0);
	    }

	    public function SUB() : ?TerminalNode
	    {
	        return $this->getToken(SimpleGrammarParser::SUB, 0);
	    }

		public function enterRule(ParseTreeListener $listener) : void
		{
			if ($listener instanceof SimpleGrammarListener) {
			    $listener->enterExpr($this);
		    }
		}

		public function exitRule(ParseTreeListener $listener) : void
		{
			if ($listener instanceof SimpleGrammarListener) {
			    $listener->exitExpr($this);
		    }
		}

		public function accept(ParseTreeVisitor $visitor)
		{
			if ($visitor instanceof SimpleGrammarVisitor) {
			    return $visitor->visitExpr($this);
		    }

			return $visitor->visitChildren($this);
		}
	} 

	class TermContext extends ParserRuleContext
	{
		public function __construct(?ParserRuleContext $parent, ?int $invokingState = null)
		{
			parent::__construct($parent, $invokingState);
		}

		public function getRuleIndex() : int
		{
		    return SimpleGrammarParser::RULE_term;
	    }

	    public function fact() : ?FactContext
	    {
	    	return $this->getTypedRuleContext(FactContext::class, 0);
	    }

	    public function term() : ?TermContext
	    {
	    	return $this->getTypedRuleContext(TermContext::class, 0);
	    }

	    public function MUL() : ?TerminalNode
	    {
	        return $this->getToken(SimpleGrammarParser::MUL, 0);
	    }

	    public function DIV() : ?TerminalNode
	    {
	        return $this->getToken(SimpleGrammarParser::DIV, 0);
	    }

	    public function MOD() : ?TerminalNode
	    {
	        return $this->getToken(SimpleGrammarParser::MOD, 0);
	    }

		public function enterRule(ParseTreeListener $listener) : void
		{
			if ($listener instanceof SimpleGrammarListener) {
			    $listener->enterTerm($this);
		    }
		}

		public function exitRule(ParseTreeListener $listener) : void
		{
			if ($listener instanceof SimpleGrammarListener) {
			    $listener->exitTerm($this);
		    }
		}

		public function accept(ParseTreeVisitor $visitor)
		{
			if ($visitor instanceof SimpleGrammarVisitor) {
			    return $visitor->visitTerm($this);
		    }

			return $visitor->visitChildren($this);
		}
	} 

	class FactContext extends ParserRuleContext
	{
		public function __construct(?ParserRuleContext $parent, ?int $invokingState = null)
		{
			parent::__construct($parent, $invokingState);
		}

		public function getRuleIndex() : int
		{
		    return SimpleGrammarParser::RULE_fact;
	    }

	    public function VAR() : ?TerminalNode
	    {
	        return $this->getToken(SimpleGrammarParser::VAR, 0);
	    }

	    public function NUM() : ?TerminalNode
	    {
	        return $this->getToken(SimpleGrammarParser::NUM, 0);
	    }

	    public function OPEN() : ?TerminalNode
	    {
	        return $this->getToken(SimpleGrammarParser::OPEN, 0);
	    }

	    public function expr() : ?ExprContext
	    {
	    	return $this->getTypedRuleContext(ExprContext::class, 0);
	    }

	    public function CLOSE() : ?TerminalNode
	    {
	        return $this->getToken(SimpleGrammarParser::CLOSE, 0);
	    }

		public function enterRule(ParseTreeListener $listener) : void
		{
			if ($listener instanceof SimpleGrammarListener) {
			    $listener->enterFact($this);
		    }
		}

		public function exitRule(ParseTreeListener $listener) : void
		{
			if ($listener instanceof SimpleGrammarListener) {
			    $listener->exitFact($this);
		    }
		}

		public function accept(ParseTreeVisitor $visitor)
		{
			if ($visitor instanceof SimpleGrammarVisitor) {
			    return $visitor->visitFact($this);
		    }

			return $visitor->visitChildren($this);
		}
	} 
}