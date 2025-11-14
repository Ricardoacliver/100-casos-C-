using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o tamanho da base (5 a 15): ");
        int baseTamanho = int.Parse(Console.ReadLine());

        if (baseTamanho < 5 || baseTamanho > 15)
        {
            Console.WriteLine("Valor fora do intervalo!");
            return;
        }

        // Imprime triângulo
        for (int i = 1; i <= baseTamanho; i += 2)
        {
            string linha = new string('#', i);
            Console.WriteLine(linha.PadLeft(baseTamanho + i / 2)); // centraliza
        }

        Console.ReadKey();
    }
}