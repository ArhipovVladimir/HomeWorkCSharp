// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

int [] ConvertInt (string poz)
{   
    string [] pozMassStr = new string [poz.Length] ;
    pozMassStr = poz.Split('.');
    if (poz.Length==1) return new int [] {-1, -1};
    int [] pozMasInt = new int [2];
    for (int i = 0; i < pozMassStr.Length; i++)
    {
        pozMasInt [i]= Convert.ToInt32(pozMassStr[i]);
    }

    return new int [] {pozMasInt[0], pozMasInt[1]};
}


int FindElem (int [,] matrix, int [] poz)
{   
    
    if (poz[0] > matrix.GetLength(0) || poz[1] > matrix.GetLength(1) || poz[1] ==-1) return -1;
    return matrix [poz[0], poz[1]];
}


int [,] matrixResult = GetMatrix (3,4);
PrintMatrix(matrixResult);
Console.Write("введите позицию элемента показанном массиве в формате I.J: ");
string pozString = Console.ReadLine();
int [] pozInt = ConvertInt (pozString);
int elem = FindElem(matrixResult, pozInt);
if (elem==-1) Console.WriteLine("Такого элемента нет");
else {Console.WriteLine($"искомый элемент {elem}");}