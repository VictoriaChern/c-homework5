using System;
using static System.Console;

Clear();
double[] array = randomArray(4);
WriteLine($"[{string.Join(", ",array)}] -> {(Math.Round(getMax(array) - getMin(array), 3))}");

double[] randomArray(int size) {
    Random random = new Random();
    double[] array = new double[size];
    for(int i = 0; i < array.Length; i++) {
        array[i] = Math.Round(random.NextDouble(), 3);
    }
    return array;
}

double getMin(double[] array) {
    double min = array[0];
    for(int i = 1; i < array.Length; i++) {
        if(array[i] < min) {
            min = array[i];
        }
    }
    return min;
}

double getMax(double[] array) {
    double max = array[0];
    for(int i = 1; i < array.Length; i++) {
        if(array[i] > max) {
            max = array[i];
        }
    }
    return max;
}
