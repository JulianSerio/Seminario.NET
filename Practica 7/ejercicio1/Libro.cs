namespace ejercicio1;

public class Libro : IAlquilable,  IReciclable {
    public void reciclar()
    {
        Console.WriteLine("Reciclando libro");
    }

    public void SeAlquilaA(Persona p)
    {
        Console.WriteLine("Alquilando libro a persona");
    }

    public void seDevuelve()
    {
        Console.WriteLine("Libro devuelto por persona");
    }
}
