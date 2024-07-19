# Taller 1


## Puntos 1 Mateo

### Punto 11 (Enfocado en Funciones)

'''
internal class Punto11
{


    static int Resultado = 0;
    static void Main(string[] args)
    {

        

        int InputA = 0;

        int InputB = 0;


            bool MenuON = true;

        while (MenuON)
            {
            Console.WriteLine("/*/*/*/*/*/*/*/*/*/");
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("/*/*/*/*/*/*/*/*/*/");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Cerrar Programa");

            int Respusta = Convert.ToInt32(Console.ReadLine());

            switch (Respusta)
            {
                case 1:
                    Console.WriteLine("Ingrese el primer numero");
                    InputA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    InputB = Convert.ToInt32(Console.ReadLine());
                    Sumar(InputA, InputB);
                    Console.WriteLine("La respuesta a la suma es: " + Resultado);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el primer numero");
                    InputA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    InputB = Convert.ToInt32(Console.ReadLine());
                    Restar(InputA, InputB);
                    Console.WriteLine("La respuesta a la resta es: " + Resultado);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el primer numero");
                    InputA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    InputB = Convert.ToInt32(Console.ReadLine());
                    Multiplicar(InputA, InputB);
                    Console.WriteLine("La respuesta a la multiplicacion es: " + Resultado);
                    break;
                case 4:
                    Console.WriteLine("Ingrese el primer numero");
                    InputA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    InputB = Convert.ToInt32(Console.ReadLine());
                    Dividir(InputA, InputB);
                    Console.WriteLine("La respuesta a la division es: " + Resultado);
                    break;
                case 5:
                    MenuON = false;
                    break;
            }
        }

    }

    static void Sumar(int intA, int intB)
    {
        Resultado = intA + intB;

    }

    static void Restar(int intA, int intB)
    {
        Resultado = intA - intB;

    }

    static void Multiplicar(int intA , int intB)
    {
        Resultado = intA * intB;

    
    }

    static void Dividir(int intA , int intB)
    {
        Resultado = intA / intB;
    }

}
'''

### Punto 6 (Enfocado en condicionales y ciclos)

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

## Punto 2 Ejercicio para entender funciones

Se ubican dos estudiantes, uno en el tablero y el otro al centro del salon. En el momento en el que el estudiante escribe jump en el tablero, el estudiante en el centro del salon realizara un salto.
Si el estudiante escribe jump,2 el estudiante en el centro de la sala saltara dos veces y asi con la cantidad de veces que escriba el comando jump,n numero de saltos. Esto nos muestra como funcionan
las funciones puesto que nos muestran como al enviar una funcion con unos parametros podemos hacer diferentes acciones.


## Punto 3 Command Challenge

![image](https://github.com/user-attachments/assets/d1327d04-1be4-412f-883d-636de150d5d6)

## Punto 4 Firmas de Funciones

1.

## Punto 5 Codigo Exquisito 

Ya participe (Mateo Jimenez)

Ya participe (Jeronimo Mejia)

Participe a Medias (Esteban Cardoso)

## Punto 6 Presentacion Final

En proceso...

