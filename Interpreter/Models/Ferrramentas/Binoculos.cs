﻿namespace Interpreter.Models.Ferrramentas
{
    public class Binoculos : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Binóculos ");
        }
    }
}
