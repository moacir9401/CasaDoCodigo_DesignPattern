using DesignBridge.Models.Cor;

namespace DesignBridge.Models.Forma
{
    public interface IForma
    {
        ICor ICor { get; set; }
        string Descer();
    }
}
