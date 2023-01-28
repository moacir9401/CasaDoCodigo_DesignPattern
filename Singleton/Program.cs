
using AbstractFactory.Models;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInstalcia;

            jogador_1.Mensagem("Jogadir 1: A bola está comigo no meio do campo");

            Singleton jogador_2 = Singleton.GetInstalcia;

            jogador_2.Mensagem("Jogadir 2: recebeu a bola");

            Singleton jogador_3 = Singleton.GetInstalcia;

            jogador_3.Mensagem("Jogadir 3: recebeu  o lançamento na linha de fundo");
             
            Console.ReadKey();
        }


    }
}