// La sobrescritura de métodos en C# es un mecanismo que permite que una clase derivada redefina un método de la clase base.

public class Persona
{
    public virtual void Saludar()
    {
        Console.WriteLine("Hola");
    }
}

public class Empleado : Persona
{
    public override void Saludar()
    {
        Console.WriteLine("Hola, soy un empleado");
    }
}