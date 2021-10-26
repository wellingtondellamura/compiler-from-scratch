# Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
# encoding: utf-8
from __future__ import print_function
from antlr4 import *
from io import StringIO
import sys


def serializedATN():
    with StringIO() as buf:
        buf.write(u"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3")
        buf.write(u"\16(\4\2\t\2\4\3\t\3\4\4\t\4\4\5\t\5\3\2\3\2\3\2\6\2")
        buf.write(u"\16\n\2\r\2\16\2\17\3\3\3\3\3\3\3\3\3\3\5\3\27\n\3\3")
        buf.write(u"\4\3\4\3\4\3\4\3\4\5\4\36\n\4\3\5\3\5\3\5\3\5\3\5\3\5")
        buf.write(u"\5\5&\n\5\3\5\2\2\6\2\4\6\b\2\4\3\2\t\n\3\2\6\b\2(\2")
        buf.write(u"\r\3\2\2\2\4\26\3\2\2\2\6\35\3\2\2\2\b%\3\2\2\2\n\13")
        buf.write(u"\5\4\3\2\13\f\7\3\2\2\f\16\3\2\2\2\r\n\3\2\2\2\16\17")
        buf.write(u"\3\2\2\2\17\r\3\2\2\2\17\20\3\2\2\2\20\3\3\2\2\2\21\22")
        buf.write(u"\5\6\4\2\22\23\t\2\2\2\23\24\5\4\3\2\24\27\3\2\2\2\25")
        buf.write(u"\27\5\6\4\2\26\21\3\2\2\2\26\25\3\2\2\2\27\5\3\2\2\2")
        buf.write(u"\30\31\5\b\5\2\31\32\t\3\2\2\32\33\5\6\4\2\33\36\3\2")
        buf.write(u"\2\2\34\36\5\b\5\2\35\30\3\2\2\2\35\34\3\2\2\2\36\7\3")
        buf.write(u"\2\2\2\37&\7\f\2\2 &\7\13\2\2!\"\7\4\2\2\"#\5\4\3\2#")
        buf.write(u"$\7\5\2\2$&\3\2\2\2%\37\3\2\2\2% \3\2\2\2%!\3\2\2\2&")
        buf.write(u"\t\3\2\2\2\6\17\26\35%")
        return buf.getvalue()


class SimpleGrammarParser ( Parser ):

    grammarFileName = "SimpleGrammar.g4"

    atn = ATNDeserializer().deserialize(serializedATN())

    decisionsToDFA = [ DFA(ds, i) for i, ds in enumerate(atn.decisionToState) ]

    sharedContextCache = PredictionContextCache()

    literalNames = [ u"<INVALID>", u"';'", u"'('", u"')'", u"'%'", u"'/'", 
                     u"'*'", u"'-'", u"'+'" ]

    symbolicNames = [ u"<INVALID>", u"EOL", u"OPEN", u"CLOSE", u"MOD", u"DIV", 
                      u"MUL", u"SUB", u"ADD", u"NUM", u"VAR", u"COMMENTS", 
                      u"WS" ]

    RULE_prog = 0
    RULE_expr = 1
    RULE_term = 2
    RULE_fact = 3

    ruleNames =  [ u"prog", u"expr", u"term", u"fact" ]

    EOF = Token.EOF
    EOL=1
    OPEN=2
    CLOSE=3
    MOD=4
    DIV=5
    MUL=6
    SUB=7
    ADD=8
    NUM=9
    VAR=10
    COMMENTS=11
    WS=12

    def __init__(self, input, output=sys.stdout):
        super(SimpleGrammarParser, self).__init__(input, output=output)
        self.checkVersion("4.8")
        self._interp = ParserATNSimulator(self, self.atn, self.decisionsToDFA, self.sharedContextCache)
        self._predicates = None




    class ProgContext(ParserRuleContext):

        def __init__(self, parser, parent=None, invokingState=-1):
            super(SimpleGrammarParser.ProgContext, self).__init__(parent, invokingState)
            self.parser = parser

        def expr(self, i=None):
            if i is None:
                return self.getTypedRuleContexts(SimpleGrammarParser.ExprContext)
            else:
                return self.getTypedRuleContext(SimpleGrammarParser.ExprContext,i)


        def EOL(self, i=None):
            if i is None:
                return self.getTokens(SimpleGrammarParser.EOL)
            else:
                return self.getToken(SimpleGrammarParser.EOL, i)

        def getRuleIndex(self):
            return SimpleGrammarParser.RULE_prog

        def enterRule(self, listener):
            if hasattr(listener, "enterProg"):
                listener.enterProg(self)

        def exitRule(self, listener):
            if hasattr(listener, "exitProg"):
                listener.exitProg(self)

        def accept(self, visitor):
            if hasattr(visitor, "visitProg"):
                return visitor.visitProg(self)
            else:
                return visitor.visitChildren(self)




    def prog(self):

        localctx = SimpleGrammarParser.ProgContext(self, self._ctx, self.state)
        self.enterRule(localctx, 0, self.RULE_prog)
        self._la = 0 # Token type
        try:
            self.enterOuterAlt(localctx, 1)
            self.state = 11 
            self._errHandler.sync(self)
            _la = self._input.LA(1)
            while True:
                self.state = 8
                self.expr()
                self.state = 9
                self.match(SimpleGrammarParser.EOL)
                self.state = 13 
                self._errHandler.sync(self)
                _la = self._input.LA(1)
                if not ((((_la) & ~0x3f) == 0 and ((1 << _la) & ((1 << SimpleGrammarParser.OPEN) | (1 << SimpleGrammarParser.NUM) | (1 << SimpleGrammarParser.VAR))) != 0)):
                    break

        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx


    class ExprContext(ParserRuleContext):

        def __init__(self, parser, parent=None, invokingState=-1):
            super(SimpleGrammarParser.ExprContext, self).__init__(parent, invokingState)
            self.parser = parser

        def term(self):
            return self.getTypedRuleContext(SimpleGrammarParser.TermContext,0)


        def expr(self):
            return self.getTypedRuleContext(SimpleGrammarParser.ExprContext,0)


        def ADD(self):
            return self.getToken(SimpleGrammarParser.ADD, 0)

        def SUB(self):
            return self.getToken(SimpleGrammarParser.SUB, 0)

        def getRuleIndex(self):
            return SimpleGrammarParser.RULE_expr

        def enterRule(self, listener):
            if hasattr(listener, "enterExpr"):
                listener.enterExpr(self)

        def exitRule(self, listener):
            if hasattr(listener, "exitExpr"):
                listener.exitExpr(self)

        def accept(self, visitor):
            if hasattr(visitor, "visitExpr"):
                return visitor.visitExpr(self)
            else:
                return visitor.visitChildren(self)




    def expr(self):

        localctx = SimpleGrammarParser.ExprContext(self, self._ctx, self.state)
        self.enterRule(localctx, 2, self.RULE_expr)
        self._la = 0 # Token type
        try:
            self.state = 20
            self._errHandler.sync(self)
            la_ = self._interp.adaptivePredict(self._input,1,self._ctx)
            if la_ == 1:
                self.enterOuterAlt(localctx, 1)
                self.state = 15
                self.term()
                self.state = 16
                _la = self._input.LA(1)
                if not(_la==SimpleGrammarParser.SUB or _la==SimpleGrammarParser.ADD):
                    self._errHandler.recoverInline(self)
                else:
                    self._errHandler.reportMatch(self)
                    self.consume()
                self.state = 17
                self.expr()
                pass

            elif la_ == 2:
                self.enterOuterAlt(localctx, 2)
                self.state = 19
                self.term()
                pass


        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx


    class TermContext(ParserRuleContext):

        def __init__(self, parser, parent=None, invokingState=-1):
            super(SimpleGrammarParser.TermContext, self).__init__(parent, invokingState)
            self.parser = parser

        def fact(self):
            return self.getTypedRuleContext(SimpleGrammarParser.FactContext,0)


        def term(self):
            return self.getTypedRuleContext(SimpleGrammarParser.TermContext,0)


        def MUL(self):
            return self.getToken(SimpleGrammarParser.MUL, 0)

        def DIV(self):
            return self.getToken(SimpleGrammarParser.DIV, 0)

        def MOD(self):
            return self.getToken(SimpleGrammarParser.MOD, 0)

        def getRuleIndex(self):
            return SimpleGrammarParser.RULE_term

        def enterRule(self, listener):
            if hasattr(listener, "enterTerm"):
                listener.enterTerm(self)

        def exitRule(self, listener):
            if hasattr(listener, "exitTerm"):
                listener.exitTerm(self)

        def accept(self, visitor):
            if hasattr(visitor, "visitTerm"):
                return visitor.visitTerm(self)
            else:
                return visitor.visitChildren(self)




    def term(self):

        localctx = SimpleGrammarParser.TermContext(self, self._ctx, self.state)
        self.enterRule(localctx, 4, self.RULE_term)
        self._la = 0 # Token type
        try:
            self.state = 27
            self._errHandler.sync(self)
            la_ = self._interp.adaptivePredict(self._input,2,self._ctx)
            if la_ == 1:
                self.enterOuterAlt(localctx, 1)
                self.state = 22
                self.fact()
                self.state = 23
                _la = self._input.LA(1)
                if not((((_la) & ~0x3f) == 0 and ((1 << _la) & ((1 << SimpleGrammarParser.MOD) | (1 << SimpleGrammarParser.DIV) | (1 << SimpleGrammarParser.MUL))) != 0)):
                    self._errHandler.recoverInline(self)
                else:
                    self._errHandler.reportMatch(self)
                    self.consume()
                self.state = 24
                self.term()
                pass

            elif la_ == 2:
                self.enterOuterAlt(localctx, 2)
                self.state = 26
                self.fact()
                pass


        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx


    class FactContext(ParserRuleContext):

        def __init__(self, parser, parent=None, invokingState=-1):
            super(SimpleGrammarParser.FactContext, self).__init__(parent, invokingState)
            self.parser = parser

        def VAR(self):
            return self.getToken(SimpleGrammarParser.VAR, 0)

        def NUM(self):
            return self.getToken(SimpleGrammarParser.NUM, 0)

        def OPEN(self):
            return self.getToken(SimpleGrammarParser.OPEN, 0)

        def expr(self):
            return self.getTypedRuleContext(SimpleGrammarParser.ExprContext,0)


        def CLOSE(self):
            return self.getToken(SimpleGrammarParser.CLOSE, 0)

        def getRuleIndex(self):
            return SimpleGrammarParser.RULE_fact

        def enterRule(self, listener):
            if hasattr(listener, "enterFact"):
                listener.enterFact(self)

        def exitRule(self, listener):
            if hasattr(listener, "exitFact"):
                listener.exitFact(self)

        def accept(self, visitor):
            if hasattr(visitor, "visitFact"):
                return visitor.visitFact(self)
            else:
                return visitor.visitChildren(self)




    def fact(self):

        localctx = SimpleGrammarParser.FactContext(self, self._ctx, self.state)
        self.enterRule(localctx, 6, self.RULE_fact)
        try:
            self.state = 35
            self._errHandler.sync(self)
            token = self._input.LA(1)
            if token in [SimpleGrammarParser.VAR]:
                self.enterOuterAlt(localctx, 1)
                self.state = 29
                self.match(SimpleGrammarParser.VAR)
                pass
            elif token in [SimpleGrammarParser.NUM]:
                self.enterOuterAlt(localctx, 2)
                self.state = 30
                self.match(SimpleGrammarParser.NUM)
                pass
            elif token in [SimpleGrammarParser.OPEN]:
                self.enterOuterAlt(localctx, 3)
                self.state = 31
                self.match(SimpleGrammarParser.OPEN)
                self.state = 32
                self.expr()
                self.state = 33
                self.match(SimpleGrammarParser.CLOSE)
                pass
            else:
                raise NoViableAltException(self)

        except RecognitionException as re:
            localctx.exception = re
            self._errHandler.reportError(self, re)
            self._errHandler.recover(self, re)
        finally:
            self.exitRule()
        return localctx





