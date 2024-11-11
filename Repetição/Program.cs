// See https://aka.ms/new-console-template for more information

//While

// Random numbrand = new Random();
// int numb = numbrand.Next(1,20);
// int cont = 0;

// Console.WriteLine($"Numero Alvo: {numb}");

// while(cont != numb){

//     Console.WriteLine($"Contador: {cont}");
//     cont++;
// }

// Console.WriteLine($"Contador atingiu o número: {cont}");

//DO WHILE

// int numero = 0;

// do{
//     Console.WriteLine($"Numero = {numero}");
//     numero++;
// }while(numero > 10);


//For

// for (int numero = 0; numero <=10; numero++){

//     Console.WriteLine($"Numero = {numero}");
// }

//ForEach usado em array e listas

string[] nomes = {"Pedro", "Pedra", "Pepe"};
foreach (string nome in nomes){
    Console.WriteLine(nome);
}