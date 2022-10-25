// Задача 50: Напишите программу, которая на вход
// принимает значение элемента в двумерном массиве, и
// возвращает позицию этого элемента или же указание,
// что такого элемента нет.


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

int[] FindNumInArray(int[,] array, int findNum) //Метод перебирает элементы, сравнивает их с искомым.
{                                               //Принимает массив и искомое. Возвращает массив из 
    int[] NumPos = new int[2];                  //номеров позиции.

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == findNum)
            {
                NumPos[0] = i + 1;
                NumPos[1] = j + 1;
                return NumPos;
            }
        }
    }

    if (NumPos[0]==0 && NumPos[1]==0)
    {
        Console.Write("Искомое в массиве отсутствует: ");
    }
    return NumPos;
}

void PrintArray(int[,] inArray) // Метод выводит массив на печать.
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число от 0 до 10: ");
int num = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);

Console.WriteLine();
Console.WriteLine( String.Join("; ", FindNumInArray(array, num)));

