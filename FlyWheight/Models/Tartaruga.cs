using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingFlyWeight.Models
{
    public abstract class Tartaruga
    {
        protected string condicao;
        protected string acao;
        protected string cor { get; set; }
        public abstract void Mostrar(string cor);
    }
}
