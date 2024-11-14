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

// string[] nomes = {"Pedro", "Pedra", "Pepe"};
// foreach (string nome in nomes){
//     Console.WriteLine(nome);
// }

//Atv 1

// int soma = 0;

// for (int i = 1; i<=100; i++){
//     if(i % 2 == 0){
//         soma += i;
//     }
// }

// Console.WriteLine(soma);

//Atv 2

// for (int reg = 10; reg >=1; reg--){
//     Console.WriteLine ($"{reg}");
// }
// Console.WriteLine("Decolar");

//Atv 3
// Console.WriteLine("Digite uma palavra");
// string? palavra = Console.ReadLine();
// string convetpalavra = palavra.ToLower();
// int contador =0;

// foreach(char letras in convetpalavra){
//     if("aeiou".Contains(letras)){
//         contador++;
//     }
// }

// Console.WriteLine(contador);

//atv 4

// Console.WriteLine("Digite uma palavra");
// string? palavra = Console.ReadLine();
// string convetpalavra = palavra.ToLower();

// string reverso = new string(convetpalavra.Reverse().ToArray());

// if(convetpalavra == reverso){
//     Console.WriteLine("É um paldindromo");
// }
// else{
//     Console.WriteLine("Não é um paldindromo");
// }

//Atv 5

// Random numb = new Random();
// int numero = numb.Next(1, 101);
// Console.WriteLine("Digite seu numero");
// int num;

// while(true){
    
//     if(!int.TryParse(Console.ReadLine(), out num)){
//          Console.WriteLine("Por favor, digite um número válido.");
//         continue;
//     }
//     if(num < numero){
//     Console.WriteLine($"{num} é menor que o numero escolhido");
//     }else if(num > numero){
//     Console.WriteLine($"{num} é maior que o numero escolhido");
//     } else{
//     Console.WriteLine($"Voce acertou");
//     break;
//     }
// }
