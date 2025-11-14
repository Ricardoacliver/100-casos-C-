using System;

class Program
{
    static void Main()
    {
        double[] Q = new double[20];
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o {i + 1}º número positivo: ");
            Q[i] = double.Parse(Console.ReadLine());
            if (Q[i] < 0)
            {
                Console.WriteLine("Número inválido! Deve ser positivo.");
                i--;
            }
        }

        double maior = Q[0];
        int posicao = 0;

        for (int i = 1; i < Q.Length; i++)
        {
            if (Q[i] > maior)
            {
                maior = Q[i];
                posicao = i;
            }
        }

        Console.WriteLine($"\nMaior número: {maior}, na posição {posicao + 1}");
        Console.ReadKey();
    }
}