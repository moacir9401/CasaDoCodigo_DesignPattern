using Builder.Models.Soldados;

namespace Builder.Models.CriadorDeSoldados
{
    public abstract class CriadorDeSoldado
    {
        protected Soldado _soldado;

        public Soldado ObterSoldado()
        {
            return _soldado;
        }

        public abstract void Arma();
        public abstract void Trasporte();
        public abstract void Foco();



    }
}
