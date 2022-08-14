// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetUserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

void CreateArr (double [,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(rnd.NextDouble()*10,0);
        }
    }
      
}


void PrintArray (double [,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write ("[");
            if (j < arr.GetLength(1) - 1) Console.Write ($"{arr[i,j],  3},");
            else Console.Write ($"{arr[i,j],  3}]"); 
        }
        Console.WriteLine();
    }
         
}


void AvgColum (double [,] arr, double [] avgMass)
{
          
    for (int j = 0; j < arr.GetLength(1); j++)
    {   
       double sum=0;
        
        for (int i = 0; i < arr.GetLength(0); i++)
        {
           sum+=arr[i,j];  
        }
     
      avgMass [j] = Math.Round(sum/arr.GetLength(0),1);  

    }   
    
}

void PrintArrayAvg (double [] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
         if (i == 0) Console.Write ("[");
         if (i < arr.Length - 1) Console.Write ($"{arr[i]}- ");
         else Console.Write ($"{arr[i]}]");  
    }
}

Console.WriteLine("Введите размер масиива MxN");
Console.Write("M:");
int m = GetUserInput();
Console.Write("N:");
int n = GetUserInput();
double [,] array = new double [m,n];
CreateArr (array);
PrintArray (array); 
double [] avgMassColum = new double [n];
AvgColum (array, avgMassColum);
Console.WriteLine("Среднее арифметическое каждого столбца:"); 
PrintArrayAvg (avgMassColum);
