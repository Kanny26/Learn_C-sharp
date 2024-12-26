// La herencia en C# es un mecanismo que permite que una clase herede las propiedades y métodos de otra clase. La clase que hereda se llama "clase derivada" y la clase que se hereda se llama "clase base".

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

public class Empleado : Persona
{
    public string Departamento { get; set; }
}