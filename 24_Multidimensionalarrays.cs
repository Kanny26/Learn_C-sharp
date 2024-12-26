// los arrays multidimensionales son matrices que pueden almacenar valores de un tipo específico.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] matriz = new int[3, 4];

            // Inicializar los elementos del arreglo
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = i * j;
                }
            }

            // Acceder a los elementos del arreglo
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Elemento [{i}, {j}]: {matriz[i, j]}");
                }
            }
        }
    }
}
