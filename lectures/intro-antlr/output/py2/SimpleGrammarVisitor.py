# Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
from antlr4 import *

# This class defines a complete generic visitor for a parse tree produced by SimpleGrammarParser.

class SimpleGrammarVisitor(ParseTreeVisitor):

    # Visit a parse tree produced by SimpleGrammarParser#prog.
    def visitProg(self, ctx):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by SimpleGrammarParser#expr.
    def visitExpr(self, ctx):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by SimpleGrammarParser#term.
    def visitTerm(self, ctx):
        return self.visitChildren(ctx)


    # Visit a parse tree produced by SimpleGrammarParser#fact.
    def visitFact(self, ctx):
        return self.visitChildren(ctx)


