using System;

class Program
{
    static void Main()
    {
        Console.Write("Montar a tabuada de: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Começar por: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Terminar em: ");
        int fim = int.Parse(Console.ReadLine());

        if (fim < inicio)
        {
            Console.WriteLine("Erro: o valor final deve ser maior que o inicial.");
        }
        else
        {
            Console.WriteLine($"\nTabuada de {num} de {inicio} até {fim}:");
            for (int i = inicio; i <= fim; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        Console.ReadKey();
    }
}