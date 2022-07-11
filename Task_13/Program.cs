// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 в условии ошибка по моему при данном задании ответ дб 6
// 78 -> третьей цифры нет
// 32679 -> 6

int FriNumFind(int resalt)
{
    string numStr=Convert.ToString(resalt);
    int len = numStr.Length; 
    int poz = len - 2;
    int count = 1;
    while (count < poz)
    {
        resalt = resalt / 10;
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
    Console.WriteLine(FriNum);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


