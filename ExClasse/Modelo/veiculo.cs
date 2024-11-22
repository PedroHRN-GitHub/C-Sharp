using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExClass.Modelo
{
    public class Veiculo
    {
        // Atributos
        string marca;
        string Modelo;
        int ano;

        
        // Construtor
        public Veiculo(string marca,string Modelo ,int ano) 
        { 
            this.marca = marca; 
            this.Modelo = Modelo; 
            this.ano = ano;
        }

        // Métodos Andar e Falar
        public void acelerar()
        {
            Console.WriteLine($"{Modelo} está acelerando");
        }
        public void freiar()
        {
            Console.WriteLine($"{Modelo} está freiando");
        }
    }
}