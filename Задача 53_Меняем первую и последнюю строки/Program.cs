// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод создает двумерный массив случайных чисел.
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    return result;
}

void ChangeArray(int[,] array)
{
    int temp;
    int n = array.GetLength(0);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = array[0, i];
        array[0, i] = array[n - 1, i];
        array[n - 1, i] = temp;
    }
}

void PrintArray(int[,] inArray)
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
PrintArray(array);
ChangeArray(array);
Console.WriteLine("");
PrintArray(array);
