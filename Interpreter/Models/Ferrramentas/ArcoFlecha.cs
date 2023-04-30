namespace Interpreter.Models.Ferrramentas
{
    public class ArcoFlecha : IArmamento
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Arco e Flecha ");
        }
    }

}
