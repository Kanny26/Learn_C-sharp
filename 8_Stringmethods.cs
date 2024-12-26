// Los métodos de cadena son métodos que se utilizan para manipular cadenas de texto.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Métodos de cadenas
            string texto = "Hola Mundo";
            Console.WriteLine($"En mayúsculas: {texto.ToUpper()}, En minúsculas: {texto.ToLower()}, Longitud: {texto.Length}");
        }
    }
}