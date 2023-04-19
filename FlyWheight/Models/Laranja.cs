namespace DesingFlyWeight.Models
{
    public class Laranja : Tartaruga
    {
        public Laranja()
        {
            condicao = $"Tartaruga dentro do casco, ";
            acao = "rodando no chão - ";
        }

        public override void Mostrar(string cor)
        {
            this.cor = cor;
            Console.WriteLine($"{condicao}{acao}{cor.ToUpper()}");
        }
    }
}
