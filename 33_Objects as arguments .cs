// Los objetos como argumentos en C# se pueden pasar como parámetros a los métodos.

public void Saludar(Persona persona)
{
    Console.WriteLine("Hola, me llamo " + persona.Nombre);
}