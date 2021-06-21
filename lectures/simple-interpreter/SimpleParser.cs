namespace simple_interpreter
{
    public class SimpleParser
    {
        public string Output { get; private set; }
        private SimpleLexer _lexer;
        private Token _lookAhead;
        public SimpleParser(SimpleLexer lexer)
        {
            _lexer = lexer;
            _lookAhead = _lexer.NextToken();
        }

        private void Match(Token token)
        {
            if (_lookAhead.Type == token.Type && _lookAhead.Attribute == token.Attribute)
            {
                _lookAhead = _lexer.NextToken();
            }
            else
            {
                throw new System.Exception("\n*** Syntax Error! Values do not match. *** \n");
            }
        }

        public int Expr() //<expr> ::= <term> <rest>
        {
            var t = Term();
            var (op, v) = Rest();
            if (op == EOperation.Sum)
                return t + v;
            else if (op == EOperation.Sub)
                return t - v;
            else 
                return t;
        }

        public (EOperation,int) Rest()
        {
            if (_lookAhead.Type == ETokenType.Sum) // + <term> <rest>
            {
                Match(_lookAhead);
                var t = Term();
                return (EOperation.Sum,t);
                //Output += ("+ ");
                //Rest();
            }
            else if (_lookAhead.Type == ETokenType.Sub) // - <term> <rest>
            {
                Match(_lookAhead);
                var t = Term();
                return (EOperation.Sub,t);
                //Output += ("+ ");
                //Rest();
            }
            else //vazio
            {
                if (_lookAhead.Type != ETokenType.EOF)
                    throw new System.Exception("\n*** Syntax Error! Unexpected symbol '" + _lookAhead.Attribute + "'. ***\n");
                return (EOperation.None,0);
            }
        }

        public int Term() //<term> ::= NUMBER
        {
            if (_lookAhead.Type == ETokenType.Number)
            {
                var v = _lookAhead.Attribute.Value;
                //Output += _lookAhead.Value + " ";                
                Match(_lookAhead);
                return v;
            }
            else
            {
                throw new System.Exception("\n*** Syntax Error! '" + _lookAhead.Attribute.Value + "' it's not a number. ***\n");
            }
        }
    }


    public enum EOperation {
        Sum, Sub, None
    }
}