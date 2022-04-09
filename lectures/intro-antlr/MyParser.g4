grammar MyParser;

prog    : code EOL line
        ;

line    : prog 
        | 
        ;

code    : element 
        | output  
        | uif
        ;

element : tipo VAR equals expr cont
        ;

output  : PRINT OPEN show CLOSE
        ;

show    : STRING follow 
        | VAR follow
        ;

follow  : SUM STRING follow 
        | SUM VAR follow    
        | 
        ;

tipo    : TYPE 
        | 
        ;

equals  : EQUAL 
        | 
        ;

cont    : COMA element 
        | 
        ;

expr    : fact rest 
        | 
        ;

rest    : SUM expr 
        | SUB expr 
        | 
        ;

fact    : term more
        ;

more    : MULT fact 
        | DIV fact 
        | 
        ;

term    : OPEN expr CLOSE 
        | NUM 
        | VAR 
        | cfunction 
        | input
        | umath
        ;

uif     : IF OPEN condition CLOSE OPENB prog CLOSEB
        ;

condition   : expr comp expr other
            ;

comp    : DEQUAL 
        | BIGGER 
        | SMALLER 
        | BEQUAL 
        | SMEQUAL 
        | NEQUAL
        ;

other   : AND condition 
        | OR condition 
        | 
        ;

uelse   : ELSE OPENB prog CLOSEB;

uwhile  : WHILE OPEN condition CLOSE OPENB prog CLOSEB;

ufor    : FOR OPEN decl EOL condition EOL VAR incr;

decl    : TYPE VAR EQUAL expr;

incr    : DSUM 
        | DSUB
        ;

function    : TYPE FUNC OPEN par CLOSE OPENB code CLOSEB
            ;

par     : TYPE VAR COMA par 
        | TYPE VAR 
        | 
        ;

cfunction   : FUNC OPEN cpar CLOSE
            ;

cpar    : VAR COMA cpar 
        | VAR
        ;

input   : SCAN OPEN value CLOSE
        ;

value   : STRING 
        | INT 
        | FLOAT 
        | CHAR
        ;

umath   : MATH PONT mathpar
        ;

mathpar : floor 
        | ceil
        | sqrt
        | pot
        | fmax
        | fmin
        | rint
        ;

floor   : FLOOR OPEN CLOSE     //Arredonda para baixo
        ;

ceil    : CEIL OPEN CLOSE     //Arredonda para cima
        ;

sqrt    : SQRT OPEN CLOSE     //Raiz quadrada
        ;

pot     : POT OPEN NUM COMA NUM CLOSE     //Pontencia
        ;

fmax    : FMAX OPEN NUM COMA NUM CLOSE    //Maior valor
        ;

fmin    : FMIN OPEN NUM COMA NUM CLOSE    //Menor valor
        ;

rint    : RINT OPEN CLOSE     //Arredonda para int
        ;

//TOKENS

PRINT       :   'print';
SCAN        :   'scan';
FUNC        :   'func';
IF          :   'if';
ELSE        :   'else';
FOR         :   'for';
WHILE       :   'while';
STRING      :   'string';
INT         :   'int';
FLOAT       :   'float';
CHAR        :   'char';
TYPE        :   'type';
MATH        :   'math';
FLOOR       :   'floor';
CEIL        :   'ceil';
SQRT        :   'sqrt';
POT         :   'pot';
FMAX        :   'fmax';
FMIN        :   'fmin';
RINT        :   'rint';
PONT        :   '.';
OPEN        :   '(';
CLOSE       :   ')';
OPENB       :   '{';
CLOSEB      :   '}';
SUM         :   '+';
SUB         :   '-';
MULT        :   '*';
DIV         :   '/';
MOD         :   '%';
COMA        :   ',';
EOL         :   ';';
EQUAL      :   '=';
DEQUAL      :   '==';
DSUM        :   '+=';
DSUB        :   '-=';
BIGGER      :   '>';
SMALLER     :   '<';
BEQUAL      :   '>=';
SMEQUAL     :   '<=';
NEQUAL      :   '!=';
AND         :   '&&';
OR          :   '||';
NUM         :   [+-]?[0-9]+('.'[0-9]+)?; 
VAR         :   '@'[a-zA-Z][a-zA-Z0-9_]*;
COMMENT     :   '/*' .*? '*/' -> skip;
LINE_COMMENT:   '//' ~[\r\n]* -> skip;
WS          :   [ \t\r\n]+ -> skip;