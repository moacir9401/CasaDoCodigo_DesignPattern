﻿namespace DesignState.Models
{
    public class PersonagemB : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new PersonagemA();
        }
    }
}