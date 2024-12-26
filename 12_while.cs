// Los bucles while son utilizados para repetir un bloque de código mientras se cumpla una condición.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Ciclo while
            int contador = 0;
            while (contador < 5)
            {
                Console.WriteLine($"Contador: {contador}");
                contador++;
            }

        }
    }
}