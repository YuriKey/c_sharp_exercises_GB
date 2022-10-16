//расстояние между двумя точками в декартовой плоскости

Console.Clear();

double FindDist(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return result;
}

Console.Write("Введите координату x1 ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату y1 ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату x2 ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату y2 ");
int y2 = int.Parse(Console.ReadLine()!);

Console.Write($"{FindDist(x1, y1, x2, y2 ):f2}"); //f2 - округление до 2го символа