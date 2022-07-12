// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 
// 78 -> третьей цифры нет
// 32679 -> 6

int FriNumFind(int resalt) // решение функции поиска 3 цифры с начала 
{
    int len = 0;
    int count = 1;
    int ostDiv =resalt;
    while (ostDiv != 0)
    {
        ostDiv = ostDiv / 10;
        len++;
    }
    while (count < len -2)
    {
        resalt=resalt/10;
        count++;
    }
    resalt = resalt % 10;   
    
    return resalt;
}

Console.Clear();
Console.WriteLine("Веедите число. Компьютер найдет его третью цифру");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = num * -1;
}

if (num > 99)
{
    int FriNum = FriNumFind(num);
    Console.WriteLine($"{num} -> {FriNum}");
}
else
{
    Console.WriteLine($"{num} -> Третьей цифры нет");
}


