// Задача 19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Palindr(int num)
{
    int rightPart = num / 1000;
    int LeftPart = num % 100;
    int LeftPartDoz = LeftPart / 10;
    int leftPartUni = num % 10;
    int retutnLeft = leftPartUni * 10 + LeftPartDoz;
    if (rightPart == retutnLeft)
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit >= 100000 || digit <= 9999)
{
    Console.WriteLine("Число непятизначное");
}
else
{
    Console.WriteLine($"{digit} -> {Palindr(digit)}");
}
