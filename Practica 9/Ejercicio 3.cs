using System.Reflection.Metadata;
using System.Runtime.Serialization;

T[] CrearArreglo <T> (params T[] valores){
    T[] lista = valores;
    return lista;
}


T GetNuevoObjetoDelMismoTipo<T> (T var) where T : new()
{
    return new T();
}

string[] vector1 = CrearArreglo<string>("uno", "dos");
foreach (string st in vector1) Console.Write(st + " - ");
Console.WriteLine();
double[] vector2 = CrearArreglo<double>(1, 2.3, 4.1, 6.7);
foreach (double valor in vector2) Console.Write(valor + " - ");
Console.WriteLine();
var stb = new System.Text.StringBuilder();
var a = GetNuevoObjetoDelMismoTipo(stb);
var b = GetNuevoObjetoDelMismoTipo(17);
Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());