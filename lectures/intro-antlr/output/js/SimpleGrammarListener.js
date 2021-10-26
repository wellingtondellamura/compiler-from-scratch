// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
// jshint ignore: start
var antlr4 = require('antlr4/index');

// This class defines a complete listener for a parse tree produced by SimpleGrammarParser.
function SimpleGrammarListener() {
	antlr4.tree.ParseTreeListener.call(this);
	return this;
}

SimpleGrammarListener.prototype = Object.create(antlr4.tree.ParseTreeListener.prototype);
SimpleGrammarListener.prototype.constructor = SimpleGrammarListener;

// Enter a parse tree produced by SimpleGrammarParser#prog.
SimpleGrammarListener.prototype.enterProg = function(ctx) {
};

// Exit a parse tree produced by SimpleGrammarParser#prog.
SimpleGrammarListener.prototype.exitProg = function(ctx) {
};


// Enter a parse tree produced by SimpleGrammarParser#expr.
SimpleGrammarListener.prototype.enterExpr = function(ctx) {
};

// Exit a parse tree produced by SimpleGrammarParser#expr.
SimpleGrammarListener.prototype.exitExpr = function(ctx) {
};


// Enter a parse tree produced by SimpleGrammarParser#term.
SimpleGrammarListener.prototype.enterTerm = function(ctx) {
};

// Exit a parse tree produced by SimpleGrammarParser#term.
SimpleGrammarListener.prototype.exitTerm = function(ctx) {
};


// Enter a parse tree produced by SimpleGrammarParser#fact.
SimpleGrammarListener.prototype.enterFact = function(ctx) {
};

// Exit a parse tree produced by SimpleGrammarParser#fact.
SimpleGrammarListener.prototype.exitFact = function(ctx) {
};



exports.SimpleGrammarListener = SimpleGrammarListener;