// Задача 58: Задайте две матрицы. Напишите 
// программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int [,] MatrixPow (int [,] matrix1, int [,] matrix2)
{   
    int[,] matrixPow = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
           {
               for (int k = 0; k < matrix2.GetLength(0); k++)
               {
                   matrixPow[i,j] += matrix1[i,k] * matrix2[k,j];
               }
           }
    }
    return matrixPow;
}


Console.WriteLine("Введите размер масиива MxN");
Console.Write("M:");
int m = GetUserInput();
Console.Write("N:");
int n = GetUserInput();
int [,] matrix1 = GetMatrix (m, n);
int [,] matrix2 = GetMatrix (n, m);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int [,] matrixPow = MatrixPow (matrix1, matrix2);
Console.WriteLine();
PrintMatrix(matrixPow);
