namespace contadorCSharp
{
    using System;

    public static class TesteConsertado
    {
        public static void MetodoEstatico()
        {
            Console.WriteLine("Exercício 5: Método estático executado com sucesso!");
        }
    }

    public class Contador
    {
        public static int TotalCriados { get; private set; } = 0;

        public Contador()
        {
            TotalCriados++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Contador c1 = new Contador();
            Contador c2 = new Contador();
            Contador c3 = new Contador();
            Console.WriteLine($"Exercício 4: Total de contadores criados = {Contador.TotalCriados}");

            Console.WriteLine("--------------------------------------------------");

            TesteConsertado.MetodoEstatico();
        }
    }
}


