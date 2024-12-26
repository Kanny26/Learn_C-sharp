// La palabra clave params se utiliza para permitir que un método acepte un número variable de parámetros.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Palabra clave params
            int SumarTodos(params int[] numeros)
            {
                int suma = 0;
                foreach (int numero in numeros)
                    suma += numero;
                return suma;
            }
            Console.WriteLine($"Suma total: {SumarTodos(1, 2, 3, 4, 5)}");

        }
    }
}
