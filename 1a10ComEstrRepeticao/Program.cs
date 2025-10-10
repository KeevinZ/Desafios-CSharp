using System;

class Program
{
    static void Main()
    {
        int soma = 0;

        for (int i = 1; i <= 10; i++)
        {
            soma += i;
        }

        Console.WriteLine($"A soma dos números de 1 a 10 é: {soma}");
    }
}
