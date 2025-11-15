using System;

public class Exerc40
{
    static void Main(string[] args)
    {

        int res = 0;


        Console.Write("Valor 1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Valor 2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int posn1 = Math.Abs(n1);
        int posn2 = Math.Abs(n2);

        for (int i = 0; i < posn2; i++)
        {
            res += posn1;
        }

        if ((n2 < 0 && n2 > 0) || (n1 < 0 && n2 > 0))
        {
            res = -res;
        }

        Console.WriteLine($"Multiplicação: {res}");

    }

}
