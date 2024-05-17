﻿using ejercicio6;

int[] vector = [1, 2, 3, 4, 5];
vector.Donde(i => i > 3) // IEnumerable<int> : 4, 5
    .Seleccionar(i => i * 10) // IEnumerable<int> : 40, 50
    .Seleccionar(i => $"({i})") // IEnumerable<string> : "(40)", "(50)"
    .ForEach(st => Console.WriteLine(st));