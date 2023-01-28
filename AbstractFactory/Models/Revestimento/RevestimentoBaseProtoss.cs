using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models.Revestimento
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor Amarela");
        }
    }
}
