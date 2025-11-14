using System;

class Program
{
    static void Main()
    {
        double popA = 80000, taxaA = 0.03;
        double popB = 200000, taxaB = 0.015;
        int anos = 0;

        while (popA < popB)
        {
            popA += popA * taxaA;
            popB += popB * taxaB;
            anos++;
        }

        Console.WriteLine($"Serão necessários {anos} anos para A ultrapassar B.");
        Console.ReadKey();
    }
}