using System.Collections;
using System.Drawing;


var lista = new ListaEnlazada<int>();
lista.AgregarAdelante(3);
lista.AgregarAdelante(100);
lista.AgregarAtras(10);
lista.AgregarAtras(11);
lista.AgregarAdelante(0);
IEnumerator<int> enumerador = lista.GetEnumerator();
while (enumerador.MoveNext())
{
int i = enumerador.Current;
Console.Write(i + " ");
}
Console.WriteLine();



class ListaEnlazada<T>(){
    private List<Nodo<T>> nodos = new List<Nodo<T>>();

    public void AgregarAdelante(T valor){
        Nodo<T> node = new Nodo<T>(valor);
        nodos.Insert(0,node);
    }

    public void AgregarAtras(T valor){
        Nodo<T> node = new Nodo<T>(valor);
        nodos.Add(node);
    }

    internal IEnumerator<T> GetEnumerator()
    {
         foreach (var nodo in nodos)
        {
            yield return nodo.Valor;
        }
    }
}

class Nodo<T>{
    public T Valor { get; private set; }
    public Nodo<T>? Proximo { get; set; } = null;

    public Nodo (T valor){
        this.Valor = valor;
    }
}
