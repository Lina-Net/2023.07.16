﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);

}

int ReleaseArray(int[] array)
{
    int c = 0;
     for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            c++;
    return c;
}


Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));