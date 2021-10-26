<?php

/*
 * Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
 */

namespace Grammar {
	use Antlr\Antlr4\Runtime\Atn\ATNDeserializer;
	use Antlr\Antlr4\Runtime\Atn\LexerATNSimulator;
	use Antlr\Antlr4\Runtime\Lexer;
	use Antlr\Antlr4\Runtime\CharStream;
	use Antlr\Antlr4\Runtime\PredictionContexts\PredictionContextCache;
	use Antlr\Antlr4\Runtime\RuleContext;
	use Antlr\Antlr4\Runtime\Atn\ATN;
	use Antlr\Antlr4\Runtime\Dfa\DFA;
	use Antlr\Antlr4\Runtime\Vocabulary;
	use Antlr\Antlr4\Runtime\RuntimeMetaData;
	use Antlr\Antlr4\Runtime\VocabularyImpl;

	final class SimpleGrammarLexer extends Lexer
	{
		public const EOL = 1, OPEN = 2, CLOSE = 3, MOD = 4, DIV = 5, MUL = 6, 
               SUB = 7, ADD = 8, NUM = 9, VAR = 10, COMMENTS = 11, WS = 12;

		/**
		 * @var array<string>
		 */
		public const CHANNEL_NAMES = [
			'DEFAULT_TOKEN_CHANNEL', 'HIDDEN'
		];

		/**
		 * @var array<string>
		 */
		public const MODE_NAMES = [
			'DEFAULT_MODE'
		];

		/**
		 * @var array<string>
		 */
		public const RULE_NAMES = [
			'EOL', 'OPEN', 'CLOSE', 'MOD', 'DIV', 'MUL', 'SUB', 'ADD', 'NUM', 'VAR', 
			'COMMENTS', 'WS'
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
		    "\u{2}\u{E}\u{44}\u{8}\u{1}\u{4}\u{2}\u{9}\u{2}\u{4}\u{3}\u{9}\u{3}" .
		    "\u{4}\u{4}\u{9}\u{4}\u{4}\u{5}\u{9}\u{5}\u{4}\u{6}\u{9}\u{6}\u{4}" .
		    "\u{7}\u{9}\u{7}\u{4}\u{8}\u{9}\u{8}\u{4}\u{9}\u{9}\u{9}\u{4}\u{A}" .
		    "\u{9}\u{A}\u{4}\u{B}\u{9}\u{B}\u{4}\u{C}\u{9}\u{C}\u{4}\u{D}\u{9}" .
		    "\u{D}\u{3}\u{2}\u{3}\u{2}\u{3}\u{3}\u{3}\u{3}\u{3}\u{4}\u{3}\u{4}" .
		    "\u{3}\u{5}\u{3}\u{5}\u{3}\u{6}\u{3}\u{6}\u{3}\u{7}\u{3}\u{7}\u{3}" .
		    "\u{8}\u{3}\u{8}\u{3}\u{9}\u{3}\u{9}\u{3}\u{A}\u{6}\u{A}\u{2D}\u{A}" .
		    "\u{A}\u{D}\u{A}\u{E}\u{A}\u{2E}\u{3}\u{B}\u{6}\u{B}\u{32}\u{A}\u{B}" .
		    "\u{D}\u{B}\u{E}\u{B}\u{33}\u{3}\u{C}\u{3}\u{C}\u{6}\u{C}\u{38}\u{A}" .
		    "\u{C}\u{D}\u{C}\u{E}\u{C}\u{39}\u{3}\u{C}\u{3}\u{C}\u{3}\u{D}\u{6}" .
		    "\u{D}\u{3F}\u{A}\u{D}\u{D}\u{D}\u{E}\u{D}\u{40}\u{3}\u{D}\u{3}\u{D}" .
		    "\u{2}\u{2}\u{E}\u{3}\u{3}\u{5}\u{4}\u{7}\u{5}\u{9}\u{6}\u{B}\u{7}" .
		    "\u{D}\u{8}\u{F}\u{9}\u{11}\u{A}\u{13}\u{B}\u{15}\u{C}\u{17}\u{D}\u{19}" .
		    "\u{E}\u{3}\u{2}\u{6}\u{3}\u{2}\u{32}\u{3B}\u{4}\u{2}\u{43}\u{5C}\u{63}" .
		    "\u{7C}\u{5}\u{2}\u{C}\u{C}\u{F}\u{F}\u{80}\u{80}\u{5}\u{2}\u{B}\u{C}" .
		    "\u{F}\u{F}\u{22}\u{22}\u{2}\u{47}\u{2}\u{3}\u{3}\u{2}\u{2}\u{2}\u{2}" .
		    "\u{5}\u{3}\u{2}\u{2}\u{2}\u{2}\u{7}\u{3}\u{2}\u{2}\u{2}\u{2}\u{9}" .
		    "\u{3}\u{2}\u{2}\u{2}\u{2}\u{B}\u{3}\u{2}\u{2}\u{2}\u{2}\u{D}\u{3}" .
		    "\u{2}\u{2}\u{2}\u{2}\u{F}\u{3}\u{2}\u{2}\u{2}\u{2}\u{11}\u{3}\u{2}" .
		    "\u{2}\u{2}\u{2}\u{13}\u{3}\u{2}\u{2}\u{2}\u{2}\u{15}\u{3}\u{2}\u{2}" .
		    "\u{2}\u{2}\u{17}\u{3}\u{2}\u{2}\u{2}\u{2}\u{19}\u{3}\u{2}\u{2}\u{2}" .
		    "\u{3}\u{1B}\u{3}\u{2}\u{2}\u{2}\u{5}\u{1D}\u{3}\u{2}\u{2}\u{2}\u{7}" .
		    "\u{1F}\u{3}\u{2}\u{2}\u{2}\u{9}\u{21}\u{3}\u{2}\u{2}\u{2}\u{B}\u{23}" .
		    "\u{3}\u{2}\u{2}\u{2}\u{D}\u{25}\u{3}\u{2}\u{2}\u{2}\u{F}\u{27}\u{3}" .
		    "\u{2}\u{2}\u{2}\u{11}\u{29}\u{3}\u{2}\u{2}\u{2}\u{13}\u{2C}\u{3}\u{2}" .
		    "\u{2}\u{2}\u{15}\u{31}\u{3}\u{2}\u{2}\u{2}\u{17}\u{35}\u{3}\u{2}\u{2}" .
		    "\u{2}\u{19}\u{3E}\u{3}\u{2}\u{2}\u{2}\u{1B}\u{1C}\u{7}\u{3D}\u{2}" .
		    "\u{2}\u{1C}\u{4}\u{3}\u{2}\u{2}\u{2}\u{1D}\u{1E}\u{7}\u{2A}\u{2}\u{2}" .
		    "\u{1E}\u{6}\u{3}\u{2}\u{2}\u{2}\u{1F}\u{20}\u{7}\u{2B}\u{2}\u{2}\u{20}" .
		    "\u{8}\u{3}\u{2}\u{2}\u{2}\u{21}\u{22}\u{7}\u{27}\u{2}\u{2}\u{22}\u{A}" .
		    "\u{3}\u{2}\u{2}\u{2}\u{23}\u{24}\u{7}\u{31}\u{2}\u{2}\u{24}\u{C}\u{3}" .
		    "\u{2}\u{2}\u{2}\u{25}\u{26}\u{7}\u{2C}\u{2}\u{2}\u{26}\u{E}\u{3}\u{2}" .
		    "\u{2}\u{2}\u{27}\u{28}\u{7}\u{2F}\u{2}\u{2}\u{28}\u{10}\u{3}\u{2}" .
		    "\u{2}\u{2}\u{29}\u{2A}\u{7}\u{2D}\u{2}\u{2}\u{2A}\u{12}\u{3}\u{2}" .
		    "\u{2}\u{2}\u{2B}\u{2D}\u{9}\u{2}\u{2}\u{2}\u{2C}\u{2B}\u{3}\u{2}\u{2}" .
		    "\u{2}\u{2D}\u{2E}\u{3}\u{2}\u{2}\u{2}\u{2E}\u{2C}\u{3}\u{2}\u{2}\u{2}" .
		    "\u{2E}\u{2F}\u{3}\u{2}\u{2}\u{2}\u{2F}\u{14}\u{3}\u{2}\u{2}\u{2}\u{30}" .
		    "\u{32}\u{9}\u{3}\u{2}\u{2}\u{31}\u{30}\u{3}\u{2}\u{2}\u{2}\u{32}\u{33}" .
		    "\u{3}\u{2}\u{2}\u{2}\u{33}\u{31}\u{3}\u{2}\u{2}\u{2}\u{33}\u{34}\u{3}" .
		    "\u{2}\u{2}\u{2}\u{34}\u{16}\u{3}\u{2}\u{2}\u{2}\u{35}\u{37}\u{7}\u{25}" .
		    "\u{2}\u{2}\u{36}\u{38}\u{9}\u{4}\u{2}\u{2}\u{37}\u{36}\u{3}\u{2}\u{2}" .
		    "\u{2}\u{38}\u{39}\u{3}\u{2}\u{2}\u{2}\u{39}\u{37}\u{3}\u{2}\u{2}\u{2}" .
		    "\u{39}\u{3A}\u{3}\u{2}\u{2}\u{2}\u{3A}\u{3B}\u{3}\u{2}\u{2}\u{2}\u{3B}" .
		    "\u{3C}\u{8}\u{C}\u{2}\u{2}\u{3C}\u{18}\u{3}\u{2}\u{2}\u{2}\u{3D}\u{3F}" .
		    "\u{9}\u{5}\u{2}\u{2}\u{3E}\u{3D}\u{3}\u{2}\u{2}\u{2}\u{3F}\u{40}\u{3}" .
		    "\u{2}\u{2}\u{2}\u{40}\u{3E}\u{3}\u{2}\u{2}\u{2}\u{40}\u{41}\u{3}\u{2}" .
		    "\u{2}\u{2}\u{41}\u{42}\u{3}\u{2}\u{2}\u{2}\u{42}\u{43}\u{8}\u{D}\u{2}" .
		    "\u{2}\u{43}\u{1A}\u{3}\u{2}\u{2}\u{2}\u{7}\u{2}\u{2E}\u{33}\u{39}" .
		    "\u{40}\u{3}\u{8}\u{2}\u{2}";

		protected static $atn;
		protected static $decisionToDFA;
		protected static $sharedContextCache;
		public function __construct(CharStream $input)
		{
			parent::__construct($input);

			self::initialize();

			$this->interp = new LexerATNSimulator($this, self::$atn, self::$decisionToDFA, self::$sharedContextCache);
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

		public static function vocabulary() : Vocabulary
		{
			static $vocabulary;

			return $vocabulary = $vocabulary ?? new VocabularyImpl(self::LITERAL_NAMES, self::SYMBOLIC_NAMES);
		}

		public function getGrammarFileName() : string
		{
			return 'SimpleGrammar.g4';
		}

		public function getRuleNames() : array
		{
			return self::RULE_NAMES;
		}

		public function getSerializedATN() : string
		{
			return self::SERIALIZED_ATN;
		}

		/**
		 * @return array<string>
		 */
		public function getChannelNames() : array
		{
			return self::CHANNEL_NAMES;
		}

		/**
		 * @return array<string>
		 */
		public function getModeNames() : array
		{
			return self::MODE_NAMES;
		}

		public function getATN() : ATN
		{
			return self::$atn;
		}

		public function getVocabulary() : Vocabulary
		{
			return self::vocabulary();
		}
	}
}