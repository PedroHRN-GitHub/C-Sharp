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

// if (mediaF >= 7)
// {
//     Console.WriteLine($"Média final {mediaF:F2}: Aprovado");
// }
// else if (mediaF >= 4)
// {
//     Console.WriteLine($"Média final {mediaF:F2}: Recuperação");
// }
// else
// {
//     Console.WriteLine($"Média final {mediaF:F2}: Reprovado");
// }

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

Console.WriteLine("PEbas");