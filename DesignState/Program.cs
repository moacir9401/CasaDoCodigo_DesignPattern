
using DesignState.Models;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Contexto contexto = new Contexto(new PersonagemA());
            
            contexto.Troca(); 
            contexto.Troca(); 
            contexto.Troca();
            contexto.Troca();

            Console.ReadKey();
        }

    }
}