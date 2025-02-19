using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Insira palavras separadas por espaço: ");
        List<string> palavras = new List<string>(Console.ReadLine().Split(' '));
        
        string resultado = ConcatenarStrings(palavras);
        
        Console.WriteLine($"Strings concatenadas: {resultado}");
    }

    static string ConcatenarStrings(List<string> strings)
    {
        return string.Join("", strings); 
    }
}
