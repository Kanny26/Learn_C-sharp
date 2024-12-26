/*Se puede crear listas que contengan objetos de una clase personalizada.*/
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

List<Persona> personas = new List<Persona>();
personas.Add(new Persona { Nombre = "Juan", Edad = 30 });
