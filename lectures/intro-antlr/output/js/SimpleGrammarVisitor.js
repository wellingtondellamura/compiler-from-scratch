// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
// jshint ignore: start
var antlr4 = require('antlr4/index');

// This class defines a complete generic visitor for a parse tree produced by SimpleGrammarParser.

function SimpleGrammarVisitor() {
	antlr4.tree.ParseTreeVisitor.call(this);
	return this;
}

SimpleGrammarVisitor.prototype = Object.create(antlr4.tree.ParseTreeVisitor.prototype);
SimpleGrammarVisitor.prototype.constructor = SimpleGrammarVisitor;

// Visit a parse tree produced by SimpleGrammarParser#prog.
SimpleGrammarVisitor.prototype.visitProg = function(ctx) {
  return this.visitChildren(ctx);
};


// Visit a parse tree produced by SimpleGrammarParser#expr.
SimpleGrammarVisitor.prototype.visitExpr = function(ctx) {
  return this.visitChildren(ctx);
};


// Visit a parse tree produced by SimpleGrammarParser#term.
SimpleGrammarVisitor.prototype.visitTerm = function(ctx) {
  return this.visitChildren(ctx);
};


// Visit a parse tree produced by SimpleGrammarParser#fact.
SimpleGrammarVisitor.prototype.visitFact = function(ctx) {
  return this.visitChildren(ctx);
};



exports.SimpleGrammarVisitor = SimpleGrammarVisitor;