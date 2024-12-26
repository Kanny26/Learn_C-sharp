// Un array es una colección de elementos del mismo tipo.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Arreglos (Arrays)
            int[] numeros = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Primer elemento: {numeros[0]}");
            Console.WriteLine("Todos los elementos:");
            foreach (int numero in numeros)
                Console.WriteLine(numero);
        }
    }
}

