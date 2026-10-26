namespace MathUtil
{
    using System;

    public static class MatematicaUtil
    {
        public static double Quadrado(double n) => n * n;
        public static double Cubo(double n) => n * n * n;
        public static long Fatorial(int n)
        {
            if (n <= 1) return 1;
            long resultado = 1;
            for (int i = 2; i <= n; i++) resultado *= i;
            return resultado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double num = 4;
            Console.WriteLine($"Quadrado de {num}: {MatematicaUtil.Quadrado(num)}");
            Console.WriteLine($"Cubo de {num}: {MatematicaUtil.Cubo(num)}");
            Console.WriteLine($"Fatorial de 5: {MatematicaUtil.Fatorial(5)}");
        }
    }
}
