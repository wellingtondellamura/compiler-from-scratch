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
		IF=1, ELSE=2, GT=3, LT=4, EQ=5, GE=6, LE=7, NE=8, PLUS=9, MINUS=10, MULT=11, 
		DIV=12, OPEN=13, CLOSE=14, OPEN_BL=15, CLOSE_BL=16, IS=17, EOL=18, PRINT=19, 
		READ=20, TYPE=21, NUM=22, VAR=23, STR=24, WS=25;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"IF", "ELSE", "GT", "LT", "EQ", "GE", "LE", "NE", "PLUS", "MINUS", "MULT", 
		"DIV", "OPEN", "CLOSE", "OPEN_BL", "CLOSE_BL", "IS", "EOL", "PRINT", "READ", 
		"TYPE", "NUM", "VAR", "STR", "WS"
	};


	public MyParserLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MyParserLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'if'", "'else'", "'>'", "'<'", "'=='", "'>='", "'<='", "'!='", 
		"'+'", "'-'", "'*'", "'/'", "'('", "')'", "'{'", "'}'", "'='", "';'", 
		"'print'", "'read'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "IF", "ELSE", "GT", "LT", "EQ", "GE", "LE", "NE", "PLUS", "MINUS", 
		"MULT", "DIV", "OPEN", "CLOSE", "OPEN_BL", "CLOSE_BL", "IS", "EOL", "PRINT", 
		"READ", "TYPE", "NUM", "VAR", "STR", "WS"
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
		'\x5964', '\x2', '\x1B', '\xA4', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x5', '\x16', '\x85', '\n', '\x16', '\x3', 
		'\x17', '\x6', '\x17', '\x88', '\n', '\x17', '\r', '\x17', '\xE', '\x17', 
		'\x89', '\x3', '\x18', '\x3', '\x18', '\a', '\x18', '\x8E', '\n', '\x18', 
		'\f', '\x18', '\xE', '\x18', '\x91', '\v', '\x18', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x19', '\x3', '\x19', '\a', '\x19', '\x97', '\n', '\x19', 
		'\f', '\x19', '\xE', '\x19', '\x9A', '\v', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x1A', '\x6', '\x1A', '\x9F', '\n', '\x1A', '\r', '\x1A', 
		'\xE', '\x1A', '\xA0', '\x3', '\x1A', '\x3', '\x1A', '\x2', '\x2', '\x1B', 
		'\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', 
		'\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', 
		'\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', 
		'#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', 
		'\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x3', '\x2', '\b', 
		'\x3', '\x2', '\x32', ';', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x6', 
		'\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x4', 
		'\x2', '$', '$', '^', '^', '\x6', '\x2', '\f', '\f', '\xF', '\xF', '$', 
		'$', '^', '^', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', 
		'\xAC', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\x35', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\a', '=', '\x3', '\x2', '\x2', '\x2', 
		'\t', '?', '\x3', '\x2', '\x2', '\x2', '\v', '\x41', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\x44', '\x3', '\x2', '\x2', '\x2', '\xF', 'G', '\x3', '\x2', 
		'\x2', '\x2', '\x11', 'J', '\x3', '\x2', '\x2', '\x2', '\x13', 'M', '\x3', 
		'\x2', '\x2', '\x2', '\x15', 'O', '\x3', '\x2', '\x2', '\x2', '\x17', 
		'Q', '\x3', '\x2', '\x2', '\x2', '\x19', 'S', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', 'U', '\x3', '\x2', '\x2', '\x2', '\x1D', 'W', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', 'Y', '\x3', '\x2', '\x2', '\x2', '!', '[', '\x3', '\x2', 
		'\x2', '\x2', '#', ']', '\x3', '\x2', '\x2', '\x2', '%', '_', '\x3', '\x2', 
		'\x2', '\x2', '\'', '\x61', '\x3', '\x2', '\x2', '\x2', ')', 'g', '\x3', 
		'\x2', '\x2', '\x2', '+', '\x84', '\x3', '\x2', '\x2', '\x2', '-', '\x87', 
		'\x3', '\x2', '\x2', '\x2', '/', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x92', '\x3', '\x2', '\x2', '\x2', '\x33', '\x9E', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\x36', '\a', 'k', '\x2', '\x2', '\x36', '\x37', '\a', 
		'h', '\x2', '\x2', '\x37', '\x4', '\x3', '\x2', '\x2', '\x2', '\x38', 
		'\x39', '\a', 'g', '\x2', '\x2', '\x39', ':', '\a', 'n', '\x2', '\x2', 
		':', ';', '\a', 'u', '\x2', '\x2', ';', '<', '\a', 'g', '\x2', '\x2', 
		'<', '\x6', '\x3', '\x2', '\x2', '\x2', '=', '>', '\a', '@', '\x2', '\x2', 
		'>', '\b', '\x3', '\x2', '\x2', '\x2', '?', '@', '\a', '>', '\x2', '\x2', 
		'@', '\n', '\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\a', '?', '\x2', 
		'\x2', '\x42', '\x43', '\a', '?', '\x2', '\x2', '\x43', '\f', '\x3', '\x2', 
		'\x2', '\x2', '\x44', '\x45', '\a', '@', '\x2', '\x2', '\x45', '\x46', 
		'\a', '?', '\x2', '\x2', '\x46', '\xE', '\x3', '\x2', '\x2', '\x2', 'G', 
		'H', '\a', '>', '\x2', '\x2', 'H', 'I', '\a', '?', '\x2', '\x2', 'I', 
		'\x10', '\x3', '\x2', '\x2', '\x2', 'J', 'K', '\a', '#', '\x2', '\x2', 
		'K', 'L', '\a', '?', '\x2', '\x2', 'L', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'M', 'N', '\a', '-', '\x2', '\x2', 'N', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'O', 'P', '\a', '/', '\x2', '\x2', 'P', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'Q', 'R', '\a', ',', '\x2', '\x2', 'R', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'S', 'T', '\a', '\x31', '\x2', '\x2', 'T', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', 'U', 'V', '\a', '*', '\x2', '\x2', 'V', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', 'W', 'X', '\a', '+', '\x2', '\x2', 'X', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', 'Y', 'Z', '\a', '}', '\x2', '\x2', 'Z', ' ', '\x3', '\x2', '\x2', 
		'\x2', '[', '\\', '\a', '\x7F', '\x2', '\x2', '\\', '\"', '\x3', '\x2', 
		'\x2', '\x2', ']', '^', '\a', '?', '\x2', '\x2', '^', '$', '\x3', '\x2', 
		'\x2', '\x2', '_', '`', '\a', '=', '\x2', '\x2', '`', '&', '\x3', '\x2', 
		'\x2', '\x2', '\x61', '\x62', '\a', 'r', '\x2', '\x2', '\x62', '\x63', 
		'\a', 't', '\x2', '\x2', '\x63', '\x64', '\a', 'k', '\x2', '\x2', '\x64', 
		'\x65', '\a', 'p', '\x2', '\x2', '\x65', '\x66', '\a', 'v', '\x2', '\x2', 
		'\x66', '(', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\a', 't', '\x2', '\x2', 
		'h', 'i', '\a', 'g', '\x2', '\x2', 'i', 'j', '\a', '\x63', '\x2', '\x2', 
		'j', 'k', '\a', '\x66', '\x2', '\x2', 'k', '*', '\x3', '\x2', '\x2', '\x2', 
		'l', 'm', '\a', '\x64', '\x2', '\x2', 'm', 'n', '\a', 'q', '\x2', '\x2', 
		'n', 'o', '\a', 'q', '\x2', '\x2', 'o', '\x85', '\a', 'n', '\x2', '\x2', 
		'p', 'q', '\a', '\x66', '\x2', '\x2', 'q', 'r', '\a', 'q', '\x2', '\x2', 
		'r', 's', '\a', 'w', '\x2', '\x2', 's', 't', '\a', '\x64', '\x2', '\x2', 
		't', 'u', '\a', 'n', '\x2', '\x2', 'u', '\x85', '\a', 'g', '\x2', '\x2', 
		'v', 'w', '\a', 'h', '\x2', '\x2', 'w', 'x', '\a', 'n', '\x2', '\x2', 
		'x', 'y', '\a', 'q', '\x2', '\x2', 'y', 'z', '\a', '\x63', '\x2', '\x2', 
		'z', '\x85', '\a', 'v', '\x2', '\x2', '{', '|', '\a', 'u', '\x2', '\x2', 
		'|', '}', '\a', 'v', '\x2', '\x2', '}', '~', '\a', 't', '\x2', '\x2', 
		'~', '\x7F', '\a', 'k', '\x2', '\x2', '\x7F', '\x80', '\a', 'p', '\x2', 
		'\x2', '\x80', '\x85', '\a', 'i', '\x2', '\x2', '\x81', '\x82', '\a', 
		'k', '\x2', '\x2', '\x82', '\x83', '\a', 'p', '\x2', '\x2', '\x83', '\x85', 
		'\a', 'v', '\x2', '\x2', '\x84', 'l', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'p', '\x3', '\x2', '\x2', '\x2', '\x84', 'v', '\x3', '\x2', '\x2', '\x2', 
		'\x84', '{', '\x3', '\x2', '\x2', '\x2', '\x84', '\x81', '\x3', '\x2', 
		'\x2', '\x2', '\x85', ',', '\x3', '\x2', '\x2', '\x2', '\x86', '\x88', 
		'\t', '\x2', '\x2', '\x2', '\x87', '\x86', '\x3', '\x2', '\x2', '\x2', 
		'\x88', '\x89', '\x3', '\x2', '\x2', '\x2', '\x89', '\x87', '\x3', '\x2', 
		'\x2', '\x2', '\x89', '\x8A', '\x3', '\x2', '\x2', '\x2', '\x8A', '.', 
		'\x3', '\x2', '\x2', '\x2', '\x8B', '\x8F', '\t', '\x3', '\x2', '\x2', 
		'\x8C', '\x8E', '\t', '\x4', '\x2', '\x2', '\x8D', '\x8C', '\x3', '\x2', 
		'\x2', '\x2', '\x8E', '\x91', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x8D', 
		'\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\x3', '\x2', '\x2', '\x2', 
		'\x90', '\x30', '\x3', '\x2', '\x2', '\x2', '\x91', '\x8F', '\x3', '\x2', 
		'\x2', '\x2', '\x92', '\x98', '\a', '$', '\x2', '\x2', '\x93', '\x94', 
		'\a', '^', '\x2', '\x2', '\x94', '\x97', '\t', '\x5', '\x2', '\x2', '\x95', 
		'\x97', '\n', '\x6', '\x2', '\x2', '\x96', '\x93', '\x3', '\x2', '\x2', 
		'\x2', '\x96', '\x95', '\x3', '\x2', '\x2', '\x2', '\x97', '\x9A', '\x3', 
		'\x2', '\x2', '\x2', '\x98', '\x96', '\x3', '\x2', '\x2', '\x2', '\x98', 
		'\x99', '\x3', '\x2', '\x2', '\x2', '\x99', '\x9B', '\x3', '\x2', '\x2', 
		'\x2', '\x9A', '\x98', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\a', 
		'$', '\x2', '\x2', '\x9C', '\x32', '\x3', '\x2', '\x2', '\x2', '\x9D', 
		'\x9F', '\t', '\a', '\x2', '\x2', '\x9E', '\x9D', '\x3', '\x2', '\x2', 
		'\x2', '\x9F', '\xA0', '\x3', '\x2', '\x2', '\x2', '\xA0', '\x9E', '\x3', 
		'\x2', '\x2', '\x2', '\xA0', '\xA1', '\x3', '\x2', '\x2', '\x2', '\xA1', 
		'\xA2', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', '\b', '\x1A', '\x2', 
		'\x2', '\xA3', '\x34', '\x3', '\x2', '\x2', '\x2', '\t', '\x2', '\x84', 
		'\x89', '\x8F', '\x96', '\x98', '\xA0', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Grammar