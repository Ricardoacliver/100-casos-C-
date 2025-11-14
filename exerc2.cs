using System;
class program
{
    static void Main()
    {
        Console.Write("Digite o 1⁰ número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o 2⁰ número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o 3⁰ número: ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        double media = (n1 + n2 + n3) / 3;

        Console.WriteLine($"A média é: {media:F2}");
        Console.ReadKey();
    }
}