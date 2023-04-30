namespace CHAIN_OF_RESPONSABILITY.Models
{
    public abstract class Manipulador
    {
        protected Manipulador sucessor;
        public void defineSucessor(Manipulador sucessor)
        {
            this.sucessor = sucessor;
        }
        public abstract void Convoca(int quantidadePoder);
    }

}
