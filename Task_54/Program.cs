// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки 
// двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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
            array [i, j] = rnd.Next(1, 100);
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

void SortMatrix (int [,] matrix)
{
    
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1-k; j++)
            {
               
               if (matrix[i,j] < matrix[i,j+1])
            {
                (matrix[i,j] , matrix[i,j+1]) = (matrix[i,j+1] , matrix[i,j]);
            }

            }
        }
   }

}


Console.WriteLine("Введите размер масиива MxN");
Console.Write("M:");
int m = GetUserInput();
Console.Write("N:");
int n = GetUserInput();
int [,] matrix = GetMatrix (m, n);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);
