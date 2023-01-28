using AbstractFactory.Models.Energia;
using AbstractFactory.Models.Interfaces;
using AbstractFactory.Models.Revestimento;

namespace AbstractFactory.Models
{
    public class FabricaBaseTerran : IFabricaBase
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base Terran criada com sucesso!");

            RevestimentoBaseTerran revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();

            EnergiaBaseTerran energia = new EnergiaBaseTerran();
            energia.Composicao();
        }
    }
}
