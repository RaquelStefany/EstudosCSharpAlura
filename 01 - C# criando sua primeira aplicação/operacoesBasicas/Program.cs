using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Insira um valor de ponto flutuante: ");
        double valor1 = double.Parse(Console.ReadLine()!);
        Console.Write("Insira outro valor de ponto flutuante: ");
        double valor2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("\n----------------------------");
        Console.WriteLine("Operações Básicas do Valores");
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Soma: {valor1} + {valor2} = {valor1 + valor2}");
        Console.WriteLine($"Subtração: {valor1} - {valor2} = {valor1 - valor2}");
        Console.WriteLine($"Multiplicação: {valor1} * {valor2} = {valor1 * valor2}");
        Console.WriteLine($"Divisão: {valor1} / {valor2} = {valor1 / valor2}");
    }
}
