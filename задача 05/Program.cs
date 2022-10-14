Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int minus = -number;

while (minus <= number)
{
    Console.Write($"{minus} ");
    minus = minus + 1;
}
