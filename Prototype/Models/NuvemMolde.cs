using System.Runtime.CompilerServices;

namespace Prototype.Models
{
    public class NuvemConcreta : NuvemMolde
    {
        private string cor_preenchimento;
        private string cor_contorno;

        public NuvemConcreta(string preenchimento, string contorno)
        {
            cor_preenchimento = preenchimento;
            cor_contorno = contorno;
        }

        public override NuvemMolde Clone()
        {
            Console.WriteLine($"A nuvem clonada tem contorno " +
                $"{this.cor_contorno} e preenchimento {this.cor_preenchimento}");

            return this.MemberwiseClone() as NuvemMolde;
        }
    }
}
