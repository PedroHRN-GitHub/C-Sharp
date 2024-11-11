// See https://aka.ms/new-console-template for more information
Random numbrand = new Random();
int numb = numbrand.Next(1,20);
int cont = 0;

Console.WriteLine($"Numero Alvo: {numb}");

while(cont != numb){

    Console.WriteLine($"Contador: {cont}");
    cont++;
}

Console.WriteLine($"Contador atingiu o número: {cont}");