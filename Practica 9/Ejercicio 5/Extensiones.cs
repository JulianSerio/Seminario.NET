namespace ejercicio5;

public static class Extensiones{
    public static void ForEach<T> (this IEnumerable<T> secuencia,Action<T> action){
        foreach (T elem in secuencia){
            action(elem);
        }
    }
}
