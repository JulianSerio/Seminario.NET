using ejercicio7;

namespace ejercicio8;


public class ListaDePersonas{
    private List<Persona> lista;

    public ListaDePersonas(){
        lista = new List<Persona>();
    }
    public void Agregar(Persona p){
        lista.Add(p);
    }

    public Persona? this[int dni]{
        get{
            foreach (Persona p in lista){
                if (p[2] == (object)dni){
                    return p;
                }
            }
            return null;
        }
    }

    public List<string> this[char c]{
        get{
            List<string> nombres = new List<string>();
            foreach (Persona p in lista){
                if (p[0].ToString().ElementAt(0).Equals(c)){
                    nombres.Add((string)p[0]);
                 }
            }
            
            return nombres;

        }
    }

}
