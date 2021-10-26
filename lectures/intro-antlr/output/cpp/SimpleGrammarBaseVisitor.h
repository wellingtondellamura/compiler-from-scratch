
// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8

#pragma once


#include "antlr4-runtime.h"
#include "SimpleGrammarVisitor.h"


namespace Grammar {

/**
 * This class provides an empty implementation of SimpleGrammarVisitor, which can be
 * extended to create a visitor which only needs to handle a subset of the available methods.
 */
class  SimpleGrammarBaseVisitor : public SimpleGrammarVisitor {
public:

  virtual antlrcpp::Any visitProg(SimpleGrammarParser::ProgContext *ctx) override {
    return visitChildren(ctx);
  }

  virtual antlrcpp::Any visitExpr(SimpleGrammarParser::ExprContext *ctx) override {
    return visitChildren(ctx);
  }

  virtual antlrcpp::Any visitTerm(SimpleGrammarParser::TermContext *ctx) override {
    return visitChildren(ctx);
  }

  virtual antlrcpp::Any visitFact(SimpleGrammarParser::FactContext *ctx) override {
    return visitChildren(ctx);
  }


};

}  // namespace Grammar
