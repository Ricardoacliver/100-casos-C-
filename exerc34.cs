using System;


class Exerc34
{
    static void Main(string[] args)
    {
        Console.Write("Valor:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 13; i++)
        {
            Console.WriteLine(n * i);

        }

        Console.ReadKey();
    }

}

