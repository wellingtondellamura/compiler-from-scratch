// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\MyCompiler\Parser\MyParser.g4 by ANTLR 4.8
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class MyParserLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		IF=1, ELSE=2, GT=3, LT=4, EQ=5, GE=6, LE=7, NE=8, PLUS=9, MINUS=10, MULT=11, 
		DIV=12, OPEN=13, CLOSE=14, OPEN_BL=15, CLOSE_BL=16, IS=17, EOL=18, PRINT=19, 
		READ=20, TYPE=21, NUM=22, VAR=23, STR=24, WS=25;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"IF", "ELSE", "GT", "LT", "EQ", "GE", "LE", "NE", "PLUS", "MINUS", "MULT", 
			"DIV", "OPEN", "CLOSE", "OPEN_BL", "CLOSE_BL", "IS", "EOL", "PRINT", 
			"READ", "TYPE", "NUM", "VAR", "STR", "WS"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'if'", "'else'", "'>'", "'<'", "'=='", "'>='", "'<='", "'!='", 
			"'+'", "'-'", "'*'", "'/'", "'('", "')'", "'{'", "'}'", "'='", "';'", 
			"'print'", "'read'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "IF", "ELSE", "GT", "LT", "EQ", "GE", "LE", "NE", "PLUS", "MINUS", 
			"MULT", "DIV", "OPEN", "CLOSE", "OPEN_BL", "CLOSE_BL", "IS", "EOL", "PRINT", 
			"READ", "TYPE", "NUM", "VAR", "STR", "WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public MyParserLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "MyParser.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\33\u00a4\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31"+
		"\t\31\4\32\t\32\3\2\3\2\3\2\3\3\3\3\3\3\3\3\3\3\3\4\3\4\3\5\3\5\3\6\3"+
		"\6\3\6\3\7\3\7\3\7\3\b\3\b\3\b\3\t\3\t\3\t\3\n\3\n\3\13\3\13\3\f\3\f\3"+
		"\r\3\r\3\16\3\16\3\17\3\17\3\20\3\20\3\21\3\21\3\22\3\22\3\23\3\23\3\24"+
		"\3\24\3\24\3\24\3\24\3\24\3\25\3\25\3\25\3\25\3\25\3\26\3\26\3\26\3\26"+
		"\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\26"+
		"\3\26\3\26\3\26\3\26\3\26\3\26\5\26\u0085\n\26\3\27\6\27\u0088\n\27\r"+
		"\27\16\27\u0089\3\30\3\30\7\30\u008e\n\30\f\30\16\30\u0091\13\30\3\31"+
		"\3\31\3\31\3\31\7\31\u0097\n\31\f\31\16\31\u009a\13\31\3\31\3\31\3\32"+
		"\6\32\u009f\n\32\r\32\16\32\u00a0\3\32\3\32\2\2\33\3\3\5\4\7\5\t\6\13"+
		"\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23%\24\'"+
		"\25)\26+\27-\30/\31\61\32\63\33\3\2\b\3\2\62;\4\2C\\c|\6\2\62;C\\aac|"+
		"\4\2$$^^\6\2\f\f\17\17$$^^\5\2\13\f\17\17\"\"\2\u00ac\2\3\3\2\2\2\2\5"+
		"\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2"+
		"\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33"+
		"\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2"+
		"\'\3\2\2\2\2)\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2\2\2"+
		"\63\3\2\2\2\3\65\3\2\2\2\58\3\2\2\2\7=\3\2\2\2\t?\3\2\2\2\13A\3\2\2\2"+
		"\rD\3\2\2\2\17G\3\2\2\2\21J\3\2\2\2\23M\3\2\2\2\25O\3\2\2\2\27Q\3\2\2"+
		"\2\31S\3\2\2\2\33U\3\2\2\2\35W\3\2\2\2\37Y\3\2\2\2![\3\2\2\2#]\3\2\2\2"+
		"%_\3\2\2\2\'a\3\2\2\2)g\3\2\2\2+\u0084\3\2\2\2-\u0087\3\2\2\2/\u008b\3"+
		"\2\2\2\61\u0092\3\2\2\2\63\u009e\3\2\2\2\65\66\7k\2\2\66\67\7h\2\2\67"+
		"\4\3\2\2\289\7g\2\29:\7n\2\2:;\7u\2\2;<\7g\2\2<\6\3\2\2\2=>\7@\2\2>\b"+
		"\3\2\2\2?@\7>\2\2@\n\3\2\2\2AB\7?\2\2BC\7?\2\2C\f\3\2\2\2DE\7@\2\2EF\7"+
		"?\2\2F\16\3\2\2\2GH\7>\2\2HI\7?\2\2I\20\3\2\2\2JK\7#\2\2KL\7?\2\2L\22"+
		"\3\2\2\2MN\7-\2\2N\24\3\2\2\2OP\7/\2\2P\26\3\2\2\2QR\7,\2\2R\30\3\2\2"+
		"\2ST\7\61\2\2T\32\3\2\2\2UV\7*\2\2V\34\3\2\2\2WX\7+\2\2X\36\3\2\2\2YZ"+
		"\7}\2\2Z \3\2\2\2[\\\7\177\2\2\\\"\3\2\2\2]^\7?\2\2^$\3\2\2\2_`\7=\2\2"+
		"`&\3\2\2\2ab\7r\2\2bc\7t\2\2cd\7k\2\2de\7p\2\2ef\7v\2\2f(\3\2\2\2gh\7"+
		"t\2\2hi\7g\2\2ij\7c\2\2jk\7f\2\2k*\3\2\2\2lm\7d\2\2mn\7q\2\2no\7q\2\2"+
		"o\u0085\7n\2\2pq\7f\2\2qr\7q\2\2rs\7w\2\2st\7d\2\2tu\7n\2\2u\u0085\7g"+
		"\2\2vw\7h\2\2wx\7n\2\2xy\7q\2\2yz\7c\2\2z\u0085\7v\2\2{|\7u\2\2|}\7v\2"+
		"\2}~\7t\2\2~\177\7k\2\2\177\u0080\7p\2\2\u0080\u0085\7i\2\2\u0081\u0082"+
		"\7k\2\2\u0082\u0083\7p\2\2\u0083\u0085\7v\2\2\u0084l\3\2\2\2\u0084p\3"+
		"\2\2\2\u0084v\3\2\2\2\u0084{\3\2\2\2\u0084\u0081\3\2\2\2\u0085,\3\2\2"+
		"\2\u0086\u0088\t\2\2\2\u0087\u0086\3\2\2\2\u0088\u0089\3\2\2\2\u0089\u0087"+
		"\3\2\2\2\u0089\u008a\3\2\2\2\u008a.\3\2\2\2\u008b\u008f\t\3\2\2\u008c"+
		"\u008e\t\4\2\2\u008d\u008c\3\2\2\2\u008e\u0091\3\2\2\2\u008f\u008d\3\2"+
		"\2\2\u008f\u0090\3\2\2\2\u0090\60\3\2\2\2\u0091\u008f\3\2\2\2\u0092\u0098"+
		"\7$\2\2\u0093\u0094\7^\2\2\u0094\u0097\t\5\2\2\u0095\u0097\n\6\2\2\u0096"+
		"\u0093\3\2\2\2\u0096\u0095\3\2\2\2\u0097\u009a\3\2\2\2\u0098\u0096\3\2"+
		"\2\2\u0098\u0099\3\2\2\2\u0099\u009b\3\2\2\2\u009a\u0098\3\2\2\2\u009b"+
		"\u009c\7$\2\2\u009c\62\3\2\2\2\u009d\u009f\t\7\2\2\u009e\u009d\3\2\2\2"+
		"\u009f\u00a0\3\2\2\2\u00a0\u009e\3\2\2\2\u00a0\u00a1\3\2\2\2\u00a1\u00a2"+
		"\3\2\2\2\u00a2\u00a3\b\32\2\2\u00a3\64\3\2\2\2\t\2\u0084\u0089\u008f\u0096"+
		"\u0098\u00a0\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}