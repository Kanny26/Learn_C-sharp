// La gestión de excepciones se utiliza para manejar errores que pueden ocurrir durante la ejecución del programa.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Manejo de excepciones
            try
            {
                int divisor = 0;
                int resultado = 10 / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Operación completada.");
            }

        }
    }
}

