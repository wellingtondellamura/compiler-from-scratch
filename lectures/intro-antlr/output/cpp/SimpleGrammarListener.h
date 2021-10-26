
// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8

#pragma once


#include "antlr4-runtime.h"
#include "SimpleGrammarParser.h"


namespace Grammar {

/**
 * This interface defines an abstract listener for a parse tree produced by SimpleGrammarParser.
 */
class  SimpleGrammarListener : public antlr4::tree::ParseTreeListener {
public:

  virtual void enterProg(SimpleGrammarParser::ProgContext *ctx) = 0;
  virtual void exitProg(SimpleGrammarParser::ProgContext *ctx) = 0;

  virtual void enterExpr(SimpleGrammarParser::ExprContext *ctx) = 0;
  virtual void exitExpr(SimpleGrammarParser::ExprContext *ctx) = 0;

  virtual void enterTerm(SimpleGrammarParser::TermContext *ctx) = 0;
  virtual void exitTerm(SimpleGrammarParser::TermContext *ctx) = 0;

  virtual void enterFact(SimpleGrammarParser::FactContext *ctx) = 0;
  virtual void exitFact(SimpleGrammarParser::FactContext *ctx) = 0;


};

}  // namespace Grammar
