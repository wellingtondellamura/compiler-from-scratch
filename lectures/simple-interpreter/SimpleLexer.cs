namespace simple_interpreter
{
    public class SimpleLexer
    {
        private string _spaces = " \n\t";
        public int Position { get; protected set; }
        public string Input { get; protected set; }

        public bool HasInput { get
            {
                return !string.IsNullOrEmpty(Input) && Position < Input.Length;
            }
        }
        public SimpleLexer(string input)
        {
            this.Input = input;
            Position = 0;
        }

        private char NextChar()
        {
            if (Position == Input.Length)
                return char.MinValue;
            return Input[Position++];
        }

        public Token NextToken()
        {
            char peek;
            do{
                peek = NextChar();              
            } while (_spaces.Contains(peek));

            if (char.IsDigit(peek))
            {
                var v = "";
                do
                {
                    v+=peek;
                    peek = NextChar();         
                } while (char.IsDigit(peek));
                if (peek != char.MinValue)
                    Position--;
                return new Token(ETokenType.Number, int.Parse(v));
            }
            if (peek == '+')
                return new Token(ETokenType.Sum);
            else if (peek == '-')
                return new Token(ETokenType.Sub);
            else if (peek == char.MinValue)
                return new Token(ETokenType.EOF);

            return new Token(ETokenType.Invalid);
        }
    }

    public class Token
    {
        public ETokenType Type {get;set;}
        public int? Attribute {get;set;}

        public bool HasValue { get
            {
                return Attribute.HasValue;
            }
        }

        public Token(ETokenType type, int? value = null)
        {
            Type = type;
            Attribute = value;
        }
    }

    public enum ETokenType
    {
        Number = 0,
        Sum = 1,
        Sub = 2,

        Var = 3,

        Print = 4,
        EOF = 99,
        Invalid = -1
    }
}