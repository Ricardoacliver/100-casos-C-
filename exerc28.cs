using System;

class Program
{
    static void Main()
    {
        int somaPositivos = 0, negativos = 0;

        for (int i = 1; i <= 50; i++)
        {
            Console.Write($"Digite o {i}º valor: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0) somaPositivos += num;
            else if (num < 0) negativos++;
        }

        Console.WriteLine($"\nSoma dos positivos: {somaPositivos}");
        Console.WriteLine($"Quantidade de negativos: {negativos}");
        Console.ReadKey();
    }
}