﻿// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int[] array = new int[4];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чётных чисел: " + count);