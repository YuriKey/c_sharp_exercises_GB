// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

bool GetPoint (double b1, double k1, double b2, double k2) //1. Функция bool проверяет, есть ли точки
{                                                          // сопроикосновения прямых, возвращает true or false.
    double x = (b2 - b1)/(k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    return (y1 == y2);
}

Console.Clear();

Console.Write("Для функции y = k1 * x + b1 введите значение b1: ");
double a = double.Parse(Console.ReadLine()!);

Console.Write("Для функции y = k1 * x + b1 введите значение k1: ");
double b = double.Parse(Console.ReadLine()!);

Console.Write("Для функции y = k2 * x + b2 введите значение b2: ");
double c = double.Parse(Console.ReadLine()!);

Console.Write("Для функции y = k2 * x + b2 введите значение k2: ");
double d = double.Parse(Console.ReadLine()!);

double x = (c - a)/(b - d);
double y = b * ((c - a)/(b - d)) + a;

if (GetPoint (a, b, c, d))
{
    Console.Write($"Точка перечения прямых ({x}; {y})");
}
else
{
    Console.Write("Прямые не пересекаются.");
}