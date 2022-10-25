// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size)         //1.Функция, заполняющая массив размера size случайными вещественными числами.
{                                   //Принимает size, возвращает массив.
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
        // res[i] = Math.Round(res[i], 2);
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

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

double[] numArray = GetArray(size);

Console.WriteLine(String.Join("; ", numArray));
Console.WriteLine($"MAX = {FindMaxValue(numArray)}"); //(numArray):f2}");
Console.WriteLine($"MIN = {FindMinValue(numArray)}"); //(numArray):f2}");
Console.WriteLine($"Разность максимального и минимального элементов равна: {FindMaxValue(numArray) - FindMinValue(numArray)}");

//Можно обернуть 2ю и 3ю функции в метод, возвращающий уже разницу, как показано ниже.
//Но мне бы хотелось оставить на будущее эти методы отдельно друг от друга.

// double FindDiff(double[] array)
// {
//     double maxValue = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > maxValue)
//         {
//             maxValue = array[i];
//         }
//     }

//     double minValue = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < minValue)
//         {
//             minValue = array[i];
//         }
//     }
//     double diff = maxValue - minValue;
//     return diff;
// }
// Console.WriteLine(String.Join("; ", numArray));
// Console.WriteLine($"Разность максимального и минимального элементов равна: {FindDiff(numArray)}");