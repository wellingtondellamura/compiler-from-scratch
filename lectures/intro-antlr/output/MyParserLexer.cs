//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\MyParser.g4 by ANTLR 4.8

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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class MyParserLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		PRINT=1, SCAN=2, FUNC=3, IF=4, ELSE=5, FOR=6, WHILE=7, STRING=8, INT=9, 
		FLOAT=10, CHAR=11, TYPE=12, MATH=13, FLOOR=14, CEIL=15, SQRT=16, POT=17, 
		FMAX=18, FMIN=19, RINT=20, PONT=21, OPEN=22, CLOSE=23, OPENB=24, CLOSEB=25, 
		SUM=26, SUB=27, MULT=28, DIV=29, MOD=30, COMA=31, EOL=32, EQUAL=33, DEQUAL=34, 
		DSUM=35, DSUB=36, BIGGER=37, SMALLER=38, BEQUAL=39, SMEQUAL=40, NEQUAL=41, 
		AND=42, OR=43, NUM=44, VAR=45, COMMENT=46, LINE_COMMENT=47, WS=48;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"PRINT", "SCAN", "FUNC", "IF", "ELSE", "FOR", "WHILE", "STRING", "INT", 
		"FLOAT", "CHAR", "TYPE", "MATH", "FLOOR", "CEIL", "SQRT", "POT", "FMAX", 
		"FMIN", "RINT", "PONT", "OPEN", "CLOSE", "OPENB", "CLOSEB", "SUM", "SUB", 
		"MULT", "DIV", "MOD", "COMA", "EOL", "EQUAL", "DEQUAL", "DSUM", "DSUB", 
		"BIGGER", "SMALLER", "BEQUAL", "SMEQUAL", "NEQUAL", "AND", "OR", "NUM", 
		"VAR", "COMMENT", "LINE_COMMENT", "WS"
	};


	public MyParserLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MyParserLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'print'", "'scan'", "'func'", "'if'", "'else'", "'for'", "'while'", 
		"'string'", "'int'", "'float'", "'char'", "'type'", "'math'", "'floor'", 
		"'ceil'", "'sqrt'", "'pot'", "'fmax'", "'fmin'", "'rint'", "'.'", "'('", 
		"')'", "'{'", "'}'", "'+'", "'-'", "'*'", "'/'", "'%'", "','", "';'", 
		"'='", "'=='", "'+='", "'-='", "'>'", "'<'", "'>='", "'<='", "'!='", "'&&'", 
		"'||'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PRINT", "SCAN", "FUNC", "IF", "ELSE", "FOR", "WHILE", "STRING", 
		"INT", "FLOAT", "CHAR", "TYPE", "MATH", "FLOOR", "CEIL", "SQRT", "POT", 
		"FMAX", "FMIN", "RINT", "PONT", "OPEN", "CLOSE", "OPENB", "CLOSEB", "SUM", 
		"SUB", "MULT", "DIV", "MOD", "COMA", "EOL", "EQUAL", "DEQUAL", "DSUM", 
		"DSUB", "BIGGER", "SMALLER", "BEQUAL", "SMEQUAL", "NEQUAL", "AND", "OR", 
		"NUM", "VAR", "COMMENT", "LINE_COMMENT", "WS"
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

	public override string GrammarFileName { get { return "MyParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static MyParserLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x32', '\x136', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', 
		'\"', '\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', 
		'$', '\x3', '$', '\x3', '%', '\x3', '%', '\x3', '%', '\x3', '&', '\x3', 
		'&', '\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', '(', '\x3', '(', '\x3', 
		')', '\x3', ')', '\x3', ')', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', 
		'+', '\x3', '+', '\x3', '+', '\x3', ',', '\x3', ',', '\x3', ',', '\x3', 
		'-', '\x5', '-', '\x100', '\n', '-', '\x3', '-', '\x6', '-', '\x103', 
		'\n', '-', '\r', '-', '\xE', '-', '\x104', '\x3', '-', '\x3', '-', '\x6', 
		'-', '\x109', '\n', '-', '\r', '-', '\xE', '-', '\x10A', '\x5', '-', '\x10D', 
		'\n', '-', '\x3', '.', '\x3', '.', '\x3', '.', '\a', '.', '\x112', '\n', 
		'.', '\f', '.', '\xE', '.', '\x115', '\v', '.', '\x3', '/', '\x3', '/', 
		'\x3', '/', '\x3', '/', '\a', '/', '\x11B', '\n', '/', '\f', '/', '\xE', 
		'/', '\x11E', '\v', '/', '\x3', '/', '\x3', '/', '\x3', '/', '\x3', '/', 
		'\x3', '/', '\x3', '\x30', '\x3', '\x30', '\x3', '\x30', '\x3', '\x30', 
		'\a', '\x30', '\x129', '\n', '\x30', '\f', '\x30', '\xE', '\x30', '\x12C', 
		'\v', '\x30', '\x3', '\x30', '\x3', '\x30', '\x3', '\x31', '\x6', '\x31', 
		'\x131', '\n', '\x31', '\r', '\x31', '\xE', '\x31', '\x132', '\x3', '\x31', 
		'\x3', '\x31', '\x3', '\x11C', '\x2', '\x32', '\x3', '\x3', '\x5', '\x4', 
		'\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', 
		'\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', 
		'\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '%', 
		'\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', '\x19', 
		'\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', '\x39', 
		'\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', '#', '\x45', 
		'$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', '*', 'S', 
		'+', 'U', ',', 'W', '-', 'Y', '.', '[', '/', ']', '\x30', '_', '\x31', 
		'\x61', '\x32', '\x3', '\x2', '\b', '\x4', '\x2', '-', '-', '/', '/', 
		'\x3', '\x2', '\x32', ';', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x6', 
		'\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x4', 
		'\x2', '\f', '\f', '\xF', '\xF', '\x5', '\x2', '\v', '\f', '\xF', '\xF', 
		'\"', '\"', '\x2', '\x13D', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'S', '\x3', '\x2', '\x2', '\x2', '\x2', 'U', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'W', '\x3', '\x2', '\x2', '\x2', '\x2', 'Y', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '[', '\x3', '\x2', '\x2', '\x2', '\x2', ']', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '_', '\x3', '\x2', '\x2', '\x2', '\x2', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x63', '\x3', '\x2', '\x2', '\x2', 
		'\x5', 'i', '\x3', '\x2', '\x2', '\x2', '\a', 'n', '\x3', '\x2', '\x2', 
		'\x2', '\t', 's', '\x3', '\x2', '\x2', '\x2', '\v', 'v', '\x3', '\x2', 
		'\x2', '\x2', '\r', '{', '\x3', '\x2', '\x2', '\x2', '\xF', '\x7F', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '\x85', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x8C', '\x3', '\x2', '\x2', '\x2', '\x15', '\x90', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x96', '\x3', '\x2', '\x2', '\x2', '\x19', '\x9B', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\xA0', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\xA5', '\x3', '\x2', '\x2', '\x2', '\x1F', '\xAB', '\x3', '\x2', '\x2', 
		'\x2', '!', '\xB0', '\x3', '\x2', '\x2', '\x2', '#', '\xB5', '\x3', '\x2', 
		'\x2', '\x2', '%', '\xB9', '\x3', '\x2', '\x2', '\x2', '\'', '\xBE', '\x3', 
		'\x2', '\x2', '\x2', ')', '\xC3', '\x3', '\x2', '\x2', '\x2', '+', '\xC8', 
		'\x3', '\x2', '\x2', '\x2', '-', '\xCA', '\x3', '\x2', '\x2', '\x2', '/', 
		'\xCC', '\x3', '\x2', '\x2', '\x2', '\x31', '\xCE', '\x3', '\x2', '\x2', 
		'\x2', '\x33', '\xD0', '\x3', '\x2', '\x2', '\x2', '\x35', '\xD2', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\xD4', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'\xD6', '\x3', '\x2', '\x2', '\x2', ';', '\xD8', '\x3', '\x2', '\x2', 
		'\x2', '=', '\xDA', '\x3', '\x2', '\x2', '\x2', '?', '\xDC', '\x3', '\x2', 
		'\x2', '\x2', '\x41', '\xDE', '\x3', '\x2', '\x2', '\x2', '\x43', '\xE0', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\xE2', '\x3', '\x2', '\x2', '\x2', 
		'G', '\xE5', '\x3', '\x2', '\x2', '\x2', 'I', '\xE8', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\xEB', '\x3', '\x2', '\x2', '\x2', 'M', '\xED', '\x3', '\x2', 
		'\x2', '\x2', 'O', '\xEF', '\x3', '\x2', '\x2', '\x2', 'Q', '\xF2', '\x3', 
		'\x2', '\x2', '\x2', 'S', '\xF5', '\x3', '\x2', '\x2', '\x2', 'U', '\xF8', 
		'\x3', '\x2', '\x2', '\x2', 'W', '\xFB', '\x3', '\x2', '\x2', '\x2', 'Y', 
		'\xFF', '\x3', '\x2', '\x2', '\x2', '[', '\x10E', '\x3', '\x2', '\x2', 
		'\x2', ']', '\x116', '\x3', '\x2', '\x2', '\x2', '_', '\x124', '\x3', 
		'\x2', '\x2', '\x2', '\x61', '\x130', '\x3', '\x2', '\x2', '\x2', '\x63', 
		'\x64', '\a', 'r', '\x2', '\x2', '\x64', '\x65', '\a', 't', '\x2', '\x2', 
		'\x65', '\x66', '\a', 'k', '\x2', '\x2', '\x66', 'g', '\a', 'p', '\x2', 
		'\x2', 'g', 'h', '\a', 'v', '\x2', '\x2', 'h', '\x4', '\x3', '\x2', '\x2', 
		'\x2', 'i', 'j', '\a', 'u', '\x2', '\x2', 'j', 'k', '\a', '\x65', '\x2', 
		'\x2', 'k', 'l', '\a', '\x63', '\x2', '\x2', 'l', 'm', '\a', 'p', '\x2', 
		'\x2', 'm', '\x6', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', 'h', '\x2', 
		'\x2', 'o', 'p', '\a', 'w', '\x2', '\x2', 'p', 'q', '\a', 'p', '\x2', 
		'\x2', 'q', 'r', '\a', '\x65', '\x2', '\x2', 'r', '\b', '\x3', '\x2', 
		'\x2', '\x2', 's', 't', '\a', 'k', '\x2', '\x2', 't', 'u', '\a', 'h', 
		'\x2', '\x2', 'u', '\n', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\a', 'g', 
		'\x2', '\x2', 'w', 'x', '\a', 'n', '\x2', '\x2', 'x', 'y', '\a', 'u', 
		'\x2', '\x2', 'y', 'z', '\a', 'g', '\x2', '\x2', 'z', '\f', '\x3', '\x2', 
		'\x2', '\x2', '{', '|', '\a', 'h', '\x2', '\x2', '|', '}', '\a', 'q', 
		'\x2', '\x2', '}', '~', '\a', 't', '\x2', '\x2', '~', '\xE', '\x3', '\x2', 
		'\x2', '\x2', '\x7F', '\x80', '\a', 'y', '\x2', '\x2', '\x80', '\x81', 
		'\a', 'j', '\x2', '\x2', '\x81', '\x82', '\a', 'k', '\x2', '\x2', '\x82', 
		'\x83', '\a', 'n', '\x2', '\x2', '\x83', '\x84', '\a', 'g', '\x2', '\x2', 
		'\x84', '\x10', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', 'u', 
		'\x2', '\x2', '\x86', '\x87', '\a', 'v', '\x2', '\x2', '\x87', '\x88', 
		'\a', 't', '\x2', '\x2', '\x88', '\x89', '\a', 'k', '\x2', '\x2', '\x89', 
		'\x8A', '\a', 'p', '\x2', '\x2', '\x8A', '\x8B', '\a', 'i', '\x2', '\x2', 
		'\x8B', '\x12', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8D', '\a', 'k', 
		'\x2', '\x2', '\x8D', '\x8E', '\a', 'p', '\x2', '\x2', '\x8E', '\x8F', 
		'\a', 'v', '\x2', '\x2', '\x8F', '\x14', '\x3', '\x2', '\x2', '\x2', '\x90', 
		'\x91', '\a', 'h', '\x2', '\x2', '\x91', '\x92', '\a', 'n', '\x2', '\x2', 
		'\x92', '\x93', '\a', 'q', '\x2', '\x2', '\x93', '\x94', '\a', '\x63', 
		'\x2', '\x2', '\x94', '\x95', '\a', 'v', '\x2', '\x2', '\x95', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x96', '\x97', '\a', '\x65', '\x2', '\x2', 
		'\x97', '\x98', '\a', 'j', '\x2', '\x2', '\x98', '\x99', '\a', '\x63', 
		'\x2', '\x2', '\x99', '\x9A', '\a', 't', '\x2', '\x2', '\x9A', '\x18', 
		'\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\a', 'v', '\x2', '\x2', '\x9C', 
		'\x9D', '\a', '{', '\x2', '\x2', '\x9D', '\x9E', '\a', 'r', '\x2', '\x2', 
		'\x9E', '\x9F', '\a', 'g', '\x2', '\x2', '\x9F', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', '\xA0', '\xA1', '\a', 'o', '\x2', '\x2', '\xA1', '\xA2', 
		'\a', '\x63', '\x2', '\x2', '\xA2', '\xA3', '\a', 'v', '\x2', '\x2', '\xA3', 
		'\xA4', '\a', 'j', '\x2', '\x2', '\xA4', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\xA5', '\xA6', '\a', 'h', '\x2', '\x2', '\xA6', '\xA7', '\a', 
		'n', '\x2', '\x2', '\xA7', '\xA8', '\a', 'q', '\x2', '\x2', '\xA8', '\xA9', 
		'\a', 'q', '\x2', '\x2', '\xA9', '\xAA', '\a', 't', '\x2', '\x2', '\xAA', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', '\a', '\x65', '\x2', 
		'\x2', '\xAC', '\xAD', '\a', 'g', '\x2', '\x2', '\xAD', '\xAE', '\a', 
		'k', '\x2', '\x2', '\xAE', '\xAF', '\a', 'n', '\x2', '\x2', '\xAF', ' ', 
		'\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\a', 'u', '\x2', '\x2', '\xB1', 
		'\xB2', '\a', 's', '\x2', '\x2', '\xB2', '\xB3', '\a', 't', '\x2', '\x2', 
		'\xB3', '\xB4', '\a', 'v', '\x2', '\x2', '\xB4', '\"', '\x3', '\x2', '\x2', 
		'\x2', '\xB5', '\xB6', '\a', 'r', '\x2', '\x2', '\xB6', '\xB7', '\a', 
		'q', '\x2', '\x2', '\xB7', '\xB8', '\a', 'v', '\x2', '\x2', '\xB8', '$', 
		'\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', '\a', 'h', '\x2', '\x2', '\xBA', 
		'\xBB', '\a', 'o', '\x2', '\x2', '\xBB', '\xBC', '\a', '\x63', '\x2', 
		'\x2', '\xBC', '\xBD', '\a', 'z', '\x2', '\x2', '\xBD', '&', '\x3', '\x2', 
		'\x2', '\x2', '\xBE', '\xBF', '\a', 'h', '\x2', '\x2', '\xBF', '\xC0', 
		'\a', 'o', '\x2', '\x2', '\xC0', '\xC1', '\a', 'k', '\x2', '\x2', '\xC1', 
		'\xC2', '\a', 'p', '\x2', '\x2', '\xC2', '(', '\x3', '\x2', '\x2', '\x2', 
		'\xC3', '\xC4', '\a', 't', '\x2', '\x2', '\xC4', '\xC5', '\a', 'k', '\x2', 
		'\x2', '\xC5', '\xC6', '\a', 'p', '\x2', '\x2', '\xC6', '\xC7', '\a', 
		'v', '\x2', '\x2', '\xC7', '*', '\x3', '\x2', '\x2', '\x2', '\xC8', '\xC9', 
		'\a', '\x30', '\x2', '\x2', '\xC9', ',', '\x3', '\x2', '\x2', '\x2', '\xCA', 
		'\xCB', '\a', '*', '\x2', '\x2', '\xCB', '.', '\x3', '\x2', '\x2', '\x2', 
		'\xCC', '\xCD', '\a', '+', '\x2', '\x2', '\xCD', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\xCE', '\xCF', '\a', '}', '\x2', '\x2', '\xCF', '\x32', 
		'\x3', '\x2', '\x2', '\x2', '\xD0', '\xD1', '\a', '\x7F', '\x2', '\x2', 
		'\xD1', '\x34', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD3', '\a', '-', 
		'\x2', '\x2', '\xD3', '\x36', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD5', 
		'\a', '/', '\x2', '\x2', '\xD5', '\x38', '\x3', '\x2', '\x2', '\x2', '\xD6', 
		'\xD7', '\a', ',', '\x2', '\x2', '\xD7', ':', '\x3', '\x2', '\x2', '\x2', 
		'\xD8', '\xD9', '\a', '\x31', '\x2', '\x2', '\xD9', '<', '\x3', '\x2', 
		'\x2', '\x2', '\xDA', '\xDB', '\a', '\'', '\x2', '\x2', '\xDB', '>', '\x3', 
		'\x2', '\x2', '\x2', '\xDC', '\xDD', '\a', '.', '\x2', '\x2', '\xDD', 
		'@', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', '\a', '=', '\x2', '\x2', 
		'\xDF', '\x42', '\x3', '\x2', '\x2', '\x2', '\xE0', '\xE1', '\a', '?', 
		'\x2', '\x2', '\xE1', '\x44', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xE3', 
		'\a', '?', '\x2', '\x2', '\xE3', '\xE4', '\a', '?', '\x2', '\x2', '\xE4', 
		'\x46', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE6', '\a', '-', '\x2', 
		'\x2', '\xE6', '\xE7', '\a', '?', '\x2', '\x2', '\xE7', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\xE8', '\xE9', '\a', '/', '\x2', '\x2', '\xE9', '\xEA', 
		'\a', '?', '\x2', '\x2', '\xEA', 'J', '\x3', '\x2', '\x2', '\x2', '\xEB', 
		'\xEC', '\a', '@', '\x2', '\x2', '\xEC', 'L', '\x3', '\x2', '\x2', '\x2', 
		'\xED', '\xEE', '\a', '>', '\x2', '\x2', '\xEE', 'N', '\x3', '\x2', '\x2', 
		'\x2', '\xEF', '\xF0', '\a', '@', '\x2', '\x2', '\xF0', '\xF1', '\a', 
		'?', '\x2', '\x2', '\xF1', 'P', '\x3', '\x2', '\x2', '\x2', '\xF2', '\xF3', 
		'\a', '>', '\x2', '\x2', '\xF3', '\xF4', '\a', '?', '\x2', '\x2', '\xF4', 
		'R', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF6', '\a', '#', '\x2', '\x2', 
		'\xF6', '\xF7', '\a', '?', '\x2', '\x2', '\xF7', 'T', '\x3', '\x2', '\x2', 
		'\x2', '\xF8', '\xF9', '\a', '(', '\x2', '\x2', '\xF9', '\xFA', '\a', 
		'(', '\x2', '\x2', '\xFA', 'V', '\x3', '\x2', '\x2', '\x2', '\xFB', '\xFC', 
		'\a', '~', '\x2', '\x2', '\xFC', '\xFD', '\a', '~', '\x2', '\x2', '\xFD', 
		'X', '\x3', '\x2', '\x2', '\x2', '\xFE', '\x100', '\t', '\x2', '\x2', 
		'\x2', '\xFF', '\xFE', '\x3', '\x2', '\x2', '\x2', '\xFF', '\x100', '\x3', 
		'\x2', '\x2', '\x2', '\x100', '\x102', '\x3', '\x2', '\x2', '\x2', '\x101', 
		'\x103', '\t', '\x3', '\x2', '\x2', '\x102', '\x101', '\x3', '\x2', '\x2', 
		'\x2', '\x103', '\x104', '\x3', '\x2', '\x2', '\x2', '\x104', '\x102', 
		'\x3', '\x2', '\x2', '\x2', '\x104', '\x105', '\x3', '\x2', '\x2', '\x2', 
		'\x105', '\x10C', '\x3', '\x2', '\x2', '\x2', '\x106', '\x108', '\a', 
		'\x30', '\x2', '\x2', '\x107', '\x109', '\t', '\x3', '\x2', '\x2', '\x108', 
		'\x107', '\x3', '\x2', '\x2', '\x2', '\x109', '\x10A', '\x3', '\x2', '\x2', 
		'\x2', '\x10A', '\x108', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x10B', 
		'\x3', '\x2', '\x2', '\x2', '\x10B', '\x10D', '\x3', '\x2', '\x2', '\x2', 
		'\x10C', '\x106', '\x3', '\x2', '\x2', '\x2', '\x10C', '\x10D', '\x3', 
		'\x2', '\x2', '\x2', '\x10D', 'Z', '\x3', '\x2', '\x2', '\x2', '\x10E', 
		'\x10F', '\a', '\x42', '\x2', '\x2', '\x10F', '\x113', '\t', '\x4', '\x2', 
		'\x2', '\x110', '\x112', '\t', '\x5', '\x2', '\x2', '\x111', '\x110', 
		'\x3', '\x2', '\x2', '\x2', '\x112', '\x115', '\x3', '\x2', '\x2', '\x2', 
		'\x113', '\x111', '\x3', '\x2', '\x2', '\x2', '\x113', '\x114', '\x3', 
		'\x2', '\x2', '\x2', '\x114', '\\', '\x3', '\x2', '\x2', '\x2', '\x115', 
		'\x113', '\x3', '\x2', '\x2', '\x2', '\x116', '\x117', '\a', '\x31', '\x2', 
		'\x2', '\x117', '\x118', '\a', ',', '\x2', '\x2', '\x118', '\x11C', '\x3', 
		'\x2', '\x2', '\x2', '\x119', '\x11B', '\v', '\x2', '\x2', '\x2', '\x11A', 
		'\x119', '\x3', '\x2', '\x2', '\x2', '\x11B', '\x11E', '\x3', '\x2', '\x2', 
		'\x2', '\x11C', '\x11D', '\x3', '\x2', '\x2', '\x2', '\x11C', '\x11A', 
		'\x3', '\x2', '\x2', '\x2', '\x11D', '\x11F', '\x3', '\x2', '\x2', '\x2', 
		'\x11E', '\x11C', '\x3', '\x2', '\x2', '\x2', '\x11F', '\x120', '\a', 
		',', '\x2', '\x2', '\x120', '\x121', '\a', '\x31', '\x2', '\x2', '\x121', 
		'\x122', '\x3', '\x2', '\x2', '\x2', '\x122', '\x123', '\b', '/', '\x2', 
		'\x2', '\x123', '^', '\x3', '\x2', '\x2', '\x2', '\x124', '\x125', '\a', 
		'\x31', '\x2', '\x2', '\x125', '\x126', '\a', '\x31', '\x2', '\x2', '\x126', 
		'\x12A', '\x3', '\x2', '\x2', '\x2', '\x127', '\x129', '\n', '\x6', '\x2', 
		'\x2', '\x128', '\x127', '\x3', '\x2', '\x2', '\x2', '\x129', '\x12C', 
		'\x3', '\x2', '\x2', '\x2', '\x12A', '\x128', '\x3', '\x2', '\x2', '\x2', 
		'\x12A', '\x12B', '\x3', '\x2', '\x2', '\x2', '\x12B', '\x12D', '\x3', 
		'\x2', '\x2', '\x2', '\x12C', '\x12A', '\x3', '\x2', '\x2', '\x2', '\x12D', 
		'\x12E', '\b', '\x30', '\x2', '\x2', '\x12E', '`', '\x3', '\x2', '\x2', 
		'\x2', '\x12F', '\x131', '\t', '\a', '\x2', '\x2', '\x130', '\x12F', '\x3', 
		'\x2', '\x2', '\x2', '\x131', '\x132', '\x3', '\x2', '\x2', '\x2', '\x132', 
		'\x130', '\x3', '\x2', '\x2', '\x2', '\x132', '\x133', '\x3', '\x2', '\x2', 
		'\x2', '\x133', '\x134', '\x3', '\x2', '\x2', '\x2', '\x134', '\x135', 
		'\b', '\x31', '\x2', '\x2', '\x135', '\x62', '\x3', '\x2', '\x2', '\x2', 
		'\v', '\x2', '\xFF', '\x104', '\x10A', '\x10C', '\x113', '\x11C', '\x12A', 
		'\x132', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Grammar
