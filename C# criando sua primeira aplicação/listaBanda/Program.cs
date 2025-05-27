using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<string> listaBandas = new List<string>();
        bool sair = false;

        Console.WriteLine("Para sair informe um valor vazio.\n");
        do
        {
            Console.Write("Insira sua banda predileta: ");
            string banda = Console.ReadLine()!;

            if (banda == "")
            {
                sair = true;
            }
            else
            {
                listaBandas.Add(banda);
            }
        } while (sair != true);

        Console.WriteLine("\n------------------");
        Console.WriteLine("Bandas Registradas");
        Console.WriteLine("------------------");
        for (int i = 0; i < listaBandas.Count; i++)
        {
            Console.WriteLine($"Banda {i + 1}: {listaBandas[i]}");
        }
        Console.ReadKey();
    }
}
