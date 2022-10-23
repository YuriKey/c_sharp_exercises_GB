// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] GetArray(int m, int n, int minValue, int maxValue) // Метод создает двумерный массив случайных чисел.
{
    double[,] result = new double[m, n]; //Создается результирующий массив.

    for (int i = 0; i < m; i++) //счетчик бежит по строкам
        for (int j = 0; j < n; j++) //счетчик бежит по столбцам
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
            result[i, j] = Math.Round(result[i, j], 2);
        }
    return result;
}

void PrintArray(double[,] inArray)
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

double[,] array = GetArray(row, columns, 0, 100);
PrintArray(array);