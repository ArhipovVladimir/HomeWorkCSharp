// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить
//  строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int GetUserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetMatrix (int m, int n)
{
    int [,] array = new int [m,n];
    
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = rnd.Next(1, 10);
        }
    } 
    return array;
}

 
void PrintMatrix (int [,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write ("[");
            if (j < array.GetLength(1) - 1) Console.Write ($"{array[i,j],  3},");
            else Console.Write ($"{array[i,j],  3}]");
        }
        Console.WriteLine();
    } 

}

int minRow (int [,] matrix)
{   
    int sumRow =0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sumRow += matrix [0,i];
    }
    
    int min = sumRow;
    int indexMin=0;
    
    for (int i = 1; i < matrix.GetLength(1); i++)
    {
        int sumRow2 =0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sumRow2 += matrix [i,j];
        }
        if (sumRow2<min) 
        {
            sumRow2=min;
            indexMin=i;
        }
    }
    return indexMin+1;
}


Console.WriteLine("Введите размер масиива MxN");
Console.Write("M:");
int m = GetUserInput();
Console.Write("N:");
int n = GetUserInput();
int [,] matrix = GetMatrix (m, n);
PrintMatrix(matrix);
Console.WriteLine();
int minIndex = minRow (matrix);
Console.WriteLine($"номер строки  наименьшей суммой элементов {minIndex}");