double [,]? a = new double[2,2];
double [,]? b = new double[2,2];
int filasA = a.GetLength(0);
int columnasA = a.GetLength(1);
int filasB = b.GetLength(0);
int columnasB = b.GetLength(1);

double[,]? Suma(double[,] A, double[,] B){
    if (filasA + columnasA == filasB + columnasB){
        double [,]? m = new double[filasA,columnasA];
        for (int i = 0; i < filasA; i++){
            for (int j = 0; j < columnasA; j++){
                m[i,j] = A[i,j] + B[i,j];
            }
        }
        return m;
    }   
    else {
        return null;
    }
}
double[,]? Resta(double[,] A, double[,] B){
    if (filasA + columnasA == filasB + columnasB){
        double [,]? m = new double[filasA,columnasA];
        for (int i = 0; i < filasA; i++){
            for (int j = 0; j < columnasA; j++){
                m[i,j] = A[i,j] - B[i,j];
            }
        }
        return m;
    }   
    else {
        return null;
    }
}
double[,] Multiplicacion(double[,] A, double[,] B){
    if (columnasA == filasB){
        double [,]? m = new double[filasA,columnasA];
        for (int i = 0; i < filasA; i++){
            for (int j = 0; j < columnasA; j++){
                m[i,j] = A[i,j] * B[i,j];
            }
        }
        return m;
    }   
    else{
        throw new ArgumentException("Las matrices no son iguales");
    }

}
