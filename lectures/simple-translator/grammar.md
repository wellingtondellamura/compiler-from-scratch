
<expr> ::= <term> <rest>
<rest> ::= + <term> <rest>
        |  - <term> <rest>
        |  (vazio)
<term> ::= NUMBER

Observar o lookahead
9 - 5 + 2
  ^
lookahead -
first(+ <term> <rest>) = {+}
first(- <term> <rest>) = {-}
first(<rest>) = {+, -, vazio}