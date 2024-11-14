Console.WriteLine("Digite a primeira nota: ");
double nota1;
while (!double.TryParse(Console.ReadLine(), out nota1))  // Tentativa de conversão
{
    Console.WriteLine("Valor inválido! Digite uma nota válida para a primeira nota: ");
}

Console.WriteLine($"Nota digitada: {nota1}");

Console.WriteLine("Digite a segunda nota: ");
double nota2;
while (!double.TryParse(Console.ReadLine(), out nota2))  // Tentativa de conversão
{
    Console.WriteLine("Valor inválido! Digite uma nota válida para a segunda nota: ");
}

Console.WriteLine($"Nota digitada: {nota2}");

Console.WriteLine("Digite a terceira nota: ");
double nota3;
while (!double.TryParse(Console.ReadLine(), out nota3))  // Tentativa de conversão
{
    Console.WriteLine("Valor inválido! Digite uma nota válida para a terceira nota: ");
}

Console.WriteLine($"Nota digitada: {nota3}");

Console.WriteLine("Digite a quarta nota: ");
double nota4;
while (!double.TryParse(Console.ReadLine(), out nota4))  // Tentativa de conversão
{
    Console.WriteLine("Valor inválido! Digite uma nota válida para a quarta nota: ");
}

Console.WriteLine($"Nota digitada: {nota4}");

double media1 = (nota1 + nota2) / 2;
double media2 = (nota3 + nota4) / 2;
double mediaF = (media1 + media2) / 2;

if (mediaF >= 7)
{
    Console.WriteLine($"Média final {mediaF:F2}: Aprovado");
}
else if (mediaF >= 4)
{
    Console.WriteLine($"Média final {mediaF:F2}: Recuperação");
}
else
{
    Console.WriteLine($"Média final {mediaF:F2}: Reprovado");
}

// Console.WriteLine("Digite uma letra e direi se é uma vogal ou não\n");
// string? letra = Console.ReadLine();

// if( letra == "a" || letra == "A" || 
//     letra == "e" || letra == "E" ||
//     letra == "i" ||letra == "I" ||
//     letra == "o" ||letra == "O" ||
//     letra == "u" ||letra == "U"){
//     Console.WriteLine($"A letra: {letra} é uma vogal");
// }
// else{
//     Console.WriteLine($"A letra: {letra} não é uma vogal");
// }

// Console.WriteLine("Digite o Dia da semana\n");
// string? dia = Console.ReadLine();

// if(dia == "Sabado" || dia == "Domingo" ||dia == "Segunda" ||dia == "Terca" ||dia == "Quarta" ||dia == "Quinta" ||dia == "Sexta"){
//     switch(dia){
//         case "Sabado":
//             Console.WriteLine("Sabado de depression");
//             break;
//         case "Domingo":
//             Console.WriteLine("Domingo, pe de cachimbo");
//             break;
//         default:
//             Console.WriteLine("Hoje é dia de semana, então vai ganhar dinheiro seu vagabundo");
//             break;
//     }
// }else{
//     Console.WriteLine("Voce digitou errado ou não colocou um dia da semana, tente escrever sem acento ou ç e lembre da primeira letra em maiusculo");
// }

//Switch

// Console.WriteLine("Digite uma letra e direi se é uma vogal ou não\n");
// string? letra = Console.ReadLine();

// // Verifica se a entrada não é nula e não está vazia
// if (string.IsNullOrEmpty(letra))
// {
//     Console.WriteLine("Entrada inválida! Por favor, digite uma letra.");
// }
// else
// {
//     // Converte a letra para minúscula
//     string letraminuscula = letra.ToLower();

//     // Verifica se é uma letra válida e se é uma vogal
//     switch (letraminuscula)
//     {
//         case "a":
//         case "e":
//         case "i":
//         case "o":
//         case "u":
//             Console.WriteLine($"A letra: {letraminuscula} é uma vogal");
//             break;
//         default:
//             Console.WriteLine($"A letra: {letraminuscula} não é uma vogal");
//             break;
//     }
// }

//int idade = 10;
// string mensagem = idade >= 18 ? "maior de idade" : "menor de idade";
// Console.WriteLine(mensagem);

// V1

// bool idade = 15 >= 18 ? true : false;
// string? mensagem = idade == false ? "" : "Tem autorização?";
// string? autorização = "sim";
// int autorizaçãoconfirm = autorização == "sim"|| autorização == "s"||autorização == "Sim"||  autorização == "S" ? 1 : 0;
// bool autorizaçãoV = autorizaçãoconfirm == 1 ? true : false;

// bool result = idade || autorizaçãoV;

// string? entrada = result == true ? "entrada permitida" : "entrada negada";
// Console.WriteLine(entrada);

//V2

// using System.Reflection.Metadata;
// Console.WriteLine ("digite a idade");
// string? idade = Console.ReadLine();
// int idadeV = int.Parse(idade);
// bool idadeP = idadeV >= 18 ? true : false;

// string pedido = idadeP == false ? "Tem autorização:": "Só aperte enter";
// Console.WriteLine(pedido);

// string? aut = Console.ReadLine();
// bool autconfirm = aut == "sim"|| aut == "s"||aut == "Sim"||  aut == "S" ? true : false;

// bool result = idadeP || autconfirm;
// string result1 = result == true ? "entrada permitida" : "entrada Negada";

// Console.WriteLine(result1);

//outra atv

// Console.WriteLine("Digite a primeira nota: ");
// double nota1;
// while (!double.TryParse(Console.ReadLine(), out nota1))  // Tentativa de conversão
// {
//     Console.WriteLine("Valor inválido! Digite uma nota válida para a primeira nota: ");
// }

// Console.WriteLine($"Nota digitada: {nota1}");

// Console.WriteLine("Digite a segunda nota: ");
// double nota2;
// while (!double.TryParse(Console.ReadLine(), out nota2))  // Tentativa de conversão
// {
//     Console.WriteLine("Valor inválido! Digite uma nota válida para a segunda nota: ");
// }

// Console.WriteLine($"Nota digitada: {nota2}");

// Console.WriteLine("Digite a terceira nota: ");
// double nota3;
// while (!double.TryParse(Console.ReadLine(), out nota3))  // Tentativa de conversão
// {
//     Console.WriteLine("Valor inválido! Digite uma nota válida para a terceira nota: ");
// }

// Console.WriteLine($"Nota digitada: {nota3}");

// Console.WriteLine("Digite a quarta nota: ");
// double nota4;
// while (!double.TryParse(Console.ReadLine(), out nota4))  // Tentativa de conversão
// {
//     Console.WriteLine("Valor inválido! Digite uma nota válida para a quarta nota: ");
// }

// Console.WriteLine($"Nota digitada: {nota4}");

// double media1 = (nota1 + nota2) / 2;
// double media2 = (nota3 + nota4) / 2;
// double mediaF = (media1 + media2) / 2;

// Console.WriteLine ("Possui presença minima:");
// string? Presenca = Console.ReadLine();
// bool PreConf = Presenca == "sim"|| Presenca == "s"||Presenca == "Sim"||  Presenca == "S" ? true : false;


// bool result = PreConf && mediaF >= 7;
// string result1 = result == true ? $"Média {mediaF:F1}: Aprovado" : $"Média {mediaF:F1}: Reprovado";

// Console.WriteLine(result1);

//outra atv

// Console.WriteLine ("Choveu?");
// string? Chuva = Console.ReadLine();
// bool ChuvaConf = Chuva == "sim"|| Chuva == "s"||Chuva == "Sim"||  Chuva == "S" ? true : false;
// Console.WriteLine("está tarde?");
// string? Tarde = Console.ReadLine();
// bool TardeConf = Tarde == "sim"|| Tarde == "s"||Tarde == "Sim"||  Tarde == "S" ? true : false;

// bool result = ChuvaConf || TardeConf;
// string result1 = result == !false ? $"Vou Deixar para outro dia" : $"Vou pedalar";

// Console.WriteLine(result1);