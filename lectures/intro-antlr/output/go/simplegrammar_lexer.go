// Code generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8. DO NOT EDIT.

package Grammar
import (
	"fmt"
	"unicode"

	"github.com/antlr/antlr4/runtime/Go/antlr"
)
// Suppress unused import error
var _ = fmt.Printf
var _ = unicode.IsLetter


var serializedLexerAtn = []uint16{
	3, 24715, 42794, 33075, 47597, 16764, 15335, 30598, 22884, 2, 14, 68, 8, 
	1, 4, 2, 9, 2, 4, 3, 9, 3, 4, 4, 9, 4, 4, 5, 9, 5, 4, 6, 9, 6, 4, 7, 9, 
	7, 4, 8, 9, 8, 4, 9, 9, 9, 4, 10, 9, 10, 4, 11, 9, 11, 4, 12, 9, 12, 4, 
	13, 9, 13, 3, 2, 3, 2, 3, 3, 3, 3, 3, 4, 3, 4, 3, 5, 3, 5, 3, 6, 3, 6, 
	3, 7, 3, 7, 3, 8, 3, 8, 3, 9, 3, 9, 3, 10, 6, 10, 45, 10, 10, 13, 10, 14, 
	10, 46, 3, 11, 6, 11, 50, 10, 11, 13, 11, 14, 11, 51, 3, 12, 3, 12, 6, 
	12, 56, 10, 12, 13, 12, 14, 12, 57, 3, 12, 3, 12, 3, 13, 6, 13, 63, 10, 
	13, 13, 13, 14, 13, 64, 3, 13, 3, 13, 2, 2, 14, 3, 3, 5, 4, 7, 5, 9, 6, 
	11, 7, 13, 8, 15, 9, 17, 10, 19, 11, 21, 12, 23, 13, 25, 14, 3, 2, 6, 3, 
	2, 50, 59, 4, 2, 67, 92, 99, 124, 5, 2, 12, 12, 15, 15, 128, 128, 5, 2, 
	11, 12, 15, 15, 34, 34, 2, 71, 2, 3, 3, 2, 2, 2, 2, 5, 3, 2, 2, 2, 2, 7, 
	3, 2, 2, 2, 2, 9, 3, 2, 2, 2, 2, 11, 3, 2, 2, 2, 2, 13, 3, 2, 2, 2, 2, 
	15, 3, 2, 2, 2, 2, 17, 3, 2, 2, 2, 2, 19, 3, 2, 2, 2, 2, 21, 3, 2, 2, 2, 
	2, 23, 3, 2, 2, 2, 2, 25, 3, 2, 2, 2, 3, 27, 3, 2, 2, 2, 5, 29, 3, 2, 2, 
	2, 7, 31, 3, 2, 2, 2, 9, 33, 3, 2, 2, 2, 11, 35, 3, 2, 2, 2, 13, 37, 3, 
	2, 2, 2, 15, 39, 3, 2, 2, 2, 17, 41, 3, 2, 2, 2, 19, 44, 3, 2, 2, 2, 21, 
	49, 3, 2, 2, 2, 23, 53, 3, 2, 2, 2, 25, 62, 3, 2, 2, 2, 27, 28, 7, 61, 
	2, 2, 28, 4, 3, 2, 2, 2, 29, 30, 7, 42, 2, 2, 30, 6, 3, 2, 2, 2, 31, 32, 
	7, 43, 2, 2, 32, 8, 3, 2, 2, 2, 33, 34, 7, 39, 2, 2, 34, 10, 3, 2, 2, 2, 
	35, 36, 7, 49, 2, 2, 36, 12, 3, 2, 2, 2, 37, 38, 7, 44, 2, 2, 38, 14, 3, 
	2, 2, 2, 39, 40, 7, 47, 2, 2, 40, 16, 3, 2, 2, 2, 41, 42, 7, 45, 2, 2, 
	42, 18, 3, 2, 2, 2, 43, 45, 9, 2, 2, 2, 44, 43, 3, 2, 2, 2, 45, 46, 3, 
	2, 2, 2, 46, 44, 3, 2, 2, 2, 46, 47, 3, 2, 2, 2, 47, 20, 3, 2, 2, 2, 48, 
	50, 9, 3, 2, 2, 49, 48, 3, 2, 2, 2, 50, 51, 3, 2, 2, 2, 51, 49, 3, 2, 2, 
	2, 51, 52, 3, 2, 2, 2, 52, 22, 3, 2, 2, 2, 53, 55, 7, 37, 2, 2, 54, 56, 
	9, 4, 2, 2, 55, 54, 3, 2, 2, 2, 56, 57, 3, 2, 2, 2, 57, 55, 3, 2, 2, 2, 
	57, 58, 3, 2, 2, 2, 58, 59, 3, 2, 2, 2, 59, 60, 8, 12, 2, 2, 60, 24, 3, 
	2, 2, 2, 61, 63, 9, 5, 2, 2, 62, 61, 3, 2, 2, 2, 63, 64, 3, 2, 2, 2, 64, 
	62, 3, 2, 2, 2, 64, 65, 3, 2, 2, 2, 65, 66, 3, 2, 2, 2, 66, 67, 8, 13, 
	2, 2, 67, 26, 3, 2, 2, 2, 7, 2, 46, 51, 57, 64, 3, 8, 2, 2,
}

var lexerDeserializer = antlr.NewATNDeserializer(nil)
var lexerAtn = lexerDeserializer.DeserializeFromUInt16(serializedLexerAtn)

var lexerChannelNames = []string{
	"DEFAULT_TOKEN_CHANNEL", "HIDDEN",
}

var lexerModeNames = []string{
	"DEFAULT_MODE",
}

var lexerLiteralNames = []string{
	"", "';'", "'('", "')'", "'%'", "'/'", "'*'", "'-'", "'+'",
}

var lexerSymbolicNames = []string{
	"", "EOL", "OPEN", "CLOSE", "MOD", "DIV", "MUL", "SUB", "ADD", "NUM", "VAR", 
	"COMMENTS", "WS",
}

var lexerRuleNames = []string{
	"EOL", "OPEN", "CLOSE", "MOD", "DIV", "MUL", "SUB", "ADD", "NUM", "VAR", 
	"COMMENTS", "WS",
}

type SimpleGrammarLexer struct {
	*antlr.BaseLexer
	channelNames []string
	modeNames []string
	// TODO: EOF string
}

var lexerDecisionToDFA = make([]*antlr.DFA, len(lexerAtn.DecisionToState))

func init() {
	for index, ds := range lexerAtn.DecisionToState {
		lexerDecisionToDFA[index] = antlr.NewDFA(ds, index)
	}
}

func NewSimpleGrammarLexer(input antlr.CharStream) *SimpleGrammarLexer {

	l := new(SimpleGrammarLexer)

	l.BaseLexer = antlr.NewBaseLexer(input)
	l.Interpreter = antlr.NewLexerATNSimulator(l, lexerAtn, lexerDecisionToDFA, antlr.NewPredictionContextCache())

	l.channelNames = lexerChannelNames
	l.modeNames = lexerModeNames
	l.RuleNames = lexerRuleNames
	l.LiteralNames = lexerLiteralNames
	l.SymbolicNames = lexerSymbolicNames
	l.GrammarFileName = "SimpleGrammar.g4"
	// TODO: l.EOF = antlr.TokenEOF

	return l
}

// SimpleGrammarLexer tokens.
const (
	SimpleGrammarLexerEOL = 1
	SimpleGrammarLexerOPEN = 2
	SimpleGrammarLexerCLOSE = 3
	SimpleGrammarLexerMOD = 4
	SimpleGrammarLexerDIV = 5
	SimpleGrammarLexerMUL = 6
	SimpleGrammarLexerSUB = 7
	SimpleGrammarLexerADD = 8
	SimpleGrammarLexerNUM = 9
	SimpleGrammarLexerVAR = 10
	SimpleGrammarLexerCOMMENTS = 11
	SimpleGrammarLexerWS = 12
)

