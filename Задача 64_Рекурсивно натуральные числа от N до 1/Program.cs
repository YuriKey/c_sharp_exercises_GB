// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetPrint(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return start + " " + GetPrint(start - 1, end);
}

Console.Clear();
Console.Write("Введите число N ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(GetPrint(n, m));
