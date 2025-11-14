using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string texto = Console.ReadLine();

        int numCaracteres = texto.Length;
        string maiusculas = texto.ToUpper();

        int vogais = texto.Count(c => "aeiouAEIOU".Contains(c));
        int digitos = texto.Count(char.IsDigit);

        bool comecaUNI = texto.StartsWith("UNI", StringComparison.OrdinalIgnoreCase);
        bool terminaRIO = texto.EndsWith("RIO", StringComparison.OrdinalIgnoreCase);

        string semEspacos = new string(texto.Where(char.IsLetterOrDigit).ToArray());
        bool palindromo = semEspacos.Equals(new string(semEspacos.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase);

        Console.WriteLine($"\nNúmero de caracteres: {numCaracteres}");
        Console.WriteLine($"Texto em maiúsculas: {maiusculas}");
        Console.WriteLine($"Número de vogais: {vogais}");
        Console.WriteLine($"Começa com 'UNI'? {comecaUNI}");
        Console.WriteLine($"Termina com 'RIO'? {terminaRIO}");
        Console.WriteLine($"Número de dígitos: {digitos}");
        Console.WriteLine($"É palíndromo? {(palindromo ? "Sim" : "Não")}");

        Console.ReadKey();
    }
}