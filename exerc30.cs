using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        Console.WriteLine("Números pares entre 31 e 85:");

        for (int i = 31; i <= 85; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
                soma += i;
            }
        }

        Console.WriteLine($"\n\nSoma dos pares: {soma}");
        Console.ReadKey();
    }
}