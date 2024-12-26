/*Métodos que permiten acceder y modificar los valores de las propiedades de una clase.*/
public class Persona
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
}