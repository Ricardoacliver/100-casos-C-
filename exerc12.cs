uusing System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        // a) lê 10 números
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // b) lê número de comparação
        Console.Write("\nDigite um número para comparar: ");
        int comparador = int.Parse(Console.ReadLine());

        // conta quantos são menores
        int menores = 0;
        foreach (int n in numeros)
        {
            if (n < comparador) menores++;
        }

        Console.WriteLine($"\nQuantidade de números menores que {comparador}: {menores}");
        Console.ReadKey();
    }
}