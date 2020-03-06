
integer A = 3;
integer B = 5;
integer C = 8;
string D = "";

for(C=0;C<B;C++){
    document.Write('\n hola' + C);
    console.Write('\n hola' + C);
}



do{
    console.Write('\n do');
    D += A + " ";
    A++;
}while(A<B);




foreach( char E in D){
    console.write('este ciclo lleva ' + E + 'vueltas');
}