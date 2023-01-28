using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models.Energia
{
    public class EnergiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base mecânica");
        }
    }
}
