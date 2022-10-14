//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double FindDist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return result;
}

Console.Write("Введите координату x1 ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату y1 ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z1 ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату x2 ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату y2 ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату z2 ");
int Z2 = int.Parse(Console.ReadLine()!);

Console.Write($"{FindDist(X1, Y1, Z1, X2, Y2, Z2):f2}");