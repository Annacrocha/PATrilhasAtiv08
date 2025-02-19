using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Insira uma palavra: ");
        string entrada = Console.ReadLine();
        
        int numeroDeCaracteres = ContarCaracteres(entrada);
        
        Console.WriteLine($"A palavra inserida contém {numeroDeCaracteres} caracteres.");
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static int ContarCaracteres(string texto)
    {
        return texto.Length;
    }
}
