namespace ejercicio1;

public class PeliculaClasica : IAlquilable, IVendible
{
    public void SeAlquilaA(Persona p)
    {
        Console.WriteLine("Alquilando pelicula clasica a persona");
    }

    public void seDevuelve()
    {
        Console.WriteLine("Pelicula clasica devuelta por persona");

    }

    public void vender(Persona p)
    {
        Console.WriteLine("Vendiendo pelcula clasica a persona");

    }
}
