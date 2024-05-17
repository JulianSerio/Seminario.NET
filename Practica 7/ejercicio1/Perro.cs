namespace ejercicio1;

public class Perro : IVendible, IAtendible, ILavable
{
    public void lavar()
    {
        Console.WriteLine("Lavando perro");
    }

    public void seAtiendeA()
    {
        Console.WriteLine("Atendiendo perro");
    }

    public void secar()
    {
        Console.WriteLine("Secando perro");
    }

    public void vender(Persona p)
    {
        Console.WriteLine("Vendiendo perro a persona -- Como vas a vender un perro hdp");
    }


}
