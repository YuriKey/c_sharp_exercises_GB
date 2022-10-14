// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

void Palindrom(int num)
{
    int a = num % 10;
    int b = a % 100;
    int c = b % 1000;
    int d = c % 10000;
    int e = d % 100000;

    if (a == e && b == d)
    {
        Console.WriteLine($"Число {num} палиндром.");
    }
    else
    {
        Console.WriteLine($"Число {num} не палиндром.");
    }
}

Console.WriteLine("Введите пятизначное число: ");
int NUM = int.Parse(Console.ReadLine()!);
if (Math.Abs(NUM) > 99999 || Math.Abs(NUM) < 10000)
{
    Console.WriteLine("Введите корректное число.");
}
else
{
    Palindrom(NUM);
}