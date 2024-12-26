// La sobrecarga de métodos permite definir múltiples métodos con el mismo nombre pero diferentes parámetros.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Sobrecarga de métodos
            void Mostrar(string texto)
            {
                Console.WriteLine($"Texto: {texto}");
            }
            void Mostrar1(int numero)
            {
                Console.WriteLine($"Número: {numero}");
            }
            Mostrar("Hola");
            Mostrar1(123);
        }
    }
}
