using Builder.Models.Soldados;

namespace Builder.Models.CriadorDeSoldados
{
    public class CriadorDeInfantariaEspeciais : CriadorDeSoldado
    {
        public CriadorDeInfantariaEspeciais()
        {
            _soldado = new SoldadoDeInfantariaEspeciais();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Combate em solo");
        }

        public override void Trasporte()
        {
            _soldado.EscolherTransporte("Carro de operaões especiais");
        }
    }
}
