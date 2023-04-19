

using DesingAdapter.Models;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Personagem rodrigo = new Personagem();

            Aviao aviao_batalha = new Aviao();

            Iacao adaptador = new Adapter(aviao_batalha);

            Console.WriteLine("--- Caminhando ---");
            rodrigo.Andar(nameof(rodrigo));
            rodrigo.Atirar();

            Console.WriteLine();

            Console.WriteLine(" --- PEGOU UM AVIÃO NO JOGO ---");
            adaptador.Andar(nameof(adaptador));
            adaptador.Atirar();


            Console.ReadKey();
        }


    }
}