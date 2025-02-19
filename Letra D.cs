using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Insira números inteiros separados por espaço: ");
        List<int> numeros = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int maiorNumero = EncontrarMaiorNumero(numeros);

        Console.WriteLine($"O maior número é: {maiorNumero}");
    }

    static int EncontrarMaiorNumero(List<int> numeros)
    {
        return numeros.Max();
    }
}
