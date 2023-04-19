namespace DesingAdapter.Models
{
    public class Personagem : Iacao
    {
        public void Andar(string jogador)
        {
            Console.WriteLine($"{jogador} ANDOU PARA FRENTE!");
        }

        public void Atirar()
        {
            Console.WriteLine("Você atirou no jogo");
        }
    }
}
