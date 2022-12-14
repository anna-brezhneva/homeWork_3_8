// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
using System;
using static System.Console;
Clear();
Write("Введите размеры массива (x y z) через пробел: ");
string[] elements = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int x = int.Parse(elements[0]);
int y = int.Parse(elements[1]);
int z = int.Parse(elements[2]);
int[,,] array = GetArray(x, y, z, 10, 99);
PrintArray(array);
WriteLine();


int[,,] GetArray(int a, int b, int c, int min, int max)
{
    int[,,] result = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                result[i, j, k] = new Random().Next(min, max + 1);
            }
        }
        //WriteLine();
    }
    return result;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}
