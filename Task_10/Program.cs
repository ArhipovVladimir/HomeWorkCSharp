// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
  Console.Clear();
  Console.WriteLine("Веедите трехзначное число");
  int num = Convert.ToInt32(Console.ReadLine());
  if (num < 0)
    {
        num=num*-1;
    }

int resalt = num;

  if (num > 99 && num < 1000)
     {
         resalt = resalt / 10;
         resalt = resalt % 10;
         Console.WriteLine(resalt);
     }
else
    {
        Console.WriteLine("число не техзначное");
    }
