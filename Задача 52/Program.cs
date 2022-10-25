// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Функция 1. Метод создает двумерный массив случайных чисел.
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    return result;
}

// Функция 2. Считает среднее арифметическое в столбцах двумерного массива.
// Принимает двумерный массив, возвращает одномерный массив.
double[] FindAverageCol(int[,] array)
{
    double[] res = new double[array.Length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

        }
    }
}

// Функция 3. Выводит на печать двумерный массив.
void PrintArrayOld(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);

PrintArrayOld (array); // Печать исходного двумерного массива.
Console.WriteLine();
Console.Write("Средние арифметические значения столбцов равны: ");
Console.WriteLine(string.Join("; ", FindAverageCol(array))); // Вывод результата.