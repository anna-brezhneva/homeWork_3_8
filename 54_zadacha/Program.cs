// Задача 54: Задайте двумерный массив. Напишите 
//программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
SortArray(array);


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

void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = j+1; k < inArray.GetLength(1); k++)
            {
                if(inArray[i,k] > inArray[i,j])
                {
                    int temp = inArray[i,j];
                    inArray[i,j] = inArray[i,k];
                    inArray[i,k] = temp;
                }
            }
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
