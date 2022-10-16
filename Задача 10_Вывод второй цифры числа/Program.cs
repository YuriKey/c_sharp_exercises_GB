//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear ();
Console.WriteLine("Введите положительое трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 99 & num < 1000)
{
    Console.WriteLine ($"{(num/10)%10}");
}
else
{
    Console.WriteLine ($"Введите корректное число!");
}