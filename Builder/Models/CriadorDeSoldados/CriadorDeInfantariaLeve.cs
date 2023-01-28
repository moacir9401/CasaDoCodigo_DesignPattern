namespace Builder.Models.CriadorDeSoldados
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoDeInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aério");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Resposta rápida aérea");
        }

        public override void Trasporte()
        {
            _soldado.EscolherTransporte("Helicóptero de ataque do Exército");
        }
    }
}
