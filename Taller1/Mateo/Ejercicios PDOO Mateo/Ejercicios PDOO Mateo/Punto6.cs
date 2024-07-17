using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_PDOO_Mateo
{
    internal class Punto6
    {
        static void Main(string[] args)
        {
            //Enunciado: Usando un ciclo do-while calcule la suma de los primeros n números impares.
            // Ejercicio de Condiciones y/o Ciclos

            int n = 0;


            Console.WriteLine("Hola usuario, bienvenido a la consola porfavor ingrese un numero");
            Console.WriteLine("El numero que ingrese sera el valor de n para el cual se sumaran todos los impartes");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero que has ingresado ha sido: " + n);
           

            int suma = 0;
            int numeroActual = 1;

            do
            {
                if (numeroActual / 2 != 0)
                {
                    suma += numeroActual;
                }
                numeroActual++;
            }
            while (numeroActual <= n);
            Console.WriteLine("La suma de los numeros impares es: " + suma);
            Console.WriteLine("Preciona ENTER para terminar el programa");
            Console.ReadLine();

        }
    }
}
