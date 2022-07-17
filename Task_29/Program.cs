// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void FillArray (int [] collection)
{
    int length = collection.Length;
    for (int index=0; index < length; index++)
    {
        collection[index] = new Random().Next (1, 100);
    }
}

void PrintArray (int [] collection)
{
    int length = collection.Length;

    for (int index=0; index < length; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
}

Console.Clear();
Console.WriteLine("из скольки элементов задать массив?");
int n =Convert.ToInt32(Console.ReadLine()); 
int [] array = new int [n];
FillArray (array);
Console.WriteLine($"массив из произвольных {n} элементов");
PrintArray (array);
