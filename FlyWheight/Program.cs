
using DesingFlyWeight.Models;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FlyWeight flyWeight = new FlyWeight();

            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Qual tartaruga enviar para tela: ");

                cor = Console.ReadLine();

                tartaruga = flyWeight.GetTartaruga(cor);
                tartaruga.Mostrar(cor);

                Console.WriteLine();
                Console.WriteLine("---------------------------");

            }

            Console.ReadKey();
        }


    }
}