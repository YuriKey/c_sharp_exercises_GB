﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();

void Squars(int n) //задаем функцию с пустым значением
{
    for (int i = 1; i <= n; i = i + 1) // цикл for (i - счетчик; условие работы цикла; шаг счетчика).
    {
        Console.Write($"{i * i}");
        if (i != n) //!= - не равно
        {
            Console.Write(", ");    //убираем запятую в конце
        }
    }
}

Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine()!);
Squars (N);