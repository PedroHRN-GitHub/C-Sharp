//tipos primitivos
//Num inteiros

using System.Security.Cryptography;

short ano = 2024;
Console.WriteLine(ano);

int contador = 10;
Console.WriteLine(contador);

long PopuMundi = 80000000000000;
Console.WriteLine(PopuMundi);

//Num quebrados

float temp = 43.6f;
Console.WriteLine(temp);

double PrecoProduto = 199.9;
Console.WriteLine(PrecoProduto);

//Caracteres

char inicial = 'P';
Console.WriteLine(inicial);

//tipo logico

bool Logado = true;
Console.WriteLine(Logado);

bool ativo = false;
Console.WriteLine(ativo);

//Tipos não Primitivos
//NUll Types

int? idade = null;
Console.WriteLine(idade);

string saudacao = "Olá Mundo";
Console.WriteLine(saudacao);

//arrys

int[] numeros = {1,2,3,4,5};
Console.WriteLine(numeros);

string[] nomes = {"Pedro","Adriana","Carlos", "ana","ana c"};
Console.WriteLine(nomes);

//classes 
public class Pessoas{
    public required string Nome;
    public int idade;
}

// structs
public class Ponto{
    public int y;
    public int x;
}

//Enums

public enum Diadasemana{
    Seg,Terc,Quart,Quint,Sexta,Sab,Domingo
}


//interface

public interface IVeiculo{
    void Mover();
}


//delegates

public delegate int Processar(int numero);
