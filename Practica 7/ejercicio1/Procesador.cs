namespace ejercicio1;

public static class Procesador {
    public static void Alquilar(IAlquilable x, Persona p) => x.SeAlquilaA(p);
    public static void Atender(IAtendible x) => x.seAtiendeA();
    public static void Devoler (IAlquilable x, Persona p) => x.seDevuelve();
    public static void Lavar (ILavable x) => x.lavar();
    public static void Reciclar(IReciclable x) => x.reciclar(); 
    public static void Secar (ILavable x) => x.secar(); 
    public static void Vender (IVendible x, Persona p) => x.vender(p);


}   
