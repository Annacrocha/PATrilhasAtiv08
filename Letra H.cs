using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Insira números inteiros separados por espaço: ");
        string entrada = Console.ReadLine();
        
        var numeros = entrada.Split(' ')
            .Where(x => int.TryParse(x, out _))
            .Select(int.Parse)
            .ToArray();

        if (numeros.Length > 0)
        {
            double media = CalcularMedia(numeros);
            Console.WriteLine($"A média dos números é: {media}");
        }
        else
        {
            Console.WriteLine("Nenhum número válido foi inserido.");
        }
    }
    
    static double CalcularMedia(int[] numeros)
    {
        return numeros.Average();
    }
}
