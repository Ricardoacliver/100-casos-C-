using System;



public class Exerc35
{
    static void Main(string[] args)
    {

        Console.Write("Digite a quantidade de funcionários:");
        int qtd = Convert.ToInt32(Console.ReadLine());

        int menor = int.MaxValue;

        int mediasal = 0;
        int i = 0;
        while (i < qtd)
        {
            Console.Write($"Nome o {i + 1} funcionário:");
            string nome = Console.ReadLine();

            Console.Write($"Salário do {i + 1} funcionário:");
            int sal = Convert.ToInt32(Console.ReadLine());


            i++;
            mediasal += sal / qtd;

            if (sal < menor)
            {
                menor = sal;
            }

        }
        Console.WriteLine($"Media dos salários:{mediasal}");
        Console.WriteLine($"Salários mais baixo:{menor}");

    }
}
