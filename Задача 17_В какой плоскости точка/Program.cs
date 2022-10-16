//точки, плоскости

Console.Clear();
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine()!);

if (x > 0)
{
    if (y > 0)
    {
        Console.Write("Первая четверть");
    }
    else
    {
        Console.Write("Четвертая четверть");
    }
}
else
 if (x < 0)
{
    if (y > 0)
    {
        Console.Write("Вторая четверть");
    }
    else
    {
        Console.Write("Третья четверть");
    }
}