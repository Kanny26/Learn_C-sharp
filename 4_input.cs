// La entrada del usuario es el proceso de leer datos desde la pantalla o desde un archivo.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Entrada del usuario
            Console.WriteLine("Escribe tu nombre:");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine($"Hola, {nombreUsuario}!");
        }
    }
}