# Taller 1


## Puntos 1 Mateo

### Ejercicio 11 (Enfocado en Funciones)

~~~
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
~~~

### Ejercicio 6 (Enfocado en condicionales y ciclos)

~~~
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
~~~

### Ejercicio 1 Esteban Matrices

~~~
namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz de tamaño NxM
            //Llenarla de valores aleatorios (positivos y negativos)
            //Recorrerla 1 por 1, verificando si cada elemento es negativo
            //Negativo? Cambiar signo
            //Proceder


            
            int n = 0;
            int m = 0;

            
            Console.WriteLine("Ingrese el numero de filas");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de columnas");
            m = Convert.ToInt32(Console.ReadLine());

            
            int[,] Matrix = new int[n, m];
            Random randNum = new Random();

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Matrix[i, j] = randNum.Next(-1000, 1000);
                }

            }

            
            Console.WriteLine("La matriz creada es: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Matrix[i, j] < 0)
                    {
                        Matrix[i, j] = -Matrix[i, j]; 
                    }
                }
            }

            Console.WriteLine("Matriz Modificada: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
~~~

### Ejercicio 2 Funciones Jeronimo

~~~
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
~~~

### Ejercicio 7 Cadenas Jeronimo

~~~
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
                Console.WriteLine($"La parte '{partes[i]}' no es un número entero positivo.");
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
~~~

### Teoria 1 Ejercicio 6 Esteban

~~~
        int edad = 25;               // Entero
        double altura = 1.75;        // Punto flotante
        char inicial = 'A';          // Caracter
        string nombre = "Juan";      // String
        bool esEstudiante = true;    // Booleano

        
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Es estudiante: " + esEstudiante);
~~~

### Teoria 2 Ejercicio 13 Esteban

Dependiendo del tipo de array, su valor inicial seria distinto. Para uno de los casos mas comunes como un array o vector de numeros enteros, el valor inicial de los elementos dentro de el seria el 0, y se recorreria su indice desde el mismo valor, es decir, 0-1-2-3 etc.

## Punto 2 Ejercicio para entender funciones

Se ubican dos estudiantes, uno en el tablero y el otro al centro del salon. En el momento en el que el estudiante escribe jump en el tablero, el estudiante en el centro del salon realizara un salto.
Si el estudiante escribe jump,2 el estudiante en el centro de la sala saltara dos veces y asi con la cantidad de veces que escriba el comando jump,n numero de saltos. Esto nos muestra como funcionan
las funciones puesto que nos muestran como al enviar una funcion con unos parametros podemos hacer diferentes acciones.


## Punto 3 Command Challenge

![image](https://github.com/user-attachments/assets/d1327d04-1be4-412f-883d-636de150d5d6)

## Punto 4 Firmas de Funciones

1. public int Add(int a, int b) Invocacion: int result = Add(5, 3);
2. public string Saludo(string name) Invocacion: string saludos = Saludo("Maria");
3. public bool IsEven(int number) Invocacion: bool isEven = IsEven(6);
4. public string Concatenate(string str1, string str2) Invocacion: string result = ConcatenateStrings("Hello", "World");
5. public void SaludarMundo() Invocacion: SaludarMundo();
6. public int SumarElementos(int[] numeros) Invocacion: int suma = SumarElementos(new int[] {1, 2, 3, 4, 5});
7. public void Saludar(); Invoke: Saludar();
8. public void Sumar(int a, int b); Invoke: Sumar(10,2);
9. public int CalcularCuadrado(int Numero); Invoke: int resultado =CalcularCuadrado(4);
10. public void ImprimirNombreCompleto(string Nombre, string Apellido = ""); Invoke : ImprimrNombreCompleto("Juan"); o ImprimrNombreCompleto("Juan", "Perez");
11. public void Dividir(int dividendo, int divisor, out int cociente, out int residuo); Invoke : Dividir(10,2, out int resultado, out int resto);
12. public void DuplicarNumero(ref int numero); Invoke: int num = ; DupliacrNumero (ref num);
13. public int SumarNumeros(params int[] numeros); Invoke: int resultado = SumarNumero(1,2,3,4,); o SumarNumero(1,2);
14. public void MostrarDatos(string nombre, int edad); Invoke: MostrarDatos(edad : 30, nombre : "Ana");
15. public void AplicarOperacion(int a, int b, Func<int, int, int> operacion); Invoke : AplicarOperacion(5, 3, (x, y) => x + y);
16. public T ObtenerMaximo<T>(T a, T b) where T : IComparable<T> Invoke : int maximo = ObtenerMaximo (3,5); O string mayor = ObtenerMaximo("Hola", "Mundo");

## Punto 5 Codigo Exquisito 

Ya participe (Mateo Jimenez)

Ya participe (Jeronimo Mejia)

Participe a Medias (Esteban Cardoso)

## Punto 6 Presentacion Final

En proceso...

