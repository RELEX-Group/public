#!/bin/bash

#Happy New Year 2017 
#Authors: 

code="+ + + + + + + + [ - > + + + + + + + + < ] > + + + + + + + + . < + + + + + [ - > + + + + + < ] > . < + + + [ - > + + + < ] > + + + + + + . . + + + + + + + + + . < + + + + + + + + + [ - > - - - - - - - - - < ] > - - - - - - - - . < + + + + + + [ - > + + + + + + < ] > + + + + + + + + + + . < + + + + [ - > + + + + < ] > + + + + + + + . < + + + + [ - > + + + + < ] > + + . < + + + + + + + + + [ - > - - - - - - - - - < ] > - - - - - - . < + + + + + + + [ - > + + + + + + + < ] > + + + + + + + + . < + + + [ - > + + + < ] > + + + . - - - - . < + + + + [ - > + + + + < ] > + . < + + + + + + + + + [ - > - - - - - - - - - < ] > - . < + + + + [ - > + + + + < ] > + + . - - . + . + + + + + + . <";

C="s[0]=0; p=0;"
for c in $code;
do case $c in
    \+) C="$C s[\$p]=\$((\${s[\$p]}+1));";;
    \-) C="$C s[\$p]=\$((\${s[\$p]}-1));";;
    \>) C="$C p=\$((\$p+1));";;
    \<) C="$C p=\$((\$p-1));";;
    \.) C="$C printf \\\\\$(printf '%03o' \${s[\$p]});";;
    \,) C="$C read -n1 c; s[\$p]=\`printf '%d' \"'\$c\"\`;";;
    \[) C="$C while [[ \${s[\$p]} > 0 ]]; do ";;
    \]) C="$C done;";;
   esac;
done
eval $C
echo ""