// La palabra clave return se utiliza para devolver un valor desde un método.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Palabra clave return
            int Sumar(int a, int b)
            {
                return a + b;
            }
            int resultado = Sumar(3, 4);
            Console.WriteLine($"La suma es: {resultado}");
        }
    }
}

