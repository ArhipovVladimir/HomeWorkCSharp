// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 
// 78 -> третьей цифры нет
// 32679 -> 6

int FriNumFind(int resalt) // решение функции поиска 3 цифры с начала 
{
    while (resalt>999)
    {
        resalt = resalt / 10;
    }
    resalt = resalt % 10;   
    
    return resalt;
}

Console.Clear();
Console.WriteLine("Веедите число. Компьютер найдет его третью цифру");
int num = Convert.ToInt32(Console.ReadLine());
int num1=num;
if (num < 0)
{
    num1 = num * -1;
}

if (num1 > 99)
{
    int FriNum = FriNumFind(num1);
    Console.WriteLine($"{num} -> {FriNum}");
}
else
{
    Console.WriteLine($"{num1} -> Третьей цифры нет");
}


