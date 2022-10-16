// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size)        //Функция, создающая массив, заполненный случайными положительными трёхзначными числами.
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int EvenNumb(int[] someArray)                       // Создаем функцию, считающую количество четных элементов в заданном интервале.
{
    int count = 0;                                  // Счетчик четных чисел.
    for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.Clear();

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);

int[] newArray = GetArray(sizeArray);
Console.WriteLine(String.Join(", ", newArray));
Console.WriteLine($"Количество четных чисел в заданном массиве: {EvenNumb(  newArray)}"!);