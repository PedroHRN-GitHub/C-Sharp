
//COntatenacao
string nome = "pedro";
string saudacao = "olá, "+ nome +"! Bem Vindo.";
Console.WriteLine(saudacao);

//Interpolacao

string nome1 = "pedro";
string saudacao1 = $"Olá {nome1}! Bem-Vindo";

Console.WriteLine(saudacao1);
//GetType e Typeof
int numero = 5;

Console.WriteLine(numero.GetType());
Console.WriteLine(typeof(int));


//parse
string valorTexto = "100";
Console.WriteLine("A variável valorTexto é do tipo:"+ valorTexto.GetType());

int numero1 = int.Parse(valorTexto);
Console.WriteLine(numero1);
Console.WriteLine("A variável valorTexto é do tipo:"+ valorTexto.GetType());