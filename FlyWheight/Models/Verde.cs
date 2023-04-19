namespace DesingFlyWeight.Models
{
    public class Verde : Tartaruga
    {
        public Verde()
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
