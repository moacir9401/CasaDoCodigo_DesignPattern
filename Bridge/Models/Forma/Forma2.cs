using DesignBridge.Models.Cor;

namespace DesignBridge.Models.Forma
{
    public class Forma2 : IForma
    {
        public ICor ICor { get; set; }

        public string Descer()
        {
            return $"T - {ICor.Cor()}";
        }
    }
}
