//Ejercicio #1
using System;

class Program
{
    static void Main(string[] args)
    {
        int numero, mayor = int.MinValue, menor = int.MaxValue;

        Console.WriteLine("Ingrese números positivos (ingrese 0 para salir):");
        do
        {
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                if (numero > mayor)
                {
                    mayor = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }
        } while (numero != 0);

        Console.WriteLine();
        Console.WriteLine("El mayor número ingresado es: {0}", mayor);
        Console.WriteLine("El menor número ingresado es: {0}", menor);
    }
}

