﻿namespace Builder.Models.Soldados
{
    public abstract class Soldado
    {
        public string Arma { get; set; }
        public string Transporte { get; protected set; }
        public string Foco { get; protected set; }

        public abstract void EscolherArma(string arma);
        public abstract void EscolherTransporte(string transporte);
        public abstract void DefinirFoco(string foco);


    }
}
