using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número N: ");
        int N = int.Parse(Console.ReadLine());

        int divisões = 0;

        Console.WriteLine($"\nNúmeros primos entre 1 e {N}:");
        for (int i = 2; i <= N; i++)
        {
            bool primo = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                divisões++;
                if (i % j == 0)
                {
                    primo = false;
                    break;
                }
            }
            if (primo)
                Console.Write($"{i} ");
        }

        Console.WriteLine($"\n\nTotal de divisões executadas: {divisões}");
        Console.ReadKey();
    }
}