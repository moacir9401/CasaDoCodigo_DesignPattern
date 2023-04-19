namespace DesingAdapter.Models
{
    public class Adapter : Iacao
    {

        Aviao aviao;

        public Adapter(Aviao novo_aviao)
        {
            aviao = novo_aviao;
        }

        public void Andar(string jogador)
        {
            this.aviao.Voar("Rodrigo");
        }

        public void Atirar()
        {
           this.aviao.SoltarMissil();
        }
    }
}
