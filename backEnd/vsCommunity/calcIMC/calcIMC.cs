using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Calculadora de IMC ---");

        Console.Write("Digite o seu peso (kg, ex: 70): ");
        string? entradaPeso = Console.ReadLine();
        double peso = double.TryParse(entradaPeso, out double p) ? p : 0;

        Console.Write("Digite a sua altura (m, ex: 1.75): ");
        string? entradaAltura = Console.ReadLine();
        double altura = double.TryParse(entradaAltura, out double a) ? a : 0;

        if (peso <= 0 || altura <= 0)
        {
            Console.WriteLine("Valores inválidos inseridos. O programa será encerrado.");
            return;
        }

        double imc = peso / (altura * altura);

        Console.WriteLine($"\nSeu IMC é: {imc:F2}");

        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Classificação: Peso normal");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade");
        }
    }
}
