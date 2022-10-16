// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// функция заполнения массива числами от 100 до 999, принимает размер массива, мин и макс
int[] GetArray(int size, int minValue, int maxValue) //создаем функцию для создания массива с вручную задаваемым размером size и интервалом от minValue до maxValue
{
    int[] res = new int[size];                       //создаем результирующий массив для накопления результата

    for (int i = 0; i < size; i++)                              //Пользуемся циклом for, т.к знаем, сколько будет итераций.
    {                                                           // Цикл нужен для заполнения массива res случайными значениями
        res[i] = new Random().Next(minValue, maxValue + 1);     // от minValue до maxValue, включая maxValue, т.к. Next работает
    }                                                           // по методу полуинтервала.
    return res;
}

// функция, считающая четные числа, принимает массив, перебирает его через фор, проверяет на четность, выдает каунт
int EvenNumb(int[] someArray)                        // Создаем функцию, считающую элементы, находящиеся в заданном интервале.
{
    int count = 0;                                  //Результирующая переменная-счетчик.
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

Console.WriteLine("Размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимум: ");
int minArray = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимум: ");
int maxArray = int.Parse(Console.ReadLine()!);

int[] newArray = GetArray(sizeArray, minArray, maxArray);
Console.WriteLine($"Количество четных чисел в заданном массиве: {EvenNumb(  newArray)}"!);