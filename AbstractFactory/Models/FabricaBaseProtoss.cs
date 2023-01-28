using AbstractFactory.Models.Energia;
using AbstractFactory.Models.Interfaces;
using AbstractFactory.Models.Revestimento;

namespace AbstractFactory.Models
{
    public class FabricaBaseProtoss : IFabricaBase
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base Protoss criada com sucesso!");

            RevestimentoBaseProtoss revestimento = new RevestimentoBaseProtoss();
            revestimento.Composicao();

            EnergiaBaseProtoss energia = new EnergiaBaseProtoss();
            energia.Composicao();
        }
    }
}
