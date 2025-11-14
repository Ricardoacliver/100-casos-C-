using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o tempo em segundos: ");
        int totalSegundos = Convert.ToInt32(Console.ReadLine());

        int horas = totalSegundos / 3600;            // 1h = 3600s
        int minutos = (totalSegundos % 3600) / 60;   // resto das horas convertido em minutos
        int segundos = totalSegundos % 60;           // resto final

        Console.WriteLine($"\nTempo equivalente: {horas}h {minutos}m {segundos}s");
        Console.ReadKey();
    }
}