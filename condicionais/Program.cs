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
