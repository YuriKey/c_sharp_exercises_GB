// Задача "со звездочкой": 
// Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size)        //1.Функция задает массив случайных чисел, принимает размер массива, выдает массив.
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(); //Next(-100, 100); Next(0, 3);
    }
    return res;
}

int[] SortArray(int[] array)    //2. Функция сортирует массив. Принимает исходный массив, возвращает отсортированный.
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++) //i + 1, т.к. сравниваем 0й элемент с первым.
        {
            if (array[i] < array[j])               //Чтобы уменьшалось, нужен <.
            {
                temp = array[i];                   //
                array[i] = array[j];               //Замена сравниваемых элементов в случае выполнения условия.
                array[j] = temp;                   //
            }
        }
    }
    return array;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);

int[] someArray = GetArray(sizeArray);

Console.WriteLine(string.Join(", ", someArray));
Console.WriteLine(string.Join(", ", SortArray(someArray)));