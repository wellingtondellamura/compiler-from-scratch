# Exemplo de Código
    $x = 2 - 2 + 2/5;
    $y = 2 * 10 + 1;
    $z = ($x + $y) * 5;
    $p = 3.14;
    print(z);

# Gramática
    prog ::= stmt EOL lines
    lines::= prog | ε
    stmt ::= atr | imp
    atr  ::= VAR expr
    imp  ::= PRINT OPEN VAR CLOSE
    expr ::= expr SUM expr | expr SUB expr | fact  //remover a recursão à esquerda
    fact ::= fact MULT fact | fact DIV fact | term  //fatorar à esquerda
    term ::= OPEN expr CLOSE | NUM | VAR

# Extrair os Tokens
y = 2 + 10;
<var, y> <eq> <num, 2> <sum> <num, 10> <eol>

EOL = ;
OPEN = parêntesis aberto '('
CLOSE = parêntesis fechado ')'
SUM = '+'
SUB = '-'
MULT = '*'
DIV = '/'
NUM = qualquer sequencia de números ou ponto + atributo (valor 3.14)
VAR = qualquer sequencia de letras começando com $ + atributo (tabela de símbolos)
PRINT = a palavra chave 'print'

# Tabela de Símbolos
 var   valor  
  $x    4.0
  $a    3.14  

# Construir o analisador léxico

# Construir o analisador sintático e interpretador 