using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a operação (+, -, *, /): ");
        char op = char.Parse(Console.ReadLine());

        double resultado = 0;
        bool valido = true;

        switch (op)
        {
            case '+': resultado = n1 + n2; break;
            case '-': resultado = n1 - n2; break;
            case '*': resultado = n1 * n2; break;
            case '/':
                if (n2 != 0)
                    resultado = n1 / n2;
                else
                {
                    Console.WriteLine("Erro: divisão por zero!");
                    valido = false;
                }
                break;
            default:
                Console.WriteLine("Operação inválida!");
                valido = false;
                break;
        }

        if (valido)
            Console.WriteLine($"Resultado: {resultado}");

        Console.ReadKey();
    }
}