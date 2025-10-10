using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Escolha a operação (+, -, *, /): ");
        char operacao = char.Parse(Console.ReadLine());

        double resultado = 0;
        bool operacaoValida = true;

        switch (operacao)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("Erro: divisão por zero!");
                    operacaoValida = false;
                }
                break;
            default:
                Console.WriteLine("Operação inválida!");
                operacaoValida = false;
                break;
        }

        if (operacaoValida)
            Console.WriteLine($"\nResultado: {resultado}");
    }
}


