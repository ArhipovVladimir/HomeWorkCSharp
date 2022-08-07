// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76



double [] FillArr(int site)
{
    double [] array = new double [site];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble()*100,1);
    }
    return array;
}

void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + "; ");
        else
            Console.Write(arr[i] + "]");
    }
}

double DeltaMaxMim (double [] array)
{   
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < min)
        {
            min= array [i];
        }
        if (array [i] > max)
        {
            max= array [i];
        }
    }
    return max-min;
}



Console.Write("Введите размер массива ");
int site = Convert.ToInt32(Console.ReadLine());
double [] array = FillArr(site);
Print(array);
Console.WriteLine();
double res = DeltaMaxMim (array);
Console.WriteLine ($" разность между макс и мин элементами {res}");