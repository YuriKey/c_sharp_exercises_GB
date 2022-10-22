// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод создает двумерный массив случайных чисел.
{
    int[,] result = new int[m, n]; //Создается результирующий массив.

    for (int i = 0; i < m; i++) //счетчик бежит по строкам
        for (int j = 0; j < n; j++) //счетчик бежит по столбцам
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return result;
}

//Поскольку физическое представление двумерного массива это таблица, метод String.Join для вывода
//на печать не подходит. Поэтому необходимо создать новую функцию для печати на экран.

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t "); // \t табуляция, выравнивание символов друг под другом.
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
