using System;

public class Exerc38
{
    static void Main(string[] args)
    {
        while (true)
        {

            int t = 0;
            Console.Write("Digite a massa:(Ou digite '100' para encerrar)\n");
            double massa = Convert.ToDouble(Console.ReadLine());

            if (massa == 100)
            {
                break;
            }

            if (massa <= 0.05)
            {

                massa = massa / 2;
                t += 50;
                Console.WriteLine($"O tempo: {t}");

            }
            else if (massa > 0.05)
            {
                Console.WriteLine($"Valor da massa dve ser mais ainda maior...");

            }


        }
    }



}

