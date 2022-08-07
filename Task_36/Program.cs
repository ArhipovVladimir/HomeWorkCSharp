// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SummElem1(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Write("Введите размер массива ");
int site = Convert.ToInt32(Console.ReadLine());
int[] array = FillArr(site, 1, 10);
Print(array);
Console.WriteLine();
int sum = SummElem1(array);
Console.WriteLine($"сумма эементов стоящих на нечетных позициях {sum}");
