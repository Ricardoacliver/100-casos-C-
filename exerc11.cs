using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> numeros = new List<double>();
        double valor;

        Console.WriteLine("Digite valores positivos (um negativo para parar):");

        while (true)
        {
            valor = Convert.ToDouble(Console.ReadLine());

            if (valor < 0) break; // encerra se negativo
            numeros.Add(valor);
        }

        if (numeros.Count > 0)
        {
            double media = 0;
            foreach (double n in numeros)
                media += n;

            media /= numeros.Count;

            Console.WriteLine($"\nMédia dos valores inseridos: {media:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum valor positivo foi inserido.");
        }

        Console.ReadKey();
    }
}