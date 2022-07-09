Console.Clear();
Console.WriteLine("Введите число");
int num= Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"Ввеедное число {num} четное");
}
else 
{
    Console.WriteLine($"введенное число {num} нечетное");
} 