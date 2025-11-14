using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"({i}, ");
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine(")");
        }

        Console.ReadKey();
    }
}