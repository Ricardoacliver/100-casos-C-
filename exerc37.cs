using System;

public class Exerc35
{
    static void Main(string[] args)
    {

        int menor = int.MaxValue;
        double media = 0;
        int i = 0;
        while (i < 2)
        {
            Console.Write($"Digite o {i + 1} número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            i++;
            media += n / 2;

            if (n < menor)
            {
                menor = n;
            }

        }
        Console.WriteLine($"Media:{media}");
        Console.WriteLine($"Menor valor:{menor}");

    }
}



