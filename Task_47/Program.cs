﻿// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetUserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

void CreateArr (double [,]arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(rnd.NextDouble()*10,1);
        }
    }
      
}


void PrintArray (double [,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           Console.Write($"{arr[i,j]} ");  
        }
        Console.WriteLine();
    }
         
}

Console.WriteLine("введите размер масиива mxn");
Console.Write("m:");
int m = GetUserInput();
Console.Write("n:");
int n = GetUserInput();
double [,] array = new double [m,n];
CreateArr (array);
PrintArray (array); 
