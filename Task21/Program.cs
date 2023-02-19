// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите Х-координату точки А:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y-координату точки А:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z-координату точки А:");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X-координату точки B:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y-координату точки B:");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z-координату точки B:");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между точками А и В => {distance}");


double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2, MidpointRounding.ToZero);
}