// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray(int size)        //1.Функция задает массив случайных чисел, принимает размер массива, выдает массив.
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100, 100);
    }
    return res;
}

int UnevenPos(int[] someArray)  //2.Функция принимает массив, перебирает элементы, 
{                               //если элемент стоит на нечетной позиции, складывает в int res.
    int res = 0;
    for (int i = 0; i < someArray.Length ; i++)
    {
        if (i % 2 != 0)
        {
            res += someArray[i];
        }

    }
    return res;
}
Console.Clear();

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine()!);

int[] array = GetArray(sizeArray);

Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {UnevenPos(array)}");
