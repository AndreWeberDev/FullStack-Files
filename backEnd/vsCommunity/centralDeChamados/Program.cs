namespace centralDeChamados
{


    abstract class Ticket
    {
        public string Title { get; private set; }

        protected Ticket(string title) => Title = title;

        public abstract void Handle();
    }

    class TechnicalIncident : Ticket
    {
        public TechnicalIncident(string title) : base(title) { }

        public override void Handle()
        {
            Console.WriteLine("Resposta: Reiniciando os equipamentos de rede e acionando a equipe de infraestrutura N2.");
        }
    }

    class CommercialRequest : Ticket
    {
        public CommercialRequest(string title) : base(title) { }

        public override void Handle()
        {
            Console.WriteLine("Resposta: Preparando formulários de alteração contratual e enviando para assinatura do cliente.");
        }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, Ticket> tickets = new Dictionary<string, Ticket>();

            tickets.Add("SUP-001", new TechnicalIncident("Internet indisponível"));
            tickets.Add("COM-002", new CommercialRequest("Atualizar dados da empresa"));

            foreach (KeyValuePair<string, Ticket> entry in tickets)
            {
                Console.WriteLine($"{entry.Key} | {entry.Value.Title}");
                entry.Value.Handle();
                Console.WriteLine();
            }
        }
    }
}
