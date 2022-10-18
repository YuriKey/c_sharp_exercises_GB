// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] GetFib(int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = array[2] = 1;
    for (int i = 3; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

Console.Clear();
Console.Write("Введите количество чисел: ");
int num = int.Parse(Console.ReadLine()!);
int[] someArray = GetFib(num);
Console.WriteLine(string.Join(", ", someArray));


