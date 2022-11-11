// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 

string GetPrint(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    Console.WriteLine($"{start}");
    return start + " " + GetPrint(start + 1, end);
}

Console.Clear();
Console.Write("Введите количество число M ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество число N ");
int n = int.Parse(Console.ReadLine()!);;
Console.WriteLine(GetPrint(m, n));