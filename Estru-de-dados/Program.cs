// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// //Listras

// List<string> listanome = new List<string> {"wanderson", "jeane", "Ryan"};
// listanome.Add("Maria");

// Console.WriteLine("Lista de nome: ");

// for (int i = 0; i <listanome.Count; i++){
//     Console.WriteLine(listanome[i]);
// }

// Console.WriteLine("\n Verificacao do nome: Ryan");
// string nomeparaverificar = "Ryan";
// if (listanome.Contains(nomeparaverificar)){
//     Console.WriteLine("tem");
// }else{
//     Console.WriteLine("Num tem");
// }

// Console.WriteLine("Apos remover WAnderson");
// string pararemovernome = "wanderson";
// bool foiremovido = listanome.Remove(pararemovernome);
// if (foiremovido){
//     Console.WriteLine($"{pararemovernome} foi removido da lista");
// } else{
//     Console.WriteLine($"{pararemovernome} não foi encontrado na lista");
// }
// Console.WriteLine("Lista de nome: ");

// for (int i = 0; i <listanome.Count; i++){
//     Console.WriteLine(listanome[i]);
// }

//Conjunto(set)

// HashSet<int> Conjunto = new HashSet<int> {1,2,3};
// Conjunto.Add(4);
// Conjunto.Add(2);

// Console.WriteLine("Elementos dos conjuntos");
// foreach (int i in Conjunto)
// {
//     Console.WriteLine(i);
// }

// HashSet<string> frutas = new HashSet<string> {"Maca","Banana","uva"};
// frutas.Add("Laranja");
// frutas.Add("Maca");

// Console.WriteLine("Elementos dos conjuntos");
// foreach (string i in frutas)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine("\n Verificacao de existencia:");
// Console.WriteLine(frutas.Contains("Banana")?"Banana esta no conjunto" :"Banana nao esta no consjunto");

// frutas.Remove("Laranja");
// Console.WriteLine("\nApos remover laranja");
// Console.WriteLine("Elementos dos conjuntos");
// foreach (string i in frutas)
// {
//     Console.WriteLine(i);
// }

//atv 1

// int[] Numb = {1,2,3,4,5};
// int soma = 0;

// for (int i = 0; i < Numb.Length; i++) 
// { 
//     soma += Numb[i];
    
// } 
// Console.WriteLine(soma);

//Atv 2

// List<string> listanome = new List<string> {"wanderson", "jeane", "Ryan", "jeane", "Paula", "jeane"};
// int Contnome = 0;

// for (int i = 0; i <listanome.Count; i++){
//     if(listanome[i] == "jeane"){
//         Contnome++;
//     }
// }
// Console.WriteLine(Contnome);

//Atv 3

// List<int> numeros = new List<int>{1,2,2,3,4,4,5};
// HashSet<int> numerossemrep = new HashSet<int>(numeros);

// foreach(int i in numerossemrep)
// {
//     Console.WriteLine(i);
// }

//Atv 4

// HashSet<string> frutas = new HashSet<string> {"Maca","Banana","uva"};

// Console.WriteLine(frutas.Contains("Banana") ? "Tem Banana" : "Nao tem banana");

//Atv 5

// List<int> numeros = new List<int>();

// numeros.Add(1);
// numeros.Add(2);
// numeros.Add(3);
// numeros.Add(4);
// numeros.Add(5);

// foreach(int i in numeros)
// {
//     Console.WriteLine(i);
// }