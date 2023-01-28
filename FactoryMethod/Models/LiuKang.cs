using FactoryMethod.Models.Interfaces;

namespace FactoryMethod.Models
{
    public class LiuKang:IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Liu Kang");
        }
    }
}