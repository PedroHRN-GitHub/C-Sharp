using System;
using System.Collections.Generic;

int VMP = 400;
int VMPM = 400;

int AMP = 300;
int AMPM = 300;

int PMP = 250;
int PMPM = 250;

int UMP = 400;
int UMPM = 400;

int LMP = 350;
int LMPM = 350;

// Cooldown dictionaries for each player
var cooldownsVladimir = new Dictionary<string, int> { { "RecuperarMP", 0 }, { "CausarDano", 0 } };
var cooldownsAkirat = new Dictionary<string, int> { { "RecuperarMP", 0 } };
var cooldownsPassos = new Dictionary<string, int> { { "RecuperarMP", 0 } };
var cooldownsUsarik = new Dictionary<string, int> { { "RecuperarMP", 0 } };
var cooldownsLicurgo = new Dictionary<string, int> { { "RecuperarMP", 0 } };

while (true)
{
    Console.WriteLine("De quem é o Turno: \n\n1.Player\n2.Npc");
    string? Turno = Console.ReadLine();
    switch (Turno)
    {
        case "1":
            Console.WriteLine("Qual Player: \n\n1.Vladimir\n2.Akirat\n3.Passos\n4.Usarik\n5.Licurgo");
            string? A = Console.ReadLine();
            switch (A)
            {
                case "1":
                    string VNAME = "Vladimir";
                    Console.WriteLine($"Nome: {VNAME}");
                    Console.WriteLine($"MP: {VMP}\n\n");

                    bool habilidadeUsada = false;
                    while (!habilidadeUsada) // Loop para permitir novas escolhas até usar uma habilidade válida
                    {
                        Console.WriteLine("Magia: \n1. Recuperar MP (Cooldown: 2 rodadas)\n2. Causar Dano (Cooldown: 3 rodadas)");
                        string? Vhab = Console.ReadLine();
                        switch (Vhab)
                        {
                            case "1":
                                if (cooldownsVladimir["RecuperarMP"] == 0)
                                {
                                    if (VMP < VMPM)
                                    {
                                        VMP = Math.Min(VMP + VMPM * 10 / 100, VMPM);
                                        Console.WriteLine($"MP atualizado: {VMP}");
                                        cooldownsVladimir["RecuperarMP"] = 2; // Cooldown de 2 rodadas
                                        habilidadeUsada = true; // habilidade foi usada, saímos do loop
                                    }
                                    else
                                    {
                                        Console.WriteLine("MP já está no valor máximo.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Habilidade 'Recuperar MP' em cooldown por mais {cooldownsVladimir["RecuperarMP"]} rodada(s). Tente outra opção.");
                                }
                                break;

                            case "2":
                                if (cooldownsVladimir["CausarDano"] == 0)
                                {
                                    if (VMP >= 50)
                                    {
                                        Random dano = new Random();
                                        int danov = dano.Next(1, 101);
                                        double danof = danov + (danov * 15 / 100);
                                        Console.WriteLine($"Dano: {danof}");
                                        VMP -= 50;
                                        Console.WriteLine($"MP restante: {VMP}");
                                        cooldownsVladimir["CausarDano"] = 3; // Cooldown de 3 rodadas
                                        habilidadeUsada = true; // habilidade foi usada, saímos do loop
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sem mana o suficiente");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Habilidade 'Causar Dano' em cooldown por mais {cooldownsVladimir["CausarDano"]} rodada(s). Tente outra opção.");
                                }
                                break;

                            default:
                                Console.WriteLine("Opção inválida. Escolha novamente.");
                                break;
                        }
                    }
                    break;

                case "2":
                    string ANAME = "Akirat";
                    Console.WriteLine($"Nome: {ANAME}");
                    Console.WriteLine($"MP: {AMP}\n\n");

                    habilidadeUsada = false;
                    while (!habilidadeUsada)
                    {
                        Console.WriteLine("Magia: \n1. Recuperar MP (Cooldown: 2 rodadas)");
                        string? Ahab = Console.ReadLine();
                        if (Ahab == "1")
                        {
                            if (cooldownsAkirat["RecuperarMP"] == 0)
                            {
                                if (AMP < AMPM)
                                {
                                    AMP = Math.Min(AMP + AMPM * 10 / 100, AMPM);
                                    Console.WriteLine($"MP atualizado: {AMP}");
                                    cooldownsAkirat["RecuperarMP"] = 2; // Cooldown de 2 rodadas
                                    habilidadeUsada = true;
                                }
                                else
                                {
                                    Console.WriteLine("MP já está no valor máximo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Habilidade 'Recuperar MP' em cooldown por mais {cooldownsAkirat["RecuperarMP"]} rodada(s). Tente outra opção.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Escolha novamente.");
                        }
                    }
                    break;

                case "3":
                    string PNAME = "Passos";
                    Console.WriteLine($"Nome: {PNAME}");
                    Console.WriteLine($"MP: {PMP}\n\n");

                    habilidadeUsada = false;
                    while (!habilidadeUsada)
                    {
                        Console.WriteLine("Magia: \n1. Recuperar MP (Cooldown: 2 rodadas)");
                        string? Phab = Console.ReadLine();
                        if (Phab == "1")
                        {
                            if (cooldownsPassos["RecuperarMP"] == 0)
                            {
                                if (PMP < PMPM)
                                {
                                    PMP = Math.Min(PMP + PMPM * 10 / 100, PMPM);
                                    Console.WriteLine($"MP atualizado: {PMP}");
                                    cooldownsPassos["RecuperarMP"] = 2;
                                    habilidadeUsada = true;
                                }
                                else
                                {
                                    Console.WriteLine("MP já está no valor máximo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Habilidade 'Recuperar MP' em cooldown por mais {cooldownsPassos["RecuperarMP"]} rodada(s). Tente outra opção.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Escolha novamente.");
                        }
                    }
                    break;

                // Repetir a mesma lógica para Usarik e Licurgo...

                case "4":
                              string UNAME = "Usarick";
                    Console.WriteLine($"Nome: {UNAME}");
                    Console.WriteLine($"MP: {UMP}\n\n");

                    habilidadeUsada = false;
                    while (!habilidadeUsada)
                    {
                        Console.WriteLine("Magia: \n1. Recuperar MP (Cooldown: 2 rodadas)");
                        string? Uhab = Console.ReadLine();
                        if (Uhab == "1")
                        {
                            if (cooldownsUsarik["RecuperarMP"] == 0)
                            {
                                if (UMP < UMPM)
                                {
                                    UMP = Math.Min(UMP + UMPM * 10 / 100, UMPM);
                                    Console.WriteLine($"MP atualizado: {UMP}");
                                    cooldownsUsarik["RecuperarMP"] = 2;
                                    habilidadeUsada = true;
                                }
                                else
                                {
                                    Console.WriteLine("MP já está no valor máximo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Habilidade 'Recuperar MP' em cooldown por mais {cooldownsPassos["RecuperarMP"]} rodada(s). Tente outra opção.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Escolha novamente.");
                        }
                    }
                    break;
                case "5":
                              string LNAME = "Passos";
                    Console.WriteLine($"Nome: {LNAME}");
                    Console.WriteLine($"MP: {LMP}\n\n");

                    habilidadeUsada = false;
                    while (!habilidadeUsada)
                    {
                        Console.WriteLine("Magia: \n1. Recuperar MP (Cooldown: 2 rodadas)");
                        string? Lhab = Console.ReadLine();
                        if (Lhab == "1")
                        {
                            if (cooldownsLicurgo["RecuperarMP"] == 0)
                            {
                                if (LMP < LMPM)
                                {
                                    LMP = Math.Min(LMP + LMPM * 10 / 100, LMPM);
                                    Console.WriteLine($"MP atualizado: {LMP}");
                                    cooldownsLicurgo["RecuperarMP"] = 2;
                                    habilidadeUsada = true;
                                }
                                else
                                {
                                    Console.WriteLine("MP já está no valor máximo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Habilidade 'Recuperar MP' em cooldown por mais {cooldownsPassos["RecuperarMP"]} rodada(s). Tente outra opção.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Escolha novamente.");
                        }
                    }
                    break;
            }
            break;

        case "2":
            Console.WriteLine("NPC turno...");
            break;
    }

    // Atualizar cooldowns de todos os jogadores ao final de cada turno
    foreach (var key in cooldownsVladimir.Keys)
        if (cooldownsVladimir[key] > 0) cooldownsVladimir[key]--;

    foreach (var key in cooldownsAkirat.Keys)
        if (cooldownsAkirat[key] > 0) cooldownsAkirat[key]--;

    foreach (var key in cooldownsPassos.Keys)
        if (cooldownsPassos[key] > 0) cooldownsPassos[key]--;

    foreach (var key in cooldownsUsarik.Keys)
        if (cooldownsUsarik[key] > 0) cooldownsUsarik[key]--;

    foreach (var key in cooldownsLicurgo.Keys)
        if (cooldownsLicurgo[key] > 0) cooldownsLicurgo[key]--;
}
