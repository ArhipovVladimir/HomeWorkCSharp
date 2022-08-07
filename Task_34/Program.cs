// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами.
// Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int CountElem0 (int [] array)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}



Console.Write("Введите размер массива ");
int site = Convert.ToInt32(Console.ReadLine());
int[] array = FillArr(site, 100, 1000);
Print(array);
Console.WriteLine();
int count = CountElem0 (array);
Console.WriteLine ($"колличество четных эементов {count}");