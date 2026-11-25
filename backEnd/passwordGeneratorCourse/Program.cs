using System.Security.Cryptography;

namespace geradorDeSenhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           static string GeneratePassword(int lenght, bool useUppercase, bool useSpecialCharacters)
            {
                var characters = "abcdefghijklmnopqrstuvwxyz0123456789";
                if (useUppercase) characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                if (useSpecialCharacters) characters += "!#$%&'()*+,-./:;<=>?@[]^_{|}~`";
                return string.Concat(Enumerable.Range(0, lenght).Select(_ => characters[RandomNumberGenerator.GetInt32(characters.Length)]));
            }
            Console.WriteLine(GeneratePassword(13, true, true));
        }
    }
}
