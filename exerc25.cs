using System;

class Program
{
    static void Main()
    {
        int positivos = 0, negativos = 0, total = 0;
        double soma = 0;

        Console.WriteLine("Digite valores (0 para parar):");

        while (true)
        {
            double valor = double.Parse(Console.ReadLine());
            if (valor == 0) break;

            soma += valor;
            total++;

            if (valor > 0) positivos++;
            else negativos++;
        }

        if (total > 0)
        {
            double media = soma / total;
            double percPos = (positivos * 100.0) / total;
            double percNeg = (negativos * 100.0) / total;

            Console.WriteLine($"\nMédia: {media:F2}");
            Console.WriteLine($"Positivos: {positivos} ({percPos:F1}%)");
            Console.WriteLine($"Negativos: {negativos} ({percNeg:F1}%)");
        }
        else
        {
            Console.WriteLine("Nenhum valor inserido.");
        }

        Console.ReadKey();
    }
}