// Los constructores sobrecargados en C# son constructores que tienen el mismo nombre pero diferentes parámetros. Se pueden utilizar para proporcionar diferentes formas de crear un objeto.

public class Persona
{
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public Persona(string nombre)
    {
        Nombre = nombre;
        Edad = 0;
    }
}