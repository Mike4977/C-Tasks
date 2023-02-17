// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А ");
Console.Write("XА: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("YА: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В ");
Console.Write("XВ: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("YВ: ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xA, yA, xB, yB);

double d = distance;
double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(dRound);

double Distance (int x1, int y1, int x2, int y2)
{
    int resX = x2 - x1;
    int resY = y2 - y1;
    double result = Math.Sqrt(resX * resX + resY * resY);
    return result;
}

    // Math.Sqrt(5); 
    // Math.Pow(2, 10)
    // double d = 5.09998774;
    // double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
    // Console.WriteLine(dRound);
    