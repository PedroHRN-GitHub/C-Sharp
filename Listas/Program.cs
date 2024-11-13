// See https://aka.ms/new-console-template for more information
List<string> listanome = new List<string> {"wanderson", "jeane", "Ryan"};
listanome.Add("Maria");

Console.WriteLine("Lista de nome: ");

for (int i = 0; i <listanome.Count; i++){
    Console.WriteLine(listanome[i]);
}

Console.WriteLine("\n Verificacao do nome: Ryan");
string nomeparaverificar = "Ryan";
if (listanome.Contains(nomeparaverificar)){
    Console.WriteLine("tem");
}else{
    Console.WriteLine("Num tem");
}

Console.WriteLine("Apos remover WAnderson");
string pararemovernome = "wanderson";
bool foiremovido = listanome.Remove(pararemovernome);
if (foiremovido){
    Console.WriteLine($"{pararemovernome} foi removido da lista");
} else{
    Console.WriteLine($"{pararemovernome} não foi encontrado na lista");
}