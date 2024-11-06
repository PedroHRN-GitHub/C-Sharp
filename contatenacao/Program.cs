
//COntatenacao
string nome = "pedro";
string saudacao = "olá, "+ nome +"! Bem Vindo.";
Console.WriteLine(saudacao);

//Interpolacao

string nome1 = "pedro";
string saudacao1 = $"Olá {nome1}! Bem-Vindo";

Console.WriteLine(saudacao1);
//GetType e Typeof
int numero = 5;

Console.WriteLine(numero.GetType());
Console.WriteLine(typeof(int));


//parse
string valorTexto = "100";
Console.WriteLine("A variável valorTexto é do tipo:"+ valorTexto.GetType());

int numero1 = int.Parse(valorTexto);
Console.WriteLine(numero1);
Console.WriteLine("A variável valorTexto é do tipo:"+ valorTexto.GetType());

//convert\

string valoremTexto = "100";
Console.WriteLine("A variável valorTexto é do tipo:"+ valoremTexto);
Console.WriteLine("A variável valorTexto é do tipo:"+ valoremTexto.GetType());

int numeroCOnvert = Convert.ToInt32(valoremTexto);
Console.WriteLine(numeroCOnvert);
Console.WriteLine("A variável valorTexto é do tipo:"+ numeroCOnvert.GetType());

//para string

int numero2 = 234;
Console.WriteLine(numero.GetType());

string numbcomostring = numero2.ToString();
Console.WriteLine(numbcomostring.GetType());

//DAta e hora (personalizada)
DateTime dataatual = DateTime.Now;
Console.WriteLine(dataatual);

string dataFormatada = dataatual.ToString("dd/MM/yyyy");
Console.WriteLine(dataFormatada);

string horaformatada = dataatual.ToString("HH:mm:ss");
Console.WriteLine(horaformatada);

//loc

decimal valor = 1234.56m;
string valorUS = valor.ToString("C", new System.Globalization.CultureInfo("en-us"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("C", new System.Globalization.CultureInfo("PT-BR"));
Console.WriteLine(valorBR);
