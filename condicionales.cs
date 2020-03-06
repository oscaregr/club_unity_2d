
integer A = 3;
integer B = 5;

if(B<B){
    document.Write('hola');
    Console.Write('hola');
}else if(A<B && B<(2*A) || A===(B-2)){
    document.Write('si corre');
    Console.Write('si corre');
}
Console.Clear();
Console.Write('\n introduce un numero entero: ');

A = int.Parse(Console.ReadLine());

switch(A){
    case 1: 
    Console.Write('es 1');

    break;
    case 2: 
    Console.Write('es 2');

    break;
    case 3:
    Console.Write('es 3');

    break;
    
    default:
    Console.Write('te pasaste no entra');

    break;
}