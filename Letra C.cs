using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Insira o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        int resultado = retornoSoma(numero1, numero2);
        
        Console.WriteLine($"A soma dos números é: {resultado}");
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
    
    static int retornoSoma(params int[] numeros) // Mover o método para fora do Main
    {
        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }
        return soma;
    }

}
