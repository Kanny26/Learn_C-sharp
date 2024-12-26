// Los operadores lógicos son utilizados para combinar condiciones en un programa.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Operadores lógicos
            bool esAdulto = true, tieneIdentificación = false;
            if (esAdulto && tieneIdentificación)
                Console.WriteLine("Puedes ingresar.");
            else
                Console.WriteLine("Acceso denegado.");

        }
    }
}