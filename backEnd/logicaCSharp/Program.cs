namespace logicaCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Maria", "João", "Ana" };

            Console.WriteLine(nomes[0]);
            nomes[0] = "joana";
            
            List<int> numeros = new List<int>();

            numeros.Add(123);
            numeros.Add(999);
            numeros.Add(0);
            numeros.Add(643);
            numeros.Add(67);
            numeros.Add(42);
            numeros.Add(69);
            numeros.Add(100);
            numeros.Add(50);
            numeros.Add(19313);

            numeros.Sort();
            foreach (int numero in numeros) {
                Console.WriteLine(numero);
            }
        }
    }
}
