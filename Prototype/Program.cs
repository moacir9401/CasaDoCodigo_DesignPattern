
using Prototype.Models;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GerenciadorNuvens gerenciadorNuvens = new GerenciadorNuvens();

            gerenciadorNuvens["padrão"] = new NuvemConcreta(
                "Branco",
                "Azul");

            gerenciadorNuvens["personalizada"] = new NuvemConcreta(
                "Branco",
                "Laranja");

            NuvemConcreta nuvemConcreta = gerenciadorNuvens["padrão"].Clone() as NuvemConcreta;

            NuvemConcreta nuvemConcretaDois = gerenciadorNuvens["padrão"].Clone() as NuvemConcreta;

            NuvemConcreta nuvemConcretaTres = gerenciadorNuvens["personalizada"].Clone() as NuvemConcreta;


            Console.ReadKey();
        }


    }
}