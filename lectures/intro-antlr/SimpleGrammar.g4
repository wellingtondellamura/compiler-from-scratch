grammar SimpleGrammar;

expr    : term (ADD|SUB) expr 
        | term
        ;
term    : fact (MUL|DIV|MOD) term
        | fact
        ;
fact    : VAR 
        | NUM 
        | '('expr')' 
        ;

OEX         : '(';
CEX         : ')';
ADD         : '+';
SUB         : '-';
MUL         : '*';
DIV         : '/';
MOD         : '%';
NUM         : [0-9]+;
VAR         : [a-zA-Z]+;
WS          : [ \t\r\n]+ -> skip;
