// Задача 21

// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Dist (double ax, double ay, double az, double bx, double by, double bz)
{   
    double q = Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2)+ Math.Pow((bz - az), 2);
    double q1 = Math.Sqrt(q);
    return Math.Round(q1, 2, MidpointRounding.ToZero);
   
}

Console.WriteLine ("Веедите Коородинаты первой точки");
Console.Write ("X:");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y:");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Z:");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Веедите Коородинаты второй точки");
Console.Write ("X:");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y:");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Z:");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Dist (x1, y1, z1, x2, y2, z2);

Console.WriteLine ($"Растояние между точками {result}");















// double [] Inwerkoor (string oneK, string secondK)
// {
//     double [] oneMass = oneK.split.();
//     double [] secMass = secondK.split.();
    
//     foreach (double [] one in oneMass)
//     {
        
//     }
// }
// Console.WriteLine("веедите коррдинаты первой точки, (кородинаты необходисмо вводить через пробел)");
// string oneKoord = Console.ReadLine();
// Console.WriteLine("веедите коррдинаты втрой точки");
// string secondKoord = Console.ReadLine();
// // Console.WriteLine (oneKoord);
// // Console.WriteLine (secondKoord);
// Inwerkoor (oneKoord, secondKoord)

