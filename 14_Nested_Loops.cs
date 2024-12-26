// Los bucles anidados son bucles dentro de otros bucles. Se utilizan para iterar sobre estructuras de datos multidimensionales, como matrices.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Ciclos anidados
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"i: {i}, j: {j}");
                }
            }

        }
    }
}