// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Get3DArray(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, l];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue);
            }
    return result;
}

void Print3DArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ");
                Console.Write($"({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }

}

int[] BinArrayInToSingle(int[,,] array)
{
    int[] ChangedArray = new int[array.GetLength(0) * array.GetLength(1)*array.GetLength(2)];
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                ChangedArray[n++] = array[i, j, k];
            }
        }
    }
    return ChangedArray;
}

bool CheckArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] == array[j])
            {
                return true;
            }
        }
    }
    return false;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество страниц в массиве: ");
int pages = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,,] userArray = Get3DArray(row, columns, pages, 0, 100);
int[] arrayForCheck = BinArrayInToSingle(userArray);

if (CheckArray(arrayForCheck))
{
    Print3DArray(userArray);
    Console.WriteLine();
    Console.Write("Элементы массива неуникальны. Запустите код заново.");
}
else
{
    Console.WriteLine();
    Print3DArray(userArray);
    Console.WriteLine();
}