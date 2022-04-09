grammar SimpleGrammar; 

prog    : line+
        ;

line    : atrib 
        | print
        | read
        ;

atrib   : VAR EQ expr
        ;

read    : READ VAR
        ;

print   : PRINT expr
        | PRINT VAR
        ;

expr    : term ADD e1=expr       
        | term                   
        ; 

term    : fact MUL t1=term       
        | fact                   
        ; 

fact    : NUM                    #factNum
        | VAR                    #factVar
        | OPEN expr CLOSE        #factExpr
        ;

EQ      : '=';
EOL     : ';';
OPEN    : '(';
CLOSE   : ')';
MOD     : '%';
DIV     : '/';
MUL     : '*';
SUB     : '-';
ADD     : '+';
PRINT   : 'print';
READ    : 'read';
NUM     : [0-9]+;
VAR     : [a-zA-Z]+;
COMMENTS: '#'[~\r\n]+ -> skip;
WS      : [ \t\r\n]+ -> skip; 
