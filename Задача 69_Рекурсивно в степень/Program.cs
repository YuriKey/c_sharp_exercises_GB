// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int GetPow(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    return a * GetPow(a, b - 1);
}
//a^n = a*a^(n-1) => return b * GetPow(a, b)?

Console.Clear();
Console.Write("Введите число M ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень N ");
int n = int.Parse(Console.ReadLine()!); ;
Console.WriteLine(GetPow(m, n));