// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя. Массив НЕквадратный. Условие некорректное.

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

int[,] ChangeRowsColumnsArray(int[,] array)
{
    int[,] ChangedArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++) //rows
    {
        for (int j = 0; j < array.GetLength(1); j++) //columns
        {
            ChangedArray[i, j] = array[j, i];
        }
    }
    return ChangedArray;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);

if (row != columns)
{
    Console.Write("В текущем массиве действие невозможно.");
}
else
{
    ChangeRowsColumnsArray(array);
    Console.WriteLine();
    PrintArray(ChangeRowsColumnsArray(array));
}