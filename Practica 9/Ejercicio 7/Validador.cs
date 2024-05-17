namespace ejercicio7;

public class Validador<T>{
    private readonly List<ReglaValidacion<T>> reglas = new List<ReglaValidacion<T>>();


    public Validador<T> AgregarRegla(ReglaValidacion<T> regla){
        reglas.Add(regla);
        return this;
    }

    public bool Validar(T objeto, out List<string> errores){
        errores = new List<string>();
        foreach(var elem in reglas){
            if (!elem.Ok(objeto)) { errores.Add(elem.MensajeError);}
        }
        return errores.Count == 0;
    }
    
}
