// El polimorfismo en C# es la capacidad de un objeto para tomar diferentes formas. Se puede lograr mediante la herencia y la sobrescritura de métodos.

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

public class Cliente : Persona
{
    public override void Saludar()
    {
        Console.WriteLine("Hola, soy un cliente");
    }
}

public void Saludar(Persona persona)
{
    persona.Saludar();
}