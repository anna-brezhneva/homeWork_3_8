// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
using System;
using static System.Console;
Clear();
Write("Задайте количество строк массива: ");
int n = int.Parse(ReadLine());
int[,] array = GetArray(n);
PrintArray(array);


int[,] GetArray(int n)
{
    int[,] result = new int[n, n];
    int start = 1;
    int i = 0;
    int j = 0;
    while (start <= result.GetLength(0) * result.GetLength(1))
    {
        result[i, j] = start;
        start++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= result.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > result.GetLength(1) - 1)
        j--;
        else
        i--;
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0)
            {
                Write($"0{array[i, j]} ");
            }
            else
            {
                Write($"{array[i, j]} ");
            }
        }
        WriteLine();
    }
}