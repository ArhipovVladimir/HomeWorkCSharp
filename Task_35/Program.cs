// рефакторинг кода к задаче 35 семинара 
int[] FillArr(int site, int min, int max)
{
    int[] array = new int[site];
    Random r = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.Write(arr[i] + "]");
    }
}

int CountElemunt (int [] array, int min, int max)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] >= min && array[i] <= max)
        {
            count++;
        }
    }
    return count;
}



Console.Write("Введите размер массива ");
int site = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите границы массива ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] array = FillArr(site, min, max);
Print(array);
Console.WriteLine();
int count = CountElemunt (array, 10, 99);
Console.WriteLine ($"колличество эементов в диапозоне от 10 до 99 {count}");