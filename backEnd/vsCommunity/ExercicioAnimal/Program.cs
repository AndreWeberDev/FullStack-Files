namespace ExercicioAnimal
{
    using System;

    public class Animal
    {
        protected string Especie { get; set; } = string.Empty;
    }

    public class Cachorro : Animal
    {
        public Cachorro()
        {
            Especie = "Canis lupus familiaris"; 
            Console.WriteLine($"Espécie cadastrada: {Especie}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Cachorro meuCachorro = new Cachorro();
        }
    }
}