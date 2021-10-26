
// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8

#pragma once


#include "antlr4-runtime.h"
#include "SimpleGrammarListener.h"


namespace Grammar {

/**
 * This class provides an empty implementation of SimpleGrammarListener,
 * which can be extended to create a listener which only needs to handle a subset
 * of the available methods.
 */
class  SimpleGrammarBaseListener : public SimpleGrammarListener {
public:

  virtual void enterProg(SimpleGrammarParser::ProgContext * /*ctx*/) override { }
  virtual void exitProg(SimpleGrammarParser::ProgContext * /*ctx*/) override { }

  virtual void enterExpr(SimpleGrammarParser::ExprContext * /*ctx*/) override { }
  virtual void exitExpr(SimpleGrammarParser::ExprContext * /*ctx*/) override { }

  virtual void enterTerm(SimpleGrammarParser::TermContext * /*ctx*/) override { }
  virtual void exitTerm(SimpleGrammarParser::TermContext * /*ctx*/) override { }

  virtual void enterFact(SimpleGrammarParser::FactContext * /*ctx*/) override { }
  virtual void exitFact(SimpleGrammarParser::FactContext * /*ctx*/) override { }


  virtual void enterEveryRule(antlr4::ParserRuleContext * /*ctx*/) override { }
  virtual void exitEveryRule(antlr4::ParserRuleContext * /*ctx*/) override { }
  virtual void visitTerminal(antlr4::tree::TerminalNode * /*node*/) override { }
  virtual void visitErrorNode(antlr4::tree::ErrorNode * /*node*/) override { }

};

}  // namespace Grammar
