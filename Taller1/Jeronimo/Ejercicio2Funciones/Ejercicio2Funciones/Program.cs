using System;
using System.Linq;

class Programa
{
    static void Main()
    {
        float[] numeros = { -2.5f, 3.7f, 0.0f, 4.1f, 5.6f, -1.3f, 2.4f };

        float promedio = CalcularPromedioPositivos(numeros);

        Console.WriteLine($"El promedio de los números positivos es: {promedio}");
    }

    static float CalcularPromedioPositivos(float[] numeros)
    {
        var numerosPositivos = numeros.Where(n => n > 0).ToArray();

        if (numerosPositivos.Length == 0)
        {
            Console.WriteLine("No hay números positivos en el array.");
            return 0;
        }

        float promedio = numerosPositivos.Average();

        return promedio;
    }
}

