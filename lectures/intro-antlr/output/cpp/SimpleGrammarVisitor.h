
// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8

#pragma once


#include "antlr4-runtime.h"
#include "SimpleGrammarParser.h"


namespace Grammar {

/**
 * This class defines an abstract visitor for a parse tree
 * produced by SimpleGrammarParser.
 */
class  SimpleGrammarVisitor : public antlr4::tree::AbstractParseTreeVisitor {
public:

  /**
   * Visit parse trees produced by SimpleGrammarParser.
   */
    virtual antlrcpp::Any visitProg(SimpleGrammarParser::ProgContext *context) = 0;

    virtual antlrcpp::Any visitExpr(SimpleGrammarParser::ExprContext *context) = 0;

    virtual antlrcpp::Any visitTerm(SimpleGrammarParser::TermContext *context) = 0;

    virtual antlrcpp::Any visitFact(SimpleGrammarParser::FactContext *context) = 0;


};

}  // namespace Grammar
