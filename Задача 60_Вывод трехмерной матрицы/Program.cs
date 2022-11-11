// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray(int m, int n, int l, int minValue, int maxValue)
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

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество страниц в массиве: ");
int pages = int.Parse(Console.ReadLine()!);

int[,,] userArray = GetArray(row, columns, pages, 0, 20);
Print3DArray(userArray);