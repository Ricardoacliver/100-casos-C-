using System;

public class Exerc38
{
    static void Main(string[] args)
    {


        int fat = 1;
        Console.Write("Digite um número:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            fat *= i;

        }
        Console.WriteLine($"Factorial: {fat}");

    }
}
