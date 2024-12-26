// El método ToString en C# es un método que se utiliza para convertir un objeto en una cadena de texto. Se puede sobrescribir en una clase para proporcionar una representación de texto personalizada del objeto.

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}";
    }
}