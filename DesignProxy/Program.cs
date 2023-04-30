using DesignProxy.Models;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ProxyFase proxy = new ProxyFase();

            Console.WriteLine("#### Tentando acessar a fase do jo go com Password incorreto ####");

            Console.WriteLine(proxy.InformarPassword("465"));

            Console.WriteLine(proxy.Jogar());
            Console.WriteLine();

            Console.WriteLine("#### Tentando acessar a fase do jo go com Password correto ####");

            Console.WriteLine(proxy.InformarPassword("123"));
            Console.WriteLine(proxy.Jogar());
            Console.WriteLine();

            Console.ReadKey();
        }


    }
}