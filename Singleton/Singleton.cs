namespace AbstractFactory.Models
{
    public sealed class Singleton
    {
        public static Singleton instancia = null;

        public static Singleton GetInstalcia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Bola em jogo");
                }

                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}