// El bucle foreach se utiliza para iterar sobre los elementos de una colección, como un array o una lista.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Bucle foreach
            string[] frutas = { "Manzana", "Banana", "Cereza" };
            Console.WriteLine("Frutas disponibles:");
            foreach (string fruta in frutas)
                Console.WriteLine(fruta);
        }
    }
}

