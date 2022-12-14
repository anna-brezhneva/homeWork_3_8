// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
using System;
using static System.Console;
Clear();
Write("Введите количество строк первой матрицы: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов первой матрицы: ");
int columns = int.Parse(ReadLine());
int rows2 = rows;
int columns2 = columns;
int[,] firstMatrix = GetArray(rows, columns, 0, 10);
PrintArray(firstMatrix);
WriteLine();
int[,] secondMatrix = GetArray(rows2, columns2, 0, 10);
PrintArray(secondMatrix);
WriteLine();
MultiplyMartix(firstMatrix, secondMatrix);


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

void MultiplyMartix(int[,] array, int[,] inArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int mult = array[i,j] * inArray[i,j];
            Write($"{mult} ");
        }
        WriteLine();
    }
}
