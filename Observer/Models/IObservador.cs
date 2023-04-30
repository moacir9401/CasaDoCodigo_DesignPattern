namespace Observer.Models
{
    public interface IObservador
    {
        void Avisar(IPersonagem personagem); 
    }
}