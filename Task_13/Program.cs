// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 в условии ошибка по моему при данном задании ответ дб 6
// 78 -> третьей цифры нет
// 32679 -> 6


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
    Console.WriteLine(FriNum);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

int FriNumFind(int resalt)
{
    for (int count = 1; count <= 2; count++)
    {
        resalt = resalt / 10;
    }

    resalt = resalt % 10;

    return resalt;
}
