// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
if (rows == columns)
{
    WriteLine("Количество столбцов должно отличаться от количества строк. Повторите попытку");
    return;
}
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
//WriteLine($"Суммы элементов по строкам двумерного массива: [{String.Join(",", SummaRows(array))}]");
int[] array2 = SummaRows(array);
WriteLine($"Строка с наименьшей суммой элементов - это строка №{MinSummaRows(array2)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

int[] SummaRows(int[,] array)
{ 
     int[] sumArray = new int[array.GetLength(0)];
     for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

int MinSummaRows(int[] array)
{
    int minsum = array[0];
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minsum)
        {
            minsum = array[i];
            number = i+1;
        }
    }
    return number;
}