
using Interpreter.Models;
using Interpreter.Models.Ferrramentas;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mochila mochila = new Mochila(
                new Corda(),
                new Binoculos(),
                new ArcoFlecha());

            mochila.Interpretar(new Contexto());

            Console.ReadKey();

        }
    }
}