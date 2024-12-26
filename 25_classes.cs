// Las clases en C# son estructuras que definen un tipo de objeto. Una clase puede tener propiedades, métodos y eventos. Se pueden utilizar para crear objetos que tengan un comportamiento y estado específico.

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Saludar()
    {
        Console.WriteLine("Hola, me llamo " + Nombre);
    }
}