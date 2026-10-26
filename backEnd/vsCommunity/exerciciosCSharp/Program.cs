namespace exerciciosCSharp
{
    class Mensagem
    {
        private string t = "Mensagem privada exibida com sucesso!";

        public void Mostrar()
        {
            Console.WriteLine(t);
        }

        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Mensagem m = new Mensagem();
            m.Mostrar();

            int resultado = Mensagem.Somar(10, 5);
            Console.WriteLine($"Soma: {resultado}");
        }
    }
}
