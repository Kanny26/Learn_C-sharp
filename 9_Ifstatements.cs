// Las sentencias if son utilizadas para tomar decisiones en un programa.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Sentencia if
            int edad = 18;
            if (edad >= 18)
                Console.WriteLine("Eres mayor de edad.");
            else
                Console.WriteLine("Eres menor de edad.");
        }
    }
}