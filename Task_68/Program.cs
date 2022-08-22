// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

double GetUserInput()
{
    return Convert.ToDouble(Console.ReadLine());
}


double Akerman (double m, double n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Akerman (m - 1, 1);
    else if ((m > 0) && (n > 0)) return Akerman (m - 1, Akerman (m, n - 1));
    else return n + 1;

}


Console.WriteLine("Введите число M и N ");
Console.Write("M: ");
double m = GetUserInput();
Console.Write("N: ");
double n = GetUserInput();
double result = Akerman (m, n);
Console.WriteLine($" результат функции аккермвна  при параметрах {m} и {n} равен {result}");




