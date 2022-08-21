// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetUserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

int PrintSum(int m, int n)
{
    if (m == n) return 0;
    return n + PrintSum (m, n-1);
    
}


Console.WriteLine("Введите число M и N ");
Console.Write("M: ");
int m = GetUserInput();
Console.Write("N: ");
int n = GetUserInput();
int result = PrintSum(m, n);
Console.WriteLine($"Сумма натуральных чисел между {m} и {n} равна {result-n}");
