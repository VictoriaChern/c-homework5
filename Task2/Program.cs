﻿using System;
using static System.Console;

Clear();
int[] array = randomArray(4);
WriteLine($"[{string.Join(",",array)}] -> {sumOfOdd(array)}");

int[] randomArray(int size) {
    Random random = new Random();
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++) {
        array[i] = random.Next(-10,100);
    }
    return array;
}

int sumOfOdd(int[] array) {
    int sum = 0;
    for(int i = 0; i < array.Length; i++) {
        if(i % 2 != 0) {
            sum += array[i];
        }
    }
    return sum;
}
