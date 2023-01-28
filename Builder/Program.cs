
using Builder.Models;
using Builder.Models.CriadorDeSoldados;
using Builder.Models.Soldados;

namespace CasadoCodigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var exercito = new Exercito();

            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;

            // Criando um soldado das forças especiais
            criadorDeSoldado = new CriadorDeInfantariaEspeciais();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();

            Console.WriteLine($"Soldado com as características: {soldado.Arma}, " +
                $"{soldado.Transporte}, {soldado.Foco}");

            // Criando um soldado de infantaria leve
            criadorDeSoldado = new CriadorDeInfantariaLeve();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();

            Console.WriteLine($"Soldado com as características: {soldado.Arma}, " +
                $"{soldado.Transporte}, {soldado.Foco}");

           
            Console.ReadKey();
        }


    }
}