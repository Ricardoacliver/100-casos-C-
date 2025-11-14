using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o 1⁰ número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o 2⁰ número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        double soma = (n1 + n2);
        Console.WriteLine($"A soma é: {soma:F2}");
        Console.ReadKey();




    }
}
