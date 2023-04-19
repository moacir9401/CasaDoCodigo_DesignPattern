namespace DesingFlyWeight.Models
{
    public class FlyWeight
    {
        private Dictionary<string, Tartaruga> listaTartaruga = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga t = null;

            if (listaTartaruga.ContainsKey(cor))
            {
                t = listaTartaruga[cor];
            }
            else
            {
                switch (cor)
                {
                    case "Azul":
                        t = new Azul();
                        break;
                    case "Verde":
                        t = new Verde();
                        break;
                    case "Laranja":
                        t = new Laranja();
                        break;
                    case "Vermelha":
                        t = new Vermelha();
                        break;
                }

                listaTartaruga.Add(cor, t);

            }

            return t;
        }
    }
}
