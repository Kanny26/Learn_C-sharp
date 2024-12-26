// Permiten definir clases, interfaces y métodos con un marcador de tipo que se especifica en el momento de la instanciación.

public class Caja<T> {
    private T contenido;
    public void AgregarContenido(T item) {
        contenido = item;
    }
}