// Задача "со звездочкой": 
// Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size)        //1.Функция задает массив случайных чисел, принимает размер массива, выдает массив.
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100, 101);
    }
    return res;
}

int[] SortArray(int[] array)        //2. Функция сортирует массив. Принимает исходный массив, возвращает отсортированный.
{
    int[] res = new int[array.Length];       //Объявляем результирующий массив
    //int count = 0;                         //объвляем счетчик
    int temp = 0;               //Объявляем временную переменную для замены элементов
    for (int i = 1; i[res.Length] >= 0; i++)
    {
        if (array[res.Length - 1] < res[res.Length - i])
        {
            if (res[i] < res[i + 1])
            {
                temp = res[i];
                res[i] = res[i + 1];
                res[i + 1] = temp;
            }
            else
            {
                i = i + 1;
            }
        }
        i = i + 1;
    }
    return res;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);

int[] someArray = GetArray(sizeArray);

Console.WriteLine(string.Join(", ", someArray));
Console.WriteLine(string.Join(", ", SortArray(someArray)));