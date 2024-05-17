namespace ejercicio1;

public class Auto : IVendible, ILavable, IReciclable {
    public void lavar()
    {
        Console.WriteLine("Lavando auto");
    }

    public void reciclar()
    {
        Console.WriteLine("Reciclando auto");
    }

    public void secar()
    {
        Console.WriteLine("Secando auto");
    }

    public void vender(Persona p)
    {
        Console.WriteLine("Vendiendo auto a persona");
    }
}
