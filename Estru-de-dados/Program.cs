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
// frutas.Add("Pokan");
// frutas.Add("Maca");

// Console.WriteLine("Elementos dos conjuntos");
// foreach (string i in frutas)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine("\n Verificacao de existencia:");
// Console.WriteLine(frutas.Contains("Banana")?"Banana esta no conjunto" :"Banana nao esta no consjunto");
