﻿// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// [1, 2, 3, 4] -> [2, 4]
// [1, 3, 4, 5, 7, 1, 3] -> [4]
// [2, -4, 6] -> [2, -4, 6]
// [1, 3, 5] -> []
int[] a = new int[9];
void RndArr(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
        if (i % 2 == 0)
    
        Console.Write(i + " ");
    }
    
}
RndArr(a, 0, 9);
