using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Múltiplos de 7 menores que 1000:");
        for (int i = 7; i < 1000; i += 7)
        {
            Console.Write($"{i} ");
        }

        Console.ReadKey();
    }
}