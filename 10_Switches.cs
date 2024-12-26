// Las sentencias switch son utilizadas para tomar decisiones en un programa.
using System;

namespace input
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Sentencia switch
            string dia = "Lunes";
            switch (dia)
            {
                case "Lunes":
                    Console.WriteLine("Es inicio de semana.");
                    break;
                case "Viernes":
                    Console.WriteLine("Es casi fin de semana.");
                    break;
                default:
                    Console.WriteLine("Es un día cualquiera.");
                    break;
            }

        }
    }
}