namespace DesingnComposite.Models
{
    public  class Composite : ComponenteFase
    {
        private List<ComponenteFase> fasesJogo = new List<ComponenteFase>();

        public Composite(string nome) : base(nome)
        {

        }

        public override void Adicionar(ComponenteFase c)
        {
            this.fasesJogo.Add(c);
        }
        public override void Remover(ComponenteFase c)
        {
            this.fasesJogo.Remove(c);
        }
        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);

            foreach (var item in this.fasesJogo)
            {
                item.Mostrar(profundidade + 2);
            }
        }

    }
}
