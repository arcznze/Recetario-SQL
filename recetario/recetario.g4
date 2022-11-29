grammar recetario;

program : (entry)+ EOF ;

entry : receta porciones (tiempoprep)* (tiempococ)* calorias ingredientes elaboracion;

receta : GUION SP REC_LBL SEP TEXT SP?;
porciones : GUION SP POR_LBL SEP NUMBER SP TEXT SP?;
tiempoprep : GUION SP TMP_LBL SEP NUMBER SP TEXT SP?;
tiempococ : GUION SP TMC_LBL SEP NUMBER SP TEXT SP?;
calorias : GUION SP CAL_LBL SEP NUMBER SP TEXT SP? ;
ingredientes : GUION SP ING_LBL SEP NUMBER SP TEXT (COM NUMBER SP TEXT)* SP? ;
elaboracion : GUION SP ELA_LBL SEP (LISTA SP TEXT)* SP? ;

GUION   : '-' ;
REC_LBL : 'RECETA' ;
POR_LBL : 'PORCIONES' ;
TMP_LBL : 'TIEMPO PREPARACION' ;
TMC_LBL : 'TIEMPO COCCION' ;
CAL_LBL : 'CALORIAS' ;
ING_LBL : 'INGREDIENTES' ;
ELA_LBL : 'ELABORACION' ;
FEC_LBL : 'FECHA' ;
HOR_LBL : 'HORA' ;
DUR_LBL : 'DURACION' ;
TEM_LBL : 'TEMA' ;
COM : SP? ',' SP? ;
SEP : SP? ':' SP? ;
SP : ' '+ ;

NUMBER  : INT | FLOAT;
INT     : [0-9]+;
FLOAT   : [0-9]+'.'[0-9]+;
LISTA:   [0-9]+ ')' ;
TEXT :   WORD (SP WORD)* ;
WORD :   [A-Za-z_]+ ;

WS: [\n\r\t] -> skip ;