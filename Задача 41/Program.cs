// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//1. Функция принимает массив string, удаляет пробелы. конвертирует в int, возвращает int массив
int[] GetArrayFromString(string stringArray)                                        //Задаем функцию, которая считывает элементы из строчного массива и запоминает элементы в целочисленный массив.
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); // Объявляем новый массив, заполняемый методом Split. В скобках указываем критерий, 
                                                                                   //по которму выделяются элементы. Здесь это пробел. StringSplitOptions.RemoveEmptyEntries - предостерегает от ошибки, если пустая строка.
                                                                                   //Если мы введем "1 22 31 4", Split выдаст массив [1, 22, 31, 4]/
    int[] res = new int[nums.Length];                                              //Здесь создаем результирующий массив-накопитель для вывода результата.

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);                                              //В цикле проходим по массиву и конвертируем string в int.
    }
    return res;
}
//2. Функция считает количество положительных чисел
int CountPositive(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.Write("Введите целые числа через пробел: ");
string input = Console.ReadLine()!;
int[] newArray = GetArrayFromString(input);

Console.WriteLine($"Количество положительных чисел равно: {CountPositive(newArray)}");