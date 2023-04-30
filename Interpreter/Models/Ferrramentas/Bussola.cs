namespace Interpreter.Models.Ferrramentas
{

    public class Bussola : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Bússola");
        }
    }
}
