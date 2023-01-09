﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

string[] Counting = new string[3] { "Турба", "Урба", "Сентебряки" };

void PrintArray(string[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{arr[position]} ");
        position++;
    }
}

Console.WriteLine("Задан массив строк: ");
PrintArray(Counting);

void KeepSizeString(string[] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        num = num-1;
        string line = arr[i];
        int Length = line.Length;
        for (int j = 0; j < Length; j++)
        {
            if (j >= num)
            {
                line[j] = "";
            } 
        }
        Console.WriteLine();
    }
}