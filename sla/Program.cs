int VMP = 400;
int VMPM = 400;
int VHP = 200;

while(true){
    Console.WriteLine("De quem é o Turno: \n\n1.Player\n2.Npc");
    string? Turno = Console.ReadLine();
    switch(Turno){
        case"1":
            Console.WriteLine("Qual Player: \n\n1.Vladimir\n2.Akirat\n3.Passos\n4.Usarick\n5.Licurgo");
            string? A = Console.ReadLine();
            switch(A){
                case "1":
                    string VNAME = "Vladimir";
                    Console.WriteLine($"Nome: {VNAME}");
                    Console.WriteLine($"HP: {VHP}");
                    Console.WriteLine($"MP: {VMP}\n\n");
                    Console.WriteLine("Magia: \n1.\n1.\n1.");
                    string? Vhab = Console.ReadLine();
                    switch (Vhab){
                        case"1":
                            if(VMP >= 50){
                            Random dano = new Random();
                            int danov = dano.Next(1, 101);
                            double danof = danov + (danov * 15 / 100);
                            Console.WriteLine($"Dano: {danof}");
                            VMP -= 50; // Reduz o MP permanentemente
                            Console.WriteLine($"MP restante: {VMP}");
                            } else{
                                Console.WriteLine("Sem mana o suficiente");
                            }
                        break;
                        case"2":
                        VMP += VMPM*10 /100;
                        break;
                    }
                break;
                case "2":
                break;
                case "3":
                break;
                case "4":
                break;
                case "5":
                break;
                default:
                break;
            }
        break;
        case"2":
         Console.WriteLine("Qual Player: \n\n1.Vladimir\n2.Akirat\n3.Passos\n4.Usarick\n5.");
            string? b = Console.ReadLine();
            switch(b){
                case "1":
                break;
            }
        break;
    }
}