// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int GetUserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

int [,,] GetMatrix (int m, int n, int l)
{
    int [,,] array = new int [m,n,l];
    
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array [i, j, k] = rnd.Next(1, 100)+i+j+i;
            }
        
        }
    } 
    return array;
}

 
void PrintMatrix (int [,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
             Console.Write ($"{array[i,j,k],  3}({i},{j},{k})");
               
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    } 

}

Console.WriteLine("Введите размер масиива MxNхL");
Console.Write("M:");
int m = GetUserInput();
Console.Write("N:");
int n = GetUserInput();
Console.Write("L:");
int l = GetUserInput();
int [,,] matrix = GetMatrix (m, n,l);
Console.WriteLine();
PrintMatrix(matrix);
