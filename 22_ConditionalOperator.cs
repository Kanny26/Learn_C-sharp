// El operador condicional se utiliza para evaluar una condición y devolver un valor en función de ella.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Operador condicional
            int edad = 20;
            string mensaje = (edad >= 18) ? "Eres mayor de edad." : "Eres menor de edad.";
            Console.WriteLine(mensaje);

        }
    }
}

