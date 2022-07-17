// Задача 19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Palindr(int num)
{
    int revers = 0;
    int numOrig = num;
    while (num > 0)
    {
        int dig = num % 10;
        revers = revers * 10 + dig;
        num=num/10;
    }

    if (revers==numOrig) return "Да";
    else return "Нет";
}

Console.Clear();
Console.WriteLine("Введите число чтобы узнвть палиндром ли это");
int digit = Convert.ToInt32(Console.ReadLine());
digit = Math.Abs(digit);
Console.WriteLine($"{digit} -> {Palindr(digit)}");
