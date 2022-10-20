// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int size, int minValue, int maxValue) //Случайный массив от определенного размера.
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray1(int[] inArray) //Функция переворачивает массив на месте. Способ 1
{
    for (int i = 0; i < inArray.Length / 2; i++) //Счетчик проходит до половины массива.
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}

// int[] ReverseArray2(int[] inArray) //Функция переворачивает массив, складывая в другой массив. Способ 2.
// {
//     int[] result = new int[inArray.Length];

//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }
//     return result;
// }

Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
; //Массив до преобразования.

ReversArray1(array);
Console.WriteLine(String.Join(" ", array)); //Массив после преобразования.