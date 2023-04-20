using DesignBridge.Models.Cor;

namespace DesignBridge.Models.Forma
{
    public class Forma1 : IForma
    {
        public ICor ICor { get; set; }

        public string Descer()
        {
            return $"U - {ICor.Cor()}";
        }
    }
}
