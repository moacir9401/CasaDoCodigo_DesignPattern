using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingFlyWeight.Models
{
    public class Azul : Tartaruga
    {
        public Azul()
        {
            condicao = $"Tartaruga dentro do casco, ";
            acao = "rodando no chão - ";
        }

        public override void Mostrar(string cor)
        {
            this.cor = cor;
            Console.WriteLine($"{condicao}{acao}{cor.ToUpper()}");
        }
    }
}
