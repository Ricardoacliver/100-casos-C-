using System;

class Program
{
    static void Main()
    {
        int cod;
        double mediaM = 0, mediaF = 0;
        int countM = 0, countF = 0;

        while (true)
        {
            Console.Write("\nCódigo do professor (99999 para sair): ");
            cod = int.Parse(Console.ReadLine());
            if (cod == 99999) break;

            Console.Write("Sexo (M/F): ");
            char sexo = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Horas/aula mensais: ");
            double horas = double.Parse(Console.ReadLine());

            double bruto = horas * 30;
            double desconto = (sexo == 'M') ? 0.10 : 0.05;
            double liquido = bruto - (bruto * desconto);

            Console.WriteLine($"Código: {cod} | Bruto: {bruto:C2} | Líquido: {liquido:C2}");

            if (sexo == 'M') { mediaM += liquido; countM++; }
            else if (sexo == 'F') { mediaF += liquido; countF++; }
        }

        if (countM > 0) Console.WriteLine($"\nMédia dos salários (M): {mediaM / countM:C2}");
        if (countF > 0) Console.WriteLine($"Média dos salários (F): {mediaF / countF:C2}");

        Console.ReadKey();
    }
}