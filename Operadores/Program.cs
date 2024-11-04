// See https://aka.ms/new-console-template for more information
//Operadores Aritimeticos

double result = 12 + 5 +12/3;
Console.WriteLine(result);


double result2 = (12 + 5 +12)/3;
Console.WriteLine(result2);


double result3 = (2+8)*2/4;
Console.WriteLine(result3);

//[Operadores de comparação]

//== para igual
//!= para diferente
//< menor que
//> maior que
//>= maior igual que
//<= Menor igual que

//Operadores Logicos

//AND

bool A = true;
bool B = false;

Console.WriteLine(A&&B);

//OUR

bool C = true;
bool D = false;

Console.WriteLine(C||D);

//Not

bool E = true;

Console.WriteLine(!E);

//XOR

bool F = true;
bool G = false;

Console.WriteLine(F^G);

//XNOR

bool H = true;
bool I = false;

Console.WriteLine(!(H^I));

//Teste de operadores

bool L = true;
bool P = false;
bool K = false;

bool resultado = !L ||(P&&K);
bool resultado2 = L ||P&&K;
Console.WriteLine(resultado);
Console.WriteLine(resultado2);
