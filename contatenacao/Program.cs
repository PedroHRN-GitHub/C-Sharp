// See https://aka.ms/new-console-template for more information
//COntatenacao
string nome = "pedro";
string saudacao = "olá, "+ nome +"! Bem Vindo.";
Console.WriteLine(saudacao);

//Interpolacao

string nome1 = "pedro";
string saudacao1 = $"Olá {nome1}! Bem-Vindo";

Console.WriteLine(saudacao1);

int numero = 5;

Console.WriteLine(numero.GetType());