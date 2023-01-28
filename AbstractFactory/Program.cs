

using AbstractFactory.Models;
using AbstractFactory.Models.Interfaces;
using System.Collections.Concurrent;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IFabricaBase fabrica;

            Console.WriteLine("Escolha um dos personagens: " +
                "1 - Protoss | 2 - Zergs | 3 - Terranos");

            switch (Console.ReadLine())
            {
                case "1": fabrica = new FabricaBaseProtoss(); break;
                case "2": fabrica = new FabricaBaseZerg(); break;
                case "3": fabrica = new FabricaBaseTerran(); break; 
            }

            Console.ReadKey();
        }


    }
}