// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



Console.Write ("Веедите число: ");
int count = CountDigit ();
Console.WriteLine($"числел больше нуля {count}");

int CountDigit ()
{
    string d = Console.ReadLine();
    if (d=="") return 0;
    else if (Convert.ToInt32(d)>0) return 1 + CountDigit ();
    else return 0 + CountDigit ();
}
