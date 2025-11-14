using System;

class Program
{
    static void Main()
    {
        int soma = 0;

        for (int i = 1; i <= 500; i++)
        {
            if (i % 2 != 0 && i % 3 == 0)
                soma += i;
        }

        Console.WriteLine($"A soma dos ímpares múltiplos de 3 entre 1 e 500 é {soma}");
        Console.ReadKey();
    }
}