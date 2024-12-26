// Los métodos son bloques de código que realizan una tarea específica y pueden ser llamados desde otras partes del programa.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Métodos (Funciones)
            void Saludar(string nombre)
            {
                Console.WriteLine($"Hola, {nombre}!");
            }
            Saludar("Juan");

        }
    }
}

