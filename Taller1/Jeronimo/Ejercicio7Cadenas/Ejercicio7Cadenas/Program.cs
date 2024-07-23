using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena de números enteros positivos separados por espacios:");
        string entrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("La cadena no puede estar vacía.");
            return;
        }

        string[] partes = entrada.Split(' ');

        int[] numeros = new int[partes.Length];

        for (int i = 0; i < partes.Length; i++)
        {
            if (int.TryParse(partes[i], out int num) && num > 0)
            {
                numeros[i] = num;
            }
            else
            {
                Console.WriteLine($"La parte '{partes[i]}' no es un número entero positivo válido.");
                return;
            }
        }
        Console.WriteLine("Array de números enteros positivos:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}

