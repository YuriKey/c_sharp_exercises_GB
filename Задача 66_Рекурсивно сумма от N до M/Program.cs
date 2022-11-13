// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int start, int end)
{

    if (end == start)
    {
        return start;
    }
    return end + GetSum(start, end-1);
}

Console.Clear();
Console.Write("Введите число M ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"Сумма чисел от {m} до {n} равна ");
Console.WriteLine(GetSum(m, n));