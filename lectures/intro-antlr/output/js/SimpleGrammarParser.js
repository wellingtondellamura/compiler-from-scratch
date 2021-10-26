// Generated from c:\Users\wellington\projects\lectures\compiler-from-scratch\lectures\intro-antlr\SimpleGrammar.g4 by ANTLR 4.8
// jshint ignore: start
var antlr4 = require('antlr4/index');
var SimpleGrammarListener = require('./SimpleGrammarListener').SimpleGrammarListener;
var SimpleGrammarVisitor = require('./SimpleGrammarVisitor').SimpleGrammarVisitor;

var grammarFileName = "SimpleGrammar.g4";


var serializedATN = ["\u0003\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964",
    "\u0003\u000e(\u0004\u0002\t\u0002\u0004\u0003\t\u0003\u0004\u0004\t",
    "\u0004\u0004\u0005\t\u0005\u0003\u0002\u0003\u0002\u0003\u0002\u0006",
    "\u0002\u000e\n\u0002\r\u0002\u000e\u0002\u000f\u0003\u0003\u0003\u0003",
    "\u0003\u0003\u0003\u0003\u0003\u0003\u0005\u0003\u0017\n\u0003\u0003",
    "\u0004\u0003\u0004\u0003\u0004\u0003\u0004\u0003\u0004\u0005\u0004\u001e",
    "\n\u0004\u0003\u0005\u0003\u0005\u0003\u0005\u0003\u0005\u0003\u0005",
    "\u0003\u0005\u0005\u0005&\n\u0005\u0003\u0005\u0002\u0002\u0006\u0002",
    "\u0004\u0006\b\u0002\u0004\u0003\u0002\t\n\u0003\u0002\u0006\b\u0002",
    "(\u0002\r\u0003\u0002\u0002\u0002\u0004\u0016\u0003\u0002\u0002\u0002",
    "\u0006\u001d\u0003\u0002\u0002\u0002\b%\u0003\u0002\u0002\u0002\n\u000b",
    "\u0005\u0004\u0003\u0002\u000b\f\u0007\u0003\u0002\u0002\f\u000e\u0003",
    "\u0002\u0002\u0002\r\n\u0003\u0002\u0002\u0002\u000e\u000f\u0003\u0002",
    "\u0002\u0002\u000f\r\u0003\u0002\u0002\u0002\u000f\u0010\u0003\u0002",
    "\u0002\u0002\u0010\u0003\u0003\u0002\u0002\u0002\u0011\u0012\u0005\u0006",
    "\u0004\u0002\u0012\u0013\t\u0002\u0002\u0002\u0013\u0014\u0005\u0004",
    "\u0003\u0002\u0014\u0017\u0003\u0002\u0002\u0002\u0015\u0017\u0005\u0006",
    "\u0004\u0002\u0016\u0011\u0003\u0002\u0002\u0002\u0016\u0015\u0003\u0002",
    "\u0002\u0002\u0017\u0005\u0003\u0002\u0002\u0002\u0018\u0019\u0005\b",
    "\u0005\u0002\u0019\u001a\t\u0003\u0002\u0002\u001a\u001b\u0005\u0006",
    "\u0004\u0002\u001b\u001e\u0003\u0002\u0002\u0002\u001c\u001e\u0005\b",
    "\u0005\u0002\u001d\u0018\u0003\u0002\u0002\u0002\u001d\u001c\u0003\u0002",
    "\u0002\u0002\u001e\u0007\u0003\u0002\u0002\u0002\u001f&\u0007\f\u0002",
    "\u0002 &\u0007\u000b\u0002\u0002!\"\u0007\u0004\u0002\u0002\"#\u0005",
    "\u0004\u0003\u0002#$\u0007\u0005\u0002\u0002$&\u0003\u0002\u0002\u0002",
    "%\u001f\u0003\u0002\u0002\u0002% \u0003\u0002\u0002\u0002%!\u0003\u0002",
    "\u0002\u0002&\t\u0003\u0002\u0002\u0002\u0006\u000f\u0016\u001d%"].join("");


var atn = new antlr4.atn.ATNDeserializer().deserialize(serializedATN);

var decisionsToDFA = atn.decisionToState.map( function(ds, index) { return new antlr4.dfa.DFA(ds, index); });

var sharedContextCache = new antlr4.PredictionContextCache();

var literalNames = [ null, "';'", "'('", "')'", "'%'", "'/'", "'*'", "'-'", 
                     "'+'" ];

var symbolicNames = [ null, "EOL", "OPEN", "CLOSE", "MOD", "DIV", "MUL", 
                      "SUB", "ADD", "NUM", "VAR", "COMMENTS", "WS" ];

var ruleNames =  [ "prog", "expr", "term", "fact" ];

function SimpleGrammarParser (input) {
	antlr4.Parser.call(this, input);
    this._interp = new antlr4.atn.ParserATNSimulator(this, atn, decisionsToDFA, sharedContextCache);
    this.ruleNames = ruleNames;
    this.literalNames = literalNames;
    this.symbolicNames = symbolicNames;
    return this;
}

SimpleGrammarParser.prototype = Object.create(antlr4.Parser.prototype);
SimpleGrammarParser.prototype.constructor = SimpleGrammarParser;

Object.defineProperty(SimpleGrammarParser.prototype, "atn", {
	get : function() {
		return atn;
	}
});

SimpleGrammarParser.EOF = antlr4.Token.EOF;
SimpleGrammarParser.EOL = 1;
SimpleGrammarParser.OPEN = 2;
SimpleGrammarParser.CLOSE = 3;
SimpleGrammarParser.MOD = 4;
SimpleGrammarParser.DIV = 5;
SimpleGrammarParser.MUL = 6;
SimpleGrammarParser.SUB = 7;
SimpleGrammarParser.ADD = 8;
SimpleGrammarParser.NUM = 9;
SimpleGrammarParser.VAR = 10;
SimpleGrammarParser.COMMENTS = 11;
SimpleGrammarParser.WS = 12;

SimpleGrammarParser.RULE_prog = 0;
SimpleGrammarParser.RULE_expr = 1;
SimpleGrammarParser.RULE_term = 2;
SimpleGrammarParser.RULE_fact = 3;


function ProgContext(parser, parent, invokingState) {
	if(parent===undefined) {
	    parent = null;
	}
	if(invokingState===undefined || invokingState===null) {
		invokingState = -1;
	}
	antlr4.ParserRuleContext.call(this, parent, invokingState);
    this.parser = parser;
    this.ruleIndex = SimpleGrammarParser.RULE_prog;
    return this;
}

ProgContext.prototype = Object.create(antlr4.ParserRuleContext.prototype);
ProgContext.prototype.constructor = ProgContext;

ProgContext.prototype.expr = function(i) {
    if(i===undefined) {
        i = null;
    }
    if(i===null) {
        return this.getTypedRuleContexts(ExprContext);
    } else {
        return this.getTypedRuleContext(ExprContext,i);
    }
};

ProgContext.prototype.EOL = function(i) {
	if(i===undefined) {
		i = null;
	}
    if(i===null) {
        return this.getTokens(SimpleGrammarParser.EOL);
    } else {
        return this.getToken(SimpleGrammarParser.EOL, i);
    }
};


ProgContext.prototype.enterRule = function(listener) {
    if(listener instanceof SimpleGrammarListener ) {
        listener.enterProg(this);
	}
};

ProgContext.prototype.exitRule = function(listener) {
    if(listener instanceof SimpleGrammarListener ) {
        listener.exitProg(this);
	}
};

ProgContext.prototype.accept = function(visitor) {
    if ( visitor instanceof SimpleGrammarVisitor ) {
        return visitor.visitProg(this);
    } else {
        return visitor.visitChildren(this);
    }
};




SimpleGrammarParser.ProgContext = ProgContext;

SimpleGrammarParser.prototype.prog = function() {

    var localctx = new ProgContext(this, this._ctx, this.state);
    this.enterRule(localctx, 0, SimpleGrammarParser.RULE_prog);
    var _la = 0; // Token type
    try {
        this.enterOuterAlt(localctx, 1);
        this.state = 11; 
        this._errHandler.sync(this);
        _la = this._input.LA(1);
        do {
            this.state = 8;
            this.expr();
            this.state = 9;
            this.match(SimpleGrammarParser.EOL);
            this.state = 13; 
            this._errHandler.sync(this);
            _la = this._input.LA(1);
        } while((((_la) & ~0x1f) == 0 && ((1 << _la) & ((1 << SimpleGrammarParser.OPEN) | (1 << SimpleGrammarParser.NUM) | (1 << SimpleGrammarParser.VAR))) !== 0));
    } catch (re) {
    	if(re instanceof antlr4.error.RecognitionException) {
	        localctx.exception = re;
	        this._errHandler.reportError(this, re);
	        this._errHandler.recover(this, re);
	    } else {
	    	throw re;
	    }
    } finally {
        this.exitRule();
    }
    return localctx;
};


function ExprContext(parser, parent, invokingState) {
	if(parent===undefined) {
	    parent = null;
	}
	if(invokingState===undefined || invokingState===null) {
		invokingState = -1;
	}
	antlr4.ParserRuleContext.call(this, parent, invokingState);
    this.parser = parser;
    this.ruleIndex = SimpleGrammarParser.RULE_expr;
    return this;
}

ExprContext.prototype = Object.create(antlr4.ParserRuleContext.prototype);
ExprContext.prototype.constructor = ExprContext;

ExprContext.prototype.term = function() {
    return this.getTypedRuleContext(TermContext,0);
};

ExprContext.prototype.expr = function() {
    return this.getTypedRuleContext(ExprContext,0);
};

ExprContext.prototype.ADD = function() {
    return this.getToken(SimpleGrammarParser.ADD, 0);
};

ExprContext.prototype.SUB = function() {
    return this.getToken(SimpleGrammarParser.SUB, 0);
};

ExprContext.prototype.enterRule = function(listener) {
    if(listener instanceof SimpleGrammarListener ) {
        listener.enterExpr(this);
	}
};

ExprContext.prototype.exitRule = function(listener) {
    if(listener instanceof SimpleGrammarListener ) {
        listener.exitExpr(this);
	}
};

ExprContext.prototype.accept = function(visitor) {
    if ( visitor instanceof SimpleGrammarVisitor ) {
        return visitor.visitExpr(this);
    } else {
        return visitor.visitChildren(this);
    }
};




SimpleGrammarParser.ExprContext = ExprContext;

SimpleGrammarParser.prototype.expr = function() {

    var localctx = new ExprContext(this, this._ctx, this.state);
    this.enterRule(localctx, 2, SimpleGrammarParser.RULE_expr);
    var _la = 0; // Token type
    try {
        this.state = 20;
        this._errHandler.sync(this);
        var la_ = this._interp.adaptivePredict(this._input,1,this._ctx);
        switch(la_) {
        case 1:
            this.enterOuterAlt(localctx, 1);
            this.state = 15;
            this.term();
            this.state = 16;
            _la = this._input.LA(1);
            if(!(_la===SimpleGrammarParser.SUB || _la===SimpleGrammarParser.ADD)) {
            this._errHandler.recoverInline(this);
            }
            else {
            	this._errHandler.reportMatch(this);
                this.consume();
            }
            this.state = 17;
            this.expr();
            break;

        case 2:
            this.enterOuterAlt(localctx, 2);
            this.state = 19;
            this.term();
            break;

        }
    } catch (re) {
    	if(re instanceof antlr4.error.RecognitionException) {
	        localctx.exception = re;
	        this._errHandler.reportError(this, re);
	        this._errHandler.recover(this, re);
	    } else {
	    	throw re;
	    }
    } finally {
        this.exitRule();
    }
    return localctx;
};


function TermContext(parser, parent, invokingState) {
	if(parent===undefined) {
	    parent = null;
	}
	if(invokingState===undefined || invokingState===null) {
		invokingState = -1;
	}
	antlr4.ParserRuleContext.call(this, parent, invokingState);
    this.parser = parser;
    this.ruleIndex = SimpleGrammarParser.RULE_term;
    return this;
}

TermContext.prototype = Object.create(antlr4.ParserRuleContext.prototype);
TermContext.prototype.constructor = TermContext;

TermContext.prototype.fact = function() {
    return this.getTypedRuleContext(FactContext,0);
};

TermContext.prototype.term = function() {
    return this.getTypedRuleContext(TermContext,0);
};

TermContext.prototype.MUL = function() {
    return this.getToken(SimpleGrammarParser.MUL, 0);
};

TermContext.prototype.DIV = function() {
    return this.getToken(SimpleGrammarParser.DIV, 0);
};

TermContext.prototype.MOD = function() {
    return this.getToken(SimpleGrammarParser.MOD, 0);
};

TermContext.prototype.enterRule = function(listener) {
    if(listener instanceof SimpleGrammarListener ) {
        listener.enterTerm(this);
	}
};

TermContext.prototype.exitRule = function(listener) {
    if(listener instanceof SimpleGrammarListener ) {
        listener.exitTerm(this);
	}
};

TermContext.prototype.accept = function(visitor) {
    if ( visitor instanceof SimpleGrammarVisitor ) {
        return visitor.visitTerm(this);
    } else {
        return visitor.visitChildren(this);
    }
};




SimpleGrammarParser.TermContext = TermContext;

SimpleGrammarParser.prototype.term = function() {

    var localctx = new TermContext(this, this._ctx, this.state);
    this.enterRule(localctx, 4, SimpleGrammarParser.RULE_term);
    var _la = 0; // Token type
    try {
        this.state = 27;
        this._errHandler.sync(this);
        var la_ = this._interp.adaptivePredict(this._input,2,this._ctx);
        switch(la_) {
        case 1:
            this.enterOuterAlt(localctx, 1);
            this.state = 22;
            this.fact();
            this.state = 23;
            _la = this._input.LA(1);
            if(!((((_la) & ~0x1f) == 0 && ((1 << _la) & ((1 << SimpleGrammarParser.MOD) | (1 << SimpleGrammarParser.DIV) | (1 << SimpleGrammarParser.MUL))) !== 0))) {
            this._errHandler.recoverInline(this);
            }
            else {
            	this._errHandler.reportMatch(this);
                this.consume();
            }
            this.state = 24;
            this.term();
            break;

        case 2:
            this.enterOuterAlt(localctx, 2);
            this.state = 26;
            this.fact();
            break;

        }
    } catch (re) {
    	if(re instanceof antlr4.error.RecognitionException) {
	        localctx.exception = re;
	        this._errHandler.reportError(this, re);
	        this._errHandler.recover(this, re);
	    } else {
	    	throw re;
	    }
    } finally {
        this.exitRule();
    }
    return localctx;
};


function FactContext(parser, parent, invokingState) {
	if(parent===undefined) {
	    parent = null;
	}
	if(invokingState===undefined || invokingState===null) {
		invokingState = -1;
	}
	antlr4.ParserRuleContext.call(this, parent, invokingState);
    this.parser = parser;
    this.ruleIndex = SimpleGrammarParser.RULE_fact;
    return this;
}

FactContext.prototype = Object.create(antlr4.ParserRuleContext.prototype);
FactContext.prototype.constructor = FactContext;

FactContext.prototype.VAR = function() {
    return this.getToken(SimpleGrammarParser.VAR, 0);
};

FactContext.prototype.NUM = function() {
    return this.getToken(SimpleGrammarParser.NUM, 0);
};

FactContext.prototype.OPEN = function() {
    return this.getToken(SimpleGrammarParser.OPEN, 0);
};

FactContext.prototype.expr = function() {
    return this.getTypedRuleContext(ExprContext,0);
};

FactContext.prototype.CLOSE = function() {
    return this.getToken(SimpleGrammarParser.CLOSE, 0);
};

FactContext.prototype.enterRule = function(listener) {
    if(listener instanceof SimpleGrammarListener ) {
        listener.enterFact(this);
	}
};

FactContext.prototype.exitRule = function(listener) {
    if(listener instanceof SimpleGrammarListener ) {
        listener.exitFact(this);
	}
};

FactContext.prototype.accept = function(visitor) {
    if ( visitor instanceof SimpleGrammarVisitor ) {
        return visitor.visitFact(this);
    } else {
        return visitor.visitChildren(this);
    }
};




SimpleGrammarParser.FactContext = FactContext;

SimpleGrammarParser.prototype.fact = function() {

    var localctx = new FactContext(this, this._ctx, this.state);
    this.enterRule(localctx, 6, SimpleGrammarParser.RULE_fact);
    try {
        this.state = 35;
        this._errHandler.sync(this);
        switch(this._input.LA(1)) {
        case SimpleGrammarParser.VAR:
            this.enterOuterAlt(localctx, 1);
            this.state = 29;
            this.match(SimpleGrammarParser.VAR);
            break;
        case SimpleGrammarParser.NUM:
            this.enterOuterAlt(localctx, 2);
            this.state = 30;
            this.match(SimpleGrammarParser.NUM);
            break;
        case SimpleGrammarParser.OPEN:
            this.enterOuterAlt(localctx, 3);
            this.state = 31;
            this.match(SimpleGrammarParser.OPEN);
            this.state = 32;
            this.expr();
            this.state = 33;
            this.match(SimpleGrammarParser.CLOSE);
            break;
        default:
            throw new antlr4.error.NoViableAltException(this);
        }
    } catch (re) {
    	if(re instanceof antlr4.error.RecognitionException) {
	        localctx.exception = re;
	        this._errHandler.reportError(this, re);
	        this._errHandler.recover(this, re);
	    } else {
	    	throw re;
	    }
    } finally {
        this.exitRule();
    }
    return localctx;
};


exports.SimpleGrammarParser = SimpleGrammarParser;
