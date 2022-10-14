// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void Cubes(int n)
{
    for (int i = 1; i <= n; i = i + 1)
    {
        Console.Write($"{i * i * i}");
        if (i != n)
        {
            Console.Write(", ");
        }
    }
}

Console.Write("Введите целое число: ");
int N = Math.Abs(int.Parse(Console.ReadLine()!));
Cubes (N);