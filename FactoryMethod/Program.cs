using FactoryMethod.Models;
using FactoryMethod.Models.Interfaces;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine("Escolha seu personagem: ");

            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.Escolher_Personagem(escolha);

            Console.WriteLine();
            Console.Write($"Você vai jogar com ");
            personagem.Escolhido();

            Console.ReadKey();
        }

        
    }
}