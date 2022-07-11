// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.WriteLine("Введите номер дня недели, Компьютер определит выходной ли это");
int numDay= Convert.ToInt32(Console.ReadLine());
if (numDay > 7 || numDay < 1)
{
    Console.WriteLine("Такого дня недели нет");
}
else if (numDay == 6 || numDay == 7)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}

