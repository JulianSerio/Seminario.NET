namespace ejercicio1;

public class Pelicula : IAlquilable
{
    public void SeAlquilaA(Persona p)
    {
        Console.WriteLine("Alquilando pelicula a persona");
    }

    public void seDevuelve()
    {
        Console.WriteLine("Pelicula devuelta por persona");
    }
}
