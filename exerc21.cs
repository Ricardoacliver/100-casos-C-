using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];

        // Lê os 10 nomes
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º nome: ");
            nomes[i] = Console.ReadLine();
        }

        // Lê o nome a procurar
        Console.Write("\nDigite um nome para procurar: ");
        string busca = Console.ReadLine();

        // Verifica se o nome existe no array
        bool encontrado = false;
        foreach (string nome in nomes)
        {
            if (nome.Equals(busca, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = true;
                break;
            }
        }

        Console.WriteLine(encontrado ? "\nACHEI!" : "\nNÃO ACHEI!");
        Console.ReadKey();
    }
}