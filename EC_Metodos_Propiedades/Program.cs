//Ejercicio en clase
using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("** Menú de ejercicios en C# **");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("0. Salir");
            Console.WriteLine();
            Console.Write("Ingrese una opción: ");

            // Validar la entrada del usuario
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Ingrese un número del 0 al 3: ");
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 0:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción del menú.");
                    break;
            }

            // Pausar la pantalla
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine("¡Hasta luego!");
    }

    static void Ejercicio1()
    {
        // Implementar el código del ejercicio 1
    }

    static void Ejercicio2()
    {
        // Implementar el código del ejercicio 2
    }

    static void Ejercicio3()
    {
        // Implementar el código del ejercicio 3
    }
}

