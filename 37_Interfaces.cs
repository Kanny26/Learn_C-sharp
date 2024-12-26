// Las interfaces en C# son contratos que definen un conjunto de métodos y propiedades que deben ser implementados por una clase. Se pueden utilizar para proporcionar una forma de comunicación entre clases.

public interface IPersona
{
    string Nombre { get; set; }
    int Edad { get; set; }
    void Saludar();
}

public class Persona : IPersona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Saludar()
    {
        Console.WriteLine("Hola");
    }
}