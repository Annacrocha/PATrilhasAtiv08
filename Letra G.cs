using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Insira uma string: ");
        string entrada = Console.ReadLine();

        string resultado = ObterCaracteresImpares(entrada);
        Console.WriteLine($"String com caracteres em posições ímpares: {resultado}");
    }

    // Método para obter caracteres em posições ímpares
    static string ObterCaracteresImpares(string entrada)
    {
        if (string.IsNullOrEmpty(entrada))
            return string.Empty;

        string resultado = string.Empty;
        
        for (int i = 0; i < entrada.Length; i++)
        {
            // Lembre-se: posições ímpares em 1-based (human-readable) são índices pares no C#
            if (i % 2 == 0) // Índice 0, 2, 4... representam posições ímpares
            {
                resultado += entrada[i];
            }
        }

        return resultado;
    }
}
