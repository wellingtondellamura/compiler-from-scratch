
// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8


#include "SimpleGrammarListener.h"
#include "SimpleGrammarVisitor.h"

#include "SimpleGrammarParser.h"


using namespace antlrcpp;
using namespace Grammar;
using namespace antlr4;

SimpleGrammarParser::SimpleGrammarParser(TokenStream *input) : Parser(input) {
  _interpreter = new atn::ParserATNSimulator(this, _atn, _decisionToDFA, _sharedContextCache);
}

SimpleGrammarParser::~SimpleGrammarParser() {
  delete _interpreter;
}

std::string SimpleGrammarParser::getGrammarFileName() const {
  return "SimpleGrammar.g4";
}

const std::vector<std::string>& SimpleGrammarParser::getRuleNames() const {
  return _ruleNames;
}

dfa::Vocabulary& SimpleGrammarParser::getVocabulary() const {
  return _vocabulary;
}


//----------------- ProgContext ------------------------------------------------------------------

SimpleGrammarParser::ProgContext::ProgContext(ParserRuleContext *parent, size_t invokingState)
  : ParserRuleContext(parent, invokingState) {
}

std::vector<SimpleGrammarParser::ExprContext *> SimpleGrammarParser::ProgContext::expr() {
  return getRuleContexts<SimpleGrammarParser::ExprContext>();
}

SimpleGrammarParser::ExprContext* SimpleGrammarParser::ProgContext::expr(size_t i) {
  return getRuleContext<SimpleGrammarParser::ExprContext>(i);
}

std::vector<tree::TerminalNode *> SimpleGrammarParser::ProgContext::EOL() {
  return getTokens(SimpleGrammarParser::EOL);
}

tree::TerminalNode* SimpleGrammarParser::ProgContext::EOL(size_t i) {
  return getToken(SimpleGrammarParser::EOL, i);
}


size_t SimpleGrammarParser::ProgContext::getRuleIndex() const {
  return SimpleGrammarParser::RuleProg;
}

void SimpleGrammarParser::ProgContext::enterRule(tree::ParseTreeListener *listener) {
  auto parserListener = dynamic_cast<SimpleGrammarListener *>(listener);
  if (parserListener != nullptr)
    parserListener->enterProg(this);
}

void SimpleGrammarParser::ProgContext::exitRule(tree::ParseTreeListener *listener) {
  auto parserListener = dynamic_cast<SimpleGrammarListener *>(listener);
  if (parserListener != nullptr)
    parserListener->exitProg(this);
}


antlrcpp::Any SimpleGrammarParser::ProgContext::accept(tree::ParseTreeVisitor *visitor) {
  if (auto parserVisitor = dynamic_cast<SimpleGrammarVisitor*>(visitor))
    return parserVisitor->visitProg(this);
  else
    return visitor->visitChildren(this);
}

SimpleGrammarParser::ProgContext* SimpleGrammarParser::prog() {
  ProgContext *_localctx = _tracker.createInstance<ProgContext>(_ctx, getState());
  enterRule(_localctx, 0, SimpleGrammarParser::RuleProg);
  size_t _la = 0;

  auto onExit = finally([=] {
    exitRule();
  });
  try {
    enterOuterAlt(_localctx, 1);
    setState(11); 
    _errHandler->sync(this);
    _la = _input->LA(1);
    do {
      setState(8);
      expr();
      setState(9);
      match(SimpleGrammarParser::EOL);
      setState(13); 
      _errHandler->sync(this);
      _la = _input->LA(1);
    } while ((((_la & ~ 0x3fULL) == 0) &&
      ((1ULL << _la) & ((1ULL << SimpleGrammarParser::OPEN)
      | (1ULL << SimpleGrammarParser::NUM)
      | (1ULL << SimpleGrammarParser::VAR))) != 0));
   
  }
  catch (RecognitionException &e) {
    _errHandler->reportError(this, e);
    _localctx->exception = std::current_exception();
    _errHandler->recover(this, _localctx->exception);
  }

  return _localctx;
}

//----------------- ExprContext ------------------------------------------------------------------

SimpleGrammarParser::ExprContext::ExprContext(ParserRuleContext *parent, size_t invokingState)
  : ParserRuleContext(parent, invokingState) {
}

SimpleGrammarParser::TermContext* SimpleGrammarParser::ExprContext::term() {
  return getRuleContext<SimpleGrammarParser::TermContext>(0);
}

SimpleGrammarParser::ExprContext* SimpleGrammarParser::ExprContext::expr() {
  return getRuleContext<SimpleGrammarParser::ExprContext>(0);
}

tree::TerminalNode* SimpleGrammarParser::ExprContext::ADD() {
  return getToken(SimpleGrammarParser::ADD, 0);
}

tree::TerminalNode* SimpleGrammarParser::ExprContext::SUB() {
  return getToken(SimpleGrammarParser::SUB, 0);
}


size_t SimpleGrammarParser::ExprContext::getRuleIndex() const {
  return SimpleGrammarParser::RuleExpr;
}

void SimpleGrammarParser::ExprContext::enterRule(tree::ParseTreeListener *listener) {
  auto parserListener = dynamic_cast<SimpleGrammarListener *>(listener);
  if (parserListener != nullptr)
    parserListener->enterExpr(this);
}

void SimpleGrammarParser::ExprContext::exitRule(tree::ParseTreeListener *listener) {
  auto parserListener = dynamic_cast<SimpleGrammarListener *>(listener);
  if (parserListener != nullptr)
    parserListener->exitExpr(this);
}


antlrcpp::Any SimpleGrammarParser::ExprContext::accept(tree::ParseTreeVisitor *visitor) {
  if (auto parserVisitor = dynamic_cast<SimpleGrammarVisitor*>(visitor))
    return parserVisitor->visitExpr(this);
  else
    return visitor->visitChildren(this);
}

SimpleGrammarParser::ExprContext* SimpleGrammarParser::expr() {
  ExprContext *_localctx = _tracker.createInstance<ExprContext>(_ctx, getState());
  enterRule(_localctx, 2, SimpleGrammarParser::RuleExpr);
  size_t _la = 0;

  auto onExit = finally([=] {
    exitRule();
  });
  try {
    setState(20);
    _errHandler->sync(this);
    switch (getInterpreter<atn::ParserATNSimulator>()->adaptivePredict(_input, 1, _ctx)) {
    case 1: {
      enterOuterAlt(_localctx, 1);
      setState(15);
      term();
      setState(16);
      _la = _input->LA(1);
      if (!(_la == SimpleGrammarParser::SUB

      || _la == SimpleGrammarParser::ADD)) {
      _errHandler->recoverInline(this);
      }
      else {
        _errHandler->reportMatch(this);
        consume();
      }
      setState(17);
      expr();
      break;
    }

    case 2: {
      enterOuterAlt(_localctx, 2);
      setState(19);
      term();
      break;
    }

    }
   
  }
  catch (RecognitionException &e) {
    _errHandler->reportError(this, e);
    _localctx->exception = std::current_exception();
    _errHandler->recover(this, _localctx->exception);
  }

  return _localctx;
}

//----------------- TermContext ------------------------------------------------------------------

SimpleGrammarParser::TermContext::TermContext(ParserRuleContext *parent, size_t invokingState)
  : ParserRuleContext(parent, invokingState) {
}

SimpleGrammarParser::FactContext* SimpleGrammarParser::TermContext::fact() {
  return getRuleContext<SimpleGrammarParser::FactContext>(0);
}

SimpleGrammarParser::TermContext* SimpleGrammarParser::TermContext::term() {
  return getRuleContext<SimpleGrammarParser::TermContext>(0);
}

tree::TerminalNode* SimpleGrammarParser::TermContext::MUL() {
  return getToken(SimpleGrammarParser::MUL, 0);
}

tree::TerminalNode* SimpleGrammarParser::TermContext::DIV() {
  return getToken(SimpleGrammarParser::DIV, 0);
}

tree::TerminalNode* SimpleGrammarParser::TermContext::MOD() {
  return getToken(SimpleGrammarParser::MOD, 0);
}


size_t SimpleGrammarParser::TermContext::getRuleIndex() const {
  return SimpleGrammarParser::RuleTerm;
}

void SimpleGrammarParser::TermContext::enterRule(tree::ParseTreeListener *listener) {
  auto parserListener = dynamic_cast<SimpleGrammarListener *>(listener);
  if (parserListener != nullptr)
    parserListener->enterTerm(this);
}

void SimpleGrammarParser::TermContext::exitRule(tree::ParseTreeListener *listener) {
  auto parserListener = dynamic_cast<SimpleGrammarListener *>(listener);
  if (parserListener != nullptr)
    parserListener->exitTerm(this);
}


antlrcpp::Any SimpleGrammarParser::TermContext::accept(tree::ParseTreeVisitor *visitor) {
  if (auto parserVisitor = dynamic_cast<SimpleGrammarVisitor*>(visitor))
    return parserVisitor->visitTerm(this);
  else
    return visitor->visitChildren(this);
}

SimpleGrammarParser::TermContext* SimpleGrammarParser::term() {
  TermContext *_localctx = _tracker.createInstance<TermContext>(_ctx, getState());
  enterRule(_localctx, 4, SimpleGrammarParser::RuleTerm);
  size_t _la = 0;

  auto onExit = finally([=] {
    exitRule();
  });
  try {
    setState(27);
    _errHandler->sync(this);
    switch (getInterpreter<atn::ParserATNSimulator>()->adaptivePredict(_input, 2, _ctx)) {
    case 1: {
      enterOuterAlt(_localctx, 1);
      setState(22);
      fact();
      setState(23);
      _la = _input->LA(1);
      if (!((((_la & ~ 0x3fULL) == 0) &&
        ((1ULL << _la) & ((1ULL << SimpleGrammarParser::MOD)
        | (1ULL << SimpleGrammarParser::DIV)
        | (1ULL << SimpleGrammarParser::MUL))) != 0))) {
      _errHandler->recoverInline(this);
      }
      else {
        _errHandler->reportMatch(this);
        consume();
      }
      setState(24);
      term();
      break;
    }

    case 2: {
      enterOuterAlt(_localctx, 2);
      setState(26);
      fact();
      break;
    }

    }
   
  }
  catch (RecognitionException &e) {
    _errHandler->reportError(this, e);
    _localctx->exception = std::current_exception();
    _errHandler->recover(this, _localctx->exception);
  }

  return _localctx;
}

//----------------- FactContext ------------------------------------------------------------------

SimpleGrammarParser::FactContext::FactContext(ParserRuleContext *parent, size_t invokingState)
  : ParserRuleContext(parent, invokingState) {
}

tree::TerminalNode* SimpleGrammarParser::FactContext::VAR() {
  return getToken(SimpleGrammarParser::VAR, 0);
}

tree::TerminalNode* SimpleGrammarParser::FactContext::NUM() {
  return getToken(SimpleGrammarParser::NUM, 0);
}

tree::TerminalNode* SimpleGrammarParser::FactContext::OPEN() {
  return getToken(SimpleGrammarParser::OPEN, 0);
}

SimpleGrammarParser::ExprContext* SimpleGrammarParser::FactContext::expr() {
  return getRuleContext<SimpleGrammarParser::ExprContext>(0);
}

tree::TerminalNode* SimpleGrammarParser::FactContext::CLOSE() {
  return getToken(SimpleGrammarParser::CLOSE, 0);
}


size_t SimpleGrammarParser::FactContext::getRuleIndex() const {
  return SimpleGrammarParser::RuleFact;
}

void SimpleGrammarParser::FactContext::enterRule(tree::ParseTreeListener *listener) {
  auto parserListener = dynamic_cast<SimpleGrammarListener *>(listener);
  if (parserListener != nullptr)
    parserListener->enterFact(this);
}

void SimpleGrammarParser::FactContext::exitRule(tree::ParseTreeListener *listener) {
  auto parserListener = dynamic_cast<SimpleGrammarListener *>(listener);
  if (parserListener != nullptr)
    parserListener->exitFact(this);
}


antlrcpp::Any SimpleGrammarParser::FactContext::accept(tree::ParseTreeVisitor *visitor) {
  if (auto parserVisitor = dynamic_cast<SimpleGrammarVisitor*>(visitor))
    return parserVisitor->visitFact(this);
  else
    return visitor->visitChildren(this);
}

SimpleGrammarParser::FactContext* SimpleGrammarParser::fact() {
  FactContext *_localctx = _tracker.createInstance<FactContext>(_ctx, getState());
  enterRule(_localctx, 6, SimpleGrammarParser::RuleFact);

  auto onExit = finally([=] {
    exitRule();
  });
  try {
    setState(35);
    _errHandler->sync(this);
    switch (_input->LA(1)) {
      case SimpleGrammarParser::VAR: {
        enterOuterAlt(_localctx, 1);
        setState(29);
        match(SimpleGrammarParser::VAR);
        break;
      }

      case SimpleGrammarParser::NUM: {
        enterOuterAlt(_localctx, 2);
        setState(30);
        match(SimpleGrammarParser::NUM);
        break;
      }

      case SimpleGrammarParser::OPEN: {
        enterOuterAlt(_localctx, 3);
        setState(31);
        match(SimpleGrammarParser::OPEN);
        setState(32);
        expr();
        setState(33);
        match(SimpleGrammarParser::CLOSE);
        break;
      }

    default:
      throw NoViableAltException(this);
    }
   
  }
  catch (RecognitionException &e) {
    _errHandler->reportError(this, e);
    _localctx->exception = std::current_exception();
    _errHandler->recover(this, _localctx->exception);
  }

  return _localctx;
}

// Static vars and initialization.
std::vector<dfa::DFA> SimpleGrammarParser::_decisionToDFA;
atn::PredictionContextCache SimpleGrammarParser::_sharedContextCache;

// We own the ATN which in turn owns the ATN states.
atn::ATN SimpleGrammarParser::_atn;
std::vector<uint16_t> SimpleGrammarParser::_serializedATN;

std::vector<std::string> SimpleGrammarParser::_ruleNames = {
  "prog", "expr", "term", "fact"
};

std::vector<std::string> SimpleGrammarParser::_literalNames = {
  "", "';'", "'('", "')'", "'%'", "'/'", "'*'", "'-'", "'+'"
};

std::vector<std::string> SimpleGrammarParser::_symbolicNames = {
  "", "EOL", "OPEN", "CLOSE", "MOD", "DIV", "MUL", "SUB", "ADD", "NUM", 
  "VAR", "COMMENTS", "WS"
};

dfa::Vocabulary SimpleGrammarParser::_vocabulary(_literalNames, _symbolicNames);

std::vector<std::string> SimpleGrammarParser::_tokenNames;

SimpleGrammarParser::Initializer::Initializer() {
	for (size_t i = 0; i < _symbolicNames.size(); ++i) {
		std::string name = _vocabulary.getLiteralName(i);
		if (name.empty()) {
			name = _vocabulary.getSymbolicName(i);
		}

		if (name.empty()) {
			_tokenNames.push_back("<INVALID>");
		} else {
      _tokenNames.push_back(name);
    }
	}

  _serializedATN = {
    0x3, 0x608b, 0xa72a, 0x8133, 0xb9ed, 0x417c, 0x3be7, 0x7786, 0x5964, 
    0x3, 0xe, 0x28, 0x4, 0x2, 0x9, 0x2, 0x4, 0x3, 0x9, 0x3, 0x4, 0x4, 0x9, 
    0x4, 0x4, 0x5, 0x9, 0x5, 0x3, 0x2, 0x3, 0x2, 0x3, 0x2, 0x6, 0x2, 0xe, 
    0xa, 0x2, 0xd, 0x2, 0xe, 0x2, 0xf, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 
    0x3, 0x3, 0x3, 0x5, 0x3, 0x17, 0xa, 0x3, 0x3, 0x4, 0x3, 0x4, 0x3, 0x4, 
    0x3, 0x4, 0x3, 0x4, 0x5, 0x4, 0x1e, 0xa, 0x4, 0x3, 0x5, 0x3, 0x5, 0x3, 
    0x5, 0x3, 0x5, 0x3, 0x5, 0x3, 0x5, 0x5, 0x5, 0x26, 0xa, 0x5, 0x3, 0x5, 
    0x2, 0x2, 0x6, 0x2, 0x4, 0x6, 0x8, 0x2, 0x4, 0x3, 0x2, 0x9, 0xa, 0x3, 
    0x2, 0x6, 0x8, 0x2, 0x28, 0x2, 0xd, 0x3, 0x2, 0x2, 0x2, 0x4, 0x16, 0x3, 
    0x2, 0x2, 0x2, 0x6, 0x1d, 0x3, 0x2, 0x2, 0x2, 0x8, 0x25, 0x3, 0x2, 0x2, 
    0x2, 0xa, 0xb, 0x5, 0x4, 0x3, 0x2, 0xb, 0xc, 0x7, 0x3, 0x2, 0x2, 0xc, 
    0xe, 0x3, 0x2, 0x2, 0x2, 0xd, 0xa, 0x3, 0x2, 0x2, 0x2, 0xe, 0xf, 0x3, 
    0x2, 0x2, 0x2, 0xf, 0xd, 0x3, 0x2, 0x2, 0x2, 0xf, 0x10, 0x3, 0x2, 0x2, 
    0x2, 0x10, 0x3, 0x3, 0x2, 0x2, 0x2, 0x11, 0x12, 0x5, 0x6, 0x4, 0x2, 
    0x12, 0x13, 0x9, 0x2, 0x2, 0x2, 0x13, 0x14, 0x5, 0x4, 0x3, 0x2, 0x14, 
    0x17, 0x3, 0x2, 0x2, 0x2, 0x15, 0x17, 0x5, 0x6, 0x4, 0x2, 0x16, 0x11, 
    0x3, 0x2, 0x2, 0x2, 0x16, 0x15, 0x3, 0x2, 0x2, 0x2, 0x17, 0x5, 0x3, 
    0x2, 0x2, 0x2, 0x18, 0x19, 0x5, 0x8, 0x5, 0x2, 0x19, 0x1a, 0x9, 0x3, 
    0x2, 0x2, 0x1a, 0x1b, 0x5, 0x6, 0x4, 0x2, 0x1b, 0x1e, 0x3, 0x2, 0x2, 
    0x2, 0x1c, 0x1e, 0x5, 0x8, 0x5, 0x2, 0x1d, 0x18, 0x3, 0x2, 0x2, 0x2, 
    0x1d, 0x1c, 0x3, 0x2, 0x2, 0x2, 0x1e, 0x7, 0x3, 0x2, 0x2, 0x2, 0x1f, 
    0x26, 0x7, 0xc, 0x2, 0x2, 0x20, 0x26, 0x7, 0xb, 0x2, 0x2, 0x21, 0x22, 
    0x7, 0x4, 0x2, 0x2, 0x22, 0x23, 0x5, 0x4, 0x3, 0x2, 0x23, 0x24, 0x7, 
    0x5, 0x2, 0x2, 0x24, 0x26, 0x3, 0x2, 0x2, 0x2, 0x25, 0x1f, 0x3, 0x2, 
    0x2, 0x2, 0x25, 0x20, 0x3, 0x2, 0x2, 0x2, 0x25, 0x21, 0x3, 0x2, 0x2, 
    0x2, 0x26, 0x9, 0x3, 0x2, 0x2, 0x2, 0x6, 0xf, 0x16, 0x1d, 0x25, 
  };

  atn::ATNDeserializer deserializer;
  _atn = deserializer.deserialize(_serializedATN);

  size_t count = _atn.getNumberOfDecisions();
  _decisionToDFA.reserve(count);
  for (size_t i = 0; i < count; i++) { 
    _decisionToDFA.emplace_back(_atn.getDecisionState(i), i);
  }
}

SimpleGrammarParser::Initializer SimpleGrammarParser::_init;
