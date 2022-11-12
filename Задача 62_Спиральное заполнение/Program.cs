// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    int i = 0;
    int j = 0;
    for (int temp = 1; temp <= newArray.GetLength(0) * newArray.GetLength(1); temp++)
    {
        newArray[i, j] = temp;
        if (i <= j + 1 && i + j < newArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= newArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > newArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return newArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] / 10 <= 0)
                Console.Write($"0{inArray[i, j]}\t ");

            else Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите длину строки массива: ");
int l = int.Parse(Console.ReadLine()!);

int[,] userArray = new int[l,l];
int[,] changedArray = FillArray(userArray);
PrintArray(changedArray);

