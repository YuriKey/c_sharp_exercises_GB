// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size)         //1.Функция, заполняющая массив размера size случайными вещественными числами.
{                                   //Принимает size, возвращает массив.
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
        res[i] = Math.Round(res[i], 2);
    }
    return res;
}

double FindMaxValue(double[] array) //2. Функция, определяющая maxValue массива.
{                                   //Принимает массив, перебирает элементы, сравнивает и складывает maxValue, возвращает maxValue.
    double maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}

double FindMinValue(double[] array) //3. Функция, определяющая minValue массива.
{                                   //Принимает массив, перебирает элементы, сравнивает и складывает в minValue, возвращает minValue.
    double minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
        }
    }
    return minValue;
}

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
double[] numArray = GetArray(size);

Console.WriteLine(String.Join("; ", numArray));
Console.WriteLine($"MAX = {FindMaxValue(numArray):f2}");
Console.WriteLine($"MIN = {FindMinValue(numArray):f2}");
Console.WriteLine($"Разность максимального и минимального элементов равна: {FindMaxValue(numArray) - FindMinValue(numArray)}");  