using Builder.Models.CriadorDeSoldados;

namespace Builder.Models
{
    public class Exercito
    {
        public void ConstruirSoldado(CriadorDeSoldado criadorDeSoldado)
        {
            criadorDeSoldado.Arma();
            criadorDeSoldado.Trasporte();
            criadorDeSoldado.Foco();
        }
    }
}
