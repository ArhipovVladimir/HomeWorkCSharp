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

// программа считает сумму чисел не включая начальную и конечную цыфру
//например  сумма чисел мужду 3 и 9 будет включать
// 4+5+6+7+8 = 30 
Console.WriteLine("Введите число M и N ");
Console.Write("M: ");
int m = GetUserInput();
Console.Write("N: ");
int n = GetUserInput();
int n1 = n-1;
int result = PrintSum(m, n1);
Console.WriteLine($"Сумма натуральных чисел между {m} и {n} равна {result}");
