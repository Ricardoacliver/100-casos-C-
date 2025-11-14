using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();
        string[] partes = nome.Split(' ');

        Console.Write("\nAbreviatura: ");
        foreach (string p in partes)
        {
            if (p.Length <= 2)
                Console.Write($"{p} "); // preposição
            else
                Console.Write($"{p[0].ToString().ToUpper()}. ");
        }

        Console.ReadKey();
    }
}