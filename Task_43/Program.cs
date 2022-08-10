﻿// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int CetUsrerIntun()
{
    return Convert.ToInt32(Console.ReadLine());
}

double [] FindPoint (int k1, int b1, int k2, int b2)
{   
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    return new double [] {x,y};
}

Console.Clear();
Console.WriteLine("Дано уравнение вида y = k1*x+b1, y=k2*x+b2;");
Console.WriteLine("Для поиска точек пересечения введите кофф-т");
Console.Write("k1:");
int k1 = CetUsrerIntun();
Console.Write("b1:");
int b1 = CetUsrerIntun();
Console.Write("k2:");
int k2 = CetUsrerIntun();
Console.Write("b2:");
int b2 = CetUsrerIntun();
double [] Point = FindPoint (k1, b1, k2, b2);
Console.Write($"точка пересчечения прямых y={k1}*x+{b1}, y={k2}*x+{b2}");
Console.Write($" ({Point[0]}, {Point[1]})");

