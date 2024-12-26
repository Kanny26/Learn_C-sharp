// La clase Math es una clase estática que proporciona métodos para realizar operaciones matemáticas.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Clase Math
            double numero = -7.5;
            Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}, Raíz cuadrada: {Math.Sqrt(25)}, Potencia: {Math.Pow(2, 3)}");


        }
    }
}