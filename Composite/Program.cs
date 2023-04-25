using DesingnComposite.Models;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mapa = new Composite("MAPA DAS CAVERNAS");
            
            var caverna1 = new Composite("Caverna 1");

            caverna1.Adicionar(new FaseJogo("Sub Fase 1"));
            caverna1.Adicionar(new FaseJogo("Sub Fase 2"));
            caverna1.Adicionar(new FaseJogo("Sub Fase 3"));

            var caverna2 = new Composite("Caverna 2");

            caverna2.Adicionar(new FaseJogo("Sub Fase 4"));
            caverna2.Adicionar(new FaseJogo("Sub Fase 5"));

            var portaSecreta = new Composite("Porta Secreta");
            portaSecreta.Adicionar(new FaseJogo("Sub fase Secret a X"));

            mapa.Adicionar(caverna1);
            mapa.Adicionar(caverna2);
            mapa.Adicionar(portaSecreta);

            mapa.Mostrar(1);
            

            Console.ReadKey();
        }


    }
}