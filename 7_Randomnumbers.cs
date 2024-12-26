//  Los números aleatorios son números que se generan de manera aleatoria.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Números aleatorios
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(1, 101); // Entre 1 y 100
            Console.WriteLine($"Número aleatorio generado: {numeroAleatorio}");
        }
    }
}