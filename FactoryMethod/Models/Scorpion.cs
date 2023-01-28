using FactoryMethod.Models.Interfaces;

namespace FactoryMethod.Models
{
    public class Scorpion: IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Scorpion");
        }
    }
}