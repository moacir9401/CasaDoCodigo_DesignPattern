
namespace Observer.Models
{
    public interface IPersonagem
    {
        void RegistrarObservador(IObservador observador); void NotificarPersonagens();
    } 
}
