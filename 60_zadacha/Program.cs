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


int[,,] GetArray(int x, int y, int z, int min, int max)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(min, max + 1);
            }
             
        }
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
