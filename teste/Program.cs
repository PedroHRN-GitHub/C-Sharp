// See https://aka.ms/new-console-template for more information
int cal_Basal = 1600;
int cal_Dieta = cal_Basal+700;
int cal_comidas = 0;

List<string> carbo = new List<string> {$"arroz{cal_comidas+300}", "pão", "batata"};
List<string> prot = new List<string> {"Bife", "Frango", "peixe"};

string dieta;

while (true) { 
    
    switch(dieta){
        case "a":
        int i = 0; 
        i++;
        Console.WriteLine($"{i}.{carbo[i]}");
    break;
    }

}