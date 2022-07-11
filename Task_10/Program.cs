// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
  Console.Clear();
  Console.WriteLine("Веедите трехзначное число");
  int num = Convert.ToInt32(Console.ReadLine());
  int resalt = num;
  resalt = resalt / 10;
  resalt = resalt % 10;
  Console.WriteLine(resalt);
