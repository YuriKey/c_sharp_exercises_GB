// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] BinArrayInToSingle(int[,] array)
{
    int[] ChangedArray = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++) //rows
    {
        for (int j = 0; j < array.GetLength(1); j++) //columns
        {
            ChangedArray[k++] = array[i, j];
        }
    }
    return ChangedArray;
}

int[] SortArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void CountNumbers(int[] array)
{
    int count = 1;
    int element = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] == element)
        count++;
        else
        {
            Console.WriteLine($"Число {element} встречается в массиве {count} раз.");
            element = array[i];
            count = 1;
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] array1D = BinArrayInToSingle(array);
SortArray(array1D);
CountNumbers(array1D);