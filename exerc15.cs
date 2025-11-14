using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira palavra: ");
        string p1 = Console.ReadLine();

        Console.Write("Digite a segunda palavra: ");
        string p2 = Console.ReadLine();

        if (p1.Equals(p2, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("\nAs palavras são iguais.");
        else
        {
            Console.WriteLine("\nAs palavras são diferentes.");
            if (p1.Length > p2.Length)
                Console.WriteLine($"A primeira palavra ({p1}) é maior.");
            else if (p2.Length > p1.Length)
                Console.WriteLine($"A segunda palavra ({p2}) é maior.");
            else
                Console.WriteLine("As duas têm o mesmo tamanho.");

            if (p1.ToLower().Contains(p2.ToLower()))
                Console.WriteLine($"{p2} é substring de {p1}.");
        }

        Console.ReadKey();
    }
}