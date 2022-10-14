Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if (number == 1)
{
    Console.Write(" --> Понедельник");
}
else if (number == 2)
{
    Console.Write(" --> Вторник");
}
else if (number == 3)
{
    Console.Write(" --> Среда");
}
else if (number == 4)
{
    Console.Write(" --> Четверг");
}
else if (number == 5)
{
    Console.Write(" --> Пятница");
}
else if (number == 6)
{
    Console.Write(" --> Суббота");
}
else if (number == 7)
{
    Console.Write(" --> Воскресенье");
}