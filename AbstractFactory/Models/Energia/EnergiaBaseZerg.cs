using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models.Energia
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base pel a terra");
        }
    }
}
