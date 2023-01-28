using FactoryMethod.Models.Interfaces;

namespace FactoryMethod.Models
{
    public class SubZero: IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("SubZero");
        }
    }
}