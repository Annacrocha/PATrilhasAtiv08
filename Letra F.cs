using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Insira um número inteiro: ");
        int numeroInteiro = int.Parse(Console.ReadLine());
        
        string resultado = VerificarParidade(numeroInteiro);
        
        Console.WriteLine($"O número é {resultado}");
    }

    static string VerificarParidade(int numeroInteiro)
    {
        if (numeroInteiro % 2 == 0)
        {
            return "Par";
        }
        else
        {
            return "Ímpar";
        }
    }
}
