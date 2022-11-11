// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindMinRowSum(int[,] array)
{
    int minRow = 0;
    int count = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            count = i + 1;
        }
        sumRow = 0;
    }
    return count;
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
Console.Write("Введите количество столбцов в массиве, отличное от количества строк: ");
int columns = int.Parse(Console.ReadLine()!);

if (row == columns)
    Console.Write("Введите корректное количество столбцов.");
else
{
    int[,] userArray = GetArray(row, columns, 0, 10);
    PrintArray(userArray);
    Console.WriteLine();
    Console.Write($"Строка с наименьшей суммой элементов - {FindMinRowSum(userArray)}");
}