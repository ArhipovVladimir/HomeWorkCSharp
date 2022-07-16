// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumDigit(int dig)
{
    int sum = 0;
    int div = dig;
    while (div > 10)
    {
        sum = sum + div % 10;
        div = div / 10;
    }
    sum = sum+div / 10 + div % 10;
    return sum;
}

Console.WriteLine("Введите цифру компьютер посчитает сумму чисел");
int digit = Convert.ToInt32(Console.ReadLine());
digit = Math.Abs(digit);
Console.WriteLine ($"Cумма чисел цифры {digit} равна {SumDigit(digit)}");
