void Set<T> (T[] vector, T valor, int pos){
    vector[pos] = valor;
}

void Imprimir<T>(T[] vector){
    for (int i = 0; i < vector.Length; i++){
        Console.Write(vector[i] + " ");
    }
    Console.WriteLine();
}


int[] vector1 = [1, 2, 3];
bool[] vector2 = [true, true, true];
string[] vector3 = ["uno", "dos", "tres"];
Set<int>(vector1, 110, 2);
Set<bool>(vector2, false, 1);
Set<string>(vector3, "Hola Mundo!", 0);
Imprimir(vector1);
Imprimir(vector2);
Imprimir(vector3);