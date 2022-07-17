// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int PowAB (int a, int b)
{
    int res = 1;
    for (int count=1; count <=b; count++)
    {
        res=res*a;
    }
    
    return res;
}


Console.WriteLine("Введите два числа (А и В) компьютер выдаст ответ А в степени В");
Console.Write("А:");
int digitA = Convert.ToInt32(Console.ReadLine());

Console.Write("B:");
int digitB = Convert.ToInt32(Console.ReadLine());

if (digitB > 0) 
    {
    double resalt = PowAB(digitA, digitB);
    Console.WriteLine($"{digitA} в степени {digitB} Равно {resalt}");
    }

else {
        Console.WriteLine("Алоритм не предусматривает возведение в степень меньше 0");
     }

