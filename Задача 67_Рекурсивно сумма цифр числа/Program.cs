// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int GetSum(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return num%10 + GetSum(num/10);
}

Console.Clear();
Console.Write("Введите число N: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(m));