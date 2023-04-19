namespace DesingAdapter.Models
{
    public class Aviao
    {
        public void Voar(string jogador)
        {
            Console.WriteLine($"{jogador} VOOU PARA FRENTE!");
        }

        public void SoltarMissil()
        {
            Console.WriteLine("Soltou um míssil no jogo");
        }
    }
}
