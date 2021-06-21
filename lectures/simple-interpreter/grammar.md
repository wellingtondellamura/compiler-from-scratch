x = 2 + 2;
y = 2 + 10;
z = x + y;
print(z);

prog ::= stmt ; prog | stmt;
stmt ::= atr | imp
atr  ::= VAR expr
imp  ::= PRINT(VAR)
expr ::= ....

y = 2 + 10;
<var, y> <eq> <num, 2> <sum> <num, 10> <eol>

Tabela de Símbolos
#  var  valor  tipo
1   x    4      int
2   a    3.14   double

