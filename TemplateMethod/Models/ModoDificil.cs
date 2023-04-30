namespace TemplateMethod.Models
{
    public class ModoDificil : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("Adicionar obstáculo na pista");
        }
        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversário devem correr mais");
        }
    }
     
}
