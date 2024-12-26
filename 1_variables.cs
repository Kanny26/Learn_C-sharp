// Una variable es un espacio de memoria que se utiliza para almacenar un valor.
using System;

namespace variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x; //declaracion de un entero
            x = 18;//inicializacion 

            int y = 27; //declaracion + inicializacion

            int z = x + y;

            int age = 17;
            double height = 20;
            bool single = true;
            char symbol ='@';
            string name = "Stephany";


            Console.WriteLine("Hello i am: " +name);
            Console.WriteLine("Me age is: " +age);
            Console.WriteLine("Me heigh is : " +height + "cm");
            Console.WriteLine("My civil status is: " +single);
            Console.WriteLine("My symbol is: " +symbol);

        }
    }
}