// Задача 64: Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetUserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNatural(int num)
{
    if (num==0) return;
    Console.Write($"{num}, ");
    PrintNatural (num-1);
    
}


Console.Write("Введите число N: ");
int num = GetUserInput();
PrintNatural(num);