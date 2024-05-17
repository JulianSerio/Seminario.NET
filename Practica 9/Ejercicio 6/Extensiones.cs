namespace ejercicio6;

public static class Extensiones{
    public static void ForEach<T>(this IEnumerable<T> secuencia, Action<T> action){
      foreach(T elem in secuencia){
        action(elem);
      }
    }
    //Filtra los elementos de la secuencia basandose en el predicado proporcionado
    public static IEnumerable<T> Donde<T>(this IEnumerable<T> secuencia, Func<T, bool> predicado){
      foreach(T elem in secuencia){
        if (predicado(elem)){
          yield return elem;
        }
      }
    }
    //Proyecta cada elemento de la secuencia en una nueva forma basada en la función de seleccion proporcionada
    public static IEnumerable<TResult> Seleccionar<T, TResult>(this IEnumerable<T> secuencia, Func<T, TResult> selector){
      foreach(T elem in secuencia){
        yield return selector(elem);
      }
    } 
}
