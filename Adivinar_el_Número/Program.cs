static void Main(string[] args)
{
    Console.WriteLine("Piensa en un número cualquiera.");

    Console.WriteLine("Multiplica el número por 2 y presiona Enter.");
    int numero = int.Parse(Console.ReadLine());

    numero += 8;

    Console.WriteLine("Multiplica el nuevo resultado por 5 y presiona Enter.");
    numero *= 5;

    numero /= 10;

    numero -= 4;

    Console.WriteLine("¡Tu número es {0}!", numero);
}

