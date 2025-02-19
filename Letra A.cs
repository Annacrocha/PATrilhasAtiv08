using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Insira um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());
        
        int resultado = CalcularQuadrado(numero);
        
        Console.WriteLine($"O quadrado de {numero} é: {resultado}");
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static int CalcularQuadrado(int numero)
    {
        return numero * numero;
    }
}
