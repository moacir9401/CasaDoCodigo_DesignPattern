namespace TemplateMethod.Models
{
    public class ModoFacil : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("Combustível para a corrida toda");
        }
        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversários devem correr menos");
        }
    }


}
