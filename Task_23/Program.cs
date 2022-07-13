﻿// Задача 23

// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubTabl(double [] tabl)
{
    int index = 1;
    while (index < tabl.Length)
     {
        tabl [index] = Math.Pow(index, 3);
        index++;
     }
}
void PrintTable(double [] tabl)
{
    int index = 1;
    while (index < tabl.Length)
     {
        Console.Write($"{tabl[index]}, ");
        index++;
     }
}

Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());
double [] tablCubArr = new double [digit+1];
CubTabl(tablCubArr);
Console.Write($"{digit} -> ");
PrintTable(tablCubArr);