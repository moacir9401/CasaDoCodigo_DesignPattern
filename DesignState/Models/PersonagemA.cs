namespace DesignState.Models
{
    public class PersonagemA : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new PersonagemB();
        }
    }
}